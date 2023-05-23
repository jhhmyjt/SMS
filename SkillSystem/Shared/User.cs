using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem.Shared
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        //使用哈希对密码进行加密，用户登录时比对数据库中的哈希值与用户输入密码执行哈希算法后的值
        public byte[] PasswordHash { get; set; }=new byte[32];
        //盐（Salt）在密码学中，是指通过在密码任意固定位置插入特定的字符串，让散列后的结果和使用原始密码的散列结果不相符，这种过程称之为“加盐”。
        public byte[] PasswordSalt { get; set; } = new byte[32];
        public DateTime DateCreated { get; set; } = DateTime.Now;
        //职位、部门
        public bool isSuper { get; set; } = false; //管理员标识符
        public string Name { get; set; } = string.Empty; //员工姓名
        public string Sex { get; set; } = "保密"; //员工性别
        public string Phone { get; set; } = string.Empty; //员工电话
        public Job Job { get; set; }
        public int JobId { get; set; }  //job外键
        public List<SkillLicense> SkillLicenses { get; set; } = new List<SkillLicense>();
    }
}
