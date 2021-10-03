using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchanger.DataAccess.Entitites
{
    public class Course
    {
        public int Id { get; set; }
        public DateTime DataCourse { get; set;  }
        public Decimal FormSell { get; set; }
        public Decimal FormBuy { get; set; }
        public ICollection<Currency> Currency { get; set; }
        public Course()
        {
            Currency = new List<Currency>();
        }

    }
}
