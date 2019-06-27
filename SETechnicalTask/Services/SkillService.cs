using DAL;
using SETechnicalTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SETechnicalTask.Services
{
    public class SkillService
    {
        private readonly EmpContext _db;
        public SkillService(EmpContext db)
        {
            _db = db;
        }
        public Skill Get(string name)
        {
            return _db.Skills.Where(a => a.Name == name).FirstOrDefault();
        }
    }
}
