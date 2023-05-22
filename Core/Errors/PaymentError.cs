namespace Core.Errors
{
    public class PaymentError : Exception
    {
        public PaymentError() : base("PAYMENT FAIL OR CANCELED")
        {
        }
    }
}
