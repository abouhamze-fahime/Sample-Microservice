using ECommerce.Infrastructure.Database.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Patterns;

public class UnitOfWork : IUnitOfWork
{
    private readonly ECommerceContext context;

    public UnitOfWork(ECommerceContext context)
    {
        this.context = context;
    }


    public async Task SaveChanges()
    {
        await context.SaveChangesAsync();
    }
}
