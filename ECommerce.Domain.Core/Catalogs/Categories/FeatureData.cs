using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Core.Catalogs.Categories;

internal sealed class FeatureData
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int SortOrder { get; set; }
}
