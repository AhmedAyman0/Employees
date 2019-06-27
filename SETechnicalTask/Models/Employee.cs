using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SETechnicalTask.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
