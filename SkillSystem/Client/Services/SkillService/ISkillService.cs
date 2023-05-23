namespace SkillSystem.Client.Services.SkillService
{
    public interface ISkillService
    {
        List<SkillLicense> SkillLicenses { get; set; }
        Task GetSkillLicense();
    }
}
