using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;
using System.Linq.Expressions;
using COMP_4204_ConsoleOnlineStore;
using System.Security;
using System.Globalization;


namespace COMP_4204_ConsoleOnlineStore
{
    public class Program
    {

        /*// Create Globeal variables here
        public string FirstName;
        public string LastName;        
        public string Password;
        public int balance;*/

        // Entry Point
        public static void Main(string[] args)
        {
            StoreFront.StoreAccess();
            SetAccount.UserAccount();

        }

    }
    // User Details storage
    public class UserDetails
    {
        public static string input;
        private static readonly UserDetails userPass;

        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string Password { get; set; }
        public static string NewUser { get; private set; }
        public static string Passrd { get; private set; }

        public static void SignUp()
        {

        // Ask for the users name to add to the database.
        L1: Console.Clear();
            Console.Write("\tPlease enter your First name: ");
            string firstName = Console.ReadLine();
            //UserDetails User = new UserDetails();
            FirstName = firstName;


            if (firstName != "")
            {

                if (firstName == UserDetails.FirstName)
                    goto L2;
            }
            else
            {
                Console.WriteLine("\n\tNo Match was found, try again");
                goto L1;
            }

        //Console.Clear();
        L2: Console.Write("\tGreat..Now, Please enter your Last name: ");
            string lastName = Console.ReadLine();
            UserDetails LastName = new UserDetails();
            ;

        // Ask user to create a password to create the users store account.
        // Store password in DB with name.

        // The next time this user returns to the store, he is able to select the sign-in function.
        L4: Console.Write("\tPlease create a Password: ");
            string userPwd = Console.ReadLine();
            UserDetails userPass = new UserDetails();

            Password = userPwd;



            // >>>MAKE SURE TO VALIDATE LOGIN DETAILS<<<
            if (userPwd != "")
            {
                Console.Write("\tPlease Re-Enter Password: ");

                input = Console.ReadLine();
                //input = "";

                if (userPwd != input) // >>>The name I doesnt exist in the current context
                {

                    Console.WriteLine("\tTry again");
                    goto L4;
                }
                else
                {
                    goto L3;
                }
            }
            else
            {
                if (UserDetails.Password != userPwd)
                    Console.WriteLine("\n\tThis field is empty, try again");
                goto L4;
            }

        // Display message to user then Call UserAccount()
        L3: Console.WriteLine("\tYour account is being created, please wait...");
            Thread.Sleep(1000);
            SetAccount.UserAccount();
        }

        public static UserDetails GetUserPass()
        {
            return userPass;
        }

        public static void SignIn(UserDetails userPass)// >>>CHANGE NAME OF THIS<<< & OTHER REFS SIGN-IN
        {
        L5: Console.Write("\tPlease enter your First Name: ");
            string CheckUserInit = Console.ReadLine();

            if (CheckUserInit != "")
            {
                if (CheckUserInit == UserDetails.FirstName)
                    goto L6;

            }
            else
            {
                Console.WriteLine("\n\tSearching...");
                Thread.Sleep(1000);
                Console.WriteLine("\tName not found, try again");
                goto L5;
            }

        L6: Console.Write("\tPlease enter your Password: ");
            string CheckUserPwd = Console.ReadLine();


        // >>>ADD A CONDITION STATEMENT HERE<<<
        L8: string i = CheckUserPwd;
            UserDetails userDetails = new UserDetails();
            //object value = userPass.Password;
            //Console.WriteLine(userPass.Password);

            if (i != "")
            {
                Console.WriteLine("\tSearching...");
                Thread.Sleep(1000);
                //UserDetails userPass = userDetails;
                UserDetails Password = NewUser;
                bool v = Passrd == CheckUserPwd;
                if (v)
                    return;
                //SetAccount.UserAccount();
                //Console.Clear();
                //.ForegroundColor = ConsoleColor.Green; <<<<<<<ISSUE HERE>>>>>>> NEEDS ERROR IN IF ELSE

                Console.WriteLine("\tAccess denied\n");




            }
            else
            {
                Console.WriteLine("\n\tSearching...");
                Thread.Sleep(1000);
                Console.WriteLine("\tName not found, try again");
                goto L8;
            }

        }

        public static implicit operator UserDetails(string v) => throw new NotImplementedException();
    }

    // >>>>>>GET AND SET NAME AND PASSWORD fIND vIDEO<<<<<<
    public class StoreFront
    {

