namespace Samples.SOLID.ISP.Violation
{
    internal interface IRegister
    {
        public void ValidateData();
        public void Save();
        public void SendEmail();
    }
}
