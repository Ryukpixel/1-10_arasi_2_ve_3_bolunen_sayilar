using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_10_arasi_2_ve_3_bolunen_sayilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string sonuc = "";

                for ( int i = 1; i <= 10; i++)
                {
                    if ( (i % 2 == 0) && (i % 3 == 0) )
                    {
                        sonuc += i + " ";
                    }
                }

                Console.WriteLine(" 1 ile 10 arasındaki ( 1 ve 10 dahil ) sayılardan hem 2'ye hem 3'e bölünen sayılar : {0} ", sonuc);
            }
            catch (Exception ex)
            {
                Console.WriteLine("HATA : {0}", ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
