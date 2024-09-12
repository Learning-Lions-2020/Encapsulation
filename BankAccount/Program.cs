using EncapsulationDemo;

try
{
    var account = new BankAccount("Jerry Lokoroi", -10000);
    Console.WriteLine($"Account Holder: {account.AccountHolder}");
    Console.WriteLine($"Initial Balance: {account.Balance}");
}
catch (ArgumentException ex)
{

	Console.WriteLine(ex.Message );

}

catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}





/*account.Deposit(5000);
Console.WriteLine($"New Account Balance: {account.Balance}");

account.Withdraw(10000);
Console.WriteLine($"New Account Balance: {account.Balance}");*/

/*account.Balance = 100000;
account.AccountHolder = "Bonny";*/

