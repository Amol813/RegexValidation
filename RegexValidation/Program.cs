using RegexValidation;

internal class Program
{
    private static void Main(string[] args)
    {
        

        ValidatePinCode validatePinCode = new ValidatePinCode();
        validatePinCode.Validate("422 004",ValidatePinCode.PIN_CODE); //uc1,uc2

        validatePinCode.ValidateEmailOption("abc123@gmail.co.in");


    }
}