using System;
namespace acfour_aleix_tuneu
{
    public class Program
    {
        public static void Main()
        {
            const string MsgSize = "Quants números vols introduïr?";
            const string MsgInput = "Introdueix el valor #{0}: ";
            const string MsgError = "Error. Introdueix un valor enter positiu.";
            const string MsgResult = "Valors introduïts: ";

            int size = 0;
            int[] nums;

            // Demanar i validar número de valors
            Console.WriteLine(MsgSize);
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine();
                Console.WriteLine(MsgError);
            }
            Console.WriteLine();

            nums = new int[size];

            // Demanar i validar valors un per un
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(MsgInput, i+1);
                while(!int.TryParse(Console.ReadLine(), out nums[i]) || nums[i] <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(MsgError);
                }
                Console.WriteLine();
            }

            // Mostrar valors
            Console.WriteLine(MsgResult);
            foreach(int num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
