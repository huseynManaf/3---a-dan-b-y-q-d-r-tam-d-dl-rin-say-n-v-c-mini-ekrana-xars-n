namespace a_dan_b_yə_qədər_tam_ədədlərin_sayını_və_cəmini_ekrana_çıxarsın
{
    internal class Program
    {
        static void Main(string[] args)
        {             
            Console.Write("Baslangic ededi daxil edin: ");
                      int a = int.Parse(Console.ReadLine());
                      Console.Write("Son ededi daxil edin: ");
                      int b = int.Parse(Console.ReadLine());

            int count = 0;
             int sum = 0;

            for (int i = a; i <= b; i++)
            {
                sum += i;
                count++;
            }

            Console.WriteLine($"\nEdedlerin sayi: {count}\nEdedlerin cemi: {sum}");
        }
    }
}
       