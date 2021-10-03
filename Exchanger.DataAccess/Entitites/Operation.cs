using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchanger.DataAccess.Entitites
{
    public class Operation
    {
        public int Id { get; set; }
        public decimal Suma { get; set; }
        public TypeOperation  TypeOperations { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<Client> Clients { get; set; }
        public ICollection<Operator> Operators { get; set; }
        public Operation()
        {
            Courses = new List<Course>();
            Clients = new List<Client>();
            Operators = new List<Operator>();
        }
    }
    public enum TypeOperation
    {
        Sell, Buy
    }
}
