namespace Samples.SOLID.OCP.Solution
{
    sealed class DebtSavingAccount : DebtAcount
    {
        public override string Debit(decimal amount, string account)
        {
            // Valid birthday account
            // debit to investment account
            return FormatTransaction();
        }
    }
}
