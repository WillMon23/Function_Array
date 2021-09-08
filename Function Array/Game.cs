using System;
using System.Collections.Generic;
using System.Text;

namespace Function_Array
{
    class Game
    {
        // Decalres My Variable of Arrays 
        int[] num;

        /// <summary>
        /// Function meant to take in an Array of Intagers  
        /// then print the indavigual numbers from 0 to length of Index
        /// </summary>
        /// <param name="numbers"> A Collection of inatgures </param>
        void PrintArray(int[] numbers)
        { 
            // Loops Within the Array 
            for (int number = 0; number < numbers.Length; number++)
                // Print Out what THe Current Index 
                Console.WriteLine(numbers[number]);

            Console.ReadKey(true);
            Console.Clear();
        }

        /// <summary>
        /// Function meant to take in an Array of Intagers
        /// then print the indavigual numbers from length of Index to 0
        /// </summary>
        /// <param name="numbers"> Array of Intagures </param>
        void PrintBackwords(int[] numbers)
        {
            //Loops Within the Arry in Reverse 
            for (int number = (numbers.Length - 1); -1 < number; number--)
                // Print Out what THe Current Index 
                Console.WriteLine(numbers[number]);

            Console.ReadKey(true);
            Console.Clear();
        }

        void TopToBottom(int[] numbers)
        {
            int before = numbers[0];
            int after = numbers[0];
            int largest = numbers[0];
            int smallest = numbers[0];

            for(int num = 0; num < numbers.Length; num++)
            {
                if (num + 1 == numbers.Length)
                    break;

                before = numbers[num];

                after = numbers[num + 1];

                if (after > before)
                    largest = after;


                if (after < before)
                    smallest = after;

               

            }

            Console.WriteLine("The Largest Number is: " + largest);
            Console.WriteLine("The Smallest Number is: " + smallest);
        }
            
        public void Run()
        {
            // Array of Random Numbers 
            num = new int[] { 1, 2, 3, 4, 5, 6 };

            int[] num2 = new int[] { 343, 564, 54, 100, 323, 4343, 53453, 6564, 5656464};

            PrintArray(num);

            PrintBackwords(num);

            TopToBottom(num);


        }
    }
}
