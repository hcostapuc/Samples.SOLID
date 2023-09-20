namespace Samples.SOLID.SRP.Solution
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime RegistrationDate { get; set; }

        public bool IsValid() =>
            EmailService.IsValid(Email) && CpfService.IsValid(Cpf);
    }
}
