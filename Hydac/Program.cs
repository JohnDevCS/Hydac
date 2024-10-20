using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Hydac
{
   


    internal class Program
    {
        static void Main(string[] args)
        {

            bool run = true;
            menuErIkkeLoggetInd();

            bool isLoggedIn = false;


            while (run)
            {
                try
                {
                    int startmenu = int.Parse(Console.ReadLine());


                    if (startmenu == 1 || isLoggedIn) //Når du logger ind
                    {
                        string email = "admin";
                        string kodeord = "1234";

                        int undermenu = 0;
                        if (!isLoggedIn)
                        {
                            Console.WriteLine("Indtast email: ");
                            string emailInput = Console.ReadLine();

                            Console.WriteLine("Indtast Kode: ");
                            string kodeordInput = Console.ReadLine();

                            if (email != emailInput || kodeord != kodeordInput)
                            {
                                Console.WriteLine("Login oplysningerne er ikke rigtige");
                                Console.WriteLine("Tryk 'Enter' for at fortsætte");
                                Console.ReadLine();
                                Console.Clear();
                                menuErIkkeLoggetInd();
                                continue;
                            }
                            isLoggedIn = true;

                            using (StreamWriter Userlogin = new StreamWriter("GuestBook.txt", true))
                            {
                                DateTime Login_Tid = DateTime.Now;
                                Userlogin.WriteLine("| Login | " + "Navn: " + email + " | " + " Dato og Tid " + Login_Tid);

                                Userlogin.Close();
                            }
                        }
                        else
                        {
                            undermenu = startmenu;
                        }

                        Console.Clear();

                        menuErLoggetInd(email);


                        if (undermenu == 0)
                        {
                            undermenu = int.Parse(Console.ReadLine());
                        }

                        if (undermenu == 1)
                        {
                            opretGuest(email);
                         


                        }
                        else if (undermenu == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Vælg et lokale: " + "\n");

                            Console.WriteLine("1. Lokale_lille_Stue");
                            Console.WriteLine("2. Lokale_Stilling_kantine");
                            Console.WriteLine("3. Lokale_Stilling_Stueetage");
                            Console.WriteLine("4. Lokale_The_Aquarium");
                            Console.WriteLine("5. Lokale_The_Bridge-East");
                            Console.WriteLine("6. Lokale_The_Bridge-West");
                            Console.WriteLine("7. Lokale_The_Canteen-North");
                            Console.WriteLine("8. Lokale_The_Station-Platform_9¼");
                            Console.WriteLine("9. Lokale_The_Stattion-The_coffee_shop");
                            Console.WriteLine("10. Lokale_The_Station-The_Library");
                            Console.WriteLine("11. Lokale_The_Training_Center");
                            Console.WriteLine("12. Lokalelille");
                            Console.WriteLine("13. Lokaleservice");
                            Console.WriteLine("14. Lokalestor");

                            Console.Write("Vælg et lokale: ");

                            // 
                            //
                            //
                            try
                            {



                                int LokaleNummer = int.Parse(Console.ReadLine());

                                switch (LokaleNummer)
                                {
                                    case 1:
                                        Console.WriteLine("Du har valgt: Lokale_lille_Stue");
                                        break;

                                    case 2:
                                        Console.WriteLine("Du har valgt: Lokale_Stilling_kantine");
                                        break;

                                    case 3:
                                        Console.WriteLine("Du har valgt: Lokale_Stilling_Stueetage");
                                        break;

                                    case 4:
                                        Console.WriteLine("Du har valgt: Lokale_The_Aquarium");
                                        break;

                                    case 5:
                                        Console.WriteLine("Du har valgt: Lokale_The_Bridge-East");
                                        break;

                                    case 6:
                                        Console.WriteLine("Du har valgt: Lokale_The_Bridge-West");
                                        break;

                                    case 7:
                                        Console.WriteLine("Du har valgt: Lokale_The_Canteen-North");
                                        break;

                                    case 8:
                                        Console.WriteLine("Du har valgt: Lokale_The_Station-Platform_9¼");
                                        break;

                                    case 9:
                                        Console.WriteLine("Du har valgt: Lokale_The_Stattion-The_coffee_shop");
                                        break;

                                    case 10:
                                        Console.WriteLine("Du har valgt: Lokale_The_Station-The_Library");
                                        break;

                                    case 11:
                                        Console.WriteLine("Du har valgt: Lokale_The_Training_Center");
                                        break;

                                    case 12:
                                        Console.WriteLine("Du har valgt: Lokalelille");
                                        break;

                                    case 13:
                                        Console.WriteLine("Du har valgt: Lokaleservice");
                                        break;

                                    case 14:
                                        Console.WriteLine("Du har valgt: Lokalestor");
                                        break;

                                    default:
                                        Console.WriteLine("Lokalet eksisterer ikke.");
                                        break;


                                        

                                }

                                DateTime lokalebookning_tid = DateTime.Now;
                                Console.WriteLine("Lokalet er nu booket " + lokalebookning_tid);
                                using (StreamWriter opretBookning = new StreamWriter("GuestBook.txt", true))
                                {
                                    DateTime oprettelses_Tid = DateTime.Now;
                                    opretBookning.WriteLine("| LokaleBookning | " + "Navn: " + email + " | " + "Lokalenummer: " + LokaleNummer + " | " +  " Dato og Tid " + oprettelses_Tid);

                                    opretBookning.Close();
                                }


                            }

                            catch (FormatException)
                            {
                                
                                Console.WriteLine("Du indtastet ikke et rigtigt tal mellem 1 - 14");
                                Console.WriteLine("Tryk enter for at gå tilbage");
                                Console.ReadLine();
                                Console.Clear();
                                menuErLoggetInd(email);
                                continue;
                                

                            }


                           

                            Console.WriteLine("Tryk 'Enter' for at gå tilbage");


                            Console.ReadLine();
                            Console.Clear();
                            menuErLoggetInd(email);

                        }
                        else if (undermenu == 3)
                        {
                            DateTime afgangs_tid = DateTime.Now;



                            Console.WriteLine("Du er nu logget ud - " + afgangs_tid);
                            Console.WriteLine("Tryk 'Enter' for at logge ud");
                            using (StreamWriter Userlogout = new StreamWriter("GuestBook.txt", true))
                            {
                                DateTime Logout_Tid = DateTime.Now;
                                Userlogout.WriteLine("| Logout | " + "Navn: " + email + " | " + " Dato og Tid " + Logout_Tid);

                                Userlogout.Close();
                            }
                            Console.ReadLine();
                            isLoggedIn = false;
                            Console.Clear();
                            menuErIkkeLoggetInd();

                        }
                    }
                    else if (startmenu == 2)
                    {
                        opretGuest2();
                    }
                    
                    else if(startmenu != 1 || startmenu != 2)
                    {
                        Console.WriteLine("Indtast venligst et gyldigt tal ");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(startmenu);
                        Console.ReadLine();
                    }
                  }
                catch (FormatException)
                {

                    Console.WriteLine("Gør kun brug af tasterne 1 eller 2 ");
                }
            }

        }

        static void menuErLoggetInd(string email)
        {
            // Startmenu logget ind
            

            DateTime ankomst_tid = DateTime.Now;

            Console.WriteLine("Velkommen til Hydac " + "\n");
            Console.WriteLine("Logget ind som " + email + " - " + ankomst_tid);
            Console.WriteLine("1) Registrer Gæst"); 
            Console.WriteLine("2) Bookning af lokale");
            Console.WriteLine("3) Log ud");
            Console.WriteLine("Vælg en mulighed: ");
        }

        static void menuErIkkeLoggetInd()
        {
            Console.WriteLine("Velkommen til Hydac " + "\n");
            Console.WriteLine("1) Log ind");
            Console.WriteLine("2) Registrer");
            Console.WriteLine("Vælg en mulighed: ");
        }

        static void opretGuest(string email = " ")
        { //Registrer gæst når du er logget ind
            Console.Clear();
            Console.WriteLine("Registrer gæst");
            Console.WriteLine("Indtast gæste email");
            string GuestEmail = Console.ReadLine();
            Console.WriteLine("Gentag gæste email");
            string GuestEmail2 = Console.ReadLine();

            

            if (GuestEmail == GuestEmail2)
            {
                
                Console.WriteLine("Gæste email stemmer overens");

                Console.WriteLine("Indtast kode for gæst");
                string GuestPass1 = Console.ReadLine();

                Console.WriteLine("Her er gæstens email: " + GuestEmail);
                Console.WriteLine("Her er gæstens kode: " + GuestPass1);
                Console.WriteLine("Gæsten er nu oprettet i systemet");

                using (StreamWriter SaveGuest = new StreamWriter("GuestBook.txt", true))
                {
                    DateTime oprettelses_Tid = DateTime.Now;
                    SaveGuest.WriteLine("| Oprettelse | " + "Navn: " + GuestEmail + " | " + " Dato og Tid " + oprettelses_Tid);

                    SaveGuest.Close();
                }

                Console.WriteLine("Tryk 'Enter' for at gå tilbage");
                Console.ReadLine();
                Console.Clear();
                menuErLoggetInd(email);
            }
            else
            {
                Console.WriteLine("Gæster email stemmer ikke overens");
                Console.WriteLine("Tryk 'Enter' for at gå tilbage");
                Console.ReadLine();
                Console.Clear();
                menuErLoggetInd(email);
                return;
            }

            Console.WriteLine("Indtast kode for gæst");
            string GuestPass = Console.ReadLine();

            Console.WriteLine("Her er gæstens email: " + GuestEmail);
            Console.WriteLine("Her er gæstens kode: " + GuestPass);
            Console.WriteLine("Gæsten er nu oprettet i systemet");
            using (StreamWriter SaveGuest = new StreamWriter("GuestBook.txt", true))
            {
                DateTime oprettelses_Tid = DateTime.Now;
                SaveGuest.WriteLine("| Oprettelse | " + "Navn: " + GuestEmail + " | " + " Dato og Tid " + oprettelses_Tid);

                SaveGuest.Close();
            }
           


            Console.WriteLine("Tryk 'Enter' for at gå tilbage");
            Console.ReadLine();
            Console.Clear();

            menuErLoggetInd(email);
        }

        static void opretGuest2(string email = " ")
        {
            //OpretGæst når du ikke er logget ind
            Console.Clear();
            Console.WriteLine("Registrer gæst");
            Console.WriteLine("Indtast gæste email");
            string GuestEmail = Console.ReadLine();
            Console.WriteLine("Gentag gæste email");
            string GuestEmail2 = Console.ReadLine();

            if (GuestEmail == GuestEmail2)
            {
                Console.WriteLine("Gæste email stemmer overens");

                Console.WriteLine("Indtast kode for gæst");
                string GuestPass = Console.ReadLine();

                Console.WriteLine("Her er gæstens email: " + GuestEmail);
                Console.WriteLine("Her er gæstens kode: " + GuestPass);
                Console.WriteLine("Gæsten er nu oprettet i systemet");

                using (StreamWriter SaveGuest = new StreamWriter("GuestBook.txt", true))
                {
                    DateTime oprettelses_Tid = DateTime.Now;
                    SaveGuest.WriteLine("| Oprettelse | " + "Navn: " + GuestEmail + " | " + " Dato og Tid " + oprettelses_Tid);

                    SaveGuest.Close();
                }

                Console.WriteLine("Tryk 'Enter' for at gå tilbage");
                Console.ReadLine();
                Console.Clear();
                menuErIkkeLoggetInd();
            }
            else
            {
                Console.WriteLine("Gæster email stemmer ikke overens");
                Console.WriteLine("Tryk 'Enter' for at gå tilbage");
                Console.ReadLine();
                Console.Clear();
                menuErIkkeLoggetInd();
                return;
            } 
        }     
     }
}

