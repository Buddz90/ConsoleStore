using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Store.CategoriesMenu();
            Store.Category1();
            Store.Category2();
            Store.Category3();
        }
    }
    class Store
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
        public static string[] itemList2 = { "Need for Speed", "Warzone", "Rugby 2K23", "Grand Theft Auto", "NFL 2K23" };
        public static string[] item2Description = { "" }; // Continue from here
        public static int[] itemPrice2 = { 110, 60, 210, 160, 200 };
        public static string[] itemList3 = { "Halo", "Apex Legends", "Fortnite", "Friday Night Fights: Round 3", "Sim World" };
        public static string[] item3Description = { };
        public static int[] itemPrice3 = { 80, 95, 200, 240, 50 };

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
                    //Category3();
                    Console.ReadKey();
                    break;
                case 4:
                    //Cart();
                    Console.ReadKey();
                    break;
                case 5:
                    //Returns to preivious page //UserAccount();
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

        // Pc Games Category
        public static void Category1()
        {
            Console.Clear();
            Console.WriteLine("===================================================================================");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("                                    PC Games                              ");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine($"\t[1]   {itemList1[0]}                                          \t${itemPrice1[0]}\n");
            Console.WriteLine($"\t{item1Description[0]}                                                         \n");
            Console.WriteLine($"\t[2]   {itemList1[1]}                                          \t${itemPrice1[1]}\n");
            Console.WriteLine($"\t{item1Description[1]}                                                         \n");
            Console.WriteLine($"\t[3]   {itemList1[2]}                                          \t${itemPrice1[2]}\n");
            Console.WriteLine($"\t{item1Description[2]}                                                         \n");
            Console.WriteLine($"\t[4]   {itemList1[3]}                                          \t${itemPrice1[3]}\n");
            Console.WriteLine($"\t{item1Description[3]}                                                         \n");
            Console.WriteLine($"\t[5]   {itemList1[4]}                                          \t${itemPrice1[4]}\n");
            Console.WriteLine($"\t{item1Description[4]}                                                         \n");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                    \tChoose a product to add to Cart                              ");
            Console.WriteLine("                    \tView Cart                   [6]                              ");
            Console.WriteLine("                    \tBack                        [7]                              ");
            Console.WriteLine("***********************************************************************************");

            Console.ReadLine();
        }
        public static void Category2()
        {
            Console.Clear();
            Console.WriteLine("===================================================================================");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("                                    PC Games                              ");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine($"\t[1]   {itemList2[0]}                                          \t${itemPrice2[0]}\n");
            Console.WriteLine($"\t{item2Description[0]}                                                         \n");
            Console.WriteLine($"\t[2]   {itemList2[1]}                                          \t${itemPrice2[1]}\n");
            Console.WriteLine($"\t{item2Description[1]}                                                         \n");
            Console.WriteLine($"\t[3]   {itemList2[2]}                                          \t${itemPrice2[2]}\n");
            Console.WriteLine($"\t{item2Description[2]}                                                         \n");
            Console.WriteLine($"\t[4]   {itemList2[3]}                                          \t${itemPrice2[3]}\n");
            Console.WriteLine($"\t{item2Description[3]}                                                         \n");
            Console.WriteLine($"\t[5]   {itemList2[4]}                                          \t${itemPrice2[4]}\n");
            Console.WriteLine($"\t{item2Description[4]}                                                         \n");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                                                                                   ");
            Console.WriteLine("                    \tChoose a product to add to Cart                              ");
            Console.WriteLine("                    \tView Cart                   [6]                              ");
            Console.WriteLine("                    \tBack                        [7]                              ");
            Console.WriteLine("***********************************************************************************");

            Console.ReadLine();
        }
        public static void Category3()
        {
            Console.Clear();
            Console.WriteLine("===================================================================================");
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("                                    PC Games                              ");
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
                    break;
                case 2:
                    Console.WriteLine("Your item has been added to your cart.");// Add item to cart
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Your item has been added to your cart.");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Your item has been added to your cart.");//Cart();
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Your item has been added to your cart.");//UserAccount();
                    Console.ReadKey();
                    break;
                case 6:
                    //Cart();
                    Console.ReadKey();
                    break;
                case 7:
                    CategoriesMenu();
                    Thread.Sleep(1000);
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
    }
}



