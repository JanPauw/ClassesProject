using System;
using System.Collections.Generic;
using System.Text;

namespace prjClassMany
{
    class print_Items
    { 
        public void printReports()
        {
            //creating the link  to the object
            items i = new items();
            Console.Clear();

            //Welcome message
            Console.WriteLine("Welcome to  "+i.getShopName()+" and Cell number is "+i.getCellNumber());
            Console.WriteLine("###############################################################");
            Console.WriteLine("Product Name | Product Price");
            //Looping the arrays and printing out the values
            for (int x = 0; x < i.size(); x++)
            {
                Console.WriteLine("{0} ,\t \t R{1}", i.getProduct(x), i.getPrice(x));
            }
            Console.WriteLine("###############################################################");
            //getting the total
            Console.WriteLine("Total price is R{0}", i.getTotal());
            Console.ReadLine();
        }


    }
}
