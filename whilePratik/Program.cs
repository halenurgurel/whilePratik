//1. soru
Console.WriteLine("1) Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırınız.");

int sayac = 1; // sayacı 1  alıyoruz

while (sayac <= 10) // 10 kere yazdırmasını istediğimiz için küçük eşittir alıyoruz.
{
    Console.WriteLine("Kendime inanıyorum ben bu yazılım işini hallederim. ");

    sayac++; // her seferinde 1 artırmazsak sonsuz döngüye girer. 10. seferde sayaçtan çıkması için artırma yapıyoruz.
}


Console.WriteLine(" ");
Console.WriteLine("------------------------------------------------------------------------------------------------");
Console.WriteLine(" ");


//2. soru
Console.WriteLine("1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");

int sayac1 = 1; // sayacı 1'den başlatıyoruz. (ilk sorudan ayrışması için ve ayrı ayrı çalışması için sayac1 şeklinde değişken tanımladım.

while (sayac1 <=20) //20'ye kadar döngüde kalması gerekiyor.
{
    Console.WriteLine(sayac);
    sayac1++; // 20'ye kadar sayması için artırıyoruz ve 20'den sonra döngüden çıkıyor.
}


Console.WriteLine(" ");

Console.WriteLine(" ");


//3. soru
Console.WriteLine("1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");

int sayac2 = 1; //1 ile başlatıyorum.

while (sayac2 <=20) //20'ye kadar devam etmesini istediğim için 20 küçük eşittir alıyorum.
{
    if (sayac2 % 2 == 0) //sadece çift sayıları ekrana yazdırmak istediğim için sayıların 2 ile kalanının 0 olması gerekiyor.
    {
        Console.WriteLine(sayac2); //sayıları yazdırıyorum.

    }
    sayac2++; // sonsuz bir döngüye girmemesi için sayıları artırıyorum ve 20'den sonra döngüden çıkıyor.
}

Console.WriteLine(" ");

Console.WriteLine(" ");


//4. soru
Console.WriteLine("50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");

int number = 50; //sayıları 50'den başlatmam gerekiyor.
int toplam = 0; // toplam ise şu an belli olmadığı için 0.

while (number <=150) // sayıların 150'ye kadar toplanması için küçük eşittir olarak aldım.
{
    toplam += number; // toplam, number kadar arttırılır ve sonuç yeniden toplam değişkenine yazılır.
    number++; // sonsuz bir döngüde kalmaması için sayıların artırılması gerekiyor ve 150'den sonra döngüden çıkılması gerekiyor. number++ ile artırdım.
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam); // sayıların toplamını yazdırdım.


Console.WriteLine(" ");

Console.WriteLine(" ");


//5. soru
Console.WriteLine("1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");

int number1 = 1; // yukarıdaki kodlarla aynı çalışabilmesi için farklı bir değer atadım.
int tekToplam = 0; //tek sayıların toplamını 0 aldık.
int ciftToplam = 0; //çift sayıların toplamını 0 aldık.


while (number1 <=120) //1 ile 120 arasındaki sayıları almak istediğimiz için 120'yi küçük eşittir aldık.
{
    if (number1 % 2 == 0) //çift sayıları bulmak için 2'ye bölümünden kalanı 0 aldık.
    {
        ciftToplam += number1; //ciftToplam, number1 kadar arttırılır ve sonuç yeniden ciftToplam değişkenine yazılır.

    }
    else //tek sayı
    {
        tekToplam += number1; //tekToplam, number1 kadar arttırılır ve sonuç yeniden tekToplam değişkenine yazılır.

    }
number1++; //sonsuz bir döngü olmaması için sayıları artırıyoruz ve 120'den sonra çıkış yapıyoruz.
}
Console.WriteLine("Tek sayıların toplamı: " + tekToplam); //tek sayıların toplamını yazıdıryoruz.
Console.WriteLine("Çift sayıların toplamı: " + ciftToplam); //çift sayıların toplamını yazıdırıyoruz.


