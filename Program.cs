using ConsoleStore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleStore
{
    // Entry Point
    class Program
    {
        static void Main(string[] args)
        {
            StoreFront.SignIn();
            Store.CategoriesMenu();
            Store.Category1();
            Store.Category2();
            Store.Category3();
            Store.Cart();
        }
    }
    
    public class StoreFront
    {
        // Request user to Enter his/her name
        public string UserName;

        public static void SignIn()
        {

            Console.WriteLine("\t*****************************************");
            Console.WriteLine("                 Welcome to EB Games ");
            Console.WriteLine("\t*****************************************");
            // ask user for name and save variable
            Console.Write("\tPlease enter user name: ");
            string UserName = Console.ReadLine();
            Accounts.UserAccount();
        }
    }

    public class Accounts
    {
        // Declare deposit and balance
        // Balance is set to 500 by default
        public static int deposit;
        public static int balance = 500;        

        public static void UserAccount()
        {
            // Display User Account Menu option and current account balance
            // Request user to select from the options
            Console.Clear();
            Console.WriteLine("\tWelcome to EB Games Store " + "\tYour balance is $ " + balance);
            Console.WriteLine("\n\tPlease select an option below: \n\n");
            Console.WriteLine("\t[1] Top-up");
            Console.WriteLine("\t[2] Browse Store");
            Console.WriteLine("\t[3] View Cart History");
            Console.WriteLine("\t[4] Log-out");
            string selectedOption = Console.ReadLine();

            // Use Switch statement to allow users to access other parts of the app
            switch (selectedOption)
            {
                case "1":
                    // Deposit Section
                    Console.Clear();
                    Console.WriteLine("\tWelcome to the Deposit Department" + "\tYour balance is " + balance + "\n\n\n");

                    Console.WriteLine("\tPlease enter the amount you want to deposit");

                    deposit = int.Parse(Console.ReadLine());
                    balance = balance + deposit;

                    Console.WriteLine("\nYour balance is now: " + balance);
                    Console.WriteLine("\tPress any key to go back");
                    Console.ReadKey();
                    UserAccount();

                    break;
                case "2":
                    // Category Menu
                    Store.CategoriesMenu();
                    Console.ReadKey();
                    Thread.Sleep(100);
                    UserAccount();
                    break;
                case "3":
                    // Cart History
                    Store.Cart();
                    Thread.Sleep(100);
                    UserAccount();
                    break;
                case "4":
                    // Sign-in Section
                    StoreFront.SignIn();
                    break;
                default:
                    Console.WriteLine("No match found");
                    break;
            }

            Console.ReadKey();

        }
    }
    class Store
    {
        // Array of products + price + description
        public static string[] pcgName = { "Item Name: NBA 2k23", "Item Name: The Witcher 3", "Item Name: Call of Duty", "Item Name: Forza Horizon 5", "\tItem Name: Ghost Recon" };
        public static int[] pcgPrice = { 160, 145, 190, 240, 134 };
        public static int[] pcgQuantity = null;
        public static string[] pcgDes = { "NBA 2K23's gameplay has a bevy of new improvements " +
                                                    "to\n \tcomplementany skill set. Flex on the rim,\n \tfinesse   " +
                                                    "your way to the rack, and experience more\n \tauthentic animations.",
                                                    "Wild Hunt is an action role-playing game with a\n \tthird-person perspective. " +
                                                    "Players control Geralt of Rivia,\n \ta monster slayer known as a Witcher",
                                                    "Call of Duty is a first-person shooter video game\n \tfranchise " +
                                                    "published by Activision. Over time, the series has\n \tseen games set" +
                                                    "in the midst of the Cold War,\n \tfuturistic worlds, and outer space",
                                                    "Forza Horizon 5 is a racing video game set in an\n \topen world environment" +
                                                    "based in a fictional representation of Mexico",
                                                    "In the series, the player is in charge of a fictional,\n \tnewly conceived squad" +
                                                    "of U.S. Army Special Forces soldiers from\n \tDelta Company, 1st Battalion, 5th Special Forces Group (5th SFG)\n" +
                                                    "\tstationed at Fort Bragg."};
        public static string[] psgName = { "Item Name: Need for Speed", "Item Name: Warzone", "Item Name: Rugby 2K22", "Item Name: Grand Theft Auto", "\tItem Name: Madden NFL 23" };
        public static int[] psgPrice = { 110, 60, 210, 160, 200 };
        public static int[] psgQuantity = null;
        public static string[] psgDes = { "Need for Speed is a racing video game franchise published\n \tby Electronic Arts" +
                                                    "and currently developed by\n \tCriterion Games, the developers of Burnout.",
                                                    "Warzone allows online multiplayer combat among 150 players,\n \talthough some limited-time game modes " +
                                                    "support 200 players.\n \tThe game features both cross-platform\n \tplay and cross-platform " +
                                                    "progression between the three\n \taforementioned titles",
                                                    "Rugby 22 offers total rugby, combining tactics and\n \tintensity through gameplay that stays " +
                                                    "true to the sport.\n \tTAKE YOUR TEAM TO THE TOP Lead your players\n \tto victory in tournaments," +
                                                    "official leagues and a Career Mode\n \tin which you can create and manage your own team.",
                                                    "Grand Theft Auto V is an action-adventure game played\n \tfrom either a third-person or" +
                                                    "first-person perspective.\n \tPlayers complete missions—linear scenarios with set\n \tobjectives—to" +
                                                    " \tprogress through the story. Outside of the missions,\n \tplayers may freely roam the open world",
                                                    "All new to Ultimate Team for Madden NFL 23\n \tis the Field Pass. With the Field Pass providing\n \ta clear " +
                                                    "path to progression, you'll always know\n \twhat you need to do next"};
        public static string[] xbgName = { "Item Name: Halo", "Item Name: Apex Legends", "Item Name: Fortnite", "Item Name: Friday Night Fights: Round 3", "\tItem Name: Sim World" };
        public static int[] xbgPrice = { 80, 95, 200, 240, 50 };
        public static int[] xbgQuantity = null;
        public static string[] xbgDes = { "Halo is set in the twenty-sixth century, with the\n \tplayer assuming the role of the Master Chief," +
                                                    "a cybernetically\n \tenhanced supersoldier. The Chief is accompanied by Cortana, an\n \tartificial intelligence." +
                                                    "Players battle aliens as they attempt\n \tto uncover the secrets of the eponymous Halo,\n \ta ring-shaped artificial world.",
                                                    "Apex Legends is an online multiplayer battle royale game\n \tfeaturing squads of three players using " +
                                                    "pre-made characters\n \twith distinctive abilities, called \"Legends\", similar to those of hero\n \tshooters. " +
                                                    "Alternate modes have been introduced allowing for single\n \tand for two-player squads since the game's release.",
                                                    "Fortnite is a survival game where 100 players fight against\n \teach other in player versus player combat " +
                                                    "to be the\n \tlast one standing. It is a fast-paced, action-packed game,\n \tnot unlike The Hunger Games," +
                                                    "where strategic thinking is a must\n \tin order to survive. There are an estimated 125 million players\n \ton Fortnite.",
                                                    "Round 3 is divided into three major sections: play mode,\n \twhere you fight as famous boxing greats against the" +
                                                    "computer\n \tor another player; ESPN Classic mode, where vintage battles—Robinson/LaMotta,\n \tAli/Frazier, etc. —are reenacted; " +
                                                    "and career mode, where you fight\n \tyour way to trophies and divisional dominance.",
                                                    "Train Sim World® is an immersive First-Person Simulator that\n \tuses real-world data to bring " +
                                                    "to life the performance,\n \tsounds and power of real trains. Featuring complete in-cab interactivity," +
                                                    "\n \tfeel the detail as you sit in the driver's seat or\n \texplore on foot and bring classic trains roaring to life!"};



        public static void CategoriesMenu()
        {
            // List of categories to display to user
            List<string> CategoryList = new List<string>();
            CategoryList.Add("PC Games");
            CategoryList.Add("PlayStation Games");
            CategoryList.Add("XBox Games");


            //Display Banner Options for user to select.
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.DarkMagenta;
            Console.WriteLine("===================================================================================");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("              \tLIMITED EDTION GAMES   LIMITED STOCK BE QUICK!                     ");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("===================================================================================");
            Console.ResetColor();
            Console.WriteLine("\n\n");

            Console.WriteLine("                           [1]" + "    " + CategoryList[0]);
            Console.WriteLine("                           [2]" + "    " + CategoryList[1]);
            Console.WriteLine("                           [3]" + "    " + CategoryList[2]);
            Console.WriteLine("                           [4]    Cart                                             ");
            Console.WriteLine("                           [5]    Back                                             ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");

            int UserInput;
            UserInput = int.Parse(Console.ReadLine());

            // Allows for user to Select a Category
            switch (UserInput)
            {
                case 1:
                    Category1();
                    Console.ReadKey();
                    break;
                case 2:
                    Category2();
                    Console.ReadKey();
                    break;
                case 3:
                    Category3();
                    Console.ReadKey();
                    break;
                case 4:
                    Cart();
                    Console.ReadKey();
                    break;
                case 5:
                    Accounts.UserAccount();
                    Console.ReadKey();
                    break;

               
                default:
                    Console.WriteLine("Please enter a valid number");
                    Thread.Sleep(500);
                    CategoriesMenu();

                    break;

            }

            Console.ReadLine();
        }
        // Displays the total list of items purchased

        public static void Cart()
        {
            Console.WriteLine("\tWelcome to your Cart\n\n");
            Console.WriteLine("\tYour purchased Items: \n");
            Object[] a = CartList.ToArray();
            foreach (object o in a)
            {

                Console.WriteLine("\t" + o);

            }Console.ReadLine();
        }
        // Created a list to add items to
        public static List<Object> CartList = new List<Object>();

        // Pc Games Category
        public static void Category1()
        {
        L1: Console.Clear();
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.WriteLine("===================================================================================");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("                                    PC Games                              ");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("===================================================================================");
            Console.ResetColor();
            Console.WriteLine("                                                                                   ");
            Console.WriteLine($"\t[1]   {pcgName[0]}\t\t\t\t\t${pcgPrice[0]}\n");
            Console.WriteLine($"\t{pcgDes[0]}\n");
            Console.WriteLine($"\t[2]   {pcgName[1]}\t\t\t\t\t${pcgPrice[1]}\n");
            Console.WriteLine($"\t{pcgDes[1]}\n");
            Console.WriteLine($"\t[3]   {pcgName[2]}\t\t\t\t\t${pcgPrice[2]}\n");
            Console.WriteLine($"\t{pcgDes[2]}\n");
            Console.WriteLine($"\t[4]   {pcgName[3]}\t\t\t\t${pcgPrice[3]}\n");
            Console.WriteLine($"\t{pcgDes[3]}\n");
            Console.WriteLine($"\t[5]   {pcgName[4]}\t\t\t\t\t${pcgPrice[4]}\n");
            Console.WriteLine($"\t{pcgDes[4]}\n");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                    \tChoose a product to add to Cart\n                              ");
            Console.WriteLine("                    \tView Cart History           [6]                              ");
            Console.WriteLine("                    \tBack                        [7]                              ");
            Console.WriteLine("***********************************************************************************");

            // Catches user input
            int UserInput;
            UserInput = int.Parse(Console.ReadLine());
            string input = "y";


            // Allows user to select an option
            // Request user to input the quantity required
            // Calculates the subtotal
            switch (UserInput)
            {
                case 1:
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int pcgQuantity = (int)Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {pcgQuantity} items of this product");
                    Console.WriteLine("\tPress Enter to Confirm");
                    Console.ReadKey();
                    int Subtotal = (pcgQuantity) * (pcgPrice[0]);


                    // Sets a condition for if there is enough funds
                    if (Accounts.balance < 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Thread.Sleep(800);
                        Accounts.balance = Accounts.balance * 1;
                        Accounts.UserAccount();

                    }
                    // Sets a condition for if there is enough funds
                    // Items are added to the list
                    // Purchase is calculated
                    // Remaining Balance is displayed
                    else if (Subtotal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(pcgName[0]);
                        CartList.Add(pcgPrice[0]);
                        CartList.Add(pcgQuantity);
                        Accounts.balance = Accounts.balance -= Subtotal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    }
                    Thread.Sleep(1000);

                    // Request user to select from the options y/n
                    // Sets a condition for if the user wants to continue browsing or not
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c1 = Console.ReadLine();

                    if (option_c1 == input)
                        goto L1;
                    else if (option_c1 != input)
                        Accounts.UserAccount();

                    break;
                case 2:
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int pcgQuantity1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {pcgQuantity1} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
                    Console.ReadKey();

                    int SUbtotal = (pcgQuantity1) * (pcgPrice[1]);

                    if (Accounts.balance <= 0)
                    {
                        Console.Clear();
                        Accounts.balance = Accounts.balance * 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Accounts.UserAccount();

                    }
                    else if (SUbtotal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(pcgName[1]);
                        CartList.Add(pcgPrice[1]);
                        CartList.Add(pcgQuantity1);
                        Accounts.balance = Accounts.balance -= SUbtotal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    }
                    Thread.Sleep(1000);
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c2 = Console.ReadLine();

                    if (option_c2 == input)
                        goto L1;
                    else if (option_c2 != input)
                        Accounts.UserAccount();
                    Console.ReadKey();
                    break;
                case 3:                  
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int pcgQuantity2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {pcgQuantity2} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");

                    int SuBtotal = (pcgQuantity2) * (pcgPrice[2]);

                    if (Accounts.balance <= 0)
                    {
                        Console.Clear();
                        Accounts.balance = Accounts.balance * 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Accounts.UserAccount();

                    }
                    else if (SuBtotal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(pcgName[2]);
                        CartList.Add(pcgPrice[2]);
                        CartList.Add(pcgQuantity2);
                        Accounts.balance = Accounts.balance -= SuBtotal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    }

                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c3 = Console.ReadLine();

                    if (option_c3 == input)
                        goto L1;
                    else if (option_c3 != input)
                        Accounts.UserAccount();
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int pcgQuantity3 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {pcgQuantity3} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");

                    int SubTotal = (pcgQuantity3) * (pcgPrice[3]);

                    if (Accounts.balance <= 0)
                    {
                        Console.Clear();
                        Accounts.balance = Accounts.balance * 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Accounts.UserAccount();

                    }
                    else if (SubTotal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(pcgName[3]);
                        CartList.Add(pcgPrice[3]);
                        CartList.Add(pcgQuantity3);
                        Accounts.balance = Accounts.balance -= SubTotal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    }
                    Console.ReadKey();
                    
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c4 = Console.ReadLine();

                    if (option_c4 == input)
                        goto L1;
                    else if (option_c4 != input)
                        Accounts.UserAccount();
                    Console.ReadKey();
                    break;
                case 5:
                    // Ask user to input the quantity they wish to purchase
                    // Add item to cartList
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int pcgQuantity4 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {pcgQuantity4} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
                    int SubtOtal = (pcgQuantity4) * (pcgPrice[4]);

                    if (Accounts.balance <= 0)
                    {
                        Console.Clear();
                        Accounts.balance = Accounts.balance * 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Accounts.UserAccount();

                    }
                    else if (SubtOtal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(pcgName[4]);
                        CartList.Add(pcgPrice[4]);
                        CartList.Add(pcgQuantity4);
                        Accounts.balance = Accounts.balance -= SubtOtal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    }
                    Console.ReadKey();

                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c5 = Console.ReadLine();

                    if (option_c5 == input)
                        goto L1;
                    else if (option_c5 != input)
                        Accounts.UserAccount();
                    Console.ReadKey();
                    break;
                case 6:
                    Cart();
                    Console.ReadKey();
                    break;
                case 7:
                    CategoriesMenu();
                    break;               
                default: break;

            }

            Console.ReadLine();
        }

        // ALL THE COMMENTS FOR CATEGORY 1 IS THE SAME FOR CATEGORY 2 & 3
        public static void Category2()
        {
        L1: Console.Clear();
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("===================================================================================");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("                                    PlayStation Games                              ");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("===================================================================================");
            Console.ResetColor();
            Console.WriteLine("                                                                                   ");
            Console.WriteLine($"\t[1]   {psgName[0]}\t\t\t\t\t\t{psgPrice[0]}\n");
            Console.WriteLine($"\t{psgDes[0]}                                                         \n");
            Console.WriteLine($"\t[2]   {psgName[1]}\t\t\t\t\t\t{psgPrice[1]}\n");
            Console.WriteLine($"\t{psgDes[1]}                                                         \n");
            Console.WriteLine($"\t[3]   {psgName[2]}\t\t\t\t\t\t{psgPrice[2]}\n");
            Console.WriteLine($"\t{psgDes[2]}                                                         \n");
            Console.WriteLine($"\t[4]   {psgName[3]}\t\t\t\t\t{psgPrice[3]}\n");
            Console.WriteLine($"\t{psgDes[3]}                                                         \n");
            Console.WriteLine($"\t[5]   {psgName[4]}\t\t\t\t\t{psgPrice[4]}\n");
            Console.WriteLine($"\t{psgDes[4]}                                                         \n");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                    \tChoose a product to add to Cart                              ");
            Console.WriteLine("                    \tView Cart                   [6]                              ");
            Console.WriteLine("                    \tBack                        [7]                              ");
            Console.WriteLine("***********************************************************************************");

            int UserInput;
            UserInput = int.Parse(Console.ReadLine());
            string input = "y";

            switch (UserInput)
            {
                case 1:
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int psgQuantity = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {psgQuantity} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");

                    int Subtotal = (psgQuantity) * (psgPrice[0]);

                    if (Accounts.balance <= 0)
                    {
                        Console.Clear();
                        Accounts.balance = Accounts.balance * 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Accounts.UserAccount();

                    }
                    else if (Subtotal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(psgName[0]);
                        CartList.Add(psgPrice[0]);
                        CartList.Add(psgQuantity);
                        Accounts.balance = Accounts.balance -= Subtotal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    }


                    Console.ReadKey();

                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c1 = Console.ReadLine();

                    if (option_c1 == input)
                        goto L1;
                    else if (option_c1 != input)
                        Accounts.UserAccount();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int psgQuantity1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {psgQuantity1} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");

                    int SUbtotal = (psgQuantity1) * (psgPrice[1]);

                    if (Accounts.balance <= 0)
                    {
                        Console.Clear();
                        Accounts.balance = Accounts.balance * 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Accounts.UserAccount();

                    }
                    else if (SUbtotal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(psgName[1]);
                        CartList.Add(psgPrice[1]);
                        CartList.Add(psgQuantity1);
                        Accounts.balance = Accounts.balance -= SUbtotal;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    };

                    Console.ReadKey();

                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c2 = Console.ReadLine();

                    if (option_c2 == input)
                        goto L1;
                    else if (option_c2 != input)
                        Accounts.UserAccount();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int psgQuantity2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {psgQuantity2} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");

                    int SuBtotal = (psgQuantity2) * (psgPrice[2]);

                    if (Accounts.balance <= 0)
                    {
                        Console.Clear();
                        Accounts.balance = Accounts.balance * 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Accounts.UserAccount();

                    }
                    else if (SuBtotal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(psgName[2]);
                        CartList.Add(psgPrice[2]);
                        CartList.Add(psgQuantity2);
                        Accounts.balance = Accounts.balance -= SuBtotal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    };

                    Console.ReadKey();

                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c3 = Console.ReadLine();

                    if (option_c3 == input)
                        goto L1;
                    else if (option_c3 != input)
                        Accounts.UserAccount();
                    Console.ReadKey();
                    break;
                case 4:
                    // Ask user to input the quantity they wish to purchase
                    // Add item to cartList
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int psgQuantity3 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {psgQuantity3} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");

                    int SubTotal = (psgQuantity3) * (psgPrice[3]);

                    if (Accounts.balance <= 0)
                    {
                        Console.Clear();
                        Accounts.balance = Accounts.balance * 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Accounts.UserAccount();

                    }
                    else if (SubTotal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(psgName[3]);
                        CartList.Add(psgPrice[3]);
                        CartList.Add(psgQuantity3);
                        Accounts.balance = Accounts.balance -= SubTotal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    };

                    Console.ReadKey();

                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c4 = Console.ReadLine();

                    if (option_c4 == input)
                        goto L1;
                    else if (option_c4 != input)
                        Accounts.UserAccount();
                    Console.ReadKey();
                    break;
                case 5:
                    // Ask user to input the quantity they wish to purchase
                    // Add item to cartList
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int psgQuantity4 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {psgQuantity4} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");

                    int SubtOtal = (psgQuantity4) * (psgPrice[4]);

                    if (Accounts.balance <= 0)
                    {
                        Console.Clear();
                        Accounts.balance = Accounts.balance * 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Accounts.UserAccount();

                    }
                    else if (SubtOtal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(psgName[4]);
                        CartList.Add(psgPrice[4]);
                        CartList.Add(psgQuantity4);
                        Accounts.balance = Accounts.balance -= SubtOtal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    };

                    Console.ReadKey();

                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c5 = Console.ReadLine();

                    if (option_c5 == input)
                        goto L1;
                    else if (option_c5 != input)
                        Accounts.UserAccount();
                    Console.ReadKey();
                    break;
                case 6:
                    //Cart();
                    Console.ReadKey();
                    break;
                case 7:
                    CategoriesMenu();
                    break;

                //Create a fail safe when user enters an invalid input too many times it logs out of user account
                default: break;

            }

            Console.ReadLine();
        }
        public static void Category3()
        {
        L1: Console.Clear();
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("===================================================================================");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("                                    Xbox Games                              ");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("===================================================================================\n\n");
            Console.ResetColor();
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine($"\t[1]   {xbgName[0]}\t\t\t\t\t\t\t{xbgPrice[0]}\n");
            Console.WriteLine($"\t{xbgDes[0]}\n");
            Console.WriteLine($"\t[2]   {xbgName[1]}\t\t\t\t\t\t{xbgPrice[1]}\n");
            Console.WriteLine($"\t{xbgDes[1]}\n");
            Console.WriteLine($"\t[3]   {xbgName[2]}\t\t\t\t\t\t{xbgPrice[2]}\n");
            Console.WriteLine($"\t{xbgDes[2]}\n");
            Console.WriteLine($"\t[4]   {xbgName[3]}\t\t\t\t{xbgPrice[3]}\n");
            Console.WriteLine($"\t{xbgDes[3]}\n");
            Console.WriteLine($"\t[5]   {xbgName[4]}\t\t\t\t\t\t{xbgPrice[4]}\n");
            Console.WriteLine($"\t{xbgDes[4]}\n");            
            Console.WriteLine("                    \tChoose a product to add to Cart                              ");
            Console.WriteLine("                    \tView Cart                   [6]                              ");
            Console.WriteLine("                    \tBack                        [7]                              ");
            Console.WriteLine("***********************************************************************************");

            int UserInput;
            UserInput = int.Parse(Console.ReadLine());
            string input = "y";

            switch (UserInput)
            {
                case 1:
                    // Ask user to input the quantity they wish to purchase
                    // Add item to cartList
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int xbgQuantity = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {xbgQuantity} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");

                    int Subtotal = (xbgQuantity) * (xbgPrice[0]);

                    if (Accounts.balance <= 0)
                    {
                        Console.Clear();
                        Accounts.balance = Accounts.balance * 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Accounts.UserAccount();

                    }
                    else if (Subtotal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(xbgName[0]);
                        CartList.Add(xbgPrice[0]);
                        CartList.Add(xbgQuantity);
                        Accounts.balance = Accounts.balance -= Subtotal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    };

                    Console.ReadKey();

                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c1 = Console.ReadLine();

                    if (option_c1 == input)
                        goto L1;
                    else if (option_c1 != input)
                        Accounts.UserAccount();
                    Console.ReadKey();
                    break;
                case 2:
                    // Ask user to input the quantity they wish to purchase
                    // Add item to cartList
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int xbgQuantity1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {xbgQuantity1} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");

                    int SUbtotal = (xbgQuantity1) * (xbgPrice[1]);

                    if (Accounts.balance <= 0)
                    {
                        Console.Clear();
                        Accounts.balance = Accounts.balance * 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Accounts.UserAccount();

                    }
                    else if (SUbtotal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(xbgName[1]);
                        CartList.Add(xbgPrice[1]);
                        CartList.Add(xbgQuantity1);
                        Accounts.balance = Accounts.balance -= SUbtotal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    };


                    Console.ReadKey();

                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c2 = Console.ReadLine();

                    if (option_c2 == input)
                        goto L1;
                    else if (option_c2 != input)
                        Accounts.UserAccount();
                    Console.ReadKey();
                    break;
                case 3:
                    // Ask user to input the quantity they wish to purchase
                    // Add item to cartList
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int xbgQuantity2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {xbgQuantity2} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");

                    int SuBtotal = (xbgQuantity2) * (xbgPrice[2]);

                    if (Accounts.balance <= 0)
                    {
                        Console.Clear();
                        Accounts.balance = Accounts.balance * 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Accounts.UserAccount();

                    }
                    else if (SuBtotal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(xbgName[2]);
                        CartList.Add(xbgPrice[2]);
                        CartList.Add(xbgQuantity2);
                        Accounts.balance = Accounts.balance -= SuBtotal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    };
                    Console.ReadKey();

                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c3 = Console.ReadLine();

                    if (option_c3 == input)
                        goto L1;
                    else if (option_c3 != input)
                        Accounts.UserAccount();
                    Console.ReadKey();
                    break;
                case 4:
                    // Ask user to input the quantity they wish to purchase
                    // Add item to cartList
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int xbgQuantity3 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {xbgQuantity3} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");

                    int SubTotal = (xbgQuantity3) * (xbgPrice[3]);

                    if (Accounts.balance <= 0)
                    {
                        Console.Clear();
                        Accounts.balance = Accounts.balance * 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Accounts.UserAccount();

                    }
                    else if (SubTotal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(xbgName[3]);
                        CartList.Add(xbgPrice[3]);
                        CartList.Add(xbgQuantity3);
                        Accounts.balance = Accounts.balance -= SubTotal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    };
                    Console.ReadKey();

                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c4 = Console.ReadLine();

                    if (option_c4 == input)
                        goto L1;
                    else if (option_c4 != input)
                        Accounts.UserAccount();
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int xbgQuantity4 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {xbgQuantity4} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");

                    int SubtOtal = (xbgQuantity4) * (xbgPrice[4]);

                    if (Accounts.balance <= 0)
                    {
                        Console.Clear();
                        Accounts.balance = Accounts.balance * 1;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Console.ReadKey();
                        Accounts.UserAccount();

                    }
                    else if (SubtOtal < Accounts.balance)
                    {
                        Console.Clear();

                        CartList.Add(xbgName[4]);
                        CartList.Add(xbgPrice[4]);
                        CartList.Add(xbgQuantity4);
                        Accounts.balance = Accounts.balance -= SubtOtal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {Accounts.balance}");
                    };
                    Console.ReadKey();

                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c5 = Console.ReadLine();

                    if (option_c5 == input)
                        goto L1;
                    else if (option_c5 != input)
                        Accounts.UserAccount();
                    Console.ReadKey();
                    break;
                case 6:
                    Cart();
                    Console.ReadKey();
                    break;
                case 7:
                    CategoriesMenu();
                    Console.ReadKey();
                    break;
                default: break;

            }

            Console.ReadLine();
        }
    }
}


