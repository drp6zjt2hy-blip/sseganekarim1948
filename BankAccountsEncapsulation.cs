public class BankAccount
{
    private decimal _balance;

    public decimal Balance
    {
        get { return _balance; }
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Deposit amount cannot be negative.");
        }

        _balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Withdrawal amount cannot be negative.");
        }

        if (amount > _balance)
        {
            throw new InvalidOperationException("Insufficient funds. Overdraft is not allowed.");
        }

        _balance -= amount;
    }
}
