namespace Samples.SOLID.ISP.Violation
{
    internal class ProductRegistration : IRegister
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
            //Product doesn't have email
            throw new NotImplementedException("This method don't serve to product");
        }
    }
}
