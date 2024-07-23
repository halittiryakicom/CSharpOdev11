//Hafta 2 Kapanış Ödevi

/* 
* 1 - Aşağıdaki çıktıyı yazan bir program.
* Merhaba
* Nasılsın ?
* İyiyim
* Sen nasılsın ?
*/
//Console.WriteLine("<---------- 1. Soru ---------->");
//Console.WriteLine("Merhaba\nNasılsın ?\nİyiyim\nSen nasılsın ?");

/*
 * 2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
 */
//Console.WriteLine("<---------- 2. Soru ---------->");
//string name = "Halit";
//int number = 61;
//Console.WriteLine($"{name} isimli kullanıcının uğurlu sayısı {number}'dır.");

/*
 * 3 - Rastgele bir sayı üretip , ekrana yazdırınız.
 */
//Console.WriteLine("<---------- 3. Soru ---------->");
//Random rnd = new Random();
//int numberRandom = rnd.Next(1, 100);
//Console.WriteLine($"Rastgele üretilen sayı:{numberRandom}");

/*
 * 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
 */
//Console.WriteLine("<---------- 4. Soru ---------->");
//Random rnd = new Random();
//int numberRandom = rnd.Next(1, 100);
//int result = numberRandom % 3;
//Console.WriteLine($"Rastgele üretilen sayı:{numberRandom}\n3'e bölümünden kalan: {result}");



/*
 * Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
 */
//Console.WriteLine("<---------- 5. Soru ---------->");
//Console.WriteLine("Lütfen yaşınızı giriniz: ");
//string age = Console.ReadLine();
//bool result = Int32.TryParse(age, out int ageResult);
//if (result)
//{
//    if (ageResult > 18)
//        Console.WriteLine("+");
//    else
//        Console.WriteLine("-");
//}
//else
//    Console.WriteLine("Lütfen rakamlar ile yaşınızı giriniz.");


/*
 * Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
 */
//Console.WriteLine("<---------- 6. Soru ---------->");
//for (int count = 0; count < 10; count++)
//    Console.WriteLine($"{count+1}.Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");


/*
 * Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
 */
//Console.WriteLine("<---------- 7. Soru ---------->");
//Console.Write("Lütfen bir metin giriniz: ");
//string textOne = Console.ReadLine();
//Console.Write("Lütfen bir metin giriniz: ");
//string textTwo = Console.ReadLine();
//string empty = textOne;
//textOne = textTwo;
//textTwo = empty;
//Console.WriteLine($"Yerleri değiştirildi 1.kelime artık {textOne} oldu. 2 kelime de artık {textTwo} oldu.");


/*
 * Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
 */
//Console.WriteLine("<---------- 8. Soru ---------->");
//using System.Diagnostics.Metrics;
//using System;

//static void BenDegerDondurmem()
//{
//    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
//}
//BenDegerDondurmem();


/*
 * İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
 */
//Console.WriteLine("<---------- 9. Soru ---------->");
//static int total(int sayi1, int sayi2)
//{
//    int toplam = sayi1 + sayi2;
//    return toplam;
//}
//int sayi1 = 10;
//int sayi2 = 20;
//Console.WriteLine($"{sayi1} + {sayi2} = {total(sayi1,sayi2)}");


/*
 * Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
 */
//Console.WriteLine("<---------- 10. Soru ---------->");
//bool inputValue;
//Console.Write("Lütfen true ya da false değeri giriniz:");
//while (!bool.TryParse(Console.ReadLine(), out inputValue)) //burada doğru değer girip girmediğini kontrol ediyoruz.
//{
//    Console.WriteLine("Geçersiz giriş. Lütfen true ya da false değeri giriniz:");
//}
//userResponseValue(inputValue);
//static void userResponseValue(bool input)
//{
//    if (input)
//        Console.WriteLine("True");
//    else
//        Console.WriteLine("False");
//}


/*
 * 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
 */
