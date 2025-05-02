using ECommerce.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Core.Catalogs.Products;

public sealed class ProductId : StronglyTypeId<ProductId>
{
    public ProductId(Guid value):base(value)
    {
        
    }
}
