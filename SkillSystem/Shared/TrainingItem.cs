using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem.Shared
{
    public class TrainingItem
    {
        //员工报名培训后生成的培训项目
        public int Id { get; set; }
        public int UserId { get; set; } //培训员工外键，该培训项目的所有者
        public User User { get; set; }
        [Column(TypeName = "decimal(5,1)")]
        public decimal Score { get; set; } = 0;
        public DateTime RegisterTime { get; set; } = DateTime.Now;  //报名的时间
        public int TrainingId { get; set; } //培训模板
        public Training Training { get; set; }
        public bool isFinished { get; set; } = false;
        public bool isPass { get; set; } = false;
    }
}
