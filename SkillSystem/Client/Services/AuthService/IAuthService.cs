﻿namespace SkillSystem.Client.Services.AuthService
{
    public interface IAuthService
    {
        UserDetails UserDetails { get; set; }
        Task GetUserDetails();
        Task<ServiceResponse<int>> Register(UserRegister request);
        Task<ServiceResponse<string>> Login(UserLogin request);
        Task<ServiceResponse<bool>> ChangePassword(UserChangePassword request);
        Task<ServiceResponse<bool>> ChangeInfo(UserInfo request);
    }
}
