using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem.Shared
{
    public class UserDetails
    {
        //该类用于在Client端接收后端传输的用户信息
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public string Name { get; set; } = string.Empty; //员工姓名
        public string Sex { get; set; } = "保密"; //员工性别
        public string Phone { get; set; } = string.Empty; //员工电话
        public int JobId { get; set; }  //job外键
    }
}
