namespace Samples.SOLID.DIP.Solution
{
    public class Client
    {
        private readonly ICpfService _cpfService;
        private readonly IEmailService _emailService;
        public Client(ICpfService cpfService,
                            IEmailService emailService)
        {
            _cpfService = cpfService ?? throw new ArgumentNullException(nameof(cpfService));
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime RegistrationDate { get; set; }

        public bool IsValid() =>
            _emailService.IsValid(Email) && _cpfService.IsValid(Cpf);
    }
}
