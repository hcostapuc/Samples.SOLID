namespace Samples.SOLID.DIP.Violation
{
    public class ClientService
    {
        public string AddClient(Client client)
        {
            if (!client.IsValid())
                return "Invalid Client";

            var clientRepository = new ClientRepository();
            clientRepository.AddClient(client);

            EmailService.Send("example@company.com", client.Email, "Welcome", "Registration is completed");
            return "Successfully registered";
        }
    }
}
