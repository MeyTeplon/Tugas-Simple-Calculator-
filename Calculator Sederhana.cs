using System;

namespace Kalkulator1
{
  class Program
  {
    static void Main(string[] args)
    {
      int angka1=0;
      int angka2=0;
      float hasil=0;
      Console.WriteLine("================================");
      Console.WriteLine("| PROGRAM KALKULATOR SEDERHANA |");
      Console.WriteLine("================================");
      Console.WriteLine();
      Console.WriteLine("Opsi Operasi Hiitung Bilangan");
      Console.WriteLine("1. Penjumlahan");
      Console.WriteLine("2. Pengurangan");
      Console.WriteLine("3. Perkalian");
      Console.WriteLine("4. Pembagian");
      Console.WriteLine();
      Console.WriteLine("Pilih Opsi (1..4) : ");
      switch (Console.ReadLine())
      {
        case "1":
          Console.WriteLine("Masukan Angka Pertama : ");
          angka1=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Masukan Angka Kedua : ");
          angka2=Convert.ToInt32(Console.ReadLine());
          hasil=angka1+angka2;
        break;
        case "2":
          Console.WriteLine("Masukan Angka Pertama : ");
          angka1=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Masukan Angka Kedua : ");
          angka2=Convert.ToInt32(Console.ReadLine());
          hasil=angka1-angka2;
        break;
        case "3":
          Console.WriteLine("Masukan Angka Pertama : ");
          angka1=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Masukan Angka Kedua : ");
          angka2=Convert.ToInt32(Console.ReadLine());
          hasil=angka1*angka2;
        break;
        case "4":
          Console.WriteLine("Masukan Angka Pertama : ");
          angka1=Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Masukan Angka Kedua : ");
          angka2=Convert.ToInt32(Console.ReadLine());
          hasil=angka1/angka2;
        break;
      }
      Console.WriteLine("Hasilnya adalah "+hasil);
      
    }
  }
}
