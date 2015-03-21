using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PhotoMananger
{
    /// <summary>
    /// 一些常用的委托
    /// </summary>
    public static class Delegates
    {
        /// <summary>
        /// 表示无参数的委托
        /// </summary>
        public delegate void Empty();

        /// <summary>
        /// 表示只有一个参数为 object 类型的委托
        /// </summary>
        /// <param name="obj"></param>
        public delegate void Object(object obj);

        /// <summary>
        /// 表示只有一个参数为 string 类型的委托
        /// </summary>
        /// <param name="obj"></param>
        public delegate void String(string s);

        /// <summary>
        /// 表示只有一个参数为 int 类型的委托
        /// </summary>
        /// <param name="obj"></param>
        public delegate void Int(int i);

        /// <summary>
        /// 表示第一个参数为 string 类型，第二个参数为 int 类型的委托
        /// </summary>
        /// <param name="obj"></param>
        public delegate void StringInt(string s, int i);

        /// <summary>
        /// 表示第一个参数为 int 类型，第二个参数为 string 类型的委托
        /// </summary>
        /// <param name="obj"></param>
        public delegate void IntString(int i, string s);

        /// <summary>
        /// 表示第一个参数为 string 类型，第二个参数为 string 类型的委托
        /// </summary>
        /// <param name="obj"></param>
        public delegate void StringString(string s1, string s2);

        /// <summary>
        /// 表示第一个参数为 int 类型，第二个参数为 int 类型的委托
        /// </summary>
        /// <param name="obj"></param>
        public delegate void IntInt(int i, int k);

        /// <summary>
        /// 表示第一个参数为 TextBox 类型，第二个参数为 int 类型的委托
        /// </summary>
        /// <param name="obj"></param>
        public delegate void TextBoxInt(System.Windows.Forms.TextBox tb, int n);

    }
}
