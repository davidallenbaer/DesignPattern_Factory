using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Factory
{
    public class CreditCardFactory
    {
        /*
         ---Problems of Simple Factory Pattern in C#---

         1)If we need to add any new product(i.e. new credit card) 
           then we need to add a new if else condition
           in the GetCreditCard method of the CreditCardFactory class.
           This violates the open/closed design principle of SOLID.

         2)We also have a tight coupling between the Factory(CreditCardFactory) class 
           and product classes(MoneyBack, Titanium, and Platinum).
        */
        public static ICreditCard GetCreditCard(string cardType)
        {
            ICreditCard cardDetails = null;
            if (cardType == "MoneyBack")
            {
                cardDetails = new MoneyBack();
            }
            else if (cardType == "Titanium")
            {
                cardDetails = new Titanium();
            }
            else if (cardType == "Platinum")
            {
                cardDetails = new Platinum();
            }
            return cardDetails;
        }
    }
}