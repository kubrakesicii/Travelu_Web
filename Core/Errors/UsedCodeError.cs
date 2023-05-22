namespace Core.Errors
{
    public class UsedCodeError : Exception
    {
        public UsedCodeError() : base("CODE ALREADY USED")
        {

        }
    }
}
