using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ISkillService
    {
        void SkillAdd(Skill skill);
        void SkillDelete(Skill skill);
        void SkillUpdate(Skill skill);
        List<Skill> GetList();
        Skill GetById(int id);
    }
}
