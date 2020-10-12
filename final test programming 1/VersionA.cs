using System;
/*
 ********************************************************************************
 * Programming I - Fall 2018 Test 3 (Version A)
 * Name:
 * Date:
 * Student #:
 * Test 3 - 20% of final grade
 * 
 ******************************************************************************** 
 */

namespace VersionA
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        #region Question 1 - 12 marks
        /* 
         * Write a method that does not take any argument nor does it
         * return a value. The method only displays the following text.
         * 
         * YOU MUST INSERT YOUR NAME IN THE TOP LINE OF THE MENU 
         * 
         * --------------------COMP100--------------------------
         *             1) Working with array of doubles     
         *             2) Working with Distance Conversion  
         *             3) Working with Boltzmann's Law        
         *             4) Working with Bills                
         *                                                       
         *             0) To exit the program
         * ------------------------------------------------------
         * Press the letter corresponding to your choice-> 
         * 
         */
       

        #endregion

        #region Question 2 - 26 marks
        /* 
         * In your Main() method, using a suitable looping structure, write the 
         * code to call the above method repeatedly. 
         * Using a suitable branching structure, write the code to implement the 
         * following functionality.
         * Valid responses includes both upper and lower case of the input. The 
         * following must be implemented:
         * 1 will call the DemoQuestion3() method
         * 2 will call the DemoQuestion4() method
         * 3 will call the DemoQuestion5() method
         * 4 will call the DemoQuestion6() method
         * 0 will terminate the program
         * Any other key will produce an error message
         * 
         * YOU DON'T HAVE TO CREATE A NEW METHOD FOR THIS QUESTION
         */        
        #endregion

        #region Question 3 - 39 marks
        /* Question 3c (12 marks)
         * 
         * Write a method with the following specification
         * name     : DisplaySmallDoublesOnly
         * arguments: array of double
         * returns  : nothing
         * display  : only the items that are less than 0.5
         * task     : use a suitable looping structure to send each
         *            suitable item to the screen.
         *            
         * YOU MUST USE A FOR loop
         */
        
        /* Question 3b (9 marks)
         * 
         * Write a method with the following specification
         * name     : DisplayDoubleArray
         * arguments: array of double
         * returns  : nothing
         * display  : all the items in the array separated by a space
         * task     : use a suitable looping structure to send each
         *            item to the screen.
         * 
         * YOU MUST USE A FOREACH loop
         */
       
        /* Question 3a (11 marks)
         * 
         * Write a method with the following specification
         * name     : GenerateDoubleArray
         * arguments: int representing the number of items to generate, 
         *            i.e. the size of the resulting array
         * returns  : double array
         * display  : nothing
         * task     : 1) create the random object to generate random numbers
         *            2) declare and allocate storage for the array
         *            3) using a suitable looping structure get a random value 
         *               and assign it the element of the array
         *               use random.NextDouble() to obtain a random double
         *            4) return the array
         */
        
        /* The driver for question 3 (7 marks)
         * 
         * 1) Call GenerateDoubleArray with argument 20 and assign the 
         *    returned value to a suitable variable
         * 2) Use DisplayDoubleArray to print the above stored value
         * 3) Print an empty line
         * 4) Use DisplaySmallDoublesOnly to print only items less than 0.5
         */
        static void DemoQuestion3()
        {
            Console.WriteLine("\n\n**********Begin Question 3 **********");
            //code for invoking question 3 goes here
            

            Console.WriteLine("\n**********End Question 3 **********\n\n");
        }
        #endregion

        #region Question 4 - 20 marks
        /* Question 4 (14 marks)
         * 
         * Write a method with the following specification
         * name     : DistanceConversion
         * arguments: an int representing the cm value to convert
         *            an int to store the km
         *            an int to store the m
         *            an int to store the remaining cm
         * returns  : nothing
         * display  : nothing
         * task     : converts the first argument (number of cm) into 
         *            km, m and cm
         *           
         * hint     : the last three parameters are decorated so that the 
         *            method is able to modify the actual parameters
         *            
         *            You may use the % and the / operation in your calculation
         *            
         *          : 100 cm = 1 m
         *          : 1000 m = 1 km
         */
       
        /* The driver for question 4 (6 marks) 
         * 
         * 1) Declare an int variable (this will be your first argument) 
         *    and initialized it to 33333
         * 2) Declare three other variables to store the km, m and cm
         * 3) Call the DistanceConversion with the appropriate arguments. Print all of the 
         *    arguments after the method call 
         * 4) Now change the first argument to 7654321 and repeat step 3.  
         */
        static void DemoQuestion4()
        {
            Console.WriteLine("\n\n**********Begin Question 4 **********");
            //code for invoking question 4 goes here
           

            Console.WriteLine("\n**********End Question 4 **********\n\n");
        }
        #endregion

        #region Question 5 - 16 marks
        /* Question 5 (8 marks)
         * 
         * Stefan's law states that the energy emitted by a black body
         * is proportional to the temperature to the fourth power. 
         * (See the word document "Equations.doc" for the formulae.) 
         * Write a method that calculates and return the energy emitted
         * by a hot body. The specifications is as follows:
         * 
         * Name:
         *  Stefan
         *  
         * Argument: 
         *  a double representing the absolute temperature of the body
         *  
         * Returns:
         *  a double indicating the total energy emitted
         *  
         * Action:
         *  calculates and return the energy emitted
         *  by a hot body. The equation will be writen on the whiteboard
         *  
         * Displays:
         *  nothing.
         * 
         */
       
        /* The driver for question 5 (8 mark)
         * 
         * 1) Declare a variable of type double and initialize it to 300
         * 2) Invoke the method with this variable and display the resulting value
         * 3) change the variable to 5000 and repeat Step 2.
         */
        static void DemoQuestion5()
        {
            Console.WriteLine("\n\n**********Begin Question 5 **********");
            //code for invoking question 5 goes here
            

            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }
        #endregion

        #region Question 6 - 24 marks
        /* Question 6 (16 marks)
         * 
         * Power cost is calculated by a tired system i.e. The cost of a unit of power
         * depends on the amount of power used.  Write a method
         * that calculates and returns the cost of the power used for a month. 
         * The specifications is as follows:
         * 
         * Name: 
         *  CalculateElectricBill
         *  
         * Argument: 
         *  an int representing the power consumed for the month
         *  
         * Returns:
         *  a double indicating the cost of the power 
         *    
         * Action:
         *  Calculates and return the cost to the customer based on the following:
         *  the first 500 units cost $0.065 per unit
         *  the second 500 units cost $0.115 per unit
         *  the remaining units cost $0.155 per unit
         *  
         * Displays:
         *  nothing.
         *         
         */
       
        /* The driver for question 6 (8 marks)
         * 
         * 1) Declare an int variable and initialized it to 445
         * 2) Invoke the CalculateElectricBill method with this variable and print the returned value
         * 3) Change the variable to 725 and repeat step 2
         * 4) Change the variable to 1250 and repeat step 2
         */
        static void DemoQuestion6()
        {
            Console.WriteLine("\n\n**********Begin Question 6 **********");
            //code for invoking question 6 goes here
            

            Console.WriteLine("\n**********End Question 6 **********\n\n");
        }
        #endregion
    }
}

