using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;

namespace PhotoMananger
{
    class Strings
    {

        private string Value;

        public Strings(string s)
        {
            this.Value = s; 
        }

        

        public string ValueOf()
        {
            return this.Value;
        }

        public Strings Between(string beginTag, string endTag)
        {
            this.Value = Between(this.Value, beginTag, endTag);
            return this;
        }

        public static string Between(string s, string beginTag, string endTag)
        {

            int beginIndex = s.IndexOf(beginTag);
            beginIndex = beginIndex + beginTag.Length;

            int endIndex = s.IndexOf(endTag, beginIndex);
            int len = endIndex - beginIndex;

            return s.Substring(beginIndex, len);
        }

        public Strings Remove(string sub)
        {
            this.Value = Remove(this.Value, sub);
            return this;
        }

        public static string Remove(string s, string sub)
        {
            return s.Replace(sub, "");
        }

        public static string[] Split(string s, string seprator)
        {
            return s.Split(new string[]{seprator}, StringSplitOptions.RemoveEmptyEntries);
        }

        public static string Join(string[] a, string seprator)
        {
            if (seprator == null)
            {
                seprator = "";
            }

            StringBuilder sb = new StringBuilder();
            int len = a.Length -1 ;
            for (int i = 0; i < len; i++)
            {
                sb.Append(a[i]);
                sb.Append(seprator);
            }

            sb.Append(a[len]);

            return sb.ToString();
        }

        public static string Format(string s, string v0)
        {
            return s.Replace("{0}", v0);
        }

        public static string Format(string s, string v0, string v1)
        {
            return Format(s, v0).Replace("{1}", v1);
        }
        public static string Format(string s, string v0, string v1, string v2)
        {
            return Format(s, v0, v1).Replace("{2}", v2);
        }

        

        public static string Format(string s, string v0, string v1, string v2, string v3)
        {
            return Format(s, v0, v1, v2).Replace("{3}", v3);
        }



        public static string Format(string s, int v0)
        {
            return Format(s, v0.ToString());
        }

        public static string Format(string s, int v0, int v1)
        {
            return Format(s, v0, v1.ToString());
        }

        public static string Format(string s, int v0, int v1, int v2)
        {
            return Format(s, v0.ToString(), v1.ToString(), v2.ToString());
        }

        public static string Format(string s, string v0, int v1)
        {
            return Format(s, v0, v1.ToString());
        }

        public static string Format(string s, int v0, string v1)
        {
            return Format(s, v0.ToString(), v1);
        }

    }
}
