using System;

namespace chap_adad_bozorgtar
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximom = 0;
            int[] adad = new int[10];
            for (int i=0; i<10; i++)
            {
                Console.WriteLine($"adad {i+1} ra vared konid");
                adad[i] = Convert.ToInt32(Console.ReadLine());

                if (adad[i] > maximom)
                {
                    maximom = adad[i];

                }
            }
            Console.WriteLine($"adad bozorg tar barabr {maximom}");

            Console.ReadKey();
        }   
    }
}
