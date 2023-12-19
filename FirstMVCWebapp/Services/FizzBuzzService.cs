namespace FirstMVCWebapp.Services
{
     
    public class FizzBuzzService : IFizzBuzzService
    {
        
        public string GetResult(string number)
        {
            if (int.TryParse(number, out int intValue))
            {
                if (intValue % 3 == 0 && intValue % 5 == 0)
                    return FizzBuzzmodel.Fizz_buzz;
                else if (intValue % 3 == 0)
                    return FizzBuzzmodel.fizz_;
                else if (intValue % 5 == 0)
                    return FizzBuzzmodel.buzz_;
                else
                    return string.Format(FizzBuzzmodel.Dividebynum, intValue);
            }
            else
            {
                return FizzBuzzmodel.InvalItem;
              
            }

        }

    }
}
