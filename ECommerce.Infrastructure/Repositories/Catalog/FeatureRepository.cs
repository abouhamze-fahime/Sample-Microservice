using ECommerce.Domain.Core.Catalogs.Features;
using ECommerce.Infrastructure.Base;
using ECommerce.Infrastructure.Database.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Repositories.Catalog;

public class FeatureRepository : IFeatureRepository
{

    private readonly ECommerceContext context;

    public FeatureRepository(ECommerceContext context)
    {
        this.context = context;
    }



    public async Task<Feature> GetById(FeatureId featureId)
    {
        return await context.Features.FindAsync(featureId);
    }

    public async Task<FeatureId> Insert(Feature feature)
    {

       await context.Features.AddAsync(feature);
        return feature.Id;
    }

    public async Task Update(Feature feature)
    {
        var currentFeature = await context.Features.FindAsync(feature.Id);

        if (currentFeature == null) throw new DatabaseException("feature Id in not valid");
        currentFeature.Update(feature);

    }


    public void Delete(FeatureId featureId)
    {
        //1 => get feature from db with featureId
        //====> remove from dbContext
        //======>SaveChanges

        //2 => create newFeature with featureId
        //====> remove from dbContext
        //======>SaveChanges
        var feature = Feature.CreateNewForDelete(featureId);
        context.Remove(feature);
        //call save changes from UnitOfWork
    }
}