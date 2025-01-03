using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concerete
{
    public class Price:IEntity
    {
        public int PriceId { get; set; }
        public string PriceType  { get; set; }
        public decimal PriceValue { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
