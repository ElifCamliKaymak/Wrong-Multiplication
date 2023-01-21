int sayi1 = KullanicidanBirinciSayiyiAl();
Console.WriteLine(new string('*', 20));
int sayi2 = 0, carpimYuzler = 0, carpimOnlar = 0, carpimBirler = 0;

//Eğer ikinci sayı 3 basamaklıdan fazla ve negatif bir sayı girilirse kullanıcıdan tekrar ikinci sayıyı istemesini sağlayan blok
while (true)
{
    try
    {
        Console.Write("Lütfen ikinci sayıyı giriniz: ");
        sayi2 = int.Parse(Console.ReadLine());

        if (sayi2 < 999 && sayi2 > 0)
            break;
    }
    catch (Exception)
    {
        Console.WriteLine("Lütfen sayı girişi yapınız!");
    }
}
Console.WriteLine(new string('*', 20));

//ikinci sayı iki basamaklı olduğunda basamaklarına ayrılacağı blok 
if (sayi2 > 9 && sayi2 < 100)
{
    int onlar = OnlarBasamakHesapla(sayi2);
    carpimOnlar = onlar * sayi1;

    int birler = BirlerBasamakHesapla(sayi2);
    carpimBirler = birler * sayi1;
}
//ikinci sayı üç basamaklı olduğunda basamaklarına ayrılacağı blok
else
{
    int yuzler = YuzlerBasamakHesapla(sayi2);
    carpimYuzler = yuzler * sayi1;

    int onlar = OnlarBasamakHesapla(sayi2);
    carpimOnlar = onlar * sayi1;

    int birler = BirlerBasamakHesapla(sayi2);
    carpimBirler = birler * sayi1;
}

//İkinci sayının birler basamağı ile birinci sayının çarpımından gelen sonucun basamaklarının ayrılmasını sağlayan blok
int[] birlerCarpimiBasamaklar = new int[5];
for (int i = 0; i < 4; i++)
{
    birlerCarpimiBasamaklar[i] = carpimBirler % 10;
    carpimBirler = carpimBirler / 10;
}

//İkinci sayının onlar basamağı ile birinci sayının çarpımından gelen sonucun basamaklarının ayrılmasını sağlayan blok
int[] onlarCarpimiBasamaklar = new int[5];
for (int i = 0; i < 5; i++)
{
    onlarCarpimiBasamaklar[i] = carpimOnlar % 10;
    carpimOnlar = carpimOnlar / 10;
}

//İkinci sayının yüzler basamağı ile birinci sayının çarpımından gelen sonucun basamaklarının ayrılmasını sağlayan blok
int[] yuzlerCarpimiBasamaklar = new int[5];
for (int i = 0; i < 5; i++)
{
    yuzlerCarpimiBasamaklar[i] = carpimYuzler % 10;
    carpimYuzler = carpimYuzler / 10;
}

//toplama işlemi
int[] BasamakToplam = new int[5];
for (int i = 0; i < 5; i++)
{
    BasamakToplam[i] = (birlerCarpimiBasamaklar[i] + onlarCarpimiBasamaklar[i] + yuzlerCarpimiBasamaklar[i]) % 10;
}

//Toplam sayıyı düz yazabilmesi adına diziyi ters çevirdik
Array.Reverse(BasamakToplam);

Console.Write("Yanlış İşlem Sonucu: ");
//Eğer sayıların ikisi de tek haneli girilirse 4 basamaklı toplam dizimizin ilk 3 elemanı 0 olacağından sıfırları yazmaması adına bu if bloğu kullanıldı.
if (BasamakToplam[0] == 0 && BasamakToplam[1] == 0 && BasamakToplam[2] == 0)
{
    for (int i = 3; i < 5; i++)
    {
        Console.Write(BasamakToplam[i]);
    }
}
//Eğer  4 basamaklı toplam dizimizin ilk 2 elemanı 0 olursa sıfırları yazmaması adına bu else if bloğu kullanıldı.
else if (BasamakToplam[0] == 0 && BasamakToplam[1] == 0)
{
    for (int i = 2; i < 5; i++)
    {
        Console.Write(BasamakToplam[i]);
    }
}
//Eğer 4 basamaklı toplam dizimizin ilk elemanı 0 olursa sıfırları yazmaması adına bu else if bloğu kullanıldı.
else if (BasamakToplam[0] == 0)
{
    for (int i = 1; i < 5; i++)
    {
        Console.Write(BasamakToplam[i]);
    }
}
else
{
    for (int i = 1; i < 5; i++)
    {
        Console.Write(BasamakToplam[i]);
    }
}
Console.ReadKey();

int KullanicidanBirinciSayiyiAl()
{
    try
    {
        Console.Write("Lütfen birinci sayıyı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        return sayi;
    }
    catch (Exception)
    {
        Console.WriteLine("Lütfen sayı girişi yapınız!");
        return KullanicidanBirinciSayiyiAl();
    }

}
int YuzlerBasamakHesapla(int x)
{
    int y = x / 100;
    return y;
}
int OnlarBasamakHesapla(int x)
{
    int y = (x % 100) / 10;
    return y;
}
int BirlerBasamakHesapla(int x)
{
    int y = (x % 10);
    return y;
}