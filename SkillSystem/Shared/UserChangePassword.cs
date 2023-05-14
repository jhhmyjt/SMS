using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem.Shared
{
    public class UserChangePassword
    {
        [Required(ErrorMessage = "请输入密码"), StringLength(100, MinimumLength = 6, ErrorMessage = "密码长度为6~100")]
        public string Password { get; set; }=string.Empty;
        [Compare("Password", ErrorMessage = "密码与确认密码不匹配")]
        public string ConfirmPassword { get; set; }= string.Empty;
    }
}
