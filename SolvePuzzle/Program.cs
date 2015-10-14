using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolvePuzzle
{
    class Program
    {
        static int solvePuzzle(int num){
            Dictionary<int,int> myDick = new Dictionary<int,int>();
            myDick.Add(0, 1);           
            myDick.Add(4, 1);            
            myDick.Add(6, 1);            
            myDick.Add(8, 2);
            myDick.Add(9, 1);
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            int cont = 0;
            foreach (int n in listOfInts) // Loop through List with foreach.
            {
                int valor = 0;
                if (myDick.ContainsKey(n)) { 
                    myDick.TryGetValue(n,out valor);
                    cont = cont + valor;
                }
            }
 
            return cont;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(solvePuzzle(346));
            Console.WriteLine(solvePuzzle(98));
        }
    }
}
