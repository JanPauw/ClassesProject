using System;
using System.Collections.Generic;
using System.Text;

namespace prjClassMany
{
    class items
    {

        #region vars raw
        private static String[] productName;
        private static double[] price;
        private static double dTotal = 0;

        private static String strShopName;
        private static String CellNo;

        private static int counterProducts=0;
        private static int counterPrice=0;

        private static int iSizeArray = 0;

        

        #endregion

       

        #region add to arrays
        public void setProduct(String strProduct)
        {
            productName[counterProducts] = strProduct;
            counterProducts++;
        }
        public void setPrice(double dblPrice)
        {
            price[counterPrice] = dblPrice;
            dTotal += dblPrice;
            counterPrice++;
        }

        #endregion

        #region Get values
        public String getProduct(int x)
        {
            return productName[x];
        }
        public double getPrice(int x)
        {
            return price[x];
        }

        public int size()
        {
            return iSizeArray;
        }

        public double getTotal()
        {
            #region using loops to work out total
            /*
            Double dblTotal = 0;
            for (int i = 0; i < counterProducts; i++)
            {
                dblTotal += price[i];
            }

            // Foreach example
           
            foreach (double i in price)
            {
                dblTotal += i;
            }
            */
            #endregion

            return dTotal;
        }


        #endregion

        #region set Values 

        #region Set array size
        public void setArray(int num)
        {
            productName = new String[num];
            price = new double[num];
            iSizeArray = num;
        }
        #endregion
        public string getShopName()
        { 
            return strShopName;
        }

        public  void setShopName(String strName)
        {
            strShopName = strName;
        }

        public  string getCellNumber()
        {
            return CellNo;
        }

        public  void setCellNumber(String strCellNum)
        {
            CellNo = strCellNum;
        }

        #endregion

    }
}
