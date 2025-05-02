using ECommerce.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Core.Catalogs.Features;

public sealed class FeatureId :  StronglyTypeId<FeatureId>
{
    public FeatureId(Guid value) : base(value)
    {

    }
}

