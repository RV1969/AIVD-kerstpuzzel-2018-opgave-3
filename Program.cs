//Opgave 3
//Gegeven is KERST= REKENEN + MET* TIEN - LETTERS
//a. (1) Welk getal hoort bij MINSTREEL?
//b. (2) REKENLES kun je als twee verschillende getallen schrijven, wat is het product van deze twee getallen?

using System;
using System.Collections.Generic;

namespace AIVD03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> k = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //Nul alvast uitgesloten
            List<string> e = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            List<string> r = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //Nul alvast uitgesloten
            List<string> s = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            List<string> t = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //Nul alvast uitgesloten
            List<string> i = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            List<string> n = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            List<string> m = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //Nul alvast uitgesloten
            List<string> l = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //Nul alvast uitgesloten

            foreach (string xa in k)
                foreach (string xb in e)
                    foreach (string xc in r)
                        foreach (string xd in s)
                            foreach (string xe in t)
                                foreach (string xf in i)
                                    foreach (string xg in n)
                                        foreach (string xh in m)
                                            foreach (string xi in l)
                                            {                                                
                                                int kerst = Convert.ToInt32(xa + xb + xc + xd + xe);
                                                int rekenen = Convert.ToInt32(xc + xb + xa + xb + xg + xb + xg);
                                                int met = Convert.ToInt32(xh + xb + xe);
                                                int tien = Convert.ToInt32(xe + xf + xb + xg);
                                                int letters = Convert.ToInt32(xi + xb + xe + xe + xb + xc + xd);

                                                if (kerst == rekenen + met * tien - letters)
                                                {
                                                    Console.WriteLine(kerst + "=" + rekenen + "+" + met + "*" + tien + "-" + letters);
                                                }                                             
                                            }                                               
            
            Console.WriteLine("Klaar.");
            Console.ReadKey();
        }
    }
}
