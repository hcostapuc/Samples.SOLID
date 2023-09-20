namespace Samples.SOLID.DIP.Solution
{
    public class EmailService : IEmailService
    {
        public bool IsValid(string email) =>
            email.Contains("@");

        public void Send(string from, string to, string subject, string body)
        {
            //Send email
        }
    }
}
