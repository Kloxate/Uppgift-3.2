using System;
namespace Uppgift_3_2

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du klarat gymasiet?");
            Console.WriteLine("J/N");
            string svar_1 = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            string svar_2 = Console.ReadLine();
            int svar_2_1 = int.Parse(svar_2);


            if (svar_1 == "J" && svar_2_1 < 22)
            {
                Console.WriteLine("Vi vill gärna antälla dig.");
            }
            else
            {
                Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
            }
        }
    }
}