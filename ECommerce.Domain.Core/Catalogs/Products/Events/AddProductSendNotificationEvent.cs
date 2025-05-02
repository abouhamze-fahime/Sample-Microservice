using ECommerce.Domain.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Core.Catalogs.Products.Events;

internal record class AddProductSendNotificationEvent : DomainEvent
{
    public ProductId ProductId { get; init; }

    public AddProductSendNotificationEvent(ProductId productId)
    {
        ProductId = productId;
        AggregateId = productId.Value;
    }
}
