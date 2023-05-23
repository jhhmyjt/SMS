namespace SkillSystem.Server.Services.SkillService
{
    public interface ISkillService
    {
        Task<ServiceResponse<List<SkillLicense>>> GetSkillLicense(int userId);
    }
}
