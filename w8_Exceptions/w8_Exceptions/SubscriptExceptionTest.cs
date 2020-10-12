using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w8_Exceptions
{
    class SubscriptExceptionTest
    {
        static void Main(string[] args)
        {
            double[] myList = {1.1, 20.2, 15.3, 14.3, 58.9, 75.3, 15.6, 45.6, 98.7, 35.7};
            const int STOP = 99;

            Console.WriteLine("Enter a position of a double number: ");
            int position = int.Parse(Console.ReadLine());
            
            while(position != STOP)
            {
                try
                {
                    Console.WriteLine($"Value on position {position} is equal to {myList[position]}");
                    int i = 4 / (2 - position); // division by 0 error simulation
                    if(myList[position] > 10)
                    {
                        throw (new Exception("No value above 10"));
                    }
                }
                //catch (Exception e) at the beginning cause a problem, coz starts from specific exceptions, general goes to end
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    throw;
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine("No division by 0");
                    throw;
                }
                catch(Exception e) //general error
                {
                    Console.WriteLine($"Error details: {e.Message}");
                    throw;
                }
                finally
                {
                    Console.WriteLine("I'm finally!");
                }
                Console.WriteLine("Enter a position of a double number: ");
                position = int.Parse(Console.ReadLine());
            }
        }
    }
}
