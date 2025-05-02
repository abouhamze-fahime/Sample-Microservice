using ECommerce.Domain.Core.Base;
using ECommerce.Domain.Core.Catalogs.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Core.Catalogs.Categories;

public class CategoryFeature :Entity<Guid>
{
    public CategoryId CategoryId { get; private set; }
    public FeatureId FeatureId { get; private set; }

    internal static CategoryFeature Create (CategoryId categoryId, FeatureId featureId)
    {
        var feature = new CategoryFeature(categoryId, featureId); 
        

        return feature;
    }
    private CategoryFeature(CategoryId categoryId, FeatureId featureId)
    {
        CategoryId = categoryId;
        FeatureId = featureId;
    
    }
    private CategoryFeature()
    {
        
    }
}
