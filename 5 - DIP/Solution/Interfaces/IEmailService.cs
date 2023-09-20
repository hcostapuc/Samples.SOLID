namespace Samples.SOLID.DIP.Solution
{
    public interface IEmailService
    {
        public bool IsValid(string email);

        public void Send(string from, string to, string subject, string body);
    }
}
