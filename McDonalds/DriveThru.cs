using System;
using System.Collections.Generic;
using System.Text;

namespace McDonalds
{
    class DriveThru
    {
        private float Number1 = 5f;
        private float Number2 = 3f;
        private float HotNSpicy = 1.09f;
        public float Tenpiece = 7.50f;

        /*  Order

            1. First, check what the menu number was input by the customer
            2. Second, return the price of the menu number that the customer chose
            3. Third, add the price menu number to my total cost
            4. Last, give the customer the  total price for everything he ordered

        */

        
        public float Order(char menuNumber)

        {
            if (menuNumber == '1')
            {
                return Number1;
            }
            if (menuNumber == '2')
            {
                return Number2;
            }
            if (menuNumber == '3')
            {
                return HotNSpicy;
            }
            if (menuNumber == '4')
            {
                return Tenpiece;
            }
            

         
                

            
            return 0; //change this later
        }

        

            



        

        public bool IceCreamMachineBroke()
        {
            return true;


        }
         private string ChickenWings()
        {
            string FlavorHotBBQ = "Hot BBQ";
            return FlavorHotBBQ;
        }
















            

    }
}
