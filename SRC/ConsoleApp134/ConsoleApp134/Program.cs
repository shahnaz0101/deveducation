using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp134
{
    internal class SortingString
    {
        public static void Main(string[] args)
        {
            string[] values = { "Samaya", "Vugar", "Novruz", "Narmina", "Edward" };

            foreach (string value in values)
            {
                Console.Write(value + ' ');
            }
            Array.Sort(values);
            Console.WriteLine("Sorted; ");
            foreach (string value in values)
            {
                Console.Write(value + ' ');
            }
            Console.WriteLine();
        }

    }
    public class Program
    {
        public static void Main(string[] array)
        {
            
          int[] Sort(int[] unsorted)
        {
            //int[] longsortedarray = { 3, 2, 1 };
            int[] longsortedarray = new int[unsorted.Length];
            
            for (int i = 0; i < unsorted.Length - 1; i++)

            {
                for (int j = 0; j < unsorted.Length - i - 1; j++)
                {

                    if (unsorted[j] > unsorted[j + 1])
                    {
                        int temp = longsortedarray[j];
                        longsortedarray[j] = longsortedarray[j + 1];
                        longsortedarray[j + 1] = temp;
                    }
                }

            }
            return longsortedarray;
           
          
        }
    }

    public class Sorter
    {
        }

        public char[] Sort(char[] unsorted)
        {
            char[] longsortedarray = new char[unsorted.Length];
            for (int i = 0; i < unsorted.Length - 1; i++)

            {
                for (int j = 0; j < unsorted.Length - i - 1; j++)
                {
                    int l = (int)unsorted[j];
                    int n = (int)unsorted[j + 1];

                    if (l > n)
                    {
                        char temp = longsortedarray[j];
                        longsortedarray[j] = longsortedarray[j + 1];
                        longsortedarray[j + 1] = temp;
                    }
                }

            }
            return longsortedarray;
        }


    }
}