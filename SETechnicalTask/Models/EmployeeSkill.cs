using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SETechnicalTask.Models
{
    public class EmployeeSkill
    {
        public int EmpId { get; set; }
        public int SkillId { get; set; }
        public Employee Employee { get; set; }

        public Skill Skill { get; set; }
    }
}
