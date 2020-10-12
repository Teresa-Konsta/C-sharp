using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viji_s_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Toronto Bank App!");
            string password = CreatePassword(6);
            Console.WriteLine($"Your pin for this session is: {password}");

            string choice;
            do
            {
                ChooseOption();
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        MakeDeposit();
                        break;

                    case "2":
                        InvestInSavings();
                        break;

                    case "3":
                        PurchaseStock();
                        break;

                    case "4":
                        ChangePin();
                        break;

                    case "5":
                        ShowAssets();
                        break;

                    default:
                        Console.WriteLine("Error. Invalid input.");
                        break;
                }
            } while (choice != "6");
        }

        static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        //// Generate a random string with a given size and case.   
        //// If second parameter is true, the return string is lowercase  
        //public string RandomString(int size, bool lowerCase)
        //{
        //    StringBuilder builder = new StringBuilder();
        //    Random random = new Random();
        //    char ch;
        //    for (int i = 0; i < size; i++)
        //    {
        //        ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
        //        builder.Append(ch);
        //    }
        //    if (lowerCase)
        //        return builder.ToString().ToLower();
        //    return builder.ToString();
        //}

        //using System;
        //using System.Security.Cryptography;

        //public static string GetRandomAlphanumericString(int length)
        //    {
        //        const string alphanumericCharacters =
        //            "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
        //            "abcdefghijklmnopqrstuvwxyz" +
        //            "0123456789";
        //        return GetRandomString(length, alphanumericCharacters);
        //    }

        //    public static string GetRandomString(int length, IEnumerable<char> characterSet)
        //    {
        //        if (length < 0)
        //            throw new ArgumentException("length must not be negative", "length");
        //        if (length > int.MaxValue / 8) // 250 million chars ought to be enough for anybody
        //            throw new ArgumentException("length is too big", "length");
        //        if (characterSet == null)
        //            throw new ArgumentNullException("characterSet");
        //        var characterArray = characterSet.Distinct().ToArray();
        //        if (characterArray.Length == 0)
        //            throw new ArgumentException("characterSet must not be empty", "characterSet");

        //        var bytes = new byte[length * 8];
        //        new RNGCryptoServiceProvider().GetBytes(bytes);
        //        var result = new char[length];
        //        for (int i = 0; i < length; i++)
        //        {
        //            ulong value = BitConverter.ToUInt64(bytes, i * 8);
        //            result[i] = characterArray[value % (uint)characterArray.Length];
        //        }
        //        return new string(result);
        //    }

        static void ChooseOption()
        {
            Console.WriteLine("Please choose from the following options: ");
            Console.WriteLine("1 – Make a deposit");
            Console.WriteLine("2 – Invest in a savings plan");
            Console.WriteLine("3 – Purchase stock");
            Console.WriteLine("4 – Change your pin");
            Console.WriteLine("5 – Asset overview");
            Console.WriteLine("6 – Exit program");
        }

        static double MakeDeposit()
        {
            Random randomDeposit = new Random(); //generate starting random balance
            double balance = randomDeposit.Next(0, 100000);
            Console.WriteLine($"Your current balance: {balance}");
            double sum;
            int stop;
            do
            {
                Console.WriteLine("Enter the sum you wish to deposit: ");
                sum = Convert.ToDouble(Console.ReadLine());
                sum++;
                Console.WriteLine("If you wish to make another deposit enter 1, if you want to exit enter 0: ");
                stop = Convert.ToInt32(Console.ReadLine());
            } while (stop != 0);
            double balanceFinal = balance + sum;
            Console.WriteLine($"Balance: {balanceFinal:C}");
            return balanceFinal;
        }

        static double InvestInSavings()
        {
           double savings;
           double balanceFinal = MakeDeposit();
             if (balanceFinal >= 5000)
             {
                savings = balanceFinal + balanceFinal * 0.05;
                Console.WriteLine($"Under 5% rate your savings balance is {savings:C}");
             }
             else
             {
                savings = balanceFinal + balanceFinal * 0.03;
                Console.WriteLine($"Under 3% rate your savings balance is {savings:C}");
             }
           return savings;
        }

        static double GetRandomeStockPrice (double minimum, double maximum)
        {
            Random randomStockPrice = new Random();
            return randomStockPrice.Next();
        }

        static double PurchaseStock()
        {
            string[] stock = "Amazon, Alphabet, Facebook, AT&T, iRobot, Wayfair, Netflix, TerraForm, Axon, CareTrust".Split();
            foreach (string stockSingle in stock)
            {
                Console.WriteLine(stockSingle + " ");
            }
            
            Console.WriteLine("Enter the number of stocks you want to buy: ");
            int stockNum = Convert.ToInt32(Console.ReadLine());
            
            string[] stockNewOrder = new string[stockNum];
            int counter = 1;
            double stockPrice;
            do
            {
                Console.WriteLine("Enter stock name: ");
                string item = Console.ReadLine();

                if (stock.Length != stock.Distinct().Count()) // search the array to see if some of that stock is already owned
                {
                    Console.WriteLine("Contains duplicates");
                }
                else
                {
                stockPrice = GetRandomeStockPrice(0.1, 200);
                Console.WriteLine($"The {item} price is: {stockPrice:C}");
                stockNewOrder[counter] = item;
                counter++;
                stockPrice++;
                }
            } while (counter <= stockNum);

            foreach (string stockNewItem in stockNewOrder)
            {
                Console.WriteLine(stockNewItem + " ");
            }
            Console.WriteLine($"The total cost of your stocks is: {stockPrice:C}");
            return stockPrice;
        }

        static void ChangePin()
        {
            string pin = CreatePassword(4);
            Console.WriteLine($"Your new pin is: {pin}");
        }

        static void ShowAssets()
        {
            Console.WriteLine("Your current assets:");
            double deposit = MakeDeposit();
            Console.WriteLine($"Deposit: {deposit:C}");
            double savings = InvestInSavings();
            Console.WriteLine($"Savings: {savings:C}");
            double stockInvestments = PurchaseStock();
            Console.WriteLine($"In stocks: {stockInvestments:C}");
            double totalAsset = deposit + savings + stockInvestments;
            Console.WriteLine($"Your total amount of assets is: {totalAsset:C}");
        }
    }
}
