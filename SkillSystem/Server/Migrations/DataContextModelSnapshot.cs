﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkillSystem.Server.Data;

#nullable disable

namespace SkillSystem.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("isSuper")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateTime(2023, 5, 12, 22, 53, 8, 299, DateTimeKind.Local).AddTicks(6379),
                            Email = "duyou@super.com",
                            PasswordHash = new byte[] { 213, 247, 225, 111, 89, 253, 198, 104, 50, 232, 140, 192, 136, 127, 173, 175, 233, 20, 253, 151, 73, 166, 151, 92, 151, 158, 78, 230, 53, 134, 122, 41, 54, 39, 31, 240, 147, 192, 115, 56, 54, 176, 22, 237, 234, 50, 125, 234, 198, 116, 131, 227, 31, 25, 211, 120, 254, 103, 10, 40, 8, 107, 137, 136 },
                            PasswordSalt = new byte[] { 88, 188, 222, 29, 13, 203, 241, 9, 164, 140, 145, 73, 240, 159, 78, 152, 79, 137, 46, 2, 56, 60, 229, 162, 80, 156, 175, 162, 49, 16, 15, 101, 180, 125, 229, 31, 80, 232, 115, 150, 213, 221, 60, 247, 149, 25, 13, 127, 194, 152, 199, 137, 72, 158, 204, 102, 53, 97, 226, 88, 173, 45, 25, 41, 88, 114, 6, 30, 188, 17, 19, 72, 205, 128, 81, 12, 154, 227, 225, 123, 35, 127, 42, 67, 88, 76, 44, 107, 168, 255, 37, 203, 2, 145, 12, 181, 169, 90, 110, 238, 92, 244, 87, 64, 247, 172, 192, 251, 133, 209, 100, 37, 200, 60, 38, 127, 208, 210, 120, 10, 145, 29, 141, 226, 184, 22, 77, 43 },
                            isSuper = true
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateTime(2023, 5, 12, 22, 53, 8, 299, DateTimeKind.Local).AddTicks(6381),
                            Email = "duyou2@super.com",
                            PasswordHash = new byte[] { 6, 60, 118, 202, 75, 139, 94, 11, 168, 185, 233, 168, 254, 71, 41, 5, 19, 222, 44, 236, 1, 55, 164, 87, 228, 197, 39, 139, 13, 172, 159, 228, 122, 233, 122, 113, 130, 184, 203, 74, 127, 61, 36, 195, 130, 169, 121, 59, 245, 210, 175, 40, 209, 98, 187, 168, 112, 220, 0, 146, 234, 90, 202, 46 },
                            PasswordSalt = new byte[] { 18, 228, 168, 69, 133, 114, 82, 77, 225, 225, 155, 241, 49, 199, 25, 23, 43, 100, 169, 30, 2, 219, 224, 162, 25, 114, 1, 11, 193, 188, 190, 116, 46, 221, 194, 123, 164, 158, 79, 135, 119, 187, 90, 174, 131, 114, 231, 73, 79, 144, 99, 25, 242, 117, 167, 222, 203, 46, 217, 209, 140, 160, 89, 167, 23, 143, 144, 59, 220, 91, 52, 99, 47, 34, 161, 170, 61, 79, 30, 65, 173, 128, 248, 184, 122, 113, 218, 82, 207, 239, 230, 251, 27, 233, 36, 180, 154, 109, 84, 101, 182, 191, 35, 25, 110, 254, 58, 21, 50, 140, 232, 137, 53, 8, 218, 134, 174, 28, 16, 18, 196, 225, 218, 113, 190, 44, 110, 4 },
                            isSuper = true
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateTime(2023, 5, 12, 22, 53, 8, 299, DateTimeKind.Local).AddTicks(6382),
                            Email = "duyou3@super.com",
                            PasswordHash = new byte[] { 203, 161, 28, 26, 178, 93, 107, 59, 99, 92, 122, 255, 80, 80, 70, 27, 222, 100, 13, 173, 190, 224, 201, 186, 249, 175, 184, 34, 22, 80, 202, 91, 96, 154, 29, 217, 178, 176, 136, 68, 197, 156, 149, 6, 152, 243, 11, 32, 233, 216, 135, 136, 244, 42, 70, 251, 66, 24, 110, 125, 71, 136, 110, 204 },
                            PasswordSalt = new byte[] { 189, 195, 135, 80, 32, 70, 143, 99, 132, 14, 220, 216, 150, 136, 82, 84, 9, 92, 240, 155, 142, 215, 239, 198, 204, 53, 143, 109, 78, 230, 173, 188, 148, 206, 200, 98, 186, 18, 168, 213, 146, 57, 64, 88, 215, 251, 141, 5, 147, 118, 58, 54, 181, 173, 82, 137, 176, 196, 43, 235, 196, 147, 5, 117, 230, 138, 163, 74, 13, 217, 121, 194, 15, 123, 226, 203, 235, 225, 204, 221, 232, 185, 66, 146, 243, 218, 142, 254, 174, 32, 4, 88, 124, 160, 183, 188, 240, 208, 237, 54, 42, 11, 112, 228, 19, 43, 32, 73, 109, 102, 3, 56, 96, 140, 0, 186, 145, 221, 155, 229, 236, 65, 160, 125, 132, 193, 191, 85 },
                            isSuper = true
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateTime(2023, 5, 12, 22, 53, 8, 299, DateTimeKind.Local).AddTicks(6383),
                            Email = "duyou4@super.com",
                            PasswordHash = new byte[] { 75, 180, 250, 46, 20, 14, 113, 125, 107, 28, 169, 50, 220, 201, 32, 127, 135, 17, 46, 28, 40, 231, 184, 129, 67, 67, 88, 192, 137, 98, 185, 79, 59, 199, 196, 231, 204, 48, 158, 51, 180, 18, 0, 244, 60, 222, 147, 67, 165, 56, 125, 244, 114, 231, 235, 87, 59, 33, 81, 103, 136, 0, 52, 239 },
                            PasswordSalt = new byte[] { 169, 41, 24, 220, 204, 248, 49, 16, 162, 211, 251, 14, 115, 143, 88, 82, 7, 10, 60, 202, 225, 109, 162, 19, 169, 157, 253, 210, 201, 129, 149, 5, 212, 131, 216, 111, 230, 151, 105, 179, 56, 157, 21, 72, 232, 38, 39, 5, 237, 128, 172, 114, 91, 245, 99, 90, 56, 1, 97, 233, 29, 18, 241, 49, 85, 30, 117, 233, 213, 70, 85, 108, 147, 94, 190, 199, 216, 174, 184, 138, 202, 106, 224, 216, 134, 32, 96, 73, 8, 251, 86, 194, 158, 167, 110, 5, 142, 253, 106, 115, 139, 71, 62, 34, 46, 218, 0, 195, 65, 115, 108, 174, 225, 171, 105, 197, 86, 129, 195, 44, 117, 130, 123, 50, 106, 166, 31, 4 },
                            isSuper = true
                        },
                        new
                        {
                            Id = 5,
                            DateCreated = new DateTime(2023, 5, 12, 22, 53, 8, 299, DateTimeKind.Local).AddTicks(6384),
                            Email = "duyou5@super.com",
                            PasswordHash = new byte[] { 67, 172, 180, 69, 48, 172, 21, 5, 213, 201, 180, 76, 130, 106, 97, 202, 203, 5, 118, 164, 131, 72, 36, 235, 141, 14, 177, 65, 57, 43, 106, 186, 237, 196, 148, 254, 12, 118, 116, 14, 230, 13, 250, 22, 251, 242, 79, 211, 8, 231, 4, 166, 72, 97, 16, 149, 99, 12, 110, 119, 184, 0, 10, 10 },
                            PasswordSalt = new byte[] { 120, 181, 199, 74, 76, 10, 8, 139, 49, 202, 92, 31, 135, 193, 242, 38, 207, 173, 191, 169, 144, 62, 211, 192, 221, 106, 114, 9, 139, 246, 180, 243, 216, 85, 196, 78, 204, 244, 207, 10, 153, 10, 158, 110, 158, 56, 26, 234, 97, 170, 70, 169, 96, 113, 120, 235, 57, 220, 118, 253, 247, 36, 38, 45, 95, 252, 217, 165, 128, 155, 118, 26, 58, 169, 43, 85, 244, 117, 2, 68, 246, 251, 58, 206, 60, 252, 111, 227, 162, 39, 194, 135, 1, 91, 144, 146, 213, 6, 219, 169, 254, 43, 63, 23, 140, 96, 12, 208, 199, 174, 60, 50, 74, 124, 151, 65, 113, 101, 205, 25, 175, 51, 11, 125, 133, 238, 26, 186 },
                            isSuper = true
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
