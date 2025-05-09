using ECommerce.Domain.Core.Base;
using ECommerce.Domain.Core.Catalogs.Features;

namespace ECommerce.Domain.Core.Catalogs.Categories;

public class Category:AggregateRoot<CategoryId>
{
    public string CategoryName { get; private set; }
    public bool IsActive { get; private set; }

    public string Description { get; private set; }

    public IReadOnlyList<CategoryFeature> CategoryFeatures => _categoryFeatures;

    private readonly List<CategoryFeature> _categoryFeatures = new List<CategoryFeature>();

    internal static Category Create (string categoryName, bool isActive, string description , List<FeatureId> features)
    {
      var category =  new Category(categoryName, isActive, description , features);
      return category;
    }

    private void CreateCategoryFeature(List<FeatureId> features)
    {
        features.ForEach(featureId  =>
        {
            var newFeature = CategoryFeature.Create(Id , featureId);
            _categoryFeatures.Add(newFeature);

        });
    }

    private Category(string categoryName , bool isActive , string description, List<FeatureId> features) 
    {
        CategoryName = categoryName;
        IsActive = isActive;
        Description = description;
        CreateCategoryFeature(features);
    }
    public Category()
    {
        
    }

}


