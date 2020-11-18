using System;
using System.Collections.Generic;

namespace Övningsuppgift_3_Campus_Mölndal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Övningsuppgifter del 3
            // 1.Skapa ett program som innehåller en array som har plats för tre nummer
            // 2.Fyll arrayen nummer. T.ex. 5, 7 och 2
            // 3.Skapa en int i som du sätter till noll.
            // 4.Skriv en while-loop körs så länge i är mindre än arrayens längd(Length), och öka i med 1 varje steg i loopen.
            // 5.I while-loopen skriv ut numret på den i:te positionen i arrayen.


            /*
            
            int[] myArray = new int[3];
            myArray[0] = 5;
            myArray[1] = 09;
            myArray[2] = 119;

            int i = 0;

            while (i < myArray.Length)
            {
                Console.WriteLine(myArray[i]);
                i++;
            }
                    
            /*  

            /*
             
            char[] x = new char[3];
            x[0] = '1';
            x[1] = '2';
            x[2] = '3';

            int i = 0;

            while (i < x.Length)
            {
                Console.WriteLine(x[i]);
                i++;
            }

            */

            /*
             
            string[] kungRobin = new string[8];
            kungRobin[0] = "Kalles";
            kungRobin[1] = "Kaviar";
            kungRobin[2] = "Smakar";
            kungRobin[3] = "väldigt";
            kungRobin[4] = "Gott";
            kungRobin[5] = "På";
            kungRobin[6] = "Mackan";
            kungRobin[7] = "<3";

            int i = 0;

            while (i < kungRobin.Length)
            {
                Console.WriteLine(kungRobin[i]);
                i++;
            }
            
            */

            /*
            string[] names = new string[5];
            names[0] = "Pelle";
            names[1] = "Plutt";
            names[2] = "Tog";
            names[3] = "Ett";
            names[4] = "Skutt";

            int i = 0;

            while (i < names.Length)
            {
                Console.WriteLine(names[i]);
                i++;
            }
            Console.ReadLine();
            */

            /*
            int[] garfield = new int[3];
            garfield[0] = 5;
            garfield[1] = 63;
            garfield[2] = 89;

            int i = 0;

            while (i < garfield.Length)
            {
                Console.WriteLine(garfield[i]);
                i++;
            }
            Console.ReadLine();
        
            */
            /*
            int[] myArray = new int[3];
            myArray[0] = 5;
            myArray[1] = 10;
            myArray[2] = 15;


            int i = 0;
            while (i < myArray.Length)
            {
                Console.WriteLine(myArray[i]);
                i++;
            }

            for (int j = 0; j < myArray.Length; j++)
            {
                Console.WriteLine(myArray[j]);
            }

            Console.ReadLine();
            */

            /*
            int[] minArray = new int[8] {2, 4, 8, 16, 32, 64, 128, 256};  // Arrayen har värdet 8. index 0 i arrayen har värde 2 och index 7 256
                                                                          // int i får startvärde 0. while lopen körs så länge i är mindre än arrayens längd vilket här är 8.
            int i = 0;                                                    // för varje varv i lopen skriver vi ut arrayens värde på den aktuella indexpossitionen som i är på. Varv 3 skriver ut 8 och varv 7 skriver ut 128.
                                                                          // 8 ligger på indexposition 2 och 256 ligger på indexpossition 7.
            while (i < minArray.Length)                                   // Därefter ökar vi värdet på i med 1 (i++;) När i når värdet 7 skrivs sista värdet 256 ut och loopen avslutas.
            {
                Console.WriteLine(minArray[i]);
                i++;
            }
            Console.ReadLine();
           
            */

            /*
            int[] one = new int[5];
            one[0] = 20;
            one[1] = 25;
            one[2] = 30;
            one[3] = 39;
            one[4] = 55;
            
            for (int i = 0; i < one.Length; i++)
            {
                Console.WriteLine(one[i]);
            }
           */

            /* LEKSTUGA Skriver ut varje index 3 gånger.
            int[] nope = new int[2];
            nope[0] = 2;
            nope[1] = 3;

            for (int i = 0; i < nope.Length; i++)
            {
                Console.WriteLine(nope[i]);
                for (int j = 0; j < nope.Length; j++)
                {
                    Console.WriteLine(nope[i]);
                    for (int a = 0; a < nope.Length; a++)
                    {
                        Console.WriteLine(nope[i]);
                    }
                }
            }
            */

            /*
            int[] store = new int[5];
            store[0] = 2;
            store[1] = 23;
            store[2] = 45;
            store[3] = 200;
            store[4] = 65;


            Console.WriteLine(store[3]);

            int i = 0;
            while (i < store.Length)
            {
                Console.WriteLine(store[i]);
                i++;
            }
            */

            /*
            int[] prutt = new int[3];

            prutt[0] = 23;
            prutt[1] = 22;
            prutt[2] = 12;

            for (int i = 0; i < prutt.Length; i++)
            {
                Console.WriteLine(prutt[i]);
                prutt[1] = 5;
                prutt[2] = 55;
                prutt[0] = 45;
            }

            Console.WriteLine(prutt[0] + " " + prutt[1] + " " + prutt[2]);
            */

            /*
            int[] age = new int[4];
            age[0] = 3;
            age[1] = 5;
            age[2] = 9;
            age[3] = 53;

            for (int i = 0; i < age.Length; i++)
            {
                Console.WriteLine(age[i]);
            }

            */

            /*
            string[] names = new string[4] { "Billy", "Pelle", "Frozen", "smulan" };

            int i = 0;

            while (i < names.Length)
            {
                Console.WriteLine(names[i]);
                i++;
            }

             */

            /*
            double[] test = new double[5];
            test[0] = 2.54;
            test[1] = 5.23;
            test[2] = 7.53;
            test[3] = 2.72;
            test[4] = 6.32;

            int i = 3;

            while (i < test.Length)
            {
                Console.WriteLine(Math.Round(test[i]));
                i++;
            }
            */
            /*
            string[] goats = new string[3] { "BillyGoat", "DaddyGoat", "MonsterGoat" };
            Array.Sort(goats);

            foreach (var item in goats)
            {
                Console.WriteLine(item);
            }
            */
            /*
            int[] gitRules = new int[2] { 2, 4 };

            foreach (var item in gitRules)
            {
                Console.WriteLine(item);
            }
            */
            /*
            char[] one = new char[5];
            one[0] = 'a';
            one[1] = 'b';
            one[2] = 'c';
            one[3] = 'd';
            one[4] = 'e';

            for (int i = 0; i < one.Length; i++)
            {
                Console.WriteLine(one[i]);
            }
            */

            /*
            bool[] falsk = new bool[4] { true, false, true, true };

            int i = 0;
            while (i < falsk.Length)
            {
                Console.WriteLine(falsk[i]);
                i++;
            }
            */

            // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // LIST START ÖVNINGAR!!!

            //  6.  Skapa ett program som innehåller en lista för strängar.
            //  7.  Lägg till en bool keepGoing som du sätter till false.
            //  8.  Skriv en do -while loop som har keepGoing booleanen som villkor.
            //  9.  Be användaren mata in en namn i do -while loopen.
            //  10. Om användarens inmatning är en tom sträng (antingen genom att kolla om strängens längd är noll eller genom att kolla om den är lika med "") sätt keepGoing till false
            //  11. Annars sätt keepGoing till true och spara namnet till listan.
            //  12. Skriv ut listan med namn.


            // KLADDPAPPER

            /*
            List<int> dangIt = new List<int>();

            dangIt.Add(52);
            dangIt.Add(63);
            dangIt.Add(83);
            dangIt.Add(45);
            dangIt.Add(33);
            dangIt.Add(14);
            dangIt.Add(39);

            for (int i = 0; i < dangIt.Count; i++)
            {
                Console.WriteLine(dangIt[i]);
            }
            */
            /*
            List<int> bla = new List<int>();
            bla.Add(34);
            bla.Add(12);

            foreach (var item in bla)
            {
                Console.WriteLine("Åh hej!");
                Console.WriteLine(item);
            }
            */

            /*
            float[] der = new float[6];

            der[0] = 34.7356723434f;
            der[1] = 15.26783453434f;
            der[2] = 37.234223434f;
            der[3] = 39.823423434f;
            der[4] = 87.23434534f;
            der[5] = 123.82345634f;

            for (int i = 0; i < der.Length; i++)
            {
                Console.WriteLine(Math.Round(der[i]));
            }
            */

            // ÖVNINGARNA LIST 6-12.
            // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            /*

            List<string> myList = new List<string>();
            bool keepGoing = false;
            int i = 0;

            do
            {
                Console.WriteLine("Mata in ett namn ");
                myList.Add(Console.ReadLine());
                Console.Clear();

                while (i < myList.Count)
                {
                    if (myList[i] == "")  
                    {
                        Console.WriteLine("Du matade inte in något, programmet avslutas.");
                        Console.ReadLine();
                        keepGoing = false;
                        
                    }
                    else if (myList[i] != "")
                    {
                        
                        Console.WriteLine(myList[i]);
                    }
                    i++;
                    
                }

            } while (keepGoing == true);
            Console.ReadLine();

            */

            /*
            
            */

            // ÖVNINGARNA 13-15.
            // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            /*

            // 13.Skapa ett program som frågar användaren efter ett heltal. 
            // 14.Skriv sedan en loop som sparar det talets gångentabell (1 till 10) i en array.
            // 15.Skriv sedan ut arrayen till consollen.

            Console.WriteLine("Skriv ett heltal!");
            int numb = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[10];
            myArray[0] = 1;
            myArray[1] = 2;
            myArray[2] = 3;
            myArray[3] = 4;
            myArray[4] = 5;
            myArray[5] = 6;
            myArray[6] = 7;
            myArray[7] = 8;
            myArray[8] = 9;
            myArray[9] = 10;

            for (int i = 0; i < myArray.Length; i++)
            {
                int temp = 0;
                temp = numb * myArray[i];
                Console.WriteLine(temp);
            }

            */

            // BRA KOD. Arrayens index börjar på 0 och slutar på 9. I uppgiften ska vi använda tal in * 1 - 10. För att använda arrayens längd som gångertabell behöver vi lägga till +1 på i varje varv i lopen så att index 0 inte blir 0-9 * inmatning utan 1-10 * inmatning.| myArray[i] =  (i+1) * numb;
            /*

            Console.WriteLine("Skriv ett heltal!");
            int numb = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[10];

            Console.Clear();
            for (int i = 0; i < myArray.Length; i++)
            {   
                myArray[i] =  (i+1) * numb;
                Console.WriteLine(myArray[i]);
            }

            */

            // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // ÖVNINGARNA 16-19.
            // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // 16.Skapa ett program som ber användaren mata in sitt namn. 
            // 17.Använd sedan en loop för att spara namnet baklänges i en lista.
            // 18.Se till så att första bokstaven i det nya namnet är storbokstav och de andra bokstäverna är små.
            // 19.Skriv ut det nya namnet. 
            // Exempel: Robin blir Nibor



            Console.WriteLine("Skriv ditt namn");
            List<char> vowels =  new List<char>();
            vowels.add
            
            

            


            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // SPEL
            // -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // Labyrinten
            /*
            int west = 0;
            int east = 0;

            Console.WriteLine("Welcome to The Labyrinth!");
            Console.WriteLine("do you want to play Y/N");
            string yesNo = Console.ReadLine();
            int i = 0;
            while (true)
            {
                Console.WriteLine("Where do you want to go?");
                Console.WriteLine("1. West");
                Console.WriteLine("2. East");
                Console.WriteLine("3. I want to go back.");
                var choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("You walked west");
                    //Console.Clear();
                    west++;

                }
                else if (choice == 2)
                {
                    Console.WriteLine("You walked east");
                    //Console.Clear();
                    east++;
                }
                else if (choice == 3)
                {
                    break;
                }

            }
            while (true)
            {
                Console.WriteLine("Where do you want to go?");
                Console.WriteLine("1. West");
                Console.WriteLine("2. East");
                var choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("You walked west.");
                    //Console.Clear();
                    west--;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("You walked east");
                    //Console.Clear();
                    east--;
                }
                else if (west == 0 && east == 0)
                {
                    break;
                }
            }
            Console.WriteLine("You found your way out of The Labyrinth");
            
            
            Console.Clear();
            Console.WriteLine("Thank you for playing");
            Console.WriteLine("Welcome back!");
            Console.Clear();
            Console.ReadLine();
            */
            // ÖVA DENNA METODEN
            /*
            List<string> coolnames = new List<string>();

            coolnames.Add("Håkan");
            coolnames.Add("Yulia");
            coolnames.Add("Tove");
            coolnames.Add("Bob");
            coolnames.Add("Vernervinge");
            coolnames.Add("Anna");

            Console.WriteLine(string.Join('!', coolnames));

            */
            /*
            // Denna metoden av List är så det ska se ut när vi sen arbetar med kod.

            List<string> notSoCoolNames = new List<string>() { "Frank", "BennyS", "Låkan", "Autobahn", "morot" };

            Console.WriteLine(string.Join('!', notSoCoolNames));
            */

            // ROBINS DEMO FRÅN FÖRELÄSNING 2 VECKA 2.

            /*

            string[] stringArray = new string[]
            {
                "January",
                "feb",
                "march",
                "april",
                "may",
                "June",
                "July",
                "August",
                "September",
                "November",
                "December"
            };

            string number;
            int choice;

            do
            {
                Console.WriteLine("Select a number from 1-12 ");
                number = Console.ReadLine();
                choice = Convert.ToInt32(number);

                if (choice <= 12)
                {
                    Console.WriteLine(stringArray[]);
                }


            } while (choice < 12);
            */

            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


        }
    }
}
