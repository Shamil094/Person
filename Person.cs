using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Person
    {
        public delegate void Yaz();

        private string firstname = "Shamil";
        private string lastname = "Celilzade";

        public void GetFirstname()
        {
            Console.WriteLine(firstname);
        }
        public void GetLastname()
        {
            Console.WriteLine(lastname);
        }
        public void Run(Yaz fn,Yaz ln)
        {
            fn.Invoke();
            ln.Invoke();
        }
    }
}
