using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem.Shared
{
    public class UserRegister
    {
        [Required(ErrorMessage ="请输入邮箱"), EmailAddress(ErrorMessage ="请输入正确的邮箱地址")]//Email字段为必须字段，且该字段符合Email格式
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage ="请输入密码"), StringLength(100,MinimumLength =6,ErrorMessage ="密码长度为6~100")]
        public string Password { get; set; }= string.Empty;
        [Compare("Password",ErrorMessage ="密码与确认密码不匹配")]
        public string ConfirmPassword { get; set; } = string.Empty;

    }
}
