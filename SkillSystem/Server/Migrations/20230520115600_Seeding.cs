using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SkillSystem.Server.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Job_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    SkillTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_SkillTypes_SkillTypeId",
                        column: x => x.SkillTypeId,
                        principalTable: "SkillTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SkillVariants",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false),
                    SkillTypeId = table.Column<int>(type: "int", nullable: false),
                    Difficulty = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillVariants", x => new { x.SkillTypeId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_SkillVariants_SkillTypes_SkillTypeId",
                        column: x => x.SkillTypeId,
                        principalTable: "SkillTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SkillVariants_Skill_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isSuper = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Job_JobId",
                        column: x => x.JobId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Training",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxCapacity = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Training", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Training_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrainingItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<decimal>(type: "decimal(5,1)", nullable: false),
                    RegisterTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingItems_Training_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Training",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TrainingItems_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "负责人事管理相关工作", "人事管理部" },
                    { 2, "负责产品开发相关工作", "开发部" },
                    { 3, "负责人员联络工作", "联络部" }
                });

            migrationBuilder.InsertData(
                table: "Skill",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "计算机操作能力", "计算机" },
                    { 2, "英语交流能力", "英语" },
                    { 3, "普通话交流能力", "普通话" },
                    { 4, "办公软件能力", "Office" }
                });

            migrationBuilder.InsertData(
                table: "SkillTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "一级" },
                    { 2, "二级" },
                    { 3, "三级" },
                    { 4, "四级" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Name", "SkillId", "SkillTypeId" },
                values: new object[,]
                {
                    { 1, "提高英语能力，通过英语四级", "英语四级培训课", 2, 4 },
                    { 2, "提高计算机能力，通过计算机四级", "计算机四级培训课", 1, 4 },
                    { 3, "提高Office能力，通过Office二级", "Office二级培训课", 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "DepartmentId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "人事管理部主管", "部门主管" },
                    { 2, 2, "开发部主管", "部门主管" },
                    { 3, 3, "联络部主管", "部门主管" },
                    { 4, 1, "人事管理部普通员工", "普通员工" },
                    { 5, 1, "人事管理部普通员工", "普通员工" },
                    { 6, 2, "开发部普通员工", "普通员工" },
                    { 7, 2, "开发部普通员工", "普通员工" },
                    { 8, 3, "联络部普通员工", "普通员工" },
                    { 9, 3, "联络部普通员工", "普通员工" }
                });

            migrationBuilder.InsertData(
                table: "SkillVariants",
                columns: new[] { "SkillId", "SkillTypeId", "Difficulty" },
                values: new object[,]
                {
                    { 1, 2, "简单" },
                    { 3, 2, "简单" },
                    { 4, 2, "简单" },
                    { 2, 4, "中等" },
                    { 3, 4, "简单" },
                    { 4, 4, "中等" }
                });

            migrationBuilder.InsertData(
                table: "Training",
                columns: new[] { "Id", "CourseId", "Description", "EndTime", "MaxCapacity", "Name", "StartTime", "Status", "Type" },
                values: new object[,]
                {
                    { 1, 1, "第一年度春季英语培训", new DateTime(2023, 6, 26, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8453), 50, "第一年度春季英语培训", new DateTime(2023, 5, 27, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8441), "未开始", "线下" },
                    { 2, 2, "第一年度秋季计算机培训", new DateTime(2023, 11, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8458), 10, "第一年度秋季计算机培训", new DateTime(2023, 8, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8456), "未开始", "线上" },
                    { 3, 3, "第一年度夏季Office培训", new DateTime(2023, 10, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8460), 30, "第一年度夏季Office培训", new DateTime(2023, 7, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8460), "未开始", "线上" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "DateCreated", "Email", "JobId", "Name", "PasswordHash", "PasswordSalt", "Phone", "Sex", "isSuper" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8678), "duyou@example.com", 1, "董磊", new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 }, new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 }, "12355556666", "男", false },
                    { 2, new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8731), "duyou2@example.com", 3, "庄娅", new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 }, new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 }, "12355553333", "女", false },
                    { 3, new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8733), "duyou3@example.com", 2, "罗山", new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 }, new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 }, "12355557777", "男", false },
                    { 4, new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8735), "duyou4@example.com", 4, "薛马俊", new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 }, new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 }, "12355554444", "男", false },
                    { 5, new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8736), "duyou5@example.com", 5, "彭广", new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 }, new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 }, "12322226666", "男", false },
                    { 6, new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8738), "duyou6@example.com", 6, "韦峰", new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 }, new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 }, "12355551234", "男", false },
                    { 7, new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8739), "duyou7@example.com", 9, "萧玉晨", new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 }, new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 }, "12355557766", "女", false },
                    { 8, new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8741), "duyou8@example.com", 7, "丁钧", new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 }, new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 }, "12355556866", "男", false },
                    { 9, new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8742), "duyou9@example.com", 9, "沈琼", new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 }, new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 }, "12355556699", "女", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SkillId",
                table: "Courses",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_SkillTypeId",
                table: "Courses",
                column: "SkillTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Job_DepartmentId",
                table: "Job",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillVariants_SkillId",
                table: "SkillVariants",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Training_CourseId",
                table: "Training",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingItems_TrainingId",
                table: "TrainingItems",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingItems_UserId",
                table: "TrainingItems",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_JobId",
                table: "Users",
                column: "JobId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkillVariants");

            migrationBuilder.DropTable(
                name: "TrainingItems");

            migrationBuilder.DropTable(
                name: "Training");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "SkillTypes");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
