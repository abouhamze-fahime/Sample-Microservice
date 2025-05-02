using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Core.Base;

public abstract class StronglyTypeId<T> : ValueObject<StronglyTypeId<T>>
{
    private Guid _id;
    public Guid Value
    {
        get { return _id; }
        private set
        {
            if (value == Guid.Empty)
                throw new BusinessRuleException("A valid id must be provided.");
            _id = value;
        }
    }

    protected StronglyTypeId(Guid value)
    {
        Value = value;
    }

    protected override bool EqualsCore(StronglyTypeId<T> other)
    {
        return Value == other.Value;
    }

    protected override int GetHashCodeCore()
    {
        unchecked
        {
            return Value.GetHashCode();
        }
    }

}
