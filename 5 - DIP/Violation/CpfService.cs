namespace Samples.SOLID.DIP.Violation
{
    public class CpfService
    {
        public static bool IsValid(string Cpf) =>
            Cpf.Length == 11;
    }
}
