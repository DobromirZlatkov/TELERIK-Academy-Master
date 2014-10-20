using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePfone
{
    class GSMCallHistoryTest
    {
       public static void Main()
       {
           //task 12
           GSM ifon = new GSM("GALAXY S4","SAMSUNG", null);
           ifon.AddCall(new Call(DateTime.Now, "0888-88-88-88", 100));
           ifon.AddCall(new Call(DateTime.Now, "0888-99-99-99", 900));
           ifon.AddCall(new Call(DateTime.Now, "0888-91-91-91", 800));

           foreach (var item in ifon.GetCallHistory())
           {
               Console.WriteLine(item.ToString());
               
           }
           Console.WriteLine("Price of the calls");
           Console.WriteLine(ifon.PriceOfTheCalls(0.37m));

           ifon.DeleteCall(1);

           Console.WriteLine("Price of the calls after delete longest conversation");
           Console.WriteLine(ifon.PriceOfTheCalls(0.37m));


           Console.WriteLine("Call list after clearing");
           ifon.ClearAllCalls();
           
           foreach (var item in ifon.GetCallHistory())
           {
               Console.WriteLine(item.ToString());
           }
           
       }                
    }
}
