using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp134
{
    internal class Program
    {
        static void Main(string[] array)
        {

            char[] charArray = new char[3];

            for(int i = 0; i < charArray.Length; i++)
            {
               charArray[i] = Convert.ToChar(Console.ReadLine());
            }

            Sorter sorter = new Sorter();
            sorter.Sort(charArray);



            for(int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(charArray[i]);
            }
           
          
        }
    }

    public class Sorter
    {
        public int[] Sort(int[] unsorted)
        {
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

        public char[] Sort(char[] unsorted)
        {
            char[] longsortedarray = new char[unsorted.Length];
            for (int i = 0; i < unsorted.Length - 1; i++)

            {
                for (int j = 0; j < unsorted.Length - i - 1; j++)
                {
                    int l = (int)unsorted[j];
                    int n = (int)unsorted[j + 1];
                    
                    if (l > n )
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