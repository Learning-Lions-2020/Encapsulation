namespace EncapsulationDemo;

public class BankAccount
{
    //private field - not accessible outside theclass
    private decimal _balance;

    public string AccountHolder { get; private set; }

    public decimal Balance
    {
        get { return _balance; }
        private set {   
            if (value < 0 )
            {
                throw new ArgumentException($"Initial balance cannot be negative. Your current balance is: {Balance}");
            }

            _balance = value; }
    }

    /// <summary>
    /// Constructor for the BankAccount class
    /// </summary>
    /// <param name="accountHolder"></param>
    /// <param name="initialBalance"></param>
    public BankAccount(string accountHolder, decimal initialBalance)
    {
        
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    /// <summary>
    /// Method for Deposit function
    /// </summary>
    /// <param name="amount"></param>
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
        Console.WriteLine($"Succesfully deposited {amount}");
    }

    /// <summary>
    /// Method for Withdwal function
    /// </summary>
    /// <param name="amount"></param>
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
        }
        Console.WriteLine($"Succesfully withdrawn {amount}");

    }

    protected void ResetBalance()
    {
        _balance = 0;
    }

}

