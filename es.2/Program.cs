using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es._2
{
    internal class Program
    {
        static void confronto(ref DateTime data, ref int []a)
        {
        }
        static void Main(string[] args)
        {
            int[] a=new int[12];
            Console.WriteLine("Inserire data di partenza");
            DateTime data = new DateTime();
            Console.WriteLine(data.ToString(Console.ReadLine()));
            Console.WriteLine("Inserire tariffe:");
            for(int i=1; i<13; i++)
            {
                Console.WriteLine("Inserire tariffa mese "+i);
                a[i]=int.Parse(Console.ReadLine());
                if(a[i]==data.Month)
                {
                    Console.WriteLine("La tua tariffa è di: "+a[i]);
                    break;
                }
            }
        }
    }
}
