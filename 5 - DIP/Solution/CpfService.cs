namespace Samples.SOLID.DIP.Solution
{
    public class CpfService : ICpfService
    {
        public bool IsValid(string Cpf) =>
            Cpf.Length == 11;
    }
}
