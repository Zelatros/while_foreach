class Program
{
    private static void Main(string[] args)
    {
        //while
        //1 den başlayarak girilen sayıya kadar (girilen sayı dahil) ortalama hesaplayan program.
        Console.Write("Lütfen bir sayı giriniz: ");
        int sayı = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;
        while (sayac<=sayı)
        {
            toplam += sayac;
            sayac ++;
        }

        Console.WriteLine("Ortalama: " + toplam/sayı);

        // 'a' dan 'z' ye kadar bütün harfleri yazdır.
        char character = 'a';
        while (character < 'z')
        {
            Console.WriteLine(character);   
            character ++;
        }

        Console.WriteLine("***foreach***");
        string[] arabalar = {"BMW","Audi","Ford"};

        foreach(var araba in arabalar)
        {
            Console.WriteLine(araba);
        }


    }
}