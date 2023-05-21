using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem.Shared
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;  //课程的名称
        public string Description { get; set; }= string.Empty;  //课程的描述
        public Skill Skill { get; set; }    //课程学习的技能
        public int SkillId { get; set; }
        public SkillType SkillType { get; set; }
        public int SkillTypeId { get; set; }    //技能的等级
    }
}
