namespace Samples.SOLID.OCP.Violation
{
    public class DebtAcount
    {
        public void Debit(decimal amount, string account, AccountType accountType)
        {
            if (accountType == AccountType.Current)
            {
                // debit to current account
            }
            if (accountType == AccountType.Savings)
            {
                // Valid birthday account
                // debit to investment account
            }
        }
    }
}
