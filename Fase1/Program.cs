using System;

namespace Fase1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the array containing the characters of the name
            char[] nameArray = { 'd', 'a', 'y', 't', 'é' };

            showArray(nameArray);
        }

        private static void showArray(char[] aArray)
        {
            Console.WriteLine("Characters of the name: ");
            for (int i = 0; i < aArray.Length; i++)
            {
                Console.WriteLine(aArray[i]);
            }
        }
    }
}
