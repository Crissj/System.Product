using System.Product.Domain.ValueObjects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharedkernel.Core;

namespace System.Product.Domain.Models.Product
{
    internal class Product : AggregateRoot<Guid>
    {
        private StringEmptyValue name { get; set; }
        private string description { get; set; }
        private PrecioValue price { get; set; }
        private CantidadValue quantity { get; set; }
        private Guid userId { get; set; }

    }
}
