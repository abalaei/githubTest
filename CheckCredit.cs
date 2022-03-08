using System;
using static System.Console;
class CheckCredit
{
   static void Main()
   {
      double price;
      const double LIMIT = 8000;
      Write("Enter price >> ");
      price = Convert.ToDouble(ReadLine());
      if(price > LIMIT)
         WriteLine("You have exceeded the credit limit of ${0}", LIMIT);
       else
          WriteLine("Approved now 143");
   }
}
