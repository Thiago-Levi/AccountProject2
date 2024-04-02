
using System.Globalization;
using AccountProject;

try
{
  Console.WriteLine("Enter account data");
  Console.Write("Number: ");
  int number = Convert.ToInt32(Console.ReadLine());

  Console.Write("Holder: ");
  string holder = Console.ReadLine();

  Console.Write("Inicial balance: ");
  double balance = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

  Console.Write("WithdrawLimit: ");
  double withdrawLimit = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

  Account account = new Account(number, holder, balance, withdrawLimit);

  System.Console.Write("Enter amount for withdraw: ");
  double amount = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
  account.Withdraw(amount);

  System.Console.WriteLine();
  System.Console.WriteLine($"New balance:{account.Balance:C}");
}
catch (DomainExceptions error)
{
  System.Console.WriteLine($"Personal error --> {error.Message}");

}


