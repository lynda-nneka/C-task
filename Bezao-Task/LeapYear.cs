using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LeapYear
{ 
  public class LeapYearGenerator
      {
              public void GetLeapYear()
          
            
          {
             for (var i = 2020; i <= 2100; ++i)
            {
               
                bool isLeapYear = true;

                if ((i % 4 == 0) && (i % 100 != 0 || (i % 400 == 0)))
                
                 if (isLeapYear)
                {
                    Console.Write(i + ",");
                }
                else
                {
                    Console.Write("is not a leap year");
                }
              }
            Console.ReadLine();
          }
        }
    
}
//To run any of the codes in Program.cs, comment the other one 



