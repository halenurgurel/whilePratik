//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

/*int sayac = 1;

while (sayac <= 10)
{
    Console.WriteLine("Kendime inanıyorum ben bu yazılım işini hallederim. ");

    sayac++;
}*/


//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

/*int sayac = 1;

while (sayac <=20)
{
    Console.WriteLine(sayac);
    sayac++;
}*/

//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

/*int sayac = 1;

while (sayac <=20)
{
    if (sayac % 2 == 0)
    {
        Console.WriteLine(sayac);

    }
    sayac++;
}*/


//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

/*int number = 50;
int toplam = 0;

while (number <=150)
{
    toplam += number;
    number++;
}
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);
*/



//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int number = 1;
int tekToplam = 0;
int ciftToplam = 0;


while (number <=120)
{
    if (number % 2 == 0) //cift sayı
    {
        ciftToplam += number;
        
    }
    else //tek sayı
    {
        tekToplam += number;
        
    }
number++;
}
Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);


