namespace Samples.SOLID.ISP.Violation
{
    internal class CustumerRegistration : IRegister
    {
        public void ValidateData()
        {
            //validate data
        }
        public void Save()
        {
            //Insert data
        }

        public void SendEmail()
        {
            //Send email to client
        }
    }
}
