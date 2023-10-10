using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan_pertama
{
    class Program
    {
        static void Main(string[] args)
        {//Begin

            //numeric p,l,luas
            double p, l, luas;

            //Display 'Masukkan panjangnya: '
            Console.Write("Masukkan Panjangnya = ");

            //Accept p
            p = Convert.ToDouble(Console.ReadLine());

            //Display 'Masukkan lebarnya: '
            Console.Write("Masukkan Lebarnya = ");

            //Accept l
            l = Convert.ToDouble(Console.ReadLine());

            //Compute luas = p*l
            luas = p * l;


            //Display 'Luasnya= ' +luas
            Console.WriteLine("Panjang = {0} Lebar = {1} Luasnya {2}", p, l, luas);
            Console.ReadKey();

        }//End
    }
}
