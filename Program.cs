using System;
namespace karakter_degistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cümleni gir.");
            string[] kelimeler = Console.ReadLine().Split();
            
            for(int i=0;i<kelimeler.Length;i++)
            {
                char[] harfler=kelimeler[i].ToArray();
                char harf=harfler[0];
                harfler[0]=harfler[harfler.Length-1];
                harfler[harfler.Length - 1] = harf;
                string yenicumle=string.Concat(harfler);
                Console.Write(yenicumle+" ");
            }
        
        }
    }
}