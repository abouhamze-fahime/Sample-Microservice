using ECommerce.Domain.Core.Base;
using ECommerce.Domain.Core.Catalogs.Categories;
using ECommerce.Domain.Core.Catalogs.Features;
using ECommerce.Domain.Core.Catalogs.Products.Events;
using ECommerce.Domain.Core.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Core.Catalogs.Products;

public class Product: AggregateRoot<ProductId>
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public string Code { get; private set; }
    public double Price { get; private set; }
    public IReadOnlyList<ProductFeatureValue> ProductFeatureValues => _productFeatureValues;

    // readonly means that we should give value through constructor 
    private readonly List<ProductFeatureValue> _productFeatureValues= new List<ProductFeatureValue>();


    internal Product CreateNew(string title, string description, string code, double price , List<ProductFeatureValueData> productFeatures)
    {
        return new Product(title, description, code, price ,productFeatures);
    }

    private void CreateNewProductFeature(List<ProductFeatureValueData>  productFeature)
    {
        productFeature.ForEach(item =>
        {
            var newFeatureValue = ProductFeatureValue.CreateNew(Id, item.FeatureId, item.Value);
            _productFeatureValues.Add(newFeatureValue);

        });
         
    }

    private Product(string title ,string description , string code , double price, List<ProductFeatureValueData> productFeature)
    {
        if (price < 0) throw new BusinessRuleException("invalid price value");
        Title = title;
        Description= description;
        Code= code;
        Price= price;
        CreateNewProductFeature(productFeature);
        AddDomainEvent(new AddProductSendNotificationEvent(Id));
    }

    private Product() { }
}
