namespace SkillSystem.Server.Services.SkillService
{
    public class SkillService : ISkillService
    {
        private readonly DataContext _context;
        public SkillService(DataContext dataContext)
        {
            _context = dataContext;
        }
        public async Task<ServiceResponse<List<SkillLicense>>> GetSkillLicense(int userId)
        {
            var response=new ServiceResponse<List<SkillLicense>>(); 
            var skillLicense = await _context.SkillLicenses
                .Include(s=>s.SkillType)
                .Include(s=>s.Skill)
                .Where(s=>s.UserId==userId)
                .ToListAsync();
            if (skillLicense == null) { 
                response.Success = false;
                response.Message = "没有任何证书";
            }
            else
            {
                response.Data = skillLicense;
            }
            return response;
        }
    }
}
