using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;

namespace BooleanLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(String.Join(",",Converter(64)));
            //Console.WriteLine(PowerOf2(7));
        }

        public static List<bool> Converter(int input)
        {
            List<bool> list = new List<bool>();

            while (input > 0)
            {
                if (input % 2 == 0)
                {
                    input = input / 2;
                    list.Add(false);
                }
                else
                {
                    input = input / 2;
                    list.Add(true);
                }
                list.Reverse();
            }
            

            bool value = false;

            foreach (bool b in list)
            {
                value = value ^ b;
            }
            Console.WriteLine("Even parity: " + Convert.ToString(value));

            return list;

        }

        public static bool PowerOf2(int bin)
        {
            if ((bin & (bin - 1)) != 0)
            {
                return false;
            }
                
            return true;
        }

        public static int BitCount(int x)
        {
            int count = 0;
            while (x > 0)
            {
                x = x & (x - 1);
                count++;
            }
            return count;
        }

        public static void VernamCipher(string input1, string input2, byte[] cipher)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(input1);
            byte[] bytes2 = Encoding.ASCII.GetBytes(input2);

            for (int i = 0; i < bytes.Length; i++)
            {
                cipher[i] = (byte)(bytes[i] ^ bytes2[i]);
            }

        }


        
    }
}