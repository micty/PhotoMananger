using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Threading;

namespace PhotoMananger
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();

            Program.Form = this;
            Logger.Setup(txtLogs);
            Stat.Date.Setup(txtStatDate);
            Stat.Photo.Setup(txtStatPhoto);
            Stat.Video.Setup(txtStatDV);
            Stat.Ignore.Setup(txtStatIgnore);
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            btn.Text = "正在处理...";
            btn.Enabled = false;

            //启用新线程去执行，主线程立即返回，UI 不受阻塞
            ThreadPool.QueueUserWorkItem(Start);

            
        }

        private void Start(object state)
        {
            Logger.Clear();

            string src = txtSource.Text;
            MoveFiles(src);

            Logger.Log("完成任务");

            this.Invoke((Delegates.Empty)delegate()
            {
                btnSubmit.Enabled = true;
                btnSubmit.Text = "开始执行";
            });
        }


        private void MoveFiles(string src) 
        {
            if (!Directory.Exists(src))
            {
                Logger.Log("源目录不存在: {0}", src);
                return;
            }

            string target = txtTarget.Text + "\\";
            string seperator = txtSeperator.Text;
            string formater = "yyyy" + seperator + "MM" + seperator + "dd";

            bool checkedDV = chkDV.Checked;
            string dv = txtDV.Text;

            bool useMove = rdMove.Checked;
            bool useOverwrite = rdOverwrite.Checked;

            Logger.Log("扫描目录: " + src);


            string[] files = Directory.GetFiles(src);

            foreach (string f in files)
            {
                FileInfo fi = new FileInfo(f);
                string ext = fi.Extension.ToLower();

                if (!IsValidFileType(ext))
                {
                    continue;
                }


                DateTime photoTime = fi.LastWriteTime;
                Stat.Date.Add(photoTime);

                string path = target + photoTime.ToString(formater);

                if (checkedDV) //默认选中
                {
                    if (ext == ".avi" || ext == ".thm")
                    {
                        path = path + "\\" + dv; //默认为 "DV"
                    }
                }

                string fullname = path + "\\" + fi.Name;

                try
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    bool existed = File.Exists(fullname);
                    bool ignored = false;

                    if (useMove) //移动文件
                    {
                        if (existed)
                        {
                            if (useOverwrite)
                            {
                                Logger.Log("移动(覆盖)文件到: {0}", fullname);
                                File.Delete(fullname);
                                fi.MoveTo(fullname);
                            }
                            else
                            {
                                Logger.Log("已存在(跳过)文件: {0}", fullname);
                                ignored = true;
                            }
                        }
                        else
                        {
                            Logger.Log("移动文件到: {0}", fullname);
                            fi.MoveTo(fullname);
                        }
                    }
                    else //拷贝文件
                    {
                        if (existed)
                        {
                            if (useOverwrite)
                            {
                                Logger.Log("拷贝(覆盖)文件到: {0}", fullname);
                                fi.CopyTo(fullname, true);
                            }
                            else
                            {
                                Logger.Log("已存在(跳过)文件: {0}", fullname);
                                ignored = true;
                            }
                        }
                        else 
                        {
                            Logger.Log("拷贝文件到: {0}", fullname);
                            fi.CopyTo(fullname);
                        }
                    }


                    if (!ignored)
                    {
                        if (ext == ".jpg")
                        {
                            Stat.Photo.Add();
                        }
                        else if (ext == ".avi")
                        {
                            Stat.Video.Add();
                        }
                    }
                    else 
                    {
                        Stat.Ignore.Add();
                    }

                }
                catch (Exception ex)
                {
                    Logger.Log(ex.Message);
                }
            }

            //处理子目录
            if (chkSubDir.Checked)
            {
                string[] dirs = Directory.GetDirectories(src);
                foreach (string d in dirs)
                {
                    MoveFiles(d); //递归
                }
            }

        }

        private bool IsValidFileType(string ext)
        {
            ext = ext.ToLower();
            return ext == ".jpg" || ext == ".avi" || ext == ".thm";
        }


        private void txtLogs_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowseSourceDir_Click(object sender, EventArgs e)
        {
            var ok = folderBrowserDialog1.ShowDialog();
            if (ok == System.Windows.Forms.DialogResult.OK)
            {
                txtSource.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnBrowseTargetDir_Click(object sender, EventArgs e)
        {
            var ok = folderBrowserDialog2.ShowDialog();
            if (ok == System.Windows.Forms.DialogResult.OK)
            {
                txtTarget.Text = folderBrowserDialog2.SelectedPath;
            }
        }


    }
}
