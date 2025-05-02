using ECommerce.Domain.Core.Catalogs.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Core.Shared;

internal sealed class ProductFeatureValueData
{
    public FeatureId FeatureId { get; init; }
    public string Value { get; init; }

    public ProductFeatureValueData(FeatureId featureId, string value)
    {
        Value = value;
        FeatureId = featureId;
    }
}
