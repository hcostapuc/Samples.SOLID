namespace Samples.SOLID.OCP.Solution
{
    sealed class DebtInvestmentAccount : DebtAcount
    {
        public override string Debit(decimal amount, string account)
        {
            // debit to investment account
            // exempt fee
            return FormatTransaction();
        }
    }
}
