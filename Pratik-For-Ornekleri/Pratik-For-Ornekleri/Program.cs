// 1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

for (int i =0; i <10; i++)
{
    Console.WriteLine("Kenime inanıyorun, ben bu yazılım işini hallederim!");
}

// 2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

for (int i =1; i <= 20; i++)
{
    Console.WriteLine(i);
}

// 3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

for (int i = 2; i <= 20; i += 2)
{
    Console.WriteLine(i);
}

// 4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int total = 0;

for (int i = 50; i <= 150; i++)
{
    Console.WriteLine(total += i);
}

// 5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int tekSayiToplam = 0;
int ciftSayiToplam = 0;

for (int i = 1; i <= 120; i++)
{
    if ( i % 2 == 0)
    {
        tekSayiToplam += i;
    }
    else
    {
        ciftSayiToplam += i;
    }
}
Console.WriteLine($"Tek sayıların toplamı: {tekSayiToplam}");
Console.WriteLine($"Çift sayıların toplamı: {ciftSayiToplam}");