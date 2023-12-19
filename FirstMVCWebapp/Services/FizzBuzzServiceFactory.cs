namespace FirstMVCWebapp.Services
{
    public class FizzBuzzServiceFactory
    {

        public static IFizzBuzzService CreateFizzBuzzService()
        {
            return new FizzBuzzService();
        }
    }
}
