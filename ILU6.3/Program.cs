using System;
using System.Data;

namespace ILU6_3
{
    class Program
    {
        static void Main()
        {
            int[] array = new int [3];
            Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Största talet av två tal");
            Console.WriteLine("3. Avsluta program");
            int meny=int.Parse(Console.ReadLine());
            Console.Clear();
            if (meny==1) 
            {
                MenyvalAddera();
            }
            if (meny==2) 
            {
                MenyvalStörstaTalet();
            }
            else if (meny==3) 
            { 
                AvslutaProgram();
            }
        }
        static void MenyvalAddera() 
        {
            int[] array = new int[3];
            Console.WriteLine("Skriv in tre heltal som du vill addera");
            for (int i = 0; i < 3; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear ();
            Console.WriteLine("Summan av de tre talen är");
            Console.WriteLine($"{Addera(array)}");
            Main();

        }
        static int Addera(int[] namn)
        {
            int addera = namn[0] + namn[1] + namn[2];
            return addera;
        }
        static void MenyvalStörstaTalet()
        {
            int[] array = new int[2];
            Console.WriteLine("Skriv in två tal, programet kommer skriva ut talet som är störst");
            for (int i = 0; i < 2; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine("Det största talet är");
            Console.WriteLine($"{Största(array)}");
            Main();
        }
        static int Största(int[] störst)
        {
            int störs = 0;

            if (störst[0] < störst[1])
            {
                störs = störst[1];
            }
            else if (störst[1] < störst[0])
            {
                störs = störst[0];
            }
            else
            {
                störs = störst[0];
            }
            return störs;
        }
        static void AvslutaProgram()
        {
        
        }


    }
}
