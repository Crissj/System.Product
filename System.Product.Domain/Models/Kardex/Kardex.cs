using Sharedkernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Product.Domain.ValueObjects;
using System.Text;
using System.Threading.Tasks;

namespace System.Product.Domain.Models.Kardex
{
    internal class Kardex : AggregateRoot<Guid>
    {
        private StringEmptyValue description { get; set; }
        private string codeOperation { get; set; }
        private CantidadValueConCero quantityInput { get; set; }
        private CantidadValueConCero quantityOut { get; set; }
        private PrecioValue priceUnit { get; set; }
        private DateTime date { get; set; }
        private Guid productId { get; set; }
        private Guid userId { get; set; }
    }
}