//Console.WriteLine("<---------- 11. Soru ---------->");
//int ageOne = 20;
//int ageTwo = 4;
//int ageThree = 10;

//static int bigAge(int ageOne, int ageTwo, int ageThree)
//{
//    int agePerson = Math.Max(ageOne, Math.Max(ageTwo, ageThree));//burada karşılatırma yapıyoruz.
//    return agePerson;
//}

//Console.WriteLine($"Yaşı en büyük olan: {bigAge(ageOne,ageTwo,ageThree)}");


/*
 *  Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
 */
//Console.WriteLine("<---------- 12. Soru ---------->");
//int maxValue = int.MinValue;// burada int değerinin en küçük olanını tanımladık.
//while (true)
//{
//    Console.WriteLine("Lütfen bir sayı giriniz: ");
//    string number = Console.ReadLine();
//    bool active = int.TryParse(number, out int resultNumber);
//    if (active == true)
//        Console.WriteLine($"Girilen sayıların en büyüğü: {bigNumber(resultNumber, ref maxValue)}");//burada ref  ile değişkinimizde ki değer işlem yapılınca değişsin diye gönderdik
//    else
//        Console.WriteLine("Lütfen sayı giriniz.");
//}
//static int bigNumber(int number, ref int max)
//{
//    max = Math.Max(number, max);//burada karşılaştırma yaptık.
//    return max; //değeri döndürdük
//}


/*
 *  Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
 */
//Console.WriteLine("<---------- 13. Soru ---------->");
//Console.Write("Lütfen birinci isimi giriniz: ");
//string name = Console.ReadLine();
//Console.Write("Lütfen ikinci isimi giriniz: ");
//string surname = Console.ReadLine();
//changeName(ref name, ref surname);
//Console.WriteLine($"İsimlerinizin yerleri değiştirildi\n1. İsim: {name}\n2. İsim: {surname}");
//static void changeName(ref string nameOne, ref string nameTwo)
//{
//    string temp = nameOne;
//    nameOne = nameTwo;
//    nameTwo = temp;
//}


/*
 * Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
 */
//Console.WriteLine("<---------- 14. Soru ---------->");
//Console.Write("Lütfen bir sayı giriniz: ");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Sayınız çift ise true değil ise false yazacaktır. Bilgi:{addEven(number)}"); 
//static bool addEven(int number)
//{
//    if (number%2 == 0)
//        return true;
//    else
//        return false;
//}


/*
 * Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
 */
//Console.WriteLine("<---------- 15. Soru ---------->");
//Console.Write("Lütfen gittiğiniz hızı yazınız: ");
//int speed = Convert.ToInt32(Console.ReadLine());
//Console.Write("Lütfen gittiğiniz süreyi yazınız. (Sayı olarak): ");
//int time = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Seyahat ettiğiniz yol {roadTraveled(speed,time)} km'dir.");
//static int roadTraveled(int speed, int time)
//{
//    int km = speed * time;
//    return km;
//}


/*
 * Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
 */
//Console.WriteLine("<---------- 16. Soru ---------->");
//Console.Write("Lütfen dairenin yarı çap değerini giriniz: ");
//int r = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Dairenin alanı: {circleArea(r)}");
//static int circleArea(int r)
//{ 
//    int pi = 3;
//    int area = pi * (r * r);
//    return area;
//}


/*
 * "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
 */
//Console.WriteLine("<---------- 17. Soru ---------->");
//string text = "Zaman bir GeRi SayIm";
//Console.WriteLine($"Büyük harfle yazım: {text.ToUpper()}\nKüçük harfle yazım: {text.ToLower()}");


/*
 * "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
 */
//Console.WriteLine("<---------- 18. Soru ---------->");
//string text = "    Selamlar   ";
//string trimmedText = text.Trim();
//Console.WriteLine($"Yazının boşluk kaldırılmadan önceki hali: {text}\nBoşluk kaldırıldıktan sonraki hali: {trimmedText}");