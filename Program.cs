﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person prs = new Person();
            prs.Run(prs.GetFirstname,prs.GetLastname);

            Console.Read();
        }
    }
}
