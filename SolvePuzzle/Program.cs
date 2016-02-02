using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolvePuzzle
{
    class Program
    {
        static string solvePuzzle(int num){
            Dictionary<int,int> myDick = new Dictionary<int,int>();
            myDick.Add(0, 1);           
            myDick.Add(4, 1);            
            myDick.Add(6, 1);            
            myDick.Add(8, 2);
            myDick.Add(9, 1);
            try
            {
                if (num > 0)
                {
                    int cont = 0;
                    string aux = num.ToString();
                    while (num > 0)
                    {
                        int valor = 0;
                        int digito = num % 10;
                        if (myDick.ContainsKey(digito))
                        {
                            myDick.TryGetValue(digito, out valor);
                            cont = cont + valor;
                        }
                        num = num / 10;
                    }

                    return aux + "=" + cont.ToString();
                }
                else {
                    return "Parámetro debe ser mayor a cero";
                }
            }
            catch (Exception ex)
            {

                return ex.Message.ToString();
            }
            
        }


        static void Main(string[] args)
        {
            Console.WriteLine(solvePuzzle(346));
            Console.WriteLine(solvePuzzle(98));
            Console.WriteLine(solvePuzzle(0));
            Console.ReadKey();
        }
    }
}
