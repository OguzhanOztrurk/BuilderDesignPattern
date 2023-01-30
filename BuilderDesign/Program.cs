using BuilderDesign.Repo;
using Newtonsoft.Json;

var product = new Product()
{
    Name = "Shoes",
    Description = "Comfortable shoes",
    SalesPrice = new decimal(340),
    Size = "43",
    Unit = 234
};
var product2 = new Product()
{
    Name = "Shirt",
    Description = "Long sleeve shirt",
    SalesPrice = new decimal(65),
    Size = "L",
    Unit = 421
};


IProductBuilder productBuilder = new DressConcreteBuilder(product);
IProductBuilder productBuilder2 = new DressConcreteBuilder(product2);
ProductResponse response = new ProductResponse();
response.Response(productBuilder);
response.Response(productBuilder2);

Console.WriteLine(JsonConvert.SerializeObject(productBuilder.Product));
Console.WriteLine(JsonConvert.SerializeObject(productBuilder.Product));