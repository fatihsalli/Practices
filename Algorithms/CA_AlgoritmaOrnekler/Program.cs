using System;

namespace CA_AlgoritmaOrnekler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region EXAMPLE 1
            //Örnek 1 - Girilen 3 basamaklı sayının basamaklarına ayıran örnek (birler,onlar,yüzler basamağındaki sayılar)

            //Çözüm 

            //Console.WriteLine("3 basamaklı bir sayı giriniz.");

            //int sayi = int.Parse(Console.ReadLine());

            //int yuzlerBasamagi = sayi / 100;
            //sayi = sayi - (yuzlerBasamagi * 100);
            //int onlarBasamagi = sayi / 10;
            //sayi = sayi - (onlarBasamagi * 10);
            //int birlerBasamagi = sayi;

            //int birlerBasamagi = sayi % 10;
            //int onlarBasamagi = ((sayi % 100) - (sayi % 10)) / 10;
            //int yuzlerBasamagi = (sayi - (sayi % 100)) / 100;   //Modlu alternatifi

            //Console.WriteLine($"Birler basamağı: {birlerBasamagi} \nOnlar basamağı: {onlarBasamagi} \nYüzler basamağı: {yuzlerBasamagi}");
            //Console.Read(); 
            #endregion

            #region EXAMPLE 2
            //Örnek 2 - Bir otoparka park eden taksinin 1 saati 5TL, minibüsün 1 saati 6TL, ticari aracın 1 saati 6.5TL dir. Taksi 1 saatten sonraki her saat başı için %20 daha fazla, minibüs 1 saatten sonraki her saat başı için toplamda %21.5 ve ticari araç 1 saatten sonraki her saat başı için toplamda %25 daha fazla ödeme yapmaktadır. Buna göre klavyeden girilen araba tipi ve kalınan saat bilgisi girildikten sonra ekrana ödenecek otopark ücretini hesaplayan programın kodlarını yazınız.

            //double taksi = 5;
            //double minibus = 6;
            //double ticari = 6.5;
            //double toplam = 0;

            //Console.WriteLine("Aracınız Nedir?");
            //string arac = Console.ReadLine().ToLower();
            //Console.WriteLine("Kaç Saat Otopark Kullanılmıştır?");
            //int saat = int.Parse(Console.ReadLine());

            //if(arac=="taksi")
            //{
            //    for(int i=1;i<=saat;i++)
            //    {
            //       toplam += taksi;
            //       taksi=taksi*1.20;
            //    }
            //}
            //else if(arac=="minibüs")
            //{
            //    for (int i = 1; i <= saat; i++)
            //    {
            //        toplam += minibus;
            //        minibus = minibus * 1.215;
            //    }
            //}
            //else if(arac=="ticari")
            //{
            //    for (int i = 1; i <= saat; i++)
            //    {
            //        toplam += ticari;
            //        ticari = ticari * 1.25;
            //    }
            //}


            //Console.WriteLine($"Ödenecek Ücret:{toplam} TL");

            #endregion

            #region EXAMPLE 3
            ////Örnek 3- Kullanıcı tarafından girilen üç sayıdan en büyük ile en küçük sayıyı toplayıp sonucu ekrana yazdırın.

            //Console.WriteLine("Lütfen birinci sayıyı yazınız.");
            //int x = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci sayıyı yazınız.");
            //int y = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen üçüncü sayıyı yazınız.");
            //int z = int.Parse(Console.ReadLine());

            //int sayiKucuk = 0;
            //int sayiBuyuk = 0;

            //if(x<y&&x<z)
            //{
            //    sayiKucuk = x;
            //}
            //else if(y<x&&y<z)
            //{
            //    sayiKucuk = y;
            //}
            //else
            //{
            //    sayiKucuk = z;
            //}

            //if (x > y && x > z)
            //{
            //    sayiBuyuk = x;
            //}
            //else if (y > x && y > z)
            //{
            //    sayiBuyuk = y;
            //}
            //else
            //{
            //    sayiBuyuk = z;
            //}

            //Console.WriteLine("Toplam: ",(sayiKucuk+sayiBuyuk));
            //Console.Read();

            #endregion

            #region EXAMPLE 4
            //Örnek 4: Elemanları tam sayı olan bir A dizisinin(20 elemanlı) rastgele sayılar atayan, sonra dizi elemanlarının aritmetik ortalamasını hesaplayan ve elemanlardan kaç tanesinin bu ortalamadan büyük ve küçük olduğunu sayan programın c# kodlarını yazınız.

            //Random rnd=new Random();
            //int[] liste = new int[20];
            //double toplam = 0;
            //int sayacBuyuk = 0;
            //int sayacKucuk = 0;

            //for (int i = 0; i < liste.Length; i++) //0-100 arasında rastgele dizi oluşturan kod 20 adet
            //{
            //    int sayiRandom=rnd.Next(0,1000);
            //    liste[i]=sayiRandom;
            //    toplam += liste[i];
            //    Console.WriteLine($"Sayı {i+1}: {sayiRandom}");
            //}
            //double ortalama=toplam/liste.Length;

            //for(int k = 0; k < liste.Length; k++)

            //    if (ortalama < liste[k])
            //    {
            //        sayacBuyuk++;
            //    }
            //    else
            //    {
            //        sayacKucuk++;
            //    }
            //Console.WriteLine($"Toplam: {toplam}");
            //Console.WriteLine($"Aritmetik ortalaması: {ortalama}");
            //Console.WriteLine($"Aritmetik ortalamadan büyük olanlar: {sayacBuyuk} adet");
            //Console.WriteLine($"Aritmetik ortalamadan büyük olanlar: {sayacKucuk} adet");
            //Console.Read(); 
            #endregion

            #region EXAMPLE 5
            //Örnek 5: İki iç açısı verilen üçgenin diğer açısını bulan örnek:

            //Console.WriteLine("Birinci açıyı giriniz.");
            //int x=int.Parse(Console.ReadLine());
            //Console.WriteLine("Birinci açıyı giriniz.");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"3.Açı: {180-(x+y)}"); 
            #endregion

            #region EXAMPLE 6
            //Örnek 6: Kullanıcıya kaç tane sayıyı toplayacağını sorup, kullanıcının toplayacağı kadar sayıyı kullanıcıya tek tek soran ve kullanıcının yazdığı bu sayıların toplamını ekrana yazan programı yazınız

            //Console.WriteLine("Kaç adet sayıyı toplayacaksınız?");
            //int x=Convert.ToInt32(Console.ReadLine());
            //int toplam = 0;

            //for(int i=0;i<x;i++)
            //{
            //    Console.WriteLine("Lütfen sayıyı giriniz.");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;
            //}
            //Console.WriteLine("Toplam: " + toplam); 
            #endregion

            #region EXAMPLE 7
            //Örnek 7: Taban değeri ve üssü kullanıcı tarafından girilen işlemin sonucunu For döngüsü kullanarak hesaplayan örnek:

            //Console.WriteLine("Taban değerini giriniz.");
            //int t=Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Üs değerini giriniz");
            //int u=Convert.ToInt32(Console.ReadLine());
            //int sonuc = 1;

            //for (int i = 0; i < u; i++)
            //{
            //    sonuc = sonuc*t; //veya çarp aktar metodu ile sonuc *= t diyebilirdik.
            //}

            //Console.WriteLine($"Tabanı {t} ve üssü {u} olan sayının değeri: {sonuc}");
            //Console.Read();

            #endregion

            #region EXAMPLE 8
            //Örnek 8 Dik kenar uzunlukları verilen dik üçgende hipotenüs hesaplayan örnek:

            //double k1, k2, k3;

            //Console.WriteLine("1.Dik kenar uzunluğunu giriniz.");
            //k1=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("2.Dik kenar uzunluğunu giriniz.");
            //k2=Convert.ToDouble(Console.ReadLine());

            //k3 = Math.Sqrt((k1*k1)+(k2*k2));

            //Console.WriteLine($"Hipotenüs uzunluğu: {k3}"); 
            #endregion

            #region EXAMPLE 9
            //Örnek 9 - 1'den 10'a kadar olan sayıların küplerinin toplamını bulan uygulamayı yazınız.

            #region ÇÖZÜM 1
            //Çözüm 1
            //int[] liste = new int[10];
            //double toplam = 0;


            //for (int i = 0; i < liste.Length; i++)
            //{
            //    liste[i] = i+1;
            //    toplam =toplam+ Math.Pow(Math.Abs(liste[i]), 3);
            //}

            //Console.WriteLine(toplam);
            //Console.Read(); 
            #endregion

            #region ÇÖZÜM 2
            //Çözüm 2

            //double toplam = 0;

            //for (int i = 1; i < 11; i++)
            //{
            //    toplam += Math.Pow(Math.Abs(i), 3);
            //}

            //Console.WriteLine(toplam);
            //Console.Read(); 
            #endregion

            #region ÇÖZÜM 3
            //Çözüm 3

            //int sayac = 1;
            //double toplamSonuc = 0;
            //string sonuc = "";

            //while(sayac<=10)
            //{
            //    toplamSonuc += Math.Pow(sayac, 3);

            //    if(sayac != 10)
            //    {
            //        sonuc += $"{sayac}³ +";
            //    }
            //    else
            //    {
            //        sonuc += $"{sayac}³ = {toplamSonuc}";
            //    }
            //    sayac++;
            //}

            //Console.WriteLine(sonuc);
            //Console.Read();  
            #endregion
            #endregion

            #region EXAMPLE 10
            //öRNEK 10 - Doğum tarihi girilen kişinin yaşını hesaplayan uygulamayı yazınız.

            #region ÇÖZÜM1
            //Çözüm 1

            //DateTime today = DateTime.Now;
            //Console.WriteLine("Lütfen doğum tarihinizi giriniz.");
            //DateTime birthdate=Convert.ToDateTime(Console.ReadLine());
            //int yas = 0;

            //if(today.Month>birthdate.Month)
            //{
            //    yas = today.Year - birthdate.Year;
            //}
            //else if(today.Month<birthdate.Month)
            //{
            //    yas = (today.Year - birthdate.Year)-1;
            //}
            //else
            //{
            //    if(today.Day>=birthdate.Day)
            //    {
            //        yas = today.Year - birthdate.Year;
            //    }
            //    else
            //    {
            //        yas = (today.Year - birthdate.Year) - 1;
            //    }
            //}

            //Console.WriteLine(yas);
            //Console.Read(); 
            #endregion

            #region ÇÖZÜM2
            //Çözüm 2

            //DateTime today = DateTime.Now;
            //Console.WriteLine("Lütfen doğum tarihinizi giriniz.");
            //DateTime birthdate = Convert.ToDateTime(Console.ReadLine());

            //TimeSpan sonuc = today - birthdate;
            //Console.WriteLine(sonuc.Days); //Timespan komutu için yazıldı ama hatalı 365 gün 6 saat var çünkü
            //Console.Read(); 
            #endregion

            #region ÇÖZÜM3
            //Çözüm 3

            //DateTime today = DateTime.Now;
            //Console.WriteLine("Lütfen doğum tarihinizi giriniz.");
            //DateTime birthdate = Convert.ToDateTime(Console.ReadLine());


            //int yas = today.Year-birthdate.Year;

            //if(birthdate>today.AddYears(-yas))
            //{
            //    yas--;
            //}

            //Console.WriteLine(yas);
            //Console.Read();  
            #endregion

            #endregion

            #region EXAMPLE 11
            //Örnek 11 - Girilen sayının faktöriyelini hesaplayan uygulamayı yazınız.

            #region ÇÖZÜM1
            //Çözüm 1

            //Console.WriteLine("Lütfen bir sayı giriniz.");
            //int sayi = int.Parse(Console.ReadLine());

            //for (int i = sayi-1; i > 0; i--)
            //{
            //    sayi *= i;
            //}

            //Console.WriteLine($"Girdiğiniz sayının faktöriyeli= {sayi}");
            //Console.Read(); 
            #endregion

            #region ÇÖZÜM2
            //Console.WriteLine("Lütfen bir sayı giriniz.");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //string sonucYazi = "";

            //while(sayi > 0)
            //{
            //    sonuc *= sayi;
            //    if(sayi != 1)
            //    {
            //        sonucYazi += $"{sayi} X ";
            //    }
            //    else
            //    {
            //        sonucYazi += $"{sayi} = {sonuc}";
            //    }
            //    sayi--;
            //}
            //Console.WriteLine(sonucYazi);
            //Console.Read(); 
            #endregion
            #endregion

            #region EXAMPLE 12
            //Örnek 12 - Pozitif sayılarda çarpma işlemini toplama kullanarak bulan uygulamayı yazınız.

            #region ÇÖZÜM 1
            //Çözüm 1

            //Console.WriteLine("1.Sayıyı Giriniz.");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı Giriniz.");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int toplam = 0;

            //for (int i = 0; i < sayi2; i++)
            //{
            //    toplam += sayi1;
            //}

            //Console.WriteLine($"Sonuç= {toplam}"); 
            #endregion

            #region ÇÖZÜM 2
            //Çözüm 2

            //Console.WriteLine("1.Sayıyı Giriniz.");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı Giriniz.");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int toplam = 0;
            //int sayac = 0;

            //while(sayac < sayi1)
            //{
            //    toplam += sayi2;
            //    sayac++;
            //}

            //Console.WriteLine($"Sonuç= {toplam}"); 
            #endregion

            #region ÇÖZÜM 3
            //Çözüm 3

            //Console.WriteLine("1.Sayıyı Giriniz.");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı Giriniz.");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int toplam = 0;
            //int sayac =0;

            //do
            //{
            //    toplam += sayi2;
            //    sayac++;
            //} while (sayac<sayi1);

            //Console.WriteLine($"Sonuç= {toplam}");
            //Console.Read(); 
            #endregion

            #endregion

            #region EXAMPLE 13
            //Örnek 13 - Pozitif sayılarda bölme işlemini çıkarma kullanarak yapan uygulamayı yapınız?

            //Çözüm 1

            //Console.WriteLine("1.Sayıyı Giriniz.");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı Giriniz.");

            //int sayi2 = int.Parse(Console.ReadLine());
            //int sonuc = 0;
            //int kalan = 0;
            //int isayi = sayi1;

            //for (int i = 1; i < isayi; i++)
            //{
            //    if(sayi1>=sayi2)
            //    {
            //        sonuc++;
            //        sayi1=sayi1- sayi2;
            //    }
            //    else
            //    {
            //        kalan = sayi1;
            //        break;
            //    }
            //}

            //Console.WriteLine($"Sonuç: {sonuc} ve Kalan: {kalan}");
            //Console.Read(); 
            #endregion

            #region EXAMPLE 14
            //Örnek 14 - Girilen pozitif sayının kaç basamaklı olduğunu söyleyen uygulamayı yazınız.

            #region ÇÖZÜM 1
            //Çözüm 1

            //Console.WriteLine("Lütfen bir sayı giriniz.");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int basamak = 0;
            //int isayi = sayi;

            //for (int i = 0; i < isayi; i++)
            //{
            //    if (sayi >= 10)
            //    {
            //        sayi = sayi / 10;
            //        basamak++;
            //    }
            //    else if(sayi < 10)
            //    {
            //        basamak++;
            //        break;
            //    }
            //}

            //Console.WriteLine($"Sayı {basamak} basamaklıdır.");
            //Console.Read(); 
            #endregion

            #region ÇÖZÜM 2
            //Çözüm 2

            //Console.WriteLine("Lütfen bir sayı giriniz.");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayac = 0;

            //while(sayi>=10)
            //{
            //    sayi /= 10;
            //    sayac++;
            //}
            //sayac++;

            //Console.WriteLine($"Sayı {sayac} basamaklıdır.");
            //Console.Read(); 
            #endregion

            #region ÇÖZÜM 3
            //Çözüm 3

            // string x= "Fatih Şallı"; ==> char[] x = {'f','a','t'...}

            //Console.WriteLine("Lütfen bir sayı giriniz.");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Basamak değeri: {sayi.ToString().Length}");
            //Console.Read(); 
            #endregion


            #endregion

            #region EXAMPLE 15
            //Örnek 15 - Girilen 3 basamaklı bir sayının basamaklarının küpleri toplamı sayının kendine eşit olup olmadığını bulan uygulamayı yazınız.

            //Console.WriteLine("3 basamaklı bir sayı giriniz.");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sayac = 1;
            //int isayi = sayi;
            //int y = sayi / 100;
            //int o = (sayi - (y * 100)) / 10;
            //int b = sayi % 10;
            //int toplam=(y*y*y)+(o*o*o)+(b*b*b);


            //while (sayi>=10)
            //{
            //    sayi /= 10;
            //    sayac++;
            //}

            //if(sayac==3)
            //{
            //    if(isayi==toplam)
            //    {
            //        Console.WriteLine("Eşittir.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Eşit değildir.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen 3 basamaklı bir sayı giriniz.");
            //}

            //Console.Read(); 
            #endregion

            #region EXAMPLE 16
            //Örnek 16 - 3 basamaklı bir sayıların basamaklarının küpleri toplamı sayının kendine eşit olan sayıları bulunuz.

            //string yazi = "";

            //for (int i = 100; i < 1000; i++)
            //{
            //    int y = i / 100;
            //    int o = (i - (y * 100)) / 10;
            //    int b = i % 10;
            //    int toplam = (y * y * y) + (o * o * o) + (b * b * b);

            //    if(i==toplam)
            //    {
            //        yazi += $"{i} ";
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //}

            //Console.WriteLine($"Basamaklarının küpleri toplamı kendine eşit olan sayılar: \n{yazi}");
            //Console.Read(); 
            #endregion






        }
    }
}
