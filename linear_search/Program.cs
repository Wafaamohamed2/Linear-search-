using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linear_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 80, 90, 5, 25, 20, 15 };

            Console.Write("Enter the value that you look for : ");
            int value  = int.Parse(Console.ReadLine());
             
            int check = Linear_search(array,array.Length,value);

            if (check == -1) { Console.WriteLine("The value not founded at any position "); }
            else { Console.WriteLine("The value is valied at position " + check); }

        }


      static int Linear_search(int[] arr, int n,int value) {
        
              for(int i = 0; i < arr.Length; i++)
              {
                if (arr[i] == value)
                {
                    return i;
                }
              }
              return -1;
        
        
        
      }
    }
}
