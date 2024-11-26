using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.core.Entities
{
    public class ProductType : BaseEntity<int>
    {
        //public int Id { get; set; }
        public string Name { get; set; }
    }
}
