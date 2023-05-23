using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillSystem.Shared
{
    public class UserInfo
    {
        //该类用于用户在Client端接收用户输入的修改信息
        [Required(ErrorMessage = "请输入姓名"), StringLength(8, MinimumLength = 2, ErrorMessage = "长度为2~8")]
        public string Name { get; set; }
        [Required(ErrorMessage = "请输入电话"), StringLength(11, MinimumLength = 11, ErrorMessage = "电话长度为11位")]
        public string Phone { get; set; }
    }
}
