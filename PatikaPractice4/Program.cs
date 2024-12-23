using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
        Console.WriteLine("Elma = 2 TL");
        Console.WriteLine("Armut = 3 TL");
        Console.WriteLine("Çilek = 3 TL");
        Console.WriteLine("Muz = 3 TL");
        Console.WriteLine("Diğer bütün meyveler = 4 TL");

        Console.WriteLine("\nHangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer):");
        string secim = Console.ReadLine().ToLower(); // Büyük/küçük harf duyarlılığı kaldırıldı

        int fiyat = 4; // Varsayılan fiyat

        switch (secim)
        {
            case "elma":
                fiyat = 2;
                break;
            case "armut":
                fiyat = 3;
                break;
            case "çilek":
                fiyat = 3;
                break;
            case "muz":
                fiyat = 3;
                break;
            default:
                fiyat = 4; // Diğer
                break;
        }

        Console.WriteLine($"Seçtiğiniz meyvenin fiyatı: {fiyat} TL");
    }
}
