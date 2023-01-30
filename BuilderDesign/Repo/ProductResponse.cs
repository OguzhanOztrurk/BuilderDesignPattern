namespace BuilderDesign.Repo;

public class ProductResponse
{
    public void Response(IProductBuilder product)
    {
        product.GetName();
        product.GetDescription();
        product.GetPrice();
        product.GetSize();
        product.GetUnit();
    }
}