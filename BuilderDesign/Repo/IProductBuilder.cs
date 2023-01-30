namespace BuilderDesign.Repo;

public abstract class IProductBuilder
{
    protected Product _product;

    public Product Product
    {
        get { return _product; }
    }

    public abstract void GetName();
    public abstract void GetDescription();
    public abstract void GetPrice();
    public abstract void GetUnit();
    public abstract void GetSize();
}