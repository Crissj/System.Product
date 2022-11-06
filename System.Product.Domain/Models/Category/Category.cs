using Sharedkernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Product.Domain.ValueObjects;
using System.Text;
using System.Threading.Tasks;

namespace System.Product.Domain.Models.Category
{
    internal class Category : AggregateRoot<Guid>
    {
        private StringEmptyValue name { get; set; }

    }
}
