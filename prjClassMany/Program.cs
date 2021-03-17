using System;

namespace prjClassMany
{
    class Program
    {
        static void Main(string[] args)
        {
            //connect to the object 
            items i = new items();
            //request the basic info
            Console.Write("Please enter the shops name :");
            i.setShopName(Console.ReadLine());

            Console.Write("Please enter the cell number :");
            i.setCellNumber(Console.ReadLine());


            Console.Write("Please enter the amount of products :");
            i.setArray(Convert.ToInt32(Console.ReadLine()));
            
            //capture the info from the capture class
            capture c = new capture();
            c.getProductDetails();

            //print everythign that is inside the classes
            print_Items p = new print_Items();
            p.printReports();




        }
    }
}
