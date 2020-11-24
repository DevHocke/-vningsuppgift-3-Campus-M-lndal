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
             
            List<string> myList = new List<string>();
            bool go = false;
            int i = 0;

            do
            {
                Console.WriteLine("Skriv ett namn");
                myList.Add(Console.ReadLine());

                while (i < myList.Count)
                {
                    if (myList[i] == "")
                    {
                        Console.WriteLine("Ingen inmatning, programmet avslutas.");
                        Console.ReadLine();
                        go = false;
                    }
                    else if (myList[i] != "")
                    {
                        Console.WriteLine(myList[i]);
                    }
                    i++;
                }
                


            } while (go == true);

            Console.ReadLine();
            
             */

            /*
             
            List<string> enLista = new List<string>();
            bool run = false;

            do
            {
                Console.WriteLine("Enter your name: ");
                enLista.Add(Console.ReadLine());
                Console.Clear();
                for (int i = 0; i < enLista.Count; i++)
                {
                    if (enLista[i] == "")
                    {
                        Console.WriteLine("You did not enter a name, program ends.");
                        Console.ReadLine();
                        run = false;
                    }
                    else if (enLista[i] != "")
                    {
                        Console.WriteLine("You wrote: " + enLista[i]);
                    }
                }
                

            } while (run == true);

            Console.ReadLine();

            */



            // -------------------------------------------------------------------------------------------------------------------------------------------------
            // ÖVNINGARNA 13-15.
            // ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // 13.Skapa ett program som frågar användaren efter ett heltal. 
            // 14.Skriv sedan en loop som sparar det talets gångentabell (1 till 10) i en array.
            // 15.Skriv sedan ut arrayen till consollen.
            /*
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

            /*
            
            Console.WriteLine("Skriv ett tal");
            int answer = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[10];
            Console.Clear();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = (i + 1) * answer;
                Console.WriteLine(x[i]);
            }

            */

            /*
            Console.WriteLine("Write a number");
            int opAnswer = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[10];
            Console.Clear();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] =  (i + 1) * opAnswer;
                Console.WriteLine(myArray[i]);
            }

            */

            /*
             * 
            Console.WriteLine("Skrev ett tal");
            string answer = Console.ReadLine();
            int converted = Convert.ToInt32(answer);
            int[] anArray = new int[10];
            Console.Clear();

            for (int i = 0; i < anArray.Length; i++)
            {
                anArray[i] = (i + 1) * converted;
                Console.WriteLine(anArray[i]);
            }

            */

            /*
              
            Console.WriteLine("Write a number");
            int opAnswer = Convert.ToInt32(Console.ReadLine());
            int[] calculate = new int[10];
            Console.Clear();

            for (int i = 0; i < calculate.Length; i++)
            {
                calculate[i] = (i + 1) * opAnswer;
                Console.WriteLine(calculate[i]);
            }

            */

            /*
             
            Console.WriteLine("Skriv ett heltal");
            string opIn = Console.ReadLine();
            int convIn = Convert.ToInt32(opIn);
            int[] aName = new int[10];
            Console.Clear();

            for (int i = 0; i < aName.Length; i++)
            {
                aName[i] = (i + 1) * convIn;
                Console.WriteLine(aName[i]);
            }

            */

            /*
            Console.WriteLine("Write a number");
            int numb = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[10];
            Console.Clear();

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = (i + 1) * numb;
                Console.WriteLine(myArray[i]);
            }

            */

            /*
             
            Console.WriteLine("Skriv ett tal");
            string answer = Console.ReadLine();
            int convertedAnswer = Convert.ToInt32(answer);
            int[] X = new int[10];
            Console.Clear();

            for (int i = 0; i < X.Length; i++)
            {
                X[i] = (i + 1) * convertedAnswer;
                Console.WriteLine(X[i]);
            }

            */

            /*
             
            Console.WriteLine("Skriv ett nummer");
            int answer = Convert.ToInt32(Console.ReadLine());
            int[] newArray = new int[10];
            Console.Clear();

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = (i+1) * answer;
                Console.WriteLine(newArray[i]);
            }

            */




            // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // ÖVNINGARNA 16-19.
            // ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // 16. Skapa ett program som ber användaren mata in sitt namn. 
            // 17. Använd sedan en loop för att spara namnet baklänges i en lista.
            // 18. Se till så att första bokstaven i det nya namnet är storbokstav och de andra bokstäverna är små.
            // 19. Skriv ut det nya namnet. 
            // Exempel: Robin blir Nibor

            // gör om stringen till en char array.

            // Console.WriteLine("Skriv ditt namn");
            // List<char> vowels =  new List<char>();
            // vowels.add






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

            // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // ÖVNINGAR 4 THURSDAY
            // -------------------------------------------------------------------------------------------------------------------------------------------------

            // 1. Skapa en lista med 10 elements
            // 2. Använd Do while för att skirva ut alla element
            // 3. Använd While för att skriva ut alla element
            // 4. Använd for för att skriva ut alla element

            /*
            List<char> elements = new List<char>();
            elements.Add('H');
            elements.Add('E');
            elements.Add('J');
            elements.Add('H');
            elements.Add('O');
            elements.Add('P');
            elements.Add('P');
            elements.Add('G');
            elements.Add('U');
            elements.Add('M');
            elements.Add('M');
            elements.Add('I');
            elements.Add('A');
            elements.Add('N');
            elements.Add('K');
            elements.Add('A');

            int i = 0;

            while (i < 16 )
            {
                Console.WriteLine(elements[i]);
                i++;
            }

            Console.ReadLine();

            */

            // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // ÖVNINGAR 4 THURSDAY
            // -------------------------------------------------------------------------------------------------------------------------------------------------
            //  5. Skapa en array av chars som innehåller ditt personnr
            //  6. Byt ut dina fyra sista till något annat i en loop
            //  7. Skriv ut det nya personnumret på samma

            int[] myArray = new int[12];
            myArray[0] = 1;
            myArray[1] = 9;
            myArray[2] = 7;
            myArray[3] = 5;
            myArray[4] = 1;
            myArray[5] = 2;
            myArray[6] = 1;
            myArray[7] = 5;
            myArray[8] = 1;
            myArray[9] = 3;
            myArray[10] = 8;
            myArray[11] = 7;




            // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // ÖVNINGAR 4 THURSDAY
            // -------------------------------------------------------------------------------------------------------------------------------------------------

            // 8.  Skriv en bok med Input. Skapa upp en lista med random strings som tex "Det var en gång", "Och sen föll det ner potatisar från himmeln!"
            // 9.  Be sedan användaren mata in en mening i konsolen
            // 10. Sätt ihop meningen och valfritt element och printa ut till konsolen
            // 11. Programmet körs så länge användaren skriver in en string.
            // 12. För att avsluta programmet så trycker användaren 0.Vid avslut skall hela boken skrivas ut. 

            // ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // ÖVNINGAR 4 THURSDAY
            // -------------------------------------------------------------------------------------------------------------------------------------------------

            // 13. Med hjälp av lika funktioner som listan har inbyggd, kolla om en lista med strings innehåller en specifik text
            // 14. Skapa upp tre listor av typen int.Två av listorna skall innehålla unika heltal och den tredje skall vara lista1 +lista2.
            // 15. Skriv ut hela innehåller på listan med, som separera de olika talen.
            // 16. Skriv ut medelvärdet av alla tal i lista3
            // 17. Kolla hur många av talen som är jämna
            // 18. Skapa en fjärde lista som innehåller alla dessa värden
            // 19. Printa ut listan med en Do while

            // --------------------------------------------------------------------------------------------------------------------------
            // FREDAG UPPGIFT BANKOMAT
            // ----------------------------------------------------------------------------------------------------------------------------

            /*
            Console.WriteLine("Welcome to the bank of zeors and ones");
            Console.WriteLine("Enter your pin 4 or 6 digits");
            string answer = Console.ReadLine();
            int pin = Convert.ToInt32(answer);
            List<int> changes = new List<int>();
            bool keepGoing = false;
            int balance = 0;
            Console.Clear();

            if (answer.Length == 4 || answer.Length == 6)
            {
                Console.WriteLine("Valid PIN, welcome!");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                do
                {
                    
                    Console.WriteLine("What do you want to do? ");
                    Console.WriteLine("1. Deposit money");
                    Console.WriteLine("2. Withdraw money");
                    Console.WriteLine("3. Check balance ");
                    Console.WriteLine("4. Collect interest");
                    Console.WriteLine("5. EXIT ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (choice == 1)
                    {
                        Console.WriteLine("How much do you want to deposit? ");
                        int newMoney = Convert.ToInt32(Console.ReadLine());
                        balance = (balance + newMoney);
                        changes.Add(balance);
                        Console.Clear();
                        Console.WriteLine("You deposited " + newMoney + " to your account.");
                        keepGoing = true;
                    }
                    else if (choice == 2)
                    {
                        if (balance == 0)
                        {
                            Console.WriteLine("You are out of money, please add some money.");
                            keepGoing = true;
                        }
                        else if (balance != 0)
                        {
                            Console.WriteLine("How much do you want to withdraw? ");
                            int removeMoney = Convert.ToInt32(Console.ReadLine());
                            balance = (balance - removeMoney);
                            changes.Add(balance);
                            Console.Clear();
                            Console.WriteLine("You withdraw " + removeMoney + " from your account.");
                            keepGoing = true;
                        }
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Your balance is: " + balance);
                        keepGoing = true;
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("How many years do you want to wait?");
                        int years = Convert.ToInt32(Console.ReadLine());
                        
                        if (balance > 1 && balance < 1001)
                        {
                            for (int i = 0; i < years; i++)
                            {
                               balance = (balance * 2);
                               changes.Add(balance);
                            }
                            foreach (var item in changes)
                            {
                                Console.WriteLine(item);
                            }

                        }
                        else if (balance >= 1001 && balance <= 5000)
                        {
                            for (int i = 0; i < years; i++)
                            {
                                balance = (balance * 3);
                                changes.Add(balance);
                            }
                            foreach (var item in changes)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else if (balance >= 5001 && balance <= 10000)
                        {
                            for (int i = 0; i < years; i++)
                            {
                                balance = (balance * 4);
                                changes.Add(balance);
                            }
                            foreach (var item in changes)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else if (balance >= 10001)
                        {
                            for (int i = 0; i < years; i++)
                            {
                                balance = (balance * 5);
                                changes.Add(balance);
                            }
                            foreach (var item in changes)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        else
                        {
                            Console.WriteLine("FEL INMATNING, GÖR OM GÖR RÄTT PAPPSKALLE :)");
                        }
                        keepGoing = true;
                    }
                    else if (choice == 5)
                    {
                        keepGoing = false;
                    }

                } while (keepGoing == true);

            }
            else
            {
                Console.WriteLine("Invalid PIN");
            }

            Console.WriteLine("Thank you for using our bank app you now have " + balance + " money in your account.");

            Console.ReadLine();
            */

            /*
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            */
            // ----------------------------------------------------------------------------------------------------------------------------------------------------------------
            // ÖVNINGSUPPGIFTER 5.
            // ---------------------------------------------------------------------------------------------------------------------------------------------------------------
            // 1.Skapa ett program som har en en array eller lista för strängar som du du kalla kompisLista.
            // 2.Fyll den med minst tre namn.T.ex.Robin, Björn B, Björn S.
            // 3.Skriv en foreach-loop för varje sträng kompis i kompisLista.
            // 4.I din loop skriv ut "Hej " + namnet på en kompis så att alla kompisar har blivit hälsade på när loopen körts klart.
            // 5.Skriv en metod static void HälsaPå(string kompis)
            // 6.Flytta innehållet i forloop från uppgift 3.till din metod. 
            // 7.I ditt huvudprogram(Main) gör så att loopen kallar på HälsaPå(kompis) istället för att skriva ut själv.
            //    Bonusuppgift: För att göra hälsningen lite mindre stel testa att använda Random rnd = new Random(); och en
            //    string array med olika hälsningsfraser för att blanda vilka fraser du använder för att hälsa på dina kompisar

            /*
            List<string> friendsList = new List<string>();
            friendsList.Add("Pelle");
            friendsList.Add("BennyBulaDenLillaFula");
            friendsList.Add("Kalle Stropp");

            NewMethod(friendsList);

            static void NewMethod(List<string> friendsList)
            {
                string[] myArray = new string[9];
                myArray[0] = "Du luktar så gott ";
                myArray[1] = "Imorgon är en ny dag ";
                myArray[2] = "Inga bullar för dig ";
                myArray[3] = "Massa bullar för dig ";
                myArray[4] = "Kom in i matchen ";
                myArray[5] = "Nope inte här heller ";
                myArray[6] = "Vill du ha en kaka ";
                myArray[7] = "Bussen gick för 5 min sedan ";
                myArray[8] = "Du är en pappskalle ";
                
                
                for (int i = 0; i < friendsList.Count; i++)
                {
                    Random rand = new Random();
                    String random = myArray[rand.Next(myArray.Length)];
                    Console.WriteLine(random + friendsList[i]);     
                }
            }

            */

            // 8.Skriv en metod sorteraTreTal som tar tre tal som paramterar och returnerar en array.
            // 9.Skapa en array och placera dina tre tal i storleksordning i arrayen.
            //    Du kan återanvända kod från tidigare uppgifter för att ta reda på vilket tal som är stört, mellan och minst.
            // 10.Returnera arrayen.
            // 11.Testa så att metoden fungerar genom att skriva ut arrayen med hjälp av en foreach-loop i huvudprogrammet.

            // Default är en bool false.
            //string enIfKontroll = default(string); // Default är en string "". Det går att kontrollera med isNullOrEmpty

            //if (string.IsNullOrEmpty(enIfKontroll))
            //{

            //}
            /*
            int[] sortArray = new int[3];
            
            
             Console.WriteLine("Ange tal 1. ");
             sortArray[0] = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Ange tal 2. ");
             sortArray[1] = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Ange tal 3. ");
             sortArray[2] = Convert.ToInt32(Console.ReadLine());

            SorteraTreTal(sortArray);  // Kallar på metoden SorteraTreTal som tar in de tre talen från användaren och sorterar dem med Array.Sort

            foreach (var item in sortArray)
            {
                Console.WriteLine(item);
            }
            


            static int[] SorteraTreTal(int[] bumbiBjörnarna) // Tar in en int Array samt returnerar en int array. 
            {
                Array.Sort(bumbiBjörnarna);
            //  Array.Reverse(bumbiBjörnarna);  // Ändrar ordningen på arrayen.
                return bumbiBjörnarna;
            }
            */

            // 12. Skriv en metod static int Hexagontal som tar en int n som parameter. 
            // 13. I metoden skapa en variabel för summan och sätt det till 0.
            // 14. Skriv en for-loop som går från k = 0 till k < n.
            // 15. I loopen öka summan med 4 * k + 1.
            // 16. Returnera summan
            // 17. I huvudprogrammet anropa på metoden och skriv ut returvärdet till konsolen.
            //   För att kolla om du gjort rätt så ger n = 1-> 1, n = 2-> 6, n = 3-> 15, n = 4-> 28
            //   https://sv.wikipedia.org/wiki/Hexagontal 
            
            /*

            Console.WriteLine(Hexagontal(2));
            
            static int Hexagontal(int n)
            {
                int sum = default(int); // dafault in är 0.

                for (int k = 0; k < n; k++)
                {
                    sum += 4 * k + 1;  // += lägger till summan + det nya värdet. endast = ändrar värdet i sum.
                }

                return sum;
            }
            Console.ReadLine();

            */

            //Avancerad uppgift till er som vill ha lite utmaning: 


            //Triangeltal är tal som kan modelleras som trianglar eller trappor. T.ex. 3 = 1 + 2 eller 10 = 1 + 2 + 3 + 4.
            // 19. Skapa en metod som givit ett tal testar med hjälp utav en loop ifall det talet är ett triangel tal.
            //     Så i det här fallet ska du bruteforca talet på något sätt eftersom det är programmering vi ska öva på och inte matte.
            // 20. Om talet är ett triangeltal så ska metoden kalla på en annan metod som skriver ut det i trapform:

            //               10

            //             6  9

            //          3  5  8

            //       1  2  3  4

            //   Dvs varje position i trappan ska skriva ut antalet platser till vänster och under det.


        }

        
    }
}
