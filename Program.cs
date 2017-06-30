using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTri1
{
    class Program
    {
        static void Main(string[] args)
        {
            int noLines;
            Console.WriteLine("Enter No of Lines: ");
            noLines = Convert.ToInt32(Console.ReadLine());
            printPascal(noLines);
            Console.ReadLine();
        }

        static void printPascal(int lines)
        {
            int[,] arr = new int[lines, lines];
            int i, j, sl, space = lines;
            for(i = 0; i < lines; i++)
            {
                for(sl = 0; sl < space; sl++)
                {
                    Console.Write(" ");
                }
                for (j = 0; j <= i; j++)
                {
                    if(j == 0 || j == i)
                    {
                        arr[i, j] = 1;                        
                    }
                    else
                    {                        
                        arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];                        
                    }
                    Console.Write(arr[i, j] + " ");
                }
                space--;
                Console.WriteLine("");
            }            
            
        }
    }
}
