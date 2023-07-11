namespace GithubDemon
{
    internal class Progrem
    {
        static void Main(string[] args)
        {
            string input = "";
            Console.Write("Iltimos son kiriting: ");
            input = Console.ReadLine();
            int intOut;
            bool tryOut = int.TryParse(input, out intOut);
            int r1, r10, r100, r1000, r10000, r100000;
            r1 = intOut % 10;
            r10 = intOut / 10 % 10;
            r100 = intOut / 100 % 10;
            r1000 = intOut / 1000 % 10;
            r10000 = intOut / 10000 % 10;
            r100000 = intOut / 100000 % 10;
            if (intOut < 1000000)
            {
                switch (r100000)
                {
                    case 1:
                        Console.Write("Bir yuz ");
                        break;
                    case 2:
                        Console.Write("Ikki yuz ");
                        break;
                    case 3:
                        Console.Write("Uch yuz ");
                        break;
                    case 4:
                        Console.Write("To`rt yuz ");
                        break;
                    case 5:
                        Console.Write("Besh yuz ");
                        break;
                    case 6:
                        Console.Write("Olti yuz ");
                        break;
                    case 7:
                        Console.Write("Yetti yuz ");
                        break;
                    case 8:
                        Console.Write("Sakkiz yuz ");
                        break;
                    case 9:
                        Console.Write("To`qqiz yuz ");
                        break;
                }
                switch (r10000)
                {
                    case 1:
                        Console.Write("On ");
                        break;
                    case 2:
                        Console.Write("Yigirma ");
                        break;
                    case 3:
                        Console.Write("Ottiz ");
                        break;
                    case 4:
                        Console.Write("Qiriq ");
                        break;
                    case 5:
                        Console.Write("Ellik ");
                        break;
                    case 6:
                        Console.Write("Oltmish ");
                        break;
                    case 7:
                        Console.Write("Yetmish ");
                        break;
                    case 8:
                        Console.Write("Sakson ");
                        break;
                    case 9:
                        Console.Write("To`qson ");
                        break;
                    case 0:
                        Console.Write("");
                        break;
                }
                switch (r1000)
                {
                    case 1:
                        Console.Write("Bir ming ");
                        break;
                    case 2:
                        Console.Write("Ikki ming ");
                        break;
                    case 3:
                        Console.Write("Uch ming ");
                        break;
                    case 4:
                        Console.Write("To`rt ming ");
                        break;
                    case 5:
                        Console.Write("Besh ming ");
                        break;
                    case 6:
                        Console.Write("Olti ming ");
                        break;
                    case 7:
                        Console.Write("Yetti ming ");
                        break;
                    case 8:
                        Console.Write("Sakkiz ming ");
                        break;
                    case 9:
                        Console.Write("To`qqiz ming ");
                        break;
                    case 0:
                        Console.Write("Ming ");
                        break;
                }
                switch (r100)
                {
                    case 1:
                        Console.Write("Bir yuz ");
                        break;
                    case 2:
                        Console.Write("Ikki yuz  ");
                        break;
                    case 3:
                        Console.Write("Uch yuz ");
                        break;
                    case 4:
                        Console.Write("To`rt yuz ");
                        break;
                    case 5:
                        Console.Write("Besh yuz ");
                        break;
                    case 6:
                        Console.Write("Olti yuz ");
                        break;
                    case 7:
                        Console.Write("Yetti yuz ");
                        break;
                    case 8:
                        Console.Write("Sakkiz yuz ");
                        break;
                    case 9:
                        Console.Write("To`qqiz yuz ");
                        break;
                    case 0:
                        Console.Write("");
                        break;
                }
                switch (r10)
                {
                    case 1:
                        Console.Write("On ");
                        break;
                    case 2:
                        Console.Write("Yigirma ");
                        break;
                    case 3:
                        Console.Write("Ottiz ");
                        break;
                    case 4:
                        Console.Write("Qiriq ");
                        break;
                    case 5:
                        Console.Write("Ellik ");
                        break;
                    case 6:
                        Console.Write("Oltmish ");
                        break;
                    case 7:
                        Console.Write("Yetmish ");
                        break;
                    case 8:
                        Console.Write("Sakson ");
                        break;
                    case 9:
                        Console.Write("To`qson ");
                        break;
                    case 0:
                        Console.Write("");
                        break;
                }
                switch (r1)
                {
                    case 1:
                        Console.Write("Bir ");
                        break;
                    case 2:
                        Console.Write("Ikki ");
                        break;
                    case 3:
                        Console.Write("Uch ");
                        break;
                    case 4:
                        Console.Write("To`rt ");
                        break;
                    case 5:
                        Console.Write("Besh ");
                        break;
                    case 6:
                        Console.Write("Olti ");
                        break;
                    case 7:
                        Console.Write("Yetti ");
                        break;
                    case 8:
                        Console.Write("Sakiz ");
                        break;
                    case 9:
                        Console.Write("To`qqiz ");
                        break;
                    case 0:
                        Console.Write("");
                        break;
                }

            }
            else
            {
                Console.WriteLine("Siz kiritgan son talablarga javob bermaydi, Iltimos qayta urunib koring!");
                Main(args);
            }
        }
    }

}