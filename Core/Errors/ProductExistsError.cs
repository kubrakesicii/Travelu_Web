namespace Core.Errors
{
    public class ProductExistsError : Exception
    {
        public ProductExistsError() : base("PRODUCT ALREADY EXISTS")
        {

        }
    }
}
