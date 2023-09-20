namespace Samples.SOLID.OCP.Solution
{
    sealed class DebtCurrentAccount : DebtAcount
    {
        public override string Debit(decimal amount, string account)
        {
            // debit to current account
            return FormatTransaction();
        }
    }
}
