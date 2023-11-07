using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMap
{
    public abstract class aSkill
    {
        public string SkillName { get; set; }
        public decimal Damage { get; set; }
        public int Duration;
        public eSkillType SkillType;


    }
}
