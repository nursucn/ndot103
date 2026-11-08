/*Kazanma listesini yapamadım*/

String[] objeler = new string[3] {"taş", "kâğıt", "makas" };
Boolean secim = false;
int tur = 0;
string girilen="";
int bgalip = 0;
int ogalip = 0;
int berabere = 0;
while (true)
{
    secim = false;
    do
    {
        Console.WriteLine("Seçiminizi yazınız:");
        girilen = Console.ReadLine();
        if (girilen.ToLower() == "bitti")
        {
            Console.WriteLine("Oyun bitti.");
            break;
        }
        for (int i = 0; i < objeler.Length; i++)
        {
            if (girilen.ToLower() == objeler[i].ToLower())
            {
                secim = true;
                break;
            }
        }
        if (secim == false)
        {
            Console.WriteLine("Taş, kağıt, makas seçeneklerinden birini seçiniz.");
        }
    } while (secim == false);
    if (secim == false)
    {
        break;
    }
    tur ++;

    int rans = Random.Shared.Next(0, 3);
    Console.WriteLine("Bilgisayarın seçimi: " + objeler[rans]);

    if (objeler[rans].ToLower() == girilen.ToLower())
    {
        Console.WriteLine("Berabere!");
        berabere++;
    }
    else if ((objeler[rans].ToLower() == "taş" && girilen.ToLower() == "makas") || (objeler[rans].ToLower() == "kâğıt" && girilen.ToLower() == "taş") || (objeler[rans].ToLower() == "makas" && girilen.ToLower() == "kâğıt"))
    {
        Console.WriteLine("Bilgisayar kazandı!");
        bgalip++;
    }
    else
    {
        Console.WriteLine("Oyuncu kazandı!");
        ogalip++;
    }
}
Console.WriteLine("Oyun oynanma sayısı: " + tur.ToString());
Console.WriteLine("Bilgisayarın kazandığı oyun sayısı: " + bgalip.ToString());
Console.WriteLine("Oyuncunun kazandığı oyun sayısı: " + ogalip.ToString());
Console.WriteLine("Berabere biten oyun sayısı: "+berabere.ToString());