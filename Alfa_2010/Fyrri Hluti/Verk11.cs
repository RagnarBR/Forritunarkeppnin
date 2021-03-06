﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FK_Alfa_2010
{
    class Verk11
    {
        static void Main(string[] args)
        {
            int sextiu = 0, thratiu = 0, tuttugu = 0, afg = 0;
            List<string> moguleikar = new List<string>();
            Console.Write("Farþegafjöldi: ");
            int f = Int32.Parse(Console.ReadLine());
            Console.Write("Fjöldi 60 manna rúta: ");
            int r60 = Int32.Parse(Console.ReadLine());
            Console.Write("Fjöldi 30 manna rúta: ");
            int r30 = Int32.Parse(Console.ReadLine());
            Console.Write("Fjöldi 20 manna rúta: ");
            int r20 = Int32.Parse(Console.ReadLine());


            if (f <= 300)
            {

                for (int sext = 0; sext <= r60; sext++)
                {
                    for (int thra = 0; thra <= r30; thra++)
                    {
                        for (int tvo = 0; tvo <= r20; tvo++)
                        {
                            moguleikar.Add(sext + ";" + thra + ";" + tvo + ";" + (sext * 60 + thra * 30 + tvo * 20));
                        }
                    }
                }

                int minnst = -1;

                foreach (string moguleiki in moguleikar)
                {
                    int heild = Int32.Parse(moguleiki.Split(';')[3]);
                    if ((minnst == -1 && heild >= f) || (heild >= f && heild - f <= minnst))
                    {
                        minnst = heild - f;
                        sextiu = Int32.Parse(moguleiki.Split(';')[0]);
                        thratiu = Int32.Parse(moguleiki.Split(';')[1]);
                        tuttugu = Int32.Parse(moguleiki.Split(';')[2]);
                    }
                }

                if (sextiu > 0)
                {
                    Console.WriteLine(sextiu + " stk 60 manna rúta");
                }
                if (thratiu > 0)
                {
                    Console.WriteLine(thratiu + " stk 30 manna rúta");
                }
                if (tuttugu > 0)
                {
                    Console.WriteLine(tuttugu + " stk 20 manna rúta");
                }
            }
            else
            {
                Console.WriteLine("Það eru ekki til nógu margar rútur.");
            }

            Console.ReadLine();
        }
    }
}
