namespace Samples.SOLID._1___SRP.Violation
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public string AddClient()
        {
            if (!Email.Contains("@"))
                return "Invalid Email";

            if (Cpf.Length != 11)
                return "Cpf Invalid";


            //Insert client

            //Send email

            return "Successfully registered!";
        }
    }
}
