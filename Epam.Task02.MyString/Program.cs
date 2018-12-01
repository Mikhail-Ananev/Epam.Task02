using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString myString = new MyString(new char[] { '4', '4' });
            //myString = new char[] {'4', '4'};
            //Console.WriteLine($"{myString.Capacity}|{myString.MyLength}");
            //MyString.Show(myString);
            myString.Append("Fucking shit! I do this!!!".ToCharArray());
            Console.WriteLine(myString.MyLength);
            MyString.Show(myString);
        }
    }
}