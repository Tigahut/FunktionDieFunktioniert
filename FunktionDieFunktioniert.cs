using System;
using System.Dynamic;
//TTTimo
namespace FSC
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        private static string FSC(string searched, string sword)
        {
            int LwLenght = sword.Length;
            int LeCounter = 0;
            int Lwcount = 0;
            string returnValue = searched + " kommt an den Stellen: ";
            while(LeCounter != LwLenght)
            {
                if(searched == Convert.ToString(sword[LeCounter]))
                {
                    returnValue += Convert.ToString(LeCounter) + " ,";
                    Lwcount++;
                }
                LeCounter++;
            }
            returnValue = returnValue.TrimEnd(',');
            returnValue += "vor. Das ist " + Lwcount + " mal!";
            return returnValue;
        }
    }
}
