﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkillSystem.Server.Data;

#nullable disable

namespace SkillSystem.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230520115600_Seeding")]
    partial class Seeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SkillSystem.Shared.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<int>("SkillTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.HasIndex("SkillTypeId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "提高英语能力，通过英语四级",
                            Name = "英语四级培训课",
                            SkillId = 2,
                            SkillTypeId = 4
                        },
                        new
                        {
                            Id = 2,
                            Description = "提高计算机能力，通过计算机四级",
                            Name = "计算机四级培训课",
                            SkillId = 1,
                            SkillTypeId = 4
                        },
                        new
                        {
                            Id = 3,
                            Description = "提高Office能力，通过Office二级",
                            Name = "Office二级培训课",
                            SkillId = 4,
                            SkillTypeId = 2
                        });
                });

            modelBuilder.Entity("SkillSystem.Shared.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "负责人事管理相关工作",
                            Name = "人事管理部"
                        },
                        new
                        {
                            Id = 2,
                            Description = "负责产品开发相关工作",
                            Name = "开发部"
                        },
                        new
                        {
                            Id = 3,
                            Description = "负责人员联络工作",
                            Name = "联络部"
                        });
                });

            modelBuilder.Entity("SkillSystem.Shared.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Job");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Description = "人事管理部主管",
                            Name = "部门主管"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            Description = "开发部主管",
                            Name = "部门主管"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 3,
                            Description = "联络部主管",
                            Name = "部门主管"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 1,
                            Description = "人事管理部普通员工",
                            Name = "普通员工"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 1,
                            Description = "人事管理部普通员工",
                            Name = "普通员工"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 2,
                            Description = "开发部普通员工",
                            Name = "普通员工"
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 2,
                            Description = "开发部普通员工",
                            Name = "普通员工"
                        },
                        new
                        {
                            Id = 8,
                            DepartmentId = 3,
                            Description = "联络部普通员工",
                            Name = "普通员工"
                        },
                        new
                        {
                            Id = 9,
                            DepartmentId = 3,
                            Description = "联络部普通员工",
                            Name = "普通员工"
                        });
                });

            modelBuilder.Entity("SkillSystem.Shared.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skill");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "计算机操作能力",
                            Name = "计算机"
                        },
                        new
                        {
                            Id = 2,
                            Description = "英语交流能力",
                            Name = "英语"
                        },
                        new
                        {
                            Id = 3,
                            Description = "普通话交流能力",
                            Name = "普通话"
                        },
                        new
                        {
                            Id = 4,
                            Description = "办公软件能力",
                            Name = "Office"
                        });
                });

            modelBuilder.Entity("SkillSystem.Shared.SkillType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SkillTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "一级"
                        },
                        new
                        {
                            Id = 2,
                            Name = "二级"
                        },
                        new
                        {
                            Id = 3,
                            Name = "三级"
                        },
                        new
                        {
                            Id = 4,
                            Name = "四级"
                        });
                });

            modelBuilder.Entity("SkillSystem.Shared.SkillVariant", b =>
                {
                    b.Property<int>("SkillTypeId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillTypeId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillVariants");

                    b.HasData(
                        new
                        {
                            SkillTypeId = 2,
                            SkillId = 1,
                            Difficulty = "简单"
                        },
                        new
                        {
                            SkillTypeId = 4,
                            SkillId = 2,
                            Difficulty = "中等"
                        },
                        new
                        {
                            SkillTypeId = 2,
                            SkillId = 3,
                            Difficulty = "简单"
                        },
                        new
                        {
                            SkillTypeId = 4,
                            SkillId = 3,
                            Difficulty = "简单"
                        },
                        new
                        {
                            SkillTypeId = 2,
                            SkillId = 4,
                            Difficulty = "简单"
                        },
                        new
                        {
                            SkillTypeId = 4,
                            SkillId = 4,
                            Difficulty = "中等"
                        });
                });

            modelBuilder.Entity("SkillSystem.Shared.Training", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaxCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Training");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Description = "第一年度春季英语培训",
                            EndTime = new DateTime(2023, 6, 26, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8453),
                            MaxCapacity = 50,
                            Name = "第一年度春季英语培训",
                            StartTime = new DateTime(2023, 5, 27, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8441),
                            Status = "未开始",
                            Type = "线下"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            Description = "第一年度秋季计算机培训",
                            EndTime = new DateTime(2023, 11, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8458),
                            MaxCapacity = 10,
                            Name = "第一年度秋季计算机培训",
                            StartTime = new DateTime(2023, 8, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8456),
                            Status = "未开始",
                            Type = "线上"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 3,
                            Description = "第一年度夏季Office培训",
                            EndTime = new DateTime(2023, 10, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8460),
                            MaxCapacity = 30,
                            Name = "第一年度夏季Office培训",
                            StartTime = new DateTime(2023, 7, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8460),
                            Status = "未开始",
                            Type = "线上"
                        });
                });

            modelBuilder.Entity("SkillSystem.Shared.TrainingItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("RegisterTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Score")
                        .HasColumnType("decimal(5,1)");

                    b.Property<int>("TrainingId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrainingId");

                    b.HasIndex("UserId");

                    b.ToTable("TrainingItems");
                });

            modelBuilder.Entity("SkillSystem.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isSuper")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8678),
                            Email = "duyou@example.com",
                            JobId = 1,
                            Name = "董磊",
                            PasswordHash = new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 },
                            PasswordSalt = new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 },
                            Phone = "12355556666",
                            Sex = "男",
                            isSuper = false
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8731),
                            Email = "duyou2@example.com",
                            JobId = 3,
                            Name = "庄娅",
                            PasswordHash = new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 },
                            PasswordSalt = new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 },
                            Phone = "12355553333",
                            Sex = "女",
                            isSuper = false
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8733),
                            Email = "duyou3@example.com",
                            JobId = 2,
                            Name = "罗山",
                            PasswordHash = new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 },
                            PasswordSalt = new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 },
                            Phone = "12355557777",
                            Sex = "男",
                            isSuper = false
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8735),
                            Email = "duyou4@example.com",
                            JobId = 4,
                            Name = "薛马俊",
                            PasswordHash = new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 },
                            PasswordSalt = new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 },
                            Phone = "12355554444",
                            Sex = "男",
                            isSuper = false
                        },
                        new
                        {
                            Id = 5,
                            DateCreated = new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8736),
                            Email = "duyou5@example.com",
                            JobId = 5,
                            Name = "彭广",
                            PasswordHash = new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 },
                            PasswordSalt = new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 },
                            Phone = "12322226666",
                            Sex = "男",
                            isSuper = false
                        },
                        new
                        {
                            Id = 6,
                            DateCreated = new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8738),
                            Email = "duyou6@example.com",
                            JobId = 6,
                            Name = "韦峰",
                            PasswordHash = new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 },
                            PasswordSalt = new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 },
                            Phone = "12355551234",
                            Sex = "男",
                            isSuper = false
                        },
                        new
                        {
                            Id = 7,
                            DateCreated = new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8739),
                            Email = "duyou7@example.com",
                            JobId = 9,
                            Name = "萧玉晨",
                            PasswordHash = new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 },
                            PasswordSalt = new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 },
                            Phone = "12355557766",
                            Sex = "女",
                            isSuper = false
                        },
                        new
                        {
                            Id = 8,
                            DateCreated = new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8741),
                            Email = "duyou8@example.com",
                            JobId = 7,
                            Name = "丁钧",
                            PasswordHash = new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 },
                            PasswordSalt = new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 },
                            Phone = "12355556866",
                            Sex = "男",
                            isSuper = false
                        },
                        new
                        {
                            Id = 9,
                            DateCreated = new DateTime(2023, 5, 20, 19, 55, 59, 923, DateTimeKind.Local).AddTicks(8742),
                            Email = "duyou9@example.com",
                            JobId = 9,
                            Name = "沈琼",
                            PasswordHash = new byte[] { 230, 184, 209, 118, 86, 0, 6, 117, 201, 8, 129, 36, 6, 56, 225, 225, 154, 231, 90, 252, 173, 122, 50, 207, 197, 46, 178, 188, 95, 203, 204, 60, 215, 138, 154, 16, 18, 205, 249, 21, 15, 112, 16, 49, 3, 216, 142, 0, 15, 116, 246, 251, 223, 226, 75, 79, 66, 130, 175, 215, 1, 90, 44, 229 },
                            PasswordSalt = new byte[] { 238, 12, 80, 51, 135, 93, 55, 100, 68, 35, 179, 80, 61, 217, 123, 22, 216, 88, 55, 83, 1, 190, 173, 133, 140, 163, 182, 185, 150, 166, 237, 171, 80, 110, 65, 46, 165, 92, 151, 238, 242, 1, 2, 238, 60, 13, 129, 148, 230, 125, 146, 244, 223, 252, 244, 176, 126, 156, 141, 171, 190, 138, 52, 31, 126, 165, 20, 70, 181, 0, 52, 134, 231, 172, 27, 94, 115, 178, 94, 41, 39, 14, 35, 135, 192, 186, 7, 50, 71, 3, 238, 224, 3, 126, 33, 141, 191, 207, 157, 221, 201, 24, 186, 164, 37, 45, 184, 20, 193, 136, 125, 178, 154, 246, 214, 141, 61, 162, 1, 166, 39, 71, 199, 100, 43, 216, 51, 96 },
                            Phone = "12355556699",
                            Sex = "女",
                            isSuper = false
                        });
                });

            modelBuilder.Entity("SkillSystem.Shared.Course", b =>
                {
                    b.HasOne("SkillSystem.Shared.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkillSystem.Shared.SkillType", "SkillType")
                        .WithMany()
                        .HasForeignKey("SkillTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("SkillType");
                });

            modelBuilder.Entity("SkillSystem.Shared.Job", b =>
                {
                    b.HasOne("SkillSystem.Shared.Department", "Department")
                        .WithMany("JobList")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("SkillSystem.Shared.SkillVariant", b =>
                {
                    b.HasOne("SkillSystem.Shared.Skill", "Skill")
                        .WithMany("Variants")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkillSystem.Shared.SkillType", "SkillType")
                        .WithMany()
                        .HasForeignKey("SkillTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("SkillType");
                });

            modelBuilder.Entity("SkillSystem.Shared.Training", b =>
                {
                    b.HasOne("SkillSystem.Shared.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("SkillSystem.Shared.TrainingItem", b =>
                {
                    b.HasOne("SkillSystem.Shared.Training", "Training")
                        .WithMany()
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkillSystem.Shared.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Training");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SkillSystem.Shared.User", b =>
                {
                    b.HasOne("SkillSystem.Shared.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Job");
                });

            modelBuilder.Entity("SkillSystem.Shared.Department", b =>
                {
                    b.Navigation("JobList");
                });

            modelBuilder.Entity("SkillSystem.Shared.Skill", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
