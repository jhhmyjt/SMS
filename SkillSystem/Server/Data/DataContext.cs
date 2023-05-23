using System.Security.Cryptography;

namespace SkillSystem.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //为没有主键的SkillVariant模型创建复合主键
            modelBuilder.Entity<SkillVariant>().HasKey(s => new { s.SkillTypeId, s.SkillId });
            modelBuilder.Entity<SkillLicense>().HasKey(s => new { s.UserId, s.SkillId });
            //填充SkillType数据
            modelBuilder.Entity<SkillType>().HasData(
                new SkillType { Id = 1, Name = "一级" },
                new SkillType { Id = 2, Name = "二级" },
                new SkillType { Id = 3, Name = "三级" },
                new SkillType { Id = 4, Name = "四级" }
                );
            //填充Skill数据
            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Name = "计算机", Description = "计算机操作能力" },
                new Skill { Id = 2, Name = "英语", Description = "英语交流能力" },
                new Skill { Id = 3, Name = "普通话", Description = "普通话交流能力" },
                new Skill { Id = 4, Name = "Office", Description = "办公软件能力" }
                );
            //填充SkillVariant数据
            modelBuilder.Entity<SkillVariant>().HasData(
                new SkillVariant { SkillId = 1, SkillTypeId = 2, Difficulty = "简单" },
                new SkillVariant { SkillId = 2, SkillTypeId = 4, Difficulty = "中等" },
                new SkillVariant { SkillId = 3, SkillTypeId = 2, Difficulty = "简单" },
                new SkillVariant { SkillId = 3, SkillTypeId = 4, Difficulty = "简单" },
                new SkillVariant { SkillId = 4, SkillTypeId = 2, Difficulty = "简单" },
                new SkillVariant { SkillId = 4, SkillTypeId = 4, Difficulty = "中等" }
                );
            modelBuilder.Entity<SkillLicense>().HasData(
                new SkillLicense { SkillId = 2, UserId = 9, SkillTypeId = 4 },
                new SkillLicense { SkillId = 3, UserId = 9, SkillTypeId = 4 }
                );
            //填充Course课程数据
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "英语四级培训课", Description = "提高英语能力，通过英语四级", SkillId = 2, SkillTypeId = 4 },
                new Course { Id = 2, Name = "计算机四级培训课", Description = "提高计算机能力，通过计算机四级", SkillId = 1, SkillTypeId = 4 },
                new Course { Id = 3, Name = "Office二级培训课", Description = "提高Office能力，通过Office二级", SkillId = 4, SkillTypeId = 2 }
                );
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "人事管理部", Description = "负责人事管理相关工作" },
                new Department { Id = 2, Name = "开发部", Description = "负责产品开发相关工作" },
                new Department { Id = 3, Name = "联络部", Description = "负责人员联络工作" }
                );
            modelBuilder.Entity<Job>().HasData(
                new Job { Id = 1, Name = "部门主管", Description = "人事管理部主管", DepartmentId = 1 },
                new Job { Id = 2, Name = "部门主管", Description = "开发部主管", DepartmentId = 2 },
                new Job { Id = 3, Name = "部门主管", Description = "联络部主管", DepartmentId = 3 },
                new Job { Id = 4, Name = "普通员工", Description = "人事管理部普通员工", DepartmentId = 1 },
                new Job { Id = 5, Name = "普通员工", Description = "人事管理部普通员工", DepartmentId = 1 },
                new Job { Id = 6, Name = "普通员工", Description = "开发部普通员工", DepartmentId = 2 },
                new Job { Id = 7, Name = "普通员工", Description = "开发部普通员工", DepartmentId = 2 },
                new Job { Id = 8, Name = "普通员工", Description = "联络部普通员工", DepartmentId = 3 },
                new Job { Id = 9, Name = "普通员工", Description = "联络部普通员工", DepartmentId = 3 }
                );
            //填充Training数据
            modelBuilder.Entity<Training>().HasData(
                new Training
                {
                    Id = 1,
                    Name = "第一年度春季英语培训",
                    Description = "第一年度春季英语培训",
                    MaxCapacity = 50,
                    Type = "线下",
                    CourseId = 1,
                    StartTime = DateTime.Now.AddDays(7),
                    EndTime = DateTime.Now.AddDays(37),
                    Status = "未开始"
                },
                new Training
                {
                    Id = 2,
                    Name = "第一年度秋季计算机培训",
                    Description = "第一年度秋季计算机培训",
                    MaxCapacity = 10,
                    Type = "线上",
                    CourseId = 2,
                    StartTime = DateTime.Now.AddMonths(3),
                    EndTime = DateTime.Now.AddMonths(6),
                    Status = "未开始"
                },
                new Training
                {
                    Id = 3,
                    Name = "第一年度夏季Office培训",
                    Description = "第一年度夏季Office培训",
                    MaxCapacity = 30,
                    Type = "线上",
                    CourseId = 3,
                    StartTime = DateTime.Now.AddMonths(2),
                    EndTime = DateTime.Now.AddMonths(5),
                    Status = "未开始"
                }
                );
            //创建初始员工账号
            //预先生成密码
            CreatePasswordHash("123456", out byte[] passwordHash1, out byte[] passwordSalt1);
            CreatePasswordHash("admin123", out byte[] passwordHash5, out byte[] passwordSalt5);
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "董磊",
                    Sex = "男",
                    Phone = "12355556666",
                    Email = "duyou@example.com",
                    DateCreated = DateTime.Now,
                    PasswordHash = passwordHash1,
                    PasswordSalt = passwordSalt1,
                    JobId = 1,
                },
                new User
                {
                    Id = 2,
                    Name = "庄娅",
                    Sex = "女",
                    Phone = "12355553333",
                    Email = "duyou2@example.com",
                    DateCreated = DateTime.Now,
                    PasswordHash = passwordHash1,
                    PasswordSalt = passwordSalt1,
                    JobId = 3,
                },
                new User
                {
                    Id = 3,
                    Name = "罗山",
                    Sex = "男",
                    Phone = "12355557777",
                    Email = "duyou3@example.com",
                    DateCreated = DateTime.Now,
                    PasswordHash = passwordHash1,
                    PasswordSalt = passwordSalt1,
                    JobId = 2,
                },
                new User
                {
                    Id = 4,
                    Name = "薛马俊",
                    Sex = "男",
                    Phone = "12355554444",
                    Email = "duyou4@example.com",
                    DateCreated = DateTime.Now,
                    PasswordHash = passwordHash1,
                    PasswordSalt = passwordSalt1,
                    JobId = 4,
                },
                new User
                {
                    Id = 5,
                    Name = "彭广",
                    Sex = "男",
                    Phone = "12322226666",
                    Email = "duyou5@example.com",
                    DateCreated = DateTime.Now,
                    PasswordHash = passwordHash1,
                    PasswordSalt = passwordSalt1,
                    JobId = 5,
                },
                new User
                {
                    Id = 6,
                    Name = "韦峰",
                    Sex = "男",
                    Phone = "12355551234",
                    Email = "duyou6@example.com",
                    DateCreated = DateTime.Now,
                    PasswordHash = passwordHash1,
                    PasswordSalt = passwordSalt1,
                    JobId = 6,
                },
                new User
                {
                    Id = 7,
                    Name = "萧玉晨",
                    Sex = "女",
                    Phone = "12355557766",
                    Email = "duyou7@example.com",
                    DateCreated = DateTime.Now,
                    PasswordHash = passwordHash1,
                    PasswordSalt = passwordSalt1,
                    JobId = 9,
                },
                new User
                {
                    Id = 8,
                    Name = "丁钧",
                    Sex = "男",
                    Phone = "12355556866",
                    Email = "duyou8@example.com",
                    DateCreated = DateTime.Now,
                    PasswordHash = passwordHash1,
                    PasswordSalt = passwordSalt1,
                    JobId = 7,
                },
                new User
                {
                    Id = 9,
                    Name = "沈琼",
                    Sex = "女",
                    Phone = "12355556699",
                    Email = "duyou9@example.com",
                    DateCreated = DateTime.Now,
                    PasswordHash = passwordHash1,
                    PasswordSalt = passwordSalt1,
                    JobId = 9,
                }
                );
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<SkillType> SkillTypes { get; set; }
        public DbSet<SkillVariant> SkillVariants { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<TrainingItem> TrainingItems { get; set; }
        public DbSet<SkillLicense> SkillLicenses { get; set; }
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            //使用密码加密算法
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
