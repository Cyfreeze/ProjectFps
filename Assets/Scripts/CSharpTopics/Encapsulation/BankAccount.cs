public class BankAccount
{

    private float balance;

    public void Deposit(float amount)
    {
        if (amount < 0)
        {
            return;
        }
        balance += amount;

    }

    public float GetBalance()
    {

        return balance;


    }

}