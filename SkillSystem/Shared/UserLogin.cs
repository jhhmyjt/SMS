using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem.Shared
{
    public class UserLogin
    {
        [Required(ErrorMessage = "请输入邮箱")]
        public string Email { get; set;}=string.Empty;
        [Required(ErrorMessage = "请输入密码"), StringLength(100, MinimumLength = 6, ErrorMessage = "密码长度为6~100")]
        public string Password { get; set; } = string.Empty;
    }
}
