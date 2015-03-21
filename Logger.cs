using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;

namespace PhotoMananger
{
    static class Logger
    {
        private static TextBox txt;

        private static Delegates.String dlgt = new Delegates.String(delegate(string s)
        {
            txt.AppendText(s);
            File.WriteAllText("log.txt", txt.Text);
        });


        public static void Setup(TextBox txt)
        {
            Logger.txt = txt;
        }

        

        public static void Log(string message)
        {
            message = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + message + "\r\n";

            Program.Form.Invoke(dlgt, new string[]
            {
                message
            });
            
        }

        public static void Clear()
        {
            Program.Form.Invoke(dlgt, new string[]
            {
                string.Empty
            });

        }

        public static void Log(string s, string arg0)
        {
            s = s.Replace("{0}", arg0);
            Log(s);
        }

        public static void Log(string s, string arg0, string arg1)
        {
            s = s.Replace("{0}", arg0).Replace("{1}", arg1);
            Log(s);
        }

        public static void Log(string s, string arg0, string arg1, string arg2)
        {
            s = s.Replace("{0}", arg0).Replace("{1}", arg1).Replace("{2}", arg2);
            Log(s);
        }


        public static void Log(string s, int arg0)
        {
            Log(s, arg0.ToString());
        }

        public static void Log(string s, int arg0, int arg1)
        {
            Log(s, arg0.ToString(), arg1.ToString());
        }

        public static void Log(string s, int arg0, int arg1, int arg2)
        {
            Log(s, arg0.ToString(), arg1.ToString(), arg2.ToString());
        }

       

  

        public static void Log(string s, string arg0, int arg1)
        {
            Log(s, arg0, arg1.ToString());
        }

        public static void Log(string s, int arg0, string arg1)
        {
            Log(s, arg0.ToString(), arg1);
        }

        public static void Log(string s, string arg0, string arg1, int arg2)
        {
            Log(s, arg0, arg1, arg2.ToString());
        }

        public static void Log(string s, string arg0, int arg1, string arg2)
        {
            Log(s, arg0, arg1.ToString(), arg2);
        }

        public static void Log(string s, string arg0, int arg1, int arg2)
        {
            Log(s, arg0, arg1.ToString(), arg2.ToString());

        }

        public static void Log(string s, int arg0, string arg1, int arg2)
        {
            Log(s, arg0.ToString(), arg1, arg2.ToString());

        }

        public static void Log(string s, int arg0, int arg1, string arg2)
        {
            Log(s, arg0.ToString(), arg1.ToString(), arg2);

        }

        public static void Log(string s, int arg0, string arg1, string arg2)
        {
            Log(s, arg0.ToString(), arg1, arg2);
        }

        
    }
}
