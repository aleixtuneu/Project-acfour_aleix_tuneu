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
            const string MsgResult = "Valors ordenants descendentment: ";

            int size = 0;
            int[] nums;
            int[] sortedNums;

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

            // Ordenar Descendentment
            sortedNums = new int[size];

            sortedNums = SortDescendent(nums);

            // Mostrar valors ordenats descendentment
            Console.WriteLine(MsgResult);
            foreach(int sortedNum in sortedNums)
            {
                Console.Write(sortedNum + " ");
            }
            Console.WriteLine();

            
        }

        public static int[] SortDescendent(int[] nums)
        {
            int aux = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j])
                    {
                        aux = nums[i];
                        nums[i] = nums[j];
                        nums[j] = aux;
                    }
                }
            }

            return nums;
        }
    }
}
