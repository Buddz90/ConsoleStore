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
    class Program
    {
        static void Main(string[] args)
        {
            StoreFront.SignIn();
            Store.CategoriesMenu();
            Store.Category1();
            Store.Category2();
            Store.Category3();

            
        }
    }
    public class StoreFront
    {

        public static void SignIn()
        {

            Console.WriteLine("*****************************************");
            Console.WriteLine("\tWelcome to EB Games ");
            Console.WriteLine("*****************************************");
            // ask user for name and save variable
            Console.WriteLine("Please enter user name:");
            name = Console.ReadLine();
            SetAccount.UserAccount();
        }
    }
    public class SetAccount
    {
        public static int deposite;
        public static int balance = 500;
        public static void UserAccount()
        {
            // Display User Account menu option
            Console.WriteLine("\tWelcome to EB Games Store" + "\tYour balance is " + balance); // <<<CHANGE STORENAME


            Console.WriteLine("\n\tPlease select an option below: \n\n");


            Console.WriteLine("[1] Top-up");
            Console.WriteLine("[2] Browse Store");
            Console.WriteLine("[3] View Cart");
            Console.WriteLine("[4] Log-out");
            string selectedOption = Console.ReadLine();


            switch (selectedOption)
            {
                case "1":
                    // Deposit Phase
                    Console.WriteLine("\tPlease enter the amount you want to deposit");
                    deposite = int.Parse(Console.ReadLine());
                    balance = balance + deposite;
                    Console.WriteLine("\nYour balance is now: " + balance);
                    Console.WriteLine("\tPress any key to go back");
                    Console.ReadKey();
                    UserAccount();

                    break;
                case "2":

                    Store.CategoriesMenu();
                    Console.ReadKey();
                    Thread.Sleep(100);
                    UserAccount();
                    break;
                case "3":
                    
                    Cart.ViewCart();
                    Console.ReadKey();
                    Thread.Sleep(100);
                    break;
                case "4":
                    StoreFront.SignIn();
                    break;
                default:
                    Console.WriteLine("No match found");
                    break;
            }

            Console.ReadKey();

        }
    }

    {
        // Array of products + price + description
        public static string[] itemList1 = { "NBA 2k23", "The Witcher 3", "Call of Duty", "Forza Horizon 5", "Ghost Recon" };
        public static string[] item1Description = { "NBA 2K23's gameplay has a bevy of new improvements " +
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
        public static int[] itemPrice1 = { 160, 145, 190, 240, 134 };
        public static string[] itemList2 = { "Need for Speed", "Warzone", "Rugby 2K22", "Grand Theft Auto", "Madden NFL 23" };
        public static string[] item2Description = { "Need for Speed is a racing video game franchise published\n \tby Electronic Arts" +
                                                    "and currently developed by\n \tCriterion Games, the developers of Burnout.",
                                                    "Warzone allows online multiplayer combat among 150 players,\n \talthough some limited-time game modes " +
                                                    "support 200 players.\n \tThe game features both cross-platform\n \tplay and cross-platform " +
                                                    "progression between the three aforementioned titles",
                                                    "Rugby 22 offers total rugby, combining tactics and\n \tintensity through gameplay that stays " +
                                                    "true to the sport.\n \tTAKE YOUR TEAM TO THE TOP Lead your players\n \tto victory in tournaments," +
                                                    "official leagues and a Career Mode\n \tin which you can create and manage your own team.",
                                                    "Grand Theft Auto V is an action-adventure game played\n \tfrom either a third-person or" +
                                                    "first-person perspective.\n \tPlayers complete missions—linear scenarios with set objectives—to\n" +
                                                    " \tprogress through the story. Outside of the missions,\n \tplayers may freely roam the open world",
                                                    "All new to Ultimate Team for Madden NFL 23\n \tis the Field Pass. With the Field Pass providing\n \ta clear " +
                                                    "path to progression, you'll always know\n \twhat you need to do next"}; // Continue from here
        public static int[] itemPrice2 = { 110, 60, 210, 160, 200 };
        public static string[] itemList3 = { "Halo", "Apex Legends", "Fortnite", "Friday Night Fights: Round 3", "Sim World" };
        public static string[] item3Description = { "Halo is set in the twenty-sixth century, with the\n \tplayer assuming the role of the Master Chief," +
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
                                                    "\n \tfeel the detail as you sit in the driver's seat or\n \texplore on foot and bring classic trains roaring to life!"};

    class Store
    {
        public static void CategoriesMenu()
        {
            List<string> CategoryList = new List<string>();
            CategoryList.Add("PC Games");
            CategoryList.Add("PlayStation Games");
            CategoryList.Add("XBox Games");


            //Display Banner Options for user to select.
            Console.Clear();
            Console.WriteLine("===================================================================================");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("              \tLIMITED EDTION GAMES   LIMITED STOCK BE QUICK!                     ");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("\n\n\n\n\n\n\n\n");

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
                    //Cart();
                    Console.ReadKey();
                    break;
                case 5:
                    SetAccount.UserAccount();
                    Console.ReadKey();
                    break;

                //Create a fail safe when user enters an invalid input too many times it logs out of user account
                default:
                    Console.WriteLine("Please enter a valid number");
                    Thread.Sleep(500);
                    CategoriesMenu();

                    break;

            }

            Console.ReadLine();
            }
        public class Inventory
        {
            public static void Products()
            {


            Console.ReadLine();
        }

        // Pc Games Category
        public static void Category1()
        {
        L1: Console.Clear();
            Console.WriteLine("===================================================================================");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("                                    PC Games                              ");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("                                                                                   ");
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



                    if (SetAccount.balance < 0)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\tERROR!:Please deposit more funds.");
                        Console.ResetColor();
                        Thread.Sleep(800);
                        SetAccount.balance = SetAccount.balance * 1;
                        SetAccount.UserAccount();

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
                        SetAccount.balance = SetAccount.balance -= Subtotal;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tPayment Successful");
                        Console.ResetColor();
                        Console.WriteLine($"\tYour Remaining balance is: {SetAccount.balance}");
                    }
                    Thread.Sleep(1000);
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c1 = Console.ReadLine();

                    if (option_c1 == input)
                        goto L1;
                    else if (option_c1 != input)
                        SetAccount.UserAccount();  
                        Console.ReadKey();
                    break;
                case 2:
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int quantity_c2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {quantity_c2} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
                    Console.ReadKey();
                    Console.WriteLine("\tYour items have been added to the cart.");
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c2 = Console.ReadLine();

                    if (option_c2 == input)
                        goto L1;
                    else if (option_c2 != input)
                        SetAccount.UserAccount();  
                        Console.ReadKey();
                    break;
                case 3:
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int quantity_c3 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {quantity_c3} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
                    Console.ReadKey();
                    Console.WriteLine("\tYour items have been added to the cart.");
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c3 = Console.ReadLine();

                    if (option_c3 == input)
                        goto L1;
                    else if (option_c3 != input)
                        SetAccount.UserAccount();  
                        Console.ReadKey();
                    break;
                case 4:
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int quantity_c4 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {quantity_c4} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
                    Console.ReadKey();
                    Console.WriteLine("\tYour items have been added to the cart.");
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c4 = Console.ReadLine();

                    if (option_c4 == input)
                        goto L1;
                    else if (option_c4 != input)
                        SetAccount.UserAccount();  
                        Console.ReadKey();
                    break;
                case 5:
                    // Ask user to input the quantity they wish to purchase
                    // Add item to cartList
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int quantity_c5 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {quantity_c5} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
                    Console.ReadKey();

                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c5 = Console.ReadLine();

                    if (option_c5 == input)
                        goto L1;
                    else if (option_c5 != input)
                        SetAccount.UserAccount();  
                        Console.ReadKey();
                    break;
                case 6:
                    //Cart();
                    Console.ReadKey();
                    break;
                case 7:
                    CategoriesMenu();
                    break;
                default: break;

            }

            Console.ReadLine();
        }
        public static void Category2()
        {
        L1: Console.Clear();
            Console.WriteLine("===================================================================================");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("                                    PlayStation Games                              ");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("                                                                                   ");
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
                    int quantity_c1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {quantity_c1} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
                    Console.ReadKey();
                    Console.WriteLine("\tYour items have been added to the cart.");
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c1 = Console.ReadLine();

                    if (option_c1 == input)
                        goto L1;
                    else if (option_c1 != input)
                        SetAccount.UserAccount();  
                        Console.ReadKey();
                    break;
                case 2:
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int quantity_c2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {quantity_c2} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
                    Console.ReadKey();
                    Console.WriteLine("\tYour items have been added to the cart.");
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c2 = Console.ReadLine();

                    if (option_c2 == input)
                        goto L1;
                    else if (option_c2 != input)
                        SetAccount.UserAccount();  
                        Console.ReadKey();
                    break;
                case 3:
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int quantity_c3 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {quantity_c3} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
                    Console.ReadKey();
                    Console.WriteLine("\tYour items have been added to the cart.");
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c3 = Console.ReadLine();

                    if (option_c3 == input)
                        goto L1;
                    else if (option_c3 != input)
                        SetAccount.UserAccount();  
                        Console.ReadKey();
                    break;
                case 4:
                    // Ask user to input the quantity they wish to purchase
                    // Add item to cartList
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int quantity_c4 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {quantity_c4} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
                    Console.ReadKey();
                    Console.WriteLine("\tYour items have been added to the cart.");
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c4 = Console.ReadLine();

                    if (option_c4 == input)
                        goto L1;
                    else if (option_c4 != input)
                        SetAccount.UserAccount();  
                        Console.ReadKey();
                    break;
                case 5:
                    // Ask user to input the quantity they wish to purchase
                    // Add item to cartList
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int quantity_c5 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {quantity_c5} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
                    Console.ReadKey();
                    Console.WriteLine("\tYour items have been added to the cart.");
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c5 = Console.ReadLine();

                    if (option_c5 == input)
                        goto L1;
                    else if (option_c5 != input)
                        SetAccount.UserAccount();  
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
            Console.WriteLine("===================================================================================");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("                                    Xbox Games                              ");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine($"\t[1]   {itemList3[0]}                                          \t${itemPrice3[0]}\n");
            Console.WriteLine($"\t{item3Description[0]}                                                         \n");
            Console.WriteLine($"\t[2]   {itemList3[1]}                                          \t${itemPrice3[1]}\n");
            Console.WriteLine($"\t{item3Description[1]}                                                         \n");
            Console.WriteLine($"\t[3]   {itemList3[2]}                                          \t${itemPrice3[2]}\n");
            Console.WriteLine($"\t{item3Description[2]}                                                         \n");
            Console.WriteLine($"\t[4]   {itemList3[3]}                                          \t${itemPrice3[3]}\n");
            Console.WriteLine($"\t{item3Description[3]}                                                         \n");
            Console.WriteLine($"\t[5]   {itemList3[4]}                                          \t${itemPrice3[4]}\n");
            Console.WriteLine($"\t{item3Description[4]}                                                         \n");
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
                    // Ask user to input the quantity they wish to purchase
                    // Add item to cartList
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int quantity_c1 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {quantity_c1} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
                    Console.ReadKey();
                    Console.WriteLine("\tYour items have been added to the cart.");
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c1 = Console.ReadLine();

                    if (option_c1 == input)
                        goto L1;
                    else if (option_c1 != input)
                        SetAccount.UserAccount();  
                        Console.ReadKey();
                    break;
                case 2:
                    // Ask user to input the quantity they wish to purchase
                    // Add item to cartList
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int quantity_c2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {quantity_c2} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
                    Console.ReadKey();
                    Console.WriteLine("\tYour items have been added to the cart.");
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c2 = Console.ReadLine();

                    if (option_c2 == input)
                        goto L1;
                    else if (option_c2 != input)
                        SetAccount.UserAccount();  
                        Console.ReadKey();
                    break;
                case 3:
                    // Ask user to input the quantity they wish to purchase
                    // Add item to cartList
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int quantity_c3 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {quantity_c3} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
                    Console.ReadKey();
                    Console.WriteLine("\tYour items have been added to the cart.");
                    Console.Write("\tWould you like to keep browsing [y/n] ?: ");
                    string option_c3 = Console.ReadLine();

                    if (option_c3 == input)
                        goto L1;
                    else if (option_c3 != input)
                        SetAccount.UserAccount();  
                        Console.ReadKey();
                    break;
                case 4:
                    // Ask user to input the quantity they wish to purchase
                    // Add item to cartList
                    Console.Write("\tPlease select the quantity you wish to purchase: ");
                    int quantity_c4 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\tYou have selected: {quantity_c4} items of this product");
                    Console.WriteLine("\tPress Enter to confirm");
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


