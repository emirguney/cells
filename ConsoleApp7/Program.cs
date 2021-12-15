using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void yazdir(int[] dizi)
        {
            foreach (int i in dizi)
            {
                Console.Write(i + "\t");
            }

            Console.WriteLine();
        }

        static int[] cellCompete(int[] hucre, int gun)
        {

            if (hucre.Length != 8 || gun < 1)
            {
                return hucre;
            } 

            int index, oHucre, sHucre;

            for (int i = 0; i < gun; i++)
            {

                index = 0;
                oHucre = 0;
                sHucre = 0;

                while (index < hucre.Length)
                {

                    if (index < hucre.Length - 1)
                    {
                        sHucre = hucre[index + 1];
                    }
                    else if (index == hucre.Length - 1)
                    {
                        sHucre = 0;
                    }

                    if (sHucre == oHucre)
                    {
                        oHucre = hucre[index];
                        hucre[index] = 0;
                    }
                    else
                    {

                        oHucre = hucre[index];

                        hucre[index] = 1;
                    }

                    index++;
                }
            }

            return hucre;
        }

        static void Main(string[] args)
        {
            int[]  dizi1 = { 1, 0, 0, 0, 0, 1, 0, 0 };
            Console.Write("Giriş dizisi : ");
            yazdir(dizi1);
            dizi1 = cellCompete(dizi1, 1);
            Console.Write("Sonuç dizisi : ");
            yazdir(dizi1);
            Console.WriteLine();


            int[] dizi2 = { 1, 1, 1, 0, 1, 1, 1, 1 };
            Console.Write("Giriş dizisi : ");
            yazdir(dizi2);
            dizi2 = cellCompete(dizi2, 2);
            Console.Write("Sonuç dizisi : ");
            yazdir(dizi2);

            Console.ReadKey();
        }

    }
}