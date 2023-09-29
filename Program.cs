namespace Objec_Oriented__Programs
{
    internal class Program
    {
                static void Main(string[] args)
        {
            Console.WriteLine("**********Object Oriented Programs**********");
            Console.WriteLine("\n1.Starpattern\n2.Star_pattern2\n3.Find Duplicate Elements");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Starpattern starpattern = new Starpattern();
                    starpattern.pattern();
                    break;

                case 2:
                    Star_pattern2 star_Pattern2 = new Star_pattern2();
                    star_Pattern2.star_pattern2();
                    break;

                case 3:
                    Duplicate_Elements duplicate_Elements = new Duplicate_Elements();
                    duplicate_Elements.duplicate_elements();
                    break;
            }

        }
    }
}