using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car :IEntity
    {
        public int BranId { get; set; }
        public string BrandName { get; set; }
    }
}
