﻿using System;

namespace using_yield_return
{
    class Program
    {
        static void Main(string[] args)
        {
            MedicalCard myCard = new MedicalCard("healthy",  "not so bad as you think", "very well");
            foreach (var s in myCard)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
