using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SkillSystem.Shared
{
    public class SkillLicense
    {
        //员工的技能执照，使用员工id和技能id作为复合主键
        public Skill? Skill { get; set; }
        public int SkillId { get; set; }
        [JsonIgnore] 
        public User? User { get; set; }
        public int UserId { get; set; }
        public SkillType? SkillType { get; set; }
        public int SkillTypeId { get; set; }
        public DateTime GetTime { get; set; } = DateTime.Now;   //获取时间
    }
}
