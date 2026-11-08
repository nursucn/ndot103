/*13te sıkıntı var*/

int satir;
Console.WriteLine("Satır sayısını girin: ");
satir = int.Parse(Console.ReadLine());

while (satir == 0)
{
    Console.WriteLine("Satır sayısı 0 olamaz. Geçerli değer girin: ");
    satir = int.Parse(Console.ReadLine());
}

while 
{
    Console.WriteLine("Geçerli bir sayı değeri girin: ");
    satir = int.Parse(Console.ReadLine());
}

Console.WriteLine("Birinci karakteri girin: ");
string bir = Console.ReadLine();
Console.WriteLine("İkinci karakteri girin: ");
string iki = Console.ReadLine();

for (int i = 1; i <= satir; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(iki + " ");
    }
    Console.WriteLine();
    for (int j = 0; j < i; j++)
    {
        Console.Write(bir + " ");
    }
    Console.WriteLine();
}
for (int i = 1; i < satir; i++)
{
    for (int j = satir - i; j > 0; j--)
    {
        Console.Write(iki + " ");
    }
    Console.WriteLine();
    for (int j = satir - i; j > 0; j--)
    {
        Console.Write(bir+ " ");
    }
    Console.WriteLine();
}