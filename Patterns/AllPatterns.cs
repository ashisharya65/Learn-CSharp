using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows you want in the pattern : ");
        if(!int.TryParse(Console.ReadLine(), out int num))
        {
            Console.WriteLine("The number you entered is not valid. Please try again.");
            return;
        }

        // method call
        Pattern1(num);
        Pattern2(num);
        Pattern3(num);
        Pattern4(num);
        Pattern5(num);
        Pattern6(num);
        Pattern7(num);
    }

    /* 
        Square/Grid pattern - 
        *****
        *****
        *****
        *****
        *****
     */
    static void Pattern1(int num)
    {

        Console.WriteLine("Grid Pattern: ");
        for (int row = 1; row <= num; row++)
        {
            for (int col=1; col <=num; col++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    /*
        Half Pyramid pattern - 
        *
        **
        ***
        ****
        *****
    */
    static void Pattern2(int num)
    {
        Console.WriteLine("\nHalf Pyramid Pattern: ");
        for (int row = 1; row <= num; row++)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    /*
        Inverted Right Half Pyramid -
        * * * * *
        * * * * 
        * * *
        * *
        *
    */
    static void Pattern3(int num)
    {
        Console.WriteLine("\nRight Half Pyramid Pattern: ");
        for (int row = 1; row <= num; row++)
        {
            for (int col = 1; col <= (num - row + 1);col++ )
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }


    /*
        Left Half Pyramid - 
                *   
              * *
            * * *
          * * * *
        * * * * *
    */
    static void Pattern4(int num)
    {
        Console.WriteLine("\nRight Half Pyramid Pattern: ");
        for (int row = 1; row <= num; row++)
        {   
            for (int space = 1; space <= (num - row); space++)
            {
                Console.Write(" ");
            }

            for(int col = 1;col<=row; col++ )
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    /*
        Pyramid Pattern - 
            *
           ***
          *****
         *******
        *********
    */

    static void Pattern5(int num)
    {
        Console.WriteLine("Pyramid Pattern: ");
        for (int row = 1; row <= num; row++)
        {
            for (int space = 1;space <= num - row; space++)
            {
                Console.Write(" ");
            }

            for (int star = 1; star <= (2 * row - 1); star++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

    }

    /*
        Inverted Pyramid - 
        ********* 
         *******  
          *****   
           ***    
            *     
    */
    static void Pattern6(int num)
    {
        Console.WriteLine("\nInverted Pyramid Pattern: ");
        
        for(int row=1; row<= num; row++)
        {
            for (int space=1; space<= (row-1) ; space++)
            {
                Console.Write(" ");
            }

            for (int star=1; star<=(2 * (num-row) + 1); star++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
        

    }

    /*
        Diamond Pattern - 
            *
           ***
          *****
         *******
        *********
         *******
          *****
           ***
            * 
    */

    static void Pattern7(int num)
    {
        Console.WriteLine("\nDiamond Pattern: ");

        // 1. UPPER PYRAMID
        for (int row=1; row<=num;row++)
        {
            for(int space=1; space<= num-row;space++)
            {
                Console.Write(" ");
            }

            for(int star=1; star<=(2*row-1); star++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        // 2. LOWER PYRAMID
        for(int row=1; row<=num-1;row++)
        {
            for (int space=1; space<=row;space++)
            {
                Console.Write(" ");
            }

            for (int star=1;star<=(2*(num-row)-1);star++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

    }
}
