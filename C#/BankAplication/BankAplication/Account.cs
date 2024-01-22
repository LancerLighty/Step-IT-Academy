using Event;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

//delegate void AccountStateHandler(string text);
delegate void AccountStateHandler(object sender, AccountEventArgs e);
class Account
{
    //AccountStateHandler accountStateHandler;

    public event AccountStateHandler Filled;
    public event AccountStateHandler Withdrawed;

    //public void SetAccountStateHandler(AccountStateHandler _accountStateHandler)
    //{
    //    accountStateHandler += _accountStateHandler;
    //}
    //public void UnsetAccountStateHandler(AccountStateHandler _accountStateHandler)
    //{
    //    accountStateHandler -= _accountStateHandler;
    //}
    public decimal Balance { set; get; }
    public Account(decimal balance)
    {
        Balance = balance;
    }
    public void FillBalance(decimal balance)
    {
        Balance += balance;
        //accountStateHandler?.Invoke($"{balance}GEL added to your account. Your Current Balance is {Balance}");
        Filled?.Invoke(this, new AccountEventArgs($"{balance}GEL added to your account. Your Current Balance is {Balance}", balance));
    }
    public void Withdraw(decimal balance)
    {
        if (Balance >= balance)
        {
            Balance -= balance;
            //accountStateHandler?.Invoke($"{balance}GEL Withdrawed from your account. Your Current Balance is {Balance}");
            Withdrawed?.Invoke(this, new AccountEventArgs($"{balance}GEL Withdrawed from your account. Your Current Balance is {Balance}", balance));
        }
        else
        {
            //accountStateHandler?.Invoke($"Not enough balance. Your Current Balance is {Balance}");
            Withdrawed?.Invoke(this, new AccountEventArgs($"Not enough balance. Your Current Balance is {Balance}", balance));
        }
    }
}
namespace Event
{
    class AccountEventArgs
    {
        public string Message { get; }
        public decimal Balance { get; }
        public AccountEventArgs(string message, decimal balance)
        {
            Message = message;
            Balance = balance;
        }
    }
}
