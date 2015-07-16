
using System.Collections.Generic;
namespace Homework_Defining_Classes___Part_1
{
    public class GSMTest
    {
        public static void CreateGSMs(int num)
        {
            List<GSM> gsms = new List<GSM>();
            for (int i = 0; i < num; i++)
            {
                gsms.Add(new GSM("Phone"+i, "Any manufacturer"));
            }
            foreach (var gsm in gsms)
            {
                System.Console.WriteLine("Model : "+gsm.Model);
                System.Console.WriteLine("Manufacturer : "+gsm.Manufacturer);
                System.Console.WriteLine("Price : "+gsm.Price);
                
                System.Console.WriteLine();
            }
            System.Console.WriteLine(GSM.IPhone4SInfo);

        }


         

    }
}
