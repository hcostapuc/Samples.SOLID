namespace Samples.SOLID.SRP.Solution
{
    public class CpfService
    {
        public static bool IsValid(string Cpf) =>
            Cpf.Length == 11;
    }
}
