using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SkillSystem.Shared
{
    public class SkillVariant
    {
        [JsonIgnore]
        public Skill? Skill { get; set; }
        public int SkillId { get; set; }
        public SkillType? SkillType { get; set; }
        public int SkillTypeId { get; set; }
        public string Difficulty { get; set; } = string.Empty;  //技能的难易程度
    }
}
