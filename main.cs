using System;

class Program
{
    static void Main(string[] args)
    {
        double sayi1, sayi2, sonuc;
        string islem;

        Console.WriteLine("İleri Düzey Hesap Makinesi");
        Console.WriteLine("Birinci sayıyı girin: ");
        sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("İkinci sayıyı girin (Eğer iki sayı gerekmiyorsa, 0 girin): ");
        sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
        Console.WriteLine("+  : Toplama");
        Console.WriteLine("-  : Çıkarma");
        Console.WriteLine("*  : Çarpma");
        Console.WriteLine("/  : Bölme");
        Console.WriteLine("^  : Üssü alma");
        Console.WriteLine("sqrt : Karekök");
        Console.WriteLine("sin : Sinüs");
        Console.WriteLine("cos : Kosinüs");
        Console.WriteLine("tan : Tanjant");
        islem = Console.ReadLine().ToLower();

        switch (islem)
        {
            case "+":
                sonuc = sayi1 + sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
                break;
            case "-":
                sonuc = sayi1 - sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
                break;
            case "*":
                sonuc = sayi1 * sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
                break;
            case "/":
                if (sayi2 != 0)
                {
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                }
                else
                {
                    Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz!");
                }
                break;
            case "^":
                sonuc = Math.Pow(sayi1, sayi2);  // Üs alma işlemi
                Console.WriteLine("Sonuç: " + sonuc);
                break;
            case "sqrt":
                if (sayi1 >= 0)
                {
                    sonuc = Math.Sqrt(sayi1);  // Karekök alma
                    Console.WriteLine("Sonuç: " + sonuc);
                }
                else
                {
                    Console.WriteLine("Negatif sayının karekökü alınamaz!");
                }
                break;
            case "sin":
                sonuc = Math.Sin(sayi1);  // Sinüs işlemi
                Console.WriteLine("Sonuç: " + sonuc);
                break;
            case "cos":
                sonuc = Math.Cos(sayi1);  // Kosinüs işlemi
                Console.WriteLine("Sonuç: " + sonuc);
                break;
            case "tan":
                sonuc = Math.Tan(sayi1);  // Tanjant işlemi
                Console.WriteLine("Sonuç: " + sonuc);
                break;
            default:
                Console.WriteLine("Geçersiz işlem.");
                break;
        }

        Console.ReadLine();
    }
}