internal class Program
{
    private static void Main(string[] args)
    {
        double bölüm;
        int sayi1, sayi2;

        Console.WriteLine("lütfen 1. sayıyı giriniz:");
        sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("lütfen 2. sayıyı giriniz");
        sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("1-toplama\n" + "2-çıkarma\n" + "3-çarpma\n" + "4-bölme");
        Console.WriteLine("lütfen yapmak istediğiniz işlemi seçiniz");
        string secim = Console.ReadLine();

        switch (secim)
        {
            case "1":

                Console.WriteLine("girdiğiniz iki sayının toplamı:" + (sayi1 + sayi2));
                Console.ReadLine();

                break;

            case "2":

                if (sayi1 > sayi2)
                {
                    Console.WriteLine("girdiğiniz iki sayının farkı:" + (sayi1 - sayi2));
                    Console.ReadLine();
                }

                else if (sayi2 > sayi1)
                {
                    Console.WriteLine("girdiğiniz iki sayının farkı:" + (sayi2 - sayi1));
                    Console.ReadLine();
                }

                break;

            case "3":

                Console.WriteLine("girdiğiniz iki sayının çarpımı:" + sayi1 * sayi2);
                Console.ReadLine();

                break;

            case "4":

                bölüm = Convert.ToDouble(sayi1 / sayi2);
                Console.WriteLine("girdiğiniz iki sayının bölümü:" + bölüm);
                Console.ReadLine();

                break;

            default:

                Console.WriteLine("lütfen geçerli bir değer giriniz.");

                break;
        }
    }
}