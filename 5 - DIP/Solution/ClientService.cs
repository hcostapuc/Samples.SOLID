using Samples.SOLID.DIP.Solution.Interfaces;

namespace Samples.SOLID.DIP.Solution
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IEmailService _emailService;
        public ClientService(IClientRepository clientRepository,
                            IEmailService emailService)
        {
            _clientRepository = clientRepository ?? throw new ArgumentNullException(nameof(clientRepository));
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
        }
        public string AddClient(Client client)
        {
            if (!client.IsValid())
                return "Invalid Client";

            _clientRepository.AddClient(client);

            _emailService.Send("example@company.com", client.Email, "Welcome", "Registration is completed");
            return "Successfully registered";
        }
    }
}
