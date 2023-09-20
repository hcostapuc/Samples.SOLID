namespace Samples.SOLID.DIP.Violation
{
    public static class EmailService
    {
        public static bool IsValid(string email) =>
            email.Contains("@");

        public static void Send(string from, string to, string subject, string body)
        {
            //Send email
        }
    }
}
