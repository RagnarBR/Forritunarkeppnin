﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delta_2009
{
    class Verk3
    {
        static void Main(string[] args)
        {
            bool afram = true;
            while (afram)
            {
                Console.Clear();
                double afslattur = 0;
                Console.Write("Fermetraverð: ");
                double ferVerd = Convert.ToDouble(Console.ReadLine());
                Console.Write("Fjöldi fermetra: ");
                double ferMetr = Convert.ToDouble(Console.ReadLine());
                double heildarverd = ferVerd * ferMetr;
                Console.WriteLine("Heildarverð verður þá: " + heildarverd);
                if (heildarverd > 1000000)
                {
                    afslattur = 10;
                }
                else if (heildarverd > 100000)
                {
                    afslattur = 5;
                }

                if (afslattur > 0)
                {
                    afslattur = (afslattur / 100) * heildarverd;
                    heildarverd -= afslattur;
                    Console.WriteLine("Afsláttur: " + (afslattur));
                    Console.WriteLine("Verð með afslætti: " + heildarverd);
                }
                Console.Write("Vilt þú reikna fleiri verðdæmi: ");
                if(Console.ReadLine().ToLower() == "nei")
                {
                    Console.WriteLine("Takk fyrir í dag.");
                    afram = false;
                    Console.ReadLine();
                }
            }
        }
    }
}
