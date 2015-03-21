using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.IO;

namespace PhotoMananger
{
    static class Stat
    {

        private static Delegates.TextBoxInt dlgt = new Delegates.TextBoxInt(delegate(TextBox txt, int s)
        {
            txt.Text = s.ToString();
        });



        public static class Date
        {

            private static int count = 0;
            private static TextBox txt;
            private static string all = "";

            public static void Setup(TextBox tb)
            {
                txt = tb;
            }

            public static int Add(DateTime dt)
            {
                var s = dt.ToString("#dddd-MM-dd#");
                if (all.Contains(s)) 
                {
                    return count;
                }

                all += s;

                count++;
                Program.Form.Invoke(dlgt, new object[]
                {
                    txt,
                    count
                });

                return count;
            }
        }

        public static class Photo
        {
            private static int count = 0;
            private static TextBox txt;

            public static void Setup(TextBox tb)
            {
                txt = tb;
            }

            public static int Add()
            {
                count++;
                Program.Form.Invoke(dlgt, new object[]
                {
                    txt,
                    count
                });

                return count;
            }
        }

        public static class Video
        {
            private static int count = 0;
            private static TextBox txt;

            public static void Setup(TextBox tb)
            {
                txt = tb;
            }

            public static int Add()
            {
                count++;
                Program.Form.Invoke(dlgt, new object[]
                {
                    txt,
                    count
                });

                return count;
            }
        }

        public static class Ignore
        {
            private static int count = 0;
            private static TextBox txt;

            public static void Setup(TextBox tb)
            {
                txt = tb;
            }

            public static int Add()
            {
                count++;
                Program.Form.Invoke(dlgt, new object[]
                {
                    txt,
                    count
                });

                return count;
            }


        }

       
        
    }
}