        // Create a store() front method with the option to sign up or sign in.
        public static void StoreAccess()
        {
            Console.Write("\tWELCOME TO DIGGYGAMEZ\n\n");
            Console.WriteLine("\tIn order for you to access this store, \n\tyou will need to Sign-Up.");
            Console.WriteLine("\tOnce your account has been created, \n\tyou must add credit to purchase your items.\n\n");
            Console.WriteLine("\tPlease select an option below\n\n\n");
            Console.WriteLine("\t\tSign-Up......[1]");
            Console.WriteLine("\t\tSign-In......[2]\n\n\n");
            // The user is to select and option.
            string input = Console.ReadLine();

            // Add requirements to throw error if user enters incorrect character.
            // User input is stored to a variable to use later.
            if (input == "1")
            {
                UserDetails.SignUp();
            }//end of if statement*/
            if (input == "2")
            {
                UserDetails.SignIn(UserDetails.GetUserPass());
            }
        }


    }

    #region UserAccount


    public class SetAccount
    {
        int deposite;
        int balance;
        public static void UserAccount()
        {
            // Display User Account menu option
            Console.WriteLine("\tWelcome to STORENAME"); // <<<CHANGE STORENAME
            Console.WriteLine("\tPlease select an option below: \n\n");
            Console.WriteLine("[1] Top-up");
            Console.WriteLine("[2] Browse Store");
            Console.WriteLine("[3] View Cart");
            Console.WriteLine("[4] Log-out");
            string selectedOption = Console.ReadLine();

            switch (selectedOption)
            {
                case "1":
                    TopUp();

                    break;
                case "2":
                    Browse();
                    break;
                case "3":
                    Cart();
                    break;
                case "4":
                    StoreFront.StoreAccess();
                    break;
                default:
                    Console.WriteLine("No match found");
                    break;
            }

            Console.ReadKey();
        }
        // Deposit funds to account = User Taken to Deposit menu
        public static void TopUp()
        {
            Console.WriteLine("\tYou are in the Top-up function Please enter the amount you want to deposit");
            int deposite = int.Parse(Console.ReadLine());
            int balance = +deposite;
            Console.WriteLine("\nYour balance is now: " + balance);
            Console.WriteLine("\tPress any key to go back");
            Console.ReadKey();
            Thread.Sleep(100);
            UserAccount();


        }
        // Start Shopping = opens to Category Menu()
        public static void Browse()
        {
            Console.WriteLine("You are in the Browse function");
            Console.WriteLine("\tPress any key to go back");
            Console.ReadKey();
            Thread.Sleep(100);
            UserAccount();
        }
        // Display Cart = Items selected by user are added to a list, and the prices calculated when user performs purchase 
        public static void Cart()
        {
            Console.WriteLine("You are in the Cart function");
            Console.WriteLine("\tPress any key to go back");
            Console.ReadKey();
            Thread.Sleep(100);
            UserAccount();
        }
        // Log-Out
        // Add requirements to throw error if user enters incorrect character.



        #endregion




    }
}




#region Deposit
// Deposit()

// User is prompted to enter and amount
// Amount is calculated and added to the users account balance and displayed.
// Add requirements to throw error if user enters incorrect character.
// Allow the user to select from the options       
// Browse
// View Cart
// Back to account
#endregion
#region Menu
// Menu()

// Create a list of 3 objects which will be the category list for the user to choose from.
// PC Games = Display item list
// PlayStation Games = Display item list
// XBox Games = Display item list
// All = Displays all items from each category.

// Back to account
// Add requirements to throw error if user enters incorrect character.
#endregion

#region Cart
// Cart() Global

// Create a list of selected items from the user inputs added to the cart. .
// Add and display total amount
// Subtract total from balance and display after purchase balance.
// Allow user to select from the options
// Continue Shopping
// Select Quantity of an item
// Remove item
// Deposit funds
// Purchase

// Back to previous page
#endregion
#region CategoryName
// catName()

// Create a list of 3 categories for the user to choose from.
// Allow the user the option to
// Select a category = taken to itemList() Option menu

// Back to menu
#endregion

#region ItemList
// itemList()

// Display list of items with a descrption and price
// Allow option for user to
// Select product to add to Cart() list
// Display Cart = taken to Cart()
// Back to previous page.
#endregion