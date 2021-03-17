using System;
using System.Collections.Generic;
using System.Text;

namespace prjClassMany
{
    class capture
    {
        public void getProductDetails()
        {
            items i = new items();

            Console.Clear();
            // this is used to loop to the size of the products you set 
            for (int x = 0; x < i.size(); x++)// the isize is there to pull the amount of products you decided to use
            {
                Console.Write( "Please enter the product name "+(x+1)+" :");//request the product name
                String strProduct = Console.ReadLine();

                Console.Write("Please enter price for "+strProduct+" R:");//request product price
                double dblPrice = Convert.ToDouble(Console.ReadLine());
                //set the values in the items object
                i.setProduct(strProduct);
                i.setPrice(dblPrice);

            }

        }
    }
}
