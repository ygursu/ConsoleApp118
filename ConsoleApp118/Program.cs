Console.WriteLine("Sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());
int toplam = sayi;
int i = 0, sayac = 1;

while (sayi != 0)
{
    Console.WriteLine("Sayı giriniz:");
    sayi = Convert.ToInt32(Console.ReadLine());
    toplam += sayi;
    if (sayi != 0)
        sayac++;
}

Console.WriteLine("Girilen sayıların toplamı={0} Ortalaması={1}", toplam, toplam / sayac);
Console.ReadKey();