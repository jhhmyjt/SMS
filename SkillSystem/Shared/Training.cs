using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem.Shared
{
    public class Training
    {
        //培训模板，管理员创建培训，员工可报名参加
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;    //培训的名称
        public string Description { get; set; } = string.Empty; //培训的描述
        public int MaxCapacity { get; set; }    //培训可容纳的最大人数
        public int RegisterNumber { get; set; } = 0; //培训报名的人数
        public string Type { get; set; } = string.Empty; //培训方式
        public int CourseId { get; set; }   //培训的课程外键
        public Course Course { get; set; }
        public DateTime StartTime { get; set; } //培训开始时间
        public DateTime EndTime { get; set; }   //培训结束时间
        public string Status { get; set; } = string.Empty;  //培训的状态（未开始，进行中，已结束）
        //以下为属性参数
        public bool Visible { get; set; } = true;   //可见
        public bool Deleted { get; set; } = false;   //未删除
        public bool Finished { get; set; } = false; //未完成
        public bool Going { get; set; } = false;  //未进行
        public bool Registering { get; set; } = false;  //未开始报名
        //以下属性不在数据库中映射，仅作为编辑状态标志
        [NotMapped]
        public bool Editing { get; set; } = false;
        [NotMapped]
        public bool IsNew { get; set; } = false;
    }
}
