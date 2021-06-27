using DataLayer;
using UserInteface;
using System;
using System.Threading;

namespace UserInterface
{
    class LoginArea
    {

        public void UserAccess(int profTag, string ProfName, string ProfPass)
        {
            

            for (int i = 0; i < 20; i++)
            {
                try
                {
                    Console.Title = "Login Account";
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("|Faculty Class Management System|");
                    Console.WriteLine("---------------------------------"); ;
                    Console.WriteLine("<<Please Enter Your Credentials>> \n");
                    Console.WriteLine("LOGIN CONSOLE! \n");
                    Console.Write("Enter Professor Tag: ");
                    profTag = int.Parse(Console.ReadLine());

                    Console.Write("Enter User Name: ");
                    ProfName = Console.ReadLine();

                    Console.Write("Enter Password: ");
                    ProfPass = Console.ReadLine();

                    UserAccounts BLuseraccounts = new UserAccounts();
                    

                    if (BLuseraccounts.VerifyLogin(profTag, ProfName, ProfPass))
                    {
                        Console.Clear();
                        Console.WriteLine("---------------------");
                        Console.WriteLine("| ACCOUNT VERIFIED! |");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Press any key to redirect in Menu.");
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine(">> Nice Press! Redirecting in 1 second..");
                        Thread.Sleep(900);

                        Console.Clear();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("\tWELCOME TO FCMS");
                        Console.WriteLine("--------------------------------");
                        Thread.Sleep(1000);
                        Menu StartMenu = new Menu();
                        StartMenu.shwMenu();

                        break;
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("    Error Wrong Credentials!");
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("\nTry Again! ");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine();
                    Console.WriteLine(e.Message);
                    Thread.Sleep(1300);
                    Console.Clear();

                }


            }
        }
            
    }
}
