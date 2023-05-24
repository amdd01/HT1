using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHT1
{
    enum TransactionType
    {
        Buy=1, Sell=-1
    }
    class Program
    {
        static void Main(string[] args)
        {
            int nominal;
            float price, curVal;
            TransactionType transType;

            Console.WriteLine("Please enter the nominal of the transaction:");
            nominal = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the trading price (decimals separated by comma):");
            price = float.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter the type of transaction: {TransactionType.Buy} or {TransactionType.Sell} ");
            transType= (TransactionType)Enum.Parse(typeof(TransactionType), Console.ReadLine(), true);

            curVal = nominal * price * ((int)transType);
        
            Console.WriteLine("The calculated current value of your transaction is {0}", curVal);
            Console.ReadLine();
        }
    }
}
