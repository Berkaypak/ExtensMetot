namespace ExtMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 382;
            Console.WriteLine(a.SayıYaz());
        }

    }               //BERKAY PAK
    static class ExtensionMetot // class static olmalıdır
    {
        public static string SayıYaz(this int s) // metot static olmalıdır
        {
            // İNT TİPİPNDE BİR SAYININ YAZILIŞINI (3 BASAMAĞA KADAR) DEĞİŞKEN ÜZERİNDEN YAPAN METOT
            string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            int b = s % 10; int o = s % 100; o = o / 10; int y = s / 100;
            if (y == 1) return " yüz " + onlar[o] + " " + birler[b];
            if (y != 0) return birler[y] + " yüz " + onlar[o] + " " + birler[b];
            else if (o != 0) return onlar[o] + " " + birler[b];
            else if (b != 0) return birler[b];
            return "sıfır";
        }
    }
}
