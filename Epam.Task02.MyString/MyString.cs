using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyString
{
    class MyString
    {
        //private int capacity;
        public int Capacity { get; set; }
        //private int myLength;
        public int MyLength { get; set; }
        private char[] charArray;
        public char[] CharArray
        {
            get => charArray;
            set
            {
                if (value is char[])
                {
                    charArray = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect type:", nameof(value));
                }
            }
        }

        public MyString()
        {
            this.MyLength = 0;
            this.Capacity = 16;
            Console.WriteLine("I am here");
        }

        public MyString(char[] charArray)
        {
            MyLength = charArray.Length;
            Capacity = charArray.Length;
            this.charArray = charArray;
            //Console.WriteLine(string.Join(" ", this.charArray));
        }
        private char[] MakeNewCharArray(char[] charArray, int newCapacity)
        {
            MyLength = charArray.Length;
            Capacity = newCapacity;
            var newCharArray = new char[newCapacity];
            newCharArray = CopyPaste(charArray, newCharArray);
            //Console.WriteLine("Here ++" + newCharArray.Length);
            //Console.WriteLine(string.Join(" ", newCharArray));
            return newCharArray;
            //Console.WriteLine(string.Join(" ", this.charArray));
        }

        private char[] CopyPaste(char[] charArray1, char[] charArray2)
        {
            
            for (int i = 0; i < charArray1.Length; i++)
            {
                charArray2[i] = charArray1[i];
            }
            return charArray2;
        }

        public char[] Append(params char[] add)
        {
            //Console.WriteLine(add.Length);
            if (add != null)
            {
                if (this.charArray.Length + add.Length > this.Capacity)
                {

                    this.charArray = MakeNewCharArray(this.charArray, this.charArray.Length + add.Length);
                    this.charArray = AddToCharArray(this.charArray, add);
                    //AddToCharArray(this.charArray, add);
                    
                }
                AddToCharArray(this.charArray, add);
            }
            return this.charArray;
        }
        private char[] AddToCharArray(char[] charArray, char[] add)
        {
            for (int i = MyLength; i < charArray.Length; i++)
            {
                //Console.WriteLine($"{charArray.Length}|{add.Length}");
                charArray[i] = add[i - MyLength];
            }

            this.MyLength =charArray.Length;
            return charArray;
        }

        public char this[int index]
        {
            get => this.charArray[index];
            set
            {
                this.charArray[index] = value;
            }
        }

        public static void Show(MyString charArray)
        {
            Console.WriteLine($"++{charArray.MyLength}");
            for (int i = 0; i < charArray.MyLength; i++)
            {
                Console.Write(charArray[i]);
            }
            Console.WriteLine();
        }

        public static char[] Concat(char[] charArray1, char[] charArray2)
        {
            long finalLength = charArray1.Length + charArray2.Length;
            char[] newCharArray = new char[finalLength];
            for (int i = 0; i < finalLength; i++)
            {
                if (i >= charArray1.Length)
                {
                    newCharArray[i] = charArray2[i - charArray1.Length];
                }
                else
                {
                    newCharArray[i] = charArray1[i];
                }
            }
            return newCharArray;
        }
        public static char[] Concat(char[] charArray1, char[] charArray2, char[] charArray3)
        {
            long finalLength = charArray1.Length + charArray2.Length + charArray3.Length;
            char[] newCharArray = new char[finalLength];
            for (int i = 0; i < finalLength; i++)
            {
                if (i >= charArray1.Length)
                {
                    if (i >= charArray1.Length + charArray2.Length)
                    {
                        newCharArray[i] = charArray3[i - charArray1.Length - charArray2.Length];
                    }
                    else
                    {
                        newCharArray[i] = charArray2[i - charArray1.Length];
                    }

                }
                else
                {
                    newCharArray[i] = charArray1[i];
                }
            }
            return newCharArray;
        }
    }
}
