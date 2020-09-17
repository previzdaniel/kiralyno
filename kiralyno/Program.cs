using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiralyno
{
    class Program
    {

        class Tabla
        {
            char[,] T;
            private char uresCella;
            private int uresOszlopokSzama;
            private int uresSorokSzama;


            public Tabla(char ch)
            {
                T = new char[8, 8];
                uresCella = ch;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        T[i, j] = uresCella;
                    }
                }
            }
            public void Elhelyez(int N)
            {
                // 1. véletlen helyérték létrehozása
                // - Random osztály értékkészlet: [0,7]
                // - Véletlen sor és oszlop kell
                // - Elhelyezzük a "K"-t csak akkor
                //   HA!!! üres --> '#'

                Random vel = new Random();

                for (int i = 0; i < N; i++)
                {
                    int sor = vel.Next(0, 8);
                    int oszlop = vel.Next(0, 8);
                    while (T[sor,oszlop] == 'K')
                    {
                        sor = vel.Next(0, 8);
                        oszlop = vel.Next(0, 8);
                    }
                    T[sor, oszlop] = 'K';
                }
            }

            public void FajlbaIr()
            {

            }

            public void Megjelenit()
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        //Console.Write("{0} ",T[i,j]);
                        //Console.Write($"T[i,j] ");
                        Console.Write(T[i,j] + " ");
                    }
                    Console.WriteLine();
                }
            }



            public int UresOszlop()
            {
                return 0;
            }

            public int UresSor()
            {
                return 0;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Királynők feladat");

            Tabla t = new Tabla('#');

            Console.WriteLine("Üres tábla: ");
            t.Megjelenit();

            Console.WriteLine();
            t.Elhelyez(5);
            Console.WriteLine();
            t.Megjelenit();

            Console.ReadKey();
        }
    }
}
