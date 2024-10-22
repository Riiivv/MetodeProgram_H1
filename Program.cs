using System.Data.Common;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MetodeProgram_H1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {


                Console.WriteLine("hej fremmede jeg har lavet en hovedmenu der køre med forskellige opgaver som køre igennem metoder \n tryk på en tast for at komme til hovedmenuen");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Hovedmenu:");
                Console.WriteLine("1: Opgave 1");
                Console.WriteLine("2: Opgave 2");
                Console.WriteLine("3: Opgave 3");
                Console.WriteLine("4: Opgave 3A");
                Console.WriteLine("5: Opgave 3B");
                Console.WriteLine("6: Opgave 3C");
                Console.WriteLine("7: Opgave 4");
                Console.WriteLine("8: Opgave 5");
                Console.WriteLine("0: Afslut Program");
                string input = Console.ReadLine();
                Console.Clear();
                switch (input)
                {
                    case "1":
                        Opgave1("Hello World");
                        break;
                    case "2":
                        Opgave2();
                        break;
                    case "3":
                        Opgave3();
                        break;
                    case "4":
                        Opgave3A();
                        break;
                    case "5":
                        Opgave3B();
                        break;
                    case "6":
                        Opgave3C();
                        break;
                    case "7":
                        Opgave4();
                        break;
                    case "8":
                        Opgave5();
                        break;
                    case "9":
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Ugyldigt valg prøv igen");
                        break;
                }
            }
        }

        static string Opgave1(string Hello_World)
        {
            Console.WriteLine("Hello World");
            Console.ReadKey();
            return Hello_World;
        }

        static void Opgave2()
        {
            Console.WriteLine("Opgave 2: skriv et input som bliver returneret \n tryk på en tast for at komme videre til programmet");
            Console.ReadKey();
            Console.WriteLine("Skriv et input");
            string input = Console.ReadLine();
            Console.WriteLine($"du indtastede: " + input + "\n tryk på en tast for at komme tilbage til menuen");

            Console.ReadKey();
        }

        static void Opgave3()
        {
            Console.WriteLine("Opgave 3: indtast 3 tal der bliver + et sammen og giver en sum = \n tryk en tast for at komme til programmet ");
            Console.ReadKey();
            Console.Write("Indtast det første tal: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast det andet tal: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast det tredje tal: ");
            int tal3 = Convert.ToInt32(Console.ReadLine());

            int sum = tal1 + tal2 + tal3;
            Console.WriteLine(sum +"\n tryk på en tast for at komme tilbage til menuen");
            Console.ReadKey();
        }

        static void Opgave3A()
        {
            Console.WriteLine("Opgave 3A: indtast 3 tal der bliver - et og giver dig resultatet = \n tryk en tast for at komme til programmet ");

            Console.ReadKey();
            Console.Write("Indtast det første tal: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast det andet tal: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast det tredje tal: ");
            int tal3 = Convert.ToInt32(Console.ReadLine());

            int sum = tal1 - tal2 - tal3;
            Console.WriteLine(sum + "\n tryk på en tast for at komme tilbage til menuen");
            Console.ReadKey();
        }

        static void Opgave3B()
        {
            Console.WriteLine("Opgave 3B: indtast 3 tal der bliver * et og giver en sum = \n tryk en tast for at komme til programmet ");

            Console.ReadKey();
            Console.Write("Indtast det første tal: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast det andet tal: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast det tredje tal: ");
            int tal3 = Convert.ToInt32(Console.ReadLine());

            int sum = tal1 * tal2 * tal3;
            Console.WriteLine(sum + "\n tryk på en tast for at komme tilbage til menuen");
            Console.ReadKey();
        }
        static void Opgave3C()
        {
            Console.WriteLine("Opgave C: indtast 2 tal der bliver + et sammen og indtast 1 tal der bliver dividere dem og giver en sum = \n tryk en tast for at komme til programmet ");
            Console.ReadKey();
            Console.Write("Indtast det første tal: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast det Andet tal: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Indtast det Tredje tal: ");
            int tal3 = Convert.ToInt32(Console.ReadLine());
            int sum = (tal1 + tal2) / tal3;
            Console.WriteLine(sum + "\n tryk på en tast for at komme tilbage til menuen");
            Console.ReadKey();
        }
        static void Opgave4()
        {
            Console.WriteLine("Opgave 4: skriv dit navn og alder der fortæller om du er gammel nok der bliver retuneret navn + alder\n tryk på en tast for at komme videre til programmet");
            Console.WriteLine("Indtast din alder");
            int alder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast dit navn");
            string navn = Console.ReadLine();

            string gruppe = "";

            if (alder >= 0 && alder <= 1)
            {
                gruppe = "Du er nyfødt";
            }
            else if (alder >= 2 && alder <= 3)
            {
                gruppe = "Du er i dagpleje eller vuggestrue";
            }
            else if (alder >= 4 && alder <= 5)
            {
                gruppe = "Du er i børnehave";
            }
            else if (alder >= 6 && alder <= 18)
            {
                gruppe = "Du går i skole";
            }
            else if (alder >= 19)
            {
                gruppe = "Nu begynder livet at blive alvor";
            }
            else
            {
                gruppe = "Ugyldig alder";
            }
            Console.WriteLine($"Dit navn er {navn} og du er {alder} år gammel du går i {gruppe}" + "\n tryk på en tast for at komme tilbage til menuen");
            Console.ReadKey();
        }

        static void Opgave5()
        {
            Console.WriteLine("opgave 5 komma seperaret array skriv fx: a,b,c,d \n tryk på en tast for at komme videre til programmet");
            Console.ReadKey();
            Console.WriteLine("indtast en kommasepereret streng");
            string input = Console.ReadLine();

            string[] values = input.Split(',');

            Console.WriteLine($"Størrelen på arrayet: {values.Length}");

            for (int i = 0; i < values.Length; i++)
            {
                {
                    Console.WriteLine($"værdi: {i + 1}: {values[i]}");
                }
                Console.WriteLine("tryk på en hvilken som helst tast for at koome tilbage til meuen");
                Console.ReadKey();
            }
        }
    }
}
