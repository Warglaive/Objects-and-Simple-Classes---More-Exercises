using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.Optimized_Banking_System
{
    public class BankAccount
    {
        public string Account { get; set; }
        public string Bank { get; set; }
        public decimal Balance { get; set; }
    }
   public class Program
    {
       public static void Main()
        {
            var listOfBanksAccName = new List<BankAccount>();
            var input = Console.ReadLine();
            while (input != "end") 
            {
                var token = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

                var bank = token[0];
                var account = token[1];
                var balance = decimal.Parse(token[2]);

                var newBankAccount = new BankAccount();
                newBankAccount.Bank = bank;
                newBankAccount.Account = account;
                newBankAccount.Balance = balance;

                listOfBanksAccName.Add(newBankAccount);
                input = Console.ReadLine();
            }
            var format = listOfBanksAccName
                .OrderByDescending(x => x.Balance)
                .ThenBy(x => x.Bank.Length)
                .ToList();
            foreach (var item in format)
            {
                Console.WriteLine($"{item.Account} -> {item.Balance} ({item.Bank})");
            }
        }
    }
}