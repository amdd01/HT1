using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHT1
{
    enum TransactionType
    {
        Buy = 1, Sell = -1
    }
    class Program
    {
        static void Main(string[] args)
        {
            int nominal;
            double priceTrade, priceOrg, profitLoss, currentValue; 
            TransactionType transType;

            //Gather input
            Console.WriteLine("Please enter the nominal of the transaction:");
            nominal = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the trading price (decimals separated by comma):");
            priceTrade = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the original or booked price (decimals separated by comma):");
            priceOrg = double.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter the type of transaction: {TransactionType.Buy} or {TransactionType.Sell} ");
            transType = (TransactionType)Enum.Parse(typeof(TransactionType), Console.ReadLine(), true);

            //Do the calculations
            currentValue = nominal * priceTrade * ((int)transType);
            profitLoss = transType.Equals(TransactionType.Sell) ? (priceTrade - priceOrg)*nominal : 0;

            //Display results
            Console.WriteLine("The calculated current value of your transaction is {0}", currentValue);
            Console.WriteLine($"The calculated profit loss of your {transType} transaction is {profitLoss}");
            Console.ReadLine();
        }
    }
}
