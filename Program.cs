﻿using System;

namespace try_catch_finally
{
        class Program
    {
        static void Main(string[] args)
        {
        //  try
        //     {
        //         Console.WriteLine("Bir sayı giriniz:");
        //         int sayi = Convert.ToInt32(Console.ReadLine());
        //         Console.WriteLine("Girmiş olduğunuz sayi :" + sayi);
        //     }
        //     catch (Exception ex)
        //     {
        //         Console.WriteLine("Hata"+ ex.Message.ToString());
        //     }
            // finally
            // {
            //     Console.WriteLine("İşlem Tamamlandı");
            // }


            try
            {   
                // int a = int.Parse(null);
                //int a = int.Parse("Test");
                int b = int.Parse("23231213213312312");


            }

            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz!");
                Console.WriteLine(ex);
            }

            catch(FormatException ex){
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                Console.WriteLine("Aşırı değer girdiniz");
                Console.WriteLine(ex);
            }
        }
    }
} 

