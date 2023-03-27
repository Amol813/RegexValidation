using RegexValidation;

internal class Program
{
    private static void Main(string[] args)
    {
        

        ValidatePinCode validatePinCode = new ValidatePinCode();
        validatePinCode.Validation("422004");
    }
}