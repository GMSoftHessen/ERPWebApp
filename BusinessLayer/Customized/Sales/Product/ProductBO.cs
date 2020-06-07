

namespace BusinessLayer.Customize
{
    public class ProductBO
    {
        ProductRepository _ProductRepository;
        
        public ProductBO(ProductRepository ProductRepository) 
        {
            _ProductRepository = ProductRepository;
        }
    }
}