using System;
using System.Collections.Generic;

namespace Fase1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the array containing the characters of the name
            char[] nameArray = { 'd', 'a', 'y', 't', 'é' };

            //Create the list that contains the characters of the name
            var nameList = arrayToList(nameArray);

            showArray(nameArray);
        }

        private static List<char> arrayToList(char[] aArray)
        {
            var listArray = new List<char>();

            for (int i = 0; i < aArray.Length; i++)
            {
                listArray.Add(aArray[i]);
            }
            return listArray;
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

