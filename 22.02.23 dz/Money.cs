using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._02._23_dz
{
    interface IPrint
    {
        void print();
    }
    class SentCheck : IPrint
    {
        public void print()
        {
            Console.WriteLine("Send check!");
        }
    }
    class ShowCheck : IPrint
    {
        public void print()
        {
            Console.WriteLine("Show check");
        }
    }
    class PrintCheck : IPrint
    {
        public void print()
        {
            Console.WriteLine("Print check");
        }
    }
    interface IMoney
    {
        void give();
        void receive();
    }
    class UAH : IMoney
    {
        public int uah;
        public void give()
        {
            Console.WriteLine();
        }
        public void receive()
        {
            Console.WriteLine();
        }
    }
}
