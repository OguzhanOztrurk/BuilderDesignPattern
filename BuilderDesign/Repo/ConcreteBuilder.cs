namespace BuilderDesign.Repo;

public class DressConcreteBuilder: IProductBuilder
{

    private Product _requestProduct;
    public DressConcreteBuilder(Product product)
    {
        _product = new Product();
        _requestProduct = product;
    }

    public override void GetName() => _product.Name = _requestProduct.Name;
    public override void GetDescription() => _product.Description = _requestProduct.Description;
    public override void GetPrice() => _product.SalesPrice = _requestProduct.SalesPrice;
    public override void GetUnit() => _product.Size = _requestProduct.Size;
    public override void GetSize() => _product.Unit = _requestProduct.Unit;
}