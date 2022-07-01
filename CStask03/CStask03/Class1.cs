using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part1
{
    public class Class1
    {
        public Class1(){ Console.WriteLine("Hello, World!"); }
        //Working with methods 01
        public int[] create_arr() { return new int[] { 1, 2, 3, 4}; }
        public void reverse_arr(ref int[] input) 
        {
            int len = input.Length;
            for(int i = 0; i < len / 2; i++)
            {
                int token = input[i];
                input[i] = input[len - i - 1];
                input[len - i - 1] = token;

            }
        }

        public void print_arr(int[] input)
        {
            foreach(int i in input) { Console.Write(i); }
        }

        //Working with methods 02
        public int fibo(int input)
        {
            int output = 1;
            int first = 0;
            int second = 1;
            for(int i = 0; i < input - 1; i++)
            {
                output = first + second;
                first = second;
                second = output;
            }
            Console.WriteLine(output);
            return output;
        }
    }
}
