namespace Samples.SOLID.ISP.Solution
{
    internal interface ICustumerRegistration
    {
        public void ValidateData();
        public void Save();
        public void SendEmail();
    }
}
