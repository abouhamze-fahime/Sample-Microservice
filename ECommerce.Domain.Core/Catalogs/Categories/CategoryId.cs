using ECommerce.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Core.Catalogs.Categories;

public sealed class CategoryId :StronglyTypeId<CategoryId>
{
    public CategoryId(Guid value) :base(value) { }
 
}
