﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillSystem.Server.Migrations
{
    /// <inheritdoc />
    public partial class otherTrainingFlag : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Training",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "SkillLicenses",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, 9 },
                column: "GetTime",
                value: new DateTime(2023, 5, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "SkillLicenses",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, 9 },
                column: "GetTime",
                value: new DateTime(2023, 5, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Deleted", "EndTime", "StartTime" },
                values: new object[] { false, new DateTime(2023, 6, 30, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(6887), new DateTime(2023, 5, 31, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Deleted", "EndTime", "StartTime" },
                values: new object[] { false, new DateTime(2023, 11, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(6892), new DateTime(2023, 8, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Deleted", "EndTime", "StartTime" },
                values: new object[] { false, new DateTime(2023, 10, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(6894), new DateTime(2023, 7, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(7104), new byte[] { 60, 155, 98, 119, 197, 144, 7, 169, 238, 216, 83, 251, 133, 255, 163, 9, 13, 153, 52, 190, 117, 215, 9, 0, 52, 26, 209, 5, 70, 245, 151, 77, 250, 128, 64, 82, 73, 45, 241, 95, 35, 93, 255, 134, 171, 245, 23, 60, 111, 117, 65, 178, 146, 249, 85, 9, 6, 106, 6, 152, 37, 195, 89, 54 }, new byte[] { 214, 36, 167, 16, 202, 10, 182, 22, 107, 26, 196, 228, 104, 67, 175, 213, 211, 103, 69, 96, 118, 16, 17, 41, 123, 179, 144, 80, 235, 12, 199, 115, 80, 96, 227, 119, 221, 187, 206, 170, 210, 187, 195, 25, 224, 160, 93, 194, 6, 231, 221, 136, 45, 179, 119, 34, 11, 25, 199, 244, 101, 186, 158, 109, 166, 146, 197, 86, 186, 6, 120, 59, 103, 185, 68, 205, 204, 86, 198, 242, 215, 150, 138, 76, 224, 230, 170, 133, 82, 168, 143, 118, 48, 173, 72, 6, 137, 98, 187, 116, 62, 163, 123, 127, 176, 89, 217, 232, 129, 21, 121, 228, 218, 81, 188, 122, 76, 27, 46, 222, 213, 233, 25, 152, 53, 165, 18, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(7107), new byte[] { 60, 155, 98, 119, 197, 144, 7, 169, 238, 216, 83, 251, 133, 255, 163, 9, 13, 153, 52, 190, 117, 215, 9, 0, 52, 26, 209, 5, 70, 245, 151, 77, 250, 128, 64, 82, 73, 45, 241, 95, 35, 93, 255, 134, 171, 245, 23, 60, 111, 117, 65, 178, 146, 249, 85, 9, 6, 106, 6, 152, 37, 195, 89, 54 }, new byte[] { 214, 36, 167, 16, 202, 10, 182, 22, 107, 26, 196, 228, 104, 67, 175, 213, 211, 103, 69, 96, 118, 16, 17, 41, 123, 179, 144, 80, 235, 12, 199, 115, 80, 96, 227, 119, 221, 187, 206, 170, 210, 187, 195, 25, 224, 160, 93, 194, 6, 231, 221, 136, 45, 179, 119, 34, 11, 25, 199, 244, 101, 186, 158, 109, 166, 146, 197, 86, 186, 6, 120, 59, 103, 185, 68, 205, 204, 86, 198, 242, 215, 150, 138, 76, 224, 230, 170, 133, 82, 168, 143, 118, 48, 173, 72, 6, 137, 98, 187, 116, 62, 163, 123, 127, 176, 89, 217, 232, 129, 21, 121, 228, 218, 81, 188, 122, 76, 27, 46, 222, 213, 233, 25, 152, 53, 165, 18, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(7109), new byte[] { 60, 155, 98, 119, 197, 144, 7, 169, 238, 216, 83, 251, 133, 255, 163, 9, 13, 153, 52, 190, 117, 215, 9, 0, 52, 26, 209, 5, 70, 245, 151, 77, 250, 128, 64, 82, 73, 45, 241, 95, 35, 93, 255, 134, 171, 245, 23, 60, 111, 117, 65, 178, 146, 249, 85, 9, 6, 106, 6, 152, 37, 195, 89, 54 }, new byte[] { 214, 36, 167, 16, 202, 10, 182, 22, 107, 26, 196, 228, 104, 67, 175, 213, 211, 103, 69, 96, 118, 16, 17, 41, 123, 179, 144, 80, 235, 12, 199, 115, 80, 96, 227, 119, 221, 187, 206, 170, 210, 187, 195, 25, 224, 160, 93, 194, 6, 231, 221, 136, 45, 179, 119, 34, 11, 25, 199, 244, 101, 186, 158, 109, 166, 146, 197, 86, 186, 6, 120, 59, 103, 185, 68, 205, 204, 86, 198, 242, 215, 150, 138, 76, 224, 230, 170, 133, 82, 168, 143, 118, 48, 173, 72, 6, 137, 98, 187, 116, 62, 163, 123, 127, 176, 89, 217, 232, 129, 21, 121, 228, 218, 81, 188, 122, 76, 27, 46, 222, 213, 233, 25, 152, 53, 165, 18, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(7110), new byte[] { 60, 155, 98, 119, 197, 144, 7, 169, 238, 216, 83, 251, 133, 255, 163, 9, 13, 153, 52, 190, 117, 215, 9, 0, 52, 26, 209, 5, 70, 245, 151, 77, 250, 128, 64, 82, 73, 45, 241, 95, 35, 93, 255, 134, 171, 245, 23, 60, 111, 117, 65, 178, 146, 249, 85, 9, 6, 106, 6, 152, 37, 195, 89, 54 }, new byte[] { 214, 36, 167, 16, 202, 10, 182, 22, 107, 26, 196, 228, 104, 67, 175, 213, 211, 103, 69, 96, 118, 16, 17, 41, 123, 179, 144, 80, 235, 12, 199, 115, 80, 96, 227, 119, 221, 187, 206, 170, 210, 187, 195, 25, 224, 160, 93, 194, 6, 231, 221, 136, 45, 179, 119, 34, 11, 25, 199, 244, 101, 186, 158, 109, 166, 146, 197, 86, 186, 6, 120, 59, 103, 185, 68, 205, 204, 86, 198, 242, 215, 150, 138, 76, 224, 230, 170, 133, 82, 168, 143, 118, 48, 173, 72, 6, 137, 98, 187, 116, 62, 163, 123, 127, 176, 89, 217, 232, 129, 21, 121, 228, 218, 81, 188, 122, 76, 27, 46, 222, 213, 233, 25, 152, 53, 165, 18, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(7112), new byte[] { 60, 155, 98, 119, 197, 144, 7, 169, 238, 216, 83, 251, 133, 255, 163, 9, 13, 153, 52, 190, 117, 215, 9, 0, 52, 26, 209, 5, 70, 245, 151, 77, 250, 128, 64, 82, 73, 45, 241, 95, 35, 93, 255, 134, 171, 245, 23, 60, 111, 117, 65, 178, 146, 249, 85, 9, 6, 106, 6, 152, 37, 195, 89, 54 }, new byte[] { 214, 36, 167, 16, 202, 10, 182, 22, 107, 26, 196, 228, 104, 67, 175, 213, 211, 103, 69, 96, 118, 16, 17, 41, 123, 179, 144, 80, 235, 12, 199, 115, 80, 96, 227, 119, 221, 187, 206, 170, 210, 187, 195, 25, 224, 160, 93, 194, 6, 231, 221, 136, 45, 179, 119, 34, 11, 25, 199, 244, 101, 186, 158, 109, 166, 146, 197, 86, 186, 6, 120, 59, 103, 185, 68, 205, 204, 86, 198, 242, 215, 150, 138, 76, 224, 230, 170, 133, 82, 168, 143, 118, 48, 173, 72, 6, 137, 98, 187, 116, 62, 163, 123, 127, 176, 89, 217, 232, 129, 21, 121, 228, 218, 81, 188, 122, 76, 27, 46, 222, 213, 233, 25, 152, 53, 165, 18, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(7113), new byte[] { 60, 155, 98, 119, 197, 144, 7, 169, 238, 216, 83, 251, 133, 255, 163, 9, 13, 153, 52, 190, 117, 215, 9, 0, 52, 26, 209, 5, 70, 245, 151, 77, 250, 128, 64, 82, 73, 45, 241, 95, 35, 93, 255, 134, 171, 245, 23, 60, 111, 117, 65, 178, 146, 249, 85, 9, 6, 106, 6, 152, 37, 195, 89, 54 }, new byte[] { 214, 36, 167, 16, 202, 10, 182, 22, 107, 26, 196, 228, 104, 67, 175, 213, 211, 103, 69, 96, 118, 16, 17, 41, 123, 179, 144, 80, 235, 12, 199, 115, 80, 96, 227, 119, 221, 187, 206, 170, 210, 187, 195, 25, 224, 160, 93, 194, 6, 231, 221, 136, 45, 179, 119, 34, 11, 25, 199, 244, 101, 186, 158, 109, 166, 146, 197, 86, 186, 6, 120, 59, 103, 185, 68, 205, 204, 86, 198, 242, 215, 150, 138, 76, 224, 230, 170, 133, 82, 168, 143, 118, 48, 173, 72, 6, 137, 98, 187, 116, 62, 163, 123, 127, 176, 89, 217, 232, 129, 21, 121, 228, 218, 81, 188, 122, 76, 27, 46, 222, 213, 233, 25, 152, 53, 165, 18, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(7115), new byte[] { 60, 155, 98, 119, 197, 144, 7, 169, 238, 216, 83, 251, 133, 255, 163, 9, 13, 153, 52, 190, 117, 215, 9, 0, 52, 26, 209, 5, 70, 245, 151, 77, 250, 128, 64, 82, 73, 45, 241, 95, 35, 93, 255, 134, 171, 245, 23, 60, 111, 117, 65, 178, 146, 249, 85, 9, 6, 106, 6, 152, 37, 195, 89, 54 }, new byte[] { 214, 36, 167, 16, 202, 10, 182, 22, 107, 26, 196, 228, 104, 67, 175, 213, 211, 103, 69, 96, 118, 16, 17, 41, 123, 179, 144, 80, 235, 12, 199, 115, 80, 96, 227, 119, 221, 187, 206, 170, 210, 187, 195, 25, 224, 160, 93, 194, 6, 231, 221, 136, 45, 179, 119, 34, 11, 25, 199, 244, 101, 186, 158, 109, 166, 146, 197, 86, 186, 6, 120, 59, 103, 185, 68, 205, 204, 86, 198, 242, 215, 150, 138, 76, 224, 230, 170, 133, 82, 168, 143, 118, 48, 173, 72, 6, 137, 98, 187, 116, 62, 163, 123, 127, 176, 89, 217, 232, 129, 21, 121, 228, 218, 81, 188, 122, 76, 27, 46, 222, 213, 233, 25, 152, 53, 165, 18, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(7116), new byte[] { 60, 155, 98, 119, 197, 144, 7, 169, 238, 216, 83, 251, 133, 255, 163, 9, 13, 153, 52, 190, 117, 215, 9, 0, 52, 26, 209, 5, 70, 245, 151, 77, 250, 128, 64, 82, 73, 45, 241, 95, 35, 93, 255, 134, 171, 245, 23, 60, 111, 117, 65, 178, 146, 249, 85, 9, 6, 106, 6, 152, 37, 195, 89, 54 }, new byte[] { 214, 36, 167, 16, 202, 10, 182, 22, 107, 26, 196, 228, 104, 67, 175, 213, 211, 103, 69, 96, 118, 16, 17, 41, 123, 179, 144, 80, 235, 12, 199, 115, 80, 96, 227, 119, 221, 187, 206, 170, 210, 187, 195, 25, 224, 160, 93, 194, 6, 231, 221, 136, 45, 179, 119, 34, 11, 25, 199, 244, 101, 186, 158, 109, 166, 146, 197, 86, 186, 6, 120, 59, 103, 185, 68, 205, 204, 86, 198, 242, 215, 150, 138, 76, 224, 230, 170, 133, 82, 168, 143, 118, 48, 173, 72, 6, 137, 98, 187, 116, 62, 163, 123, 127, 176, 89, 217, 232, 129, 21, 121, 228, 218, 81, 188, 122, 76, 27, 46, 222, 213, 233, 25, 152, 53, 165, 18, 224 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 19, 59, 26, 62, DateTimeKind.Local).AddTicks(7118), new byte[] { 60, 155, 98, 119, 197, 144, 7, 169, 238, 216, 83, 251, 133, 255, 163, 9, 13, 153, 52, 190, 117, 215, 9, 0, 52, 26, 209, 5, 70, 245, 151, 77, 250, 128, 64, 82, 73, 45, 241, 95, 35, 93, 255, 134, 171, 245, 23, 60, 111, 117, 65, 178, 146, 249, 85, 9, 6, 106, 6, 152, 37, 195, 89, 54 }, new byte[] { 214, 36, 167, 16, 202, 10, 182, 22, 107, 26, 196, 228, 104, 67, 175, 213, 211, 103, 69, 96, 118, 16, 17, 41, 123, 179, 144, 80, 235, 12, 199, 115, 80, 96, 227, 119, 221, 187, 206, 170, 210, 187, 195, 25, 224, 160, 93, 194, 6, 231, 221, 136, 45, 179, 119, 34, 11, 25, 199, 244, 101, 186, 158, 109, 166, 146, 197, 86, 186, 6, 120, 59, 103, 185, 68, 205, 204, 86, 198, 242, 215, 150, 138, 76, 224, 230, 170, 133, 82, 168, 143, 118, 48, 173, 72, 6, 137, 98, 187, 116, 62, 163, 123, 127, 176, 89, 217, 232, 129, 21, 121, 228, 218, 81, 188, 122, 76, 27, 46, 222, 213, 233, 25, 152, 53, 165, 18, 224 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Training");

            migrationBuilder.UpdateData(
                table: "SkillLicenses",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, 9 },
                column: "GetTime",
                value: new DateTime(2023, 5, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "SkillLicenses",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, 9 },
                column: "GetTime",
                value: new DateTime(2023, 5, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 30, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3551), new DateTime(2023, 5, 31, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3556), new DateTime(2023, 8, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3558), new DateTime(2023, 7, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3803), new byte[] { 178, 148, 171, 232, 68, 104, 165, 255, 87, 52, 245, 27, 56, 39, 145, 14, 105, 197, 191, 239, 169, 111, 166, 38, 150, 248, 106, 159, 205, 63, 12, 204, 208, 60, 187, 30, 19, 148, 100, 166, 168, 115, 238, 201, 170, 75, 223, 88, 130, 176, 135, 39, 226, 26, 170, 86, 44, 33, 199, 75, 33, 167, 91, 12 }, new byte[] { 167, 28, 63, 231, 90, 240, 218, 50, 102, 24, 202, 136, 167, 104, 166, 116, 105, 132, 207, 16, 213, 104, 252, 59, 43, 187, 47, 226, 84, 95, 78, 172, 103, 130, 212, 106, 2, 154, 174, 121, 130, 5, 29, 148, 42, 97, 39, 186, 202, 98, 48, 180, 61, 136, 207, 206, 53, 89, 45, 87, 213, 208, 0, 252, 116, 39, 149, 161, 220, 50, 187, 173, 240, 147, 151, 158, 231, 255, 72, 220, 158, 2, 156, 30, 228, 227, 237, 243, 137, 156, 53, 80, 0, 59, 65, 172, 185, 236, 201, 151, 25, 3, 158, 208, 227, 240, 62, 3, 177, 121, 244, 39, 45, 52, 10, 238, 170, 202, 235, 142, 136, 217, 159, 193, 62, 11, 233, 38 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3806), new byte[] { 178, 148, 171, 232, 68, 104, 165, 255, 87, 52, 245, 27, 56, 39, 145, 14, 105, 197, 191, 239, 169, 111, 166, 38, 150, 248, 106, 159, 205, 63, 12, 204, 208, 60, 187, 30, 19, 148, 100, 166, 168, 115, 238, 201, 170, 75, 223, 88, 130, 176, 135, 39, 226, 26, 170, 86, 44, 33, 199, 75, 33, 167, 91, 12 }, new byte[] { 167, 28, 63, 231, 90, 240, 218, 50, 102, 24, 202, 136, 167, 104, 166, 116, 105, 132, 207, 16, 213, 104, 252, 59, 43, 187, 47, 226, 84, 95, 78, 172, 103, 130, 212, 106, 2, 154, 174, 121, 130, 5, 29, 148, 42, 97, 39, 186, 202, 98, 48, 180, 61, 136, 207, 206, 53, 89, 45, 87, 213, 208, 0, 252, 116, 39, 149, 161, 220, 50, 187, 173, 240, 147, 151, 158, 231, 255, 72, 220, 158, 2, 156, 30, 228, 227, 237, 243, 137, 156, 53, 80, 0, 59, 65, 172, 185, 236, 201, 151, 25, 3, 158, 208, 227, 240, 62, 3, 177, 121, 244, 39, 45, 52, 10, 238, 170, 202, 235, 142, 136, 217, 159, 193, 62, 11, 233, 38 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3808), new byte[] { 178, 148, 171, 232, 68, 104, 165, 255, 87, 52, 245, 27, 56, 39, 145, 14, 105, 197, 191, 239, 169, 111, 166, 38, 150, 248, 106, 159, 205, 63, 12, 204, 208, 60, 187, 30, 19, 148, 100, 166, 168, 115, 238, 201, 170, 75, 223, 88, 130, 176, 135, 39, 226, 26, 170, 86, 44, 33, 199, 75, 33, 167, 91, 12 }, new byte[] { 167, 28, 63, 231, 90, 240, 218, 50, 102, 24, 202, 136, 167, 104, 166, 116, 105, 132, 207, 16, 213, 104, 252, 59, 43, 187, 47, 226, 84, 95, 78, 172, 103, 130, 212, 106, 2, 154, 174, 121, 130, 5, 29, 148, 42, 97, 39, 186, 202, 98, 48, 180, 61, 136, 207, 206, 53, 89, 45, 87, 213, 208, 0, 252, 116, 39, 149, 161, 220, 50, 187, 173, 240, 147, 151, 158, 231, 255, 72, 220, 158, 2, 156, 30, 228, 227, 237, 243, 137, 156, 53, 80, 0, 59, 65, 172, 185, 236, 201, 151, 25, 3, 158, 208, 227, 240, 62, 3, 177, 121, 244, 39, 45, 52, 10, 238, 170, 202, 235, 142, 136, 217, 159, 193, 62, 11, 233, 38 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3809), new byte[] { 178, 148, 171, 232, 68, 104, 165, 255, 87, 52, 245, 27, 56, 39, 145, 14, 105, 197, 191, 239, 169, 111, 166, 38, 150, 248, 106, 159, 205, 63, 12, 204, 208, 60, 187, 30, 19, 148, 100, 166, 168, 115, 238, 201, 170, 75, 223, 88, 130, 176, 135, 39, 226, 26, 170, 86, 44, 33, 199, 75, 33, 167, 91, 12 }, new byte[] { 167, 28, 63, 231, 90, 240, 218, 50, 102, 24, 202, 136, 167, 104, 166, 116, 105, 132, 207, 16, 213, 104, 252, 59, 43, 187, 47, 226, 84, 95, 78, 172, 103, 130, 212, 106, 2, 154, 174, 121, 130, 5, 29, 148, 42, 97, 39, 186, 202, 98, 48, 180, 61, 136, 207, 206, 53, 89, 45, 87, 213, 208, 0, 252, 116, 39, 149, 161, 220, 50, 187, 173, 240, 147, 151, 158, 231, 255, 72, 220, 158, 2, 156, 30, 228, 227, 237, 243, 137, 156, 53, 80, 0, 59, 65, 172, 185, 236, 201, 151, 25, 3, 158, 208, 227, 240, 62, 3, 177, 121, 244, 39, 45, 52, 10, 238, 170, 202, 235, 142, 136, 217, 159, 193, 62, 11, 233, 38 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3811), new byte[] { 178, 148, 171, 232, 68, 104, 165, 255, 87, 52, 245, 27, 56, 39, 145, 14, 105, 197, 191, 239, 169, 111, 166, 38, 150, 248, 106, 159, 205, 63, 12, 204, 208, 60, 187, 30, 19, 148, 100, 166, 168, 115, 238, 201, 170, 75, 223, 88, 130, 176, 135, 39, 226, 26, 170, 86, 44, 33, 199, 75, 33, 167, 91, 12 }, new byte[] { 167, 28, 63, 231, 90, 240, 218, 50, 102, 24, 202, 136, 167, 104, 166, 116, 105, 132, 207, 16, 213, 104, 252, 59, 43, 187, 47, 226, 84, 95, 78, 172, 103, 130, 212, 106, 2, 154, 174, 121, 130, 5, 29, 148, 42, 97, 39, 186, 202, 98, 48, 180, 61, 136, 207, 206, 53, 89, 45, 87, 213, 208, 0, 252, 116, 39, 149, 161, 220, 50, 187, 173, 240, 147, 151, 158, 231, 255, 72, 220, 158, 2, 156, 30, 228, 227, 237, 243, 137, 156, 53, 80, 0, 59, 65, 172, 185, 236, 201, 151, 25, 3, 158, 208, 227, 240, 62, 3, 177, 121, 244, 39, 45, 52, 10, 238, 170, 202, 235, 142, 136, 217, 159, 193, 62, 11, 233, 38 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3812), new byte[] { 178, 148, 171, 232, 68, 104, 165, 255, 87, 52, 245, 27, 56, 39, 145, 14, 105, 197, 191, 239, 169, 111, 166, 38, 150, 248, 106, 159, 205, 63, 12, 204, 208, 60, 187, 30, 19, 148, 100, 166, 168, 115, 238, 201, 170, 75, 223, 88, 130, 176, 135, 39, 226, 26, 170, 86, 44, 33, 199, 75, 33, 167, 91, 12 }, new byte[] { 167, 28, 63, 231, 90, 240, 218, 50, 102, 24, 202, 136, 167, 104, 166, 116, 105, 132, 207, 16, 213, 104, 252, 59, 43, 187, 47, 226, 84, 95, 78, 172, 103, 130, 212, 106, 2, 154, 174, 121, 130, 5, 29, 148, 42, 97, 39, 186, 202, 98, 48, 180, 61, 136, 207, 206, 53, 89, 45, 87, 213, 208, 0, 252, 116, 39, 149, 161, 220, 50, 187, 173, 240, 147, 151, 158, 231, 255, 72, 220, 158, 2, 156, 30, 228, 227, 237, 243, 137, 156, 53, 80, 0, 59, 65, 172, 185, 236, 201, 151, 25, 3, 158, 208, 227, 240, 62, 3, 177, 121, 244, 39, 45, 52, 10, 238, 170, 202, 235, 142, 136, 217, 159, 193, 62, 11, 233, 38 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3814), new byte[] { 178, 148, 171, 232, 68, 104, 165, 255, 87, 52, 245, 27, 56, 39, 145, 14, 105, 197, 191, 239, 169, 111, 166, 38, 150, 248, 106, 159, 205, 63, 12, 204, 208, 60, 187, 30, 19, 148, 100, 166, 168, 115, 238, 201, 170, 75, 223, 88, 130, 176, 135, 39, 226, 26, 170, 86, 44, 33, 199, 75, 33, 167, 91, 12 }, new byte[] { 167, 28, 63, 231, 90, 240, 218, 50, 102, 24, 202, 136, 167, 104, 166, 116, 105, 132, 207, 16, 213, 104, 252, 59, 43, 187, 47, 226, 84, 95, 78, 172, 103, 130, 212, 106, 2, 154, 174, 121, 130, 5, 29, 148, 42, 97, 39, 186, 202, 98, 48, 180, 61, 136, 207, 206, 53, 89, 45, 87, 213, 208, 0, 252, 116, 39, 149, 161, 220, 50, 187, 173, 240, 147, 151, 158, 231, 255, 72, 220, 158, 2, 156, 30, 228, 227, 237, 243, 137, 156, 53, 80, 0, 59, 65, 172, 185, 236, 201, 151, 25, 3, 158, 208, 227, 240, 62, 3, 177, 121, 244, 39, 45, 52, 10, 238, 170, 202, 235, 142, 136, 217, 159, 193, 62, 11, 233, 38 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3815), new byte[] { 178, 148, 171, 232, 68, 104, 165, 255, 87, 52, 245, 27, 56, 39, 145, 14, 105, 197, 191, 239, 169, 111, 166, 38, 150, 248, 106, 159, 205, 63, 12, 204, 208, 60, 187, 30, 19, 148, 100, 166, 168, 115, 238, 201, 170, 75, 223, 88, 130, 176, 135, 39, 226, 26, 170, 86, 44, 33, 199, 75, 33, 167, 91, 12 }, new byte[] { 167, 28, 63, 231, 90, 240, 218, 50, 102, 24, 202, 136, 167, 104, 166, 116, 105, 132, 207, 16, 213, 104, 252, 59, 43, 187, 47, 226, 84, 95, 78, 172, 103, 130, 212, 106, 2, 154, 174, 121, 130, 5, 29, 148, 42, 97, 39, 186, 202, 98, 48, 180, 61, 136, 207, 206, 53, 89, 45, 87, 213, 208, 0, 252, 116, 39, 149, 161, 220, 50, 187, 173, 240, 147, 151, 158, 231, 255, 72, 220, 158, 2, 156, 30, 228, 227, 237, 243, 137, 156, 53, 80, 0, 59, 65, 172, 185, 236, 201, 151, 25, 3, 158, 208, 227, 240, 62, 3, 177, 121, 244, 39, 45, 52, 10, 238, 170, 202, 235, 142, 136, 217, 159, 193, 62, 11, 233, 38 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3817), new byte[] { 178, 148, 171, 232, 68, 104, 165, 255, 87, 52, 245, 27, 56, 39, 145, 14, 105, 197, 191, 239, 169, 111, 166, 38, 150, 248, 106, 159, 205, 63, 12, 204, 208, 60, 187, 30, 19, 148, 100, 166, 168, 115, 238, 201, 170, 75, 223, 88, 130, 176, 135, 39, 226, 26, 170, 86, 44, 33, 199, 75, 33, 167, 91, 12 }, new byte[] { 167, 28, 63, 231, 90, 240, 218, 50, 102, 24, 202, 136, 167, 104, 166, 116, 105, 132, 207, 16, 213, 104, 252, 59, 43, 187, 47, 226, 84, 95, 78, 172, 103, 130, 212, 106, 2, 154, 174, 121, 130, 5, 29, 148, 42, 97, 39, 186, 202, 98, 48, 180, 61, 136, 207, 206, 53, 89, 45, 87, 213, 208, 0, 252, 116, 39, 149, 161, 220, 50, 187, 173, 240, 147, 151, 158, 231, 255, 72, 220, 158, 2, 156, 30, 228, 227, 237, 243, 137, 156, 53, 80, 0, 59, 65, 172, 185, 236, 201, 151, 25, 3, 158, 208, 227, 240, 62, 3, 177, 121, 244, 39, 45, 52, 10, 238, 170, 202, 235, 142, 136, 217, 159, 193, 62, 11, 233, 38 } });
        }
    }
}
