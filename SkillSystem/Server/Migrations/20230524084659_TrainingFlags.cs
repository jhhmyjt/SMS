﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SkillSystem.Server.Migrations
{
    /// <inheritdoc />
    public partial class TrainingFlags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Finished",
                table: "Training",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Going",
                table: "Training",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Registering",
                table: "Training",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Training",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "EndTime", "Finished", "Going", "Registering", "StartTime", "Visible" },
                values: new object[] { new DateTime(2023, 6, 30, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3551), false, false, false, new DateTime(2023, 5, 31, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3546), true });

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "Finished", "Going", "Registering", "StartTime", "Visible" },
                values: new object[] { new DateTime(2023, 11, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3556), false, false, false, new DateTime(2023, 8, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3553), true });

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "Finished", "Going", "Registering", "StartTime", "Visible" },
                values: new object[] { new DateTime(2023, 10, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3558), false, false, false, new DateTime(2023, 7, 24, 16, 46, 59, 799, DateTimeKind.Local).AddTicks(3558), true });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Finished",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "Going",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "Registering",
                table: "Training");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Training");

            migrationBuilder.UpdateData(
                table: "SkillLicenses",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, 9 },
                column: "GetTime",
                value: new DateTime(2023, 5, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "SkillLicenses",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, 9 },
                column: "GetTime",
                value: new DateTime(2023, 5, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 6, 30, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5286), new DateTime(2023, 5, 31, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 11, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5290), new DateTime(2023, 8, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5288) });

            migrationBuilder.UpdateData(
                table: "Training",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5323), new DateTime(2023, 7, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5572), new byte[] { 94, 202, 76, 156, 222, 145, 87, 148, 8, 205, 190, 140, 109, 155, 227, 108, 59, 141, 249, 227, 109, 146, 23, 64, 176, 249, 57, 62, 113, 118, 21, 109, 37, 4, 70, 172, 53, 37, 237, 20, 46, 46, 172, 251, 205, 56, 114, 177, 251, 136, 205, 167, 237, 141, 58, 182, 11, 16, 229, 42, 183, 93, 121, 42 }, new byte[] { 81, 235, 100, 190, 135, 92, 182, 83, 83, 226, 198, 45, 41, 186, 130, 39, 136, 150, 217, 231, 223, 190, 151, 19, 109, 183, 7, 151, 193, 197, 219, 161, 0, 5, 143, 89, 194, 232, 41, 68, 194, 172, 74, 149, 40, 93, 102, 72, 105, 230, 167, 211, 111, 251, 49, 60, 63, 0, 41, 134, 123, 81, 230, 67, 110, 143, 13, 113, 18, 144, 75, 167, 72, 99, 116, 17, 98, 93, 177, 10, 239, 249, 71, 83, 234, 181, 138, 199, 91, 229, 105, 112, 193, 188, 49, 32, 159, 108, 43, 178, 11, 127, 166, 1, 148, 175, 49, 235, 144, 67, 18, 205, 204, 240, 227, 106, 158, 46, 142, 21, 64, 185, 189, 229, 25, 84, 166, 79 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5574), new byte[] { 94, 202, 76, 156, 222, 145, 87, 148, 8, 205, 190, 140, 109, 155, 227, 108, 59, 141, 249, 227, 109, 146, 23, 64, 176, 249, 57, 62, 113, 118, 21, 109, 37, 4, 70, 172, 53, 37, 237, 20, 46, 46, 172, 251, 205, 56, 114, 177, 251, 136, 205, 167, 237, 141, 58, 182, 11, 16, 229, 42, 183, 93, 121, 42 }, new byte[] { 81, 235, 100, 190, 135, 92, 182, 83, 83, 226, 198, 45, 41, 186, 130, 39, 136, 150, 217, 231, 223, 190, 151, 19, 109, 183, 7, 151, 193, 197, 219, 161, 0, 5, 143, 89, 194, 232, 41, 68, 194, 172, 74, 149, 40, 93, 102, 72, 105, 230, 167, 211, 111, 251, 49, 60, 63, 0, 41, 134, 123, 81, 230, 67, 110, 143, 13, 113, 18, 144, 75, 167, 72, 99, 116, 17, 98, 93, 177, 10, 239, 249, 71, 83, 234, 181, 138, 199, 91, 229, 105, 112, 193, 188, 49, 32, 159, 108, 43, 178, 11, 127, 166, 1, 148, 175, 49, 235, 144, 67, 18, 205, 204, 240, 227, 106, 158, 46, 142, 21, 64, 185, 189, 229, 25, 84, 166, 79 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5576), new byte[] { 94, 202, 76, 156, 222, 145, 87, 148, 8, 205, 190, 140, 109, 155, 227, 108, 59, 141, 249, 227, 109, 146, 23, 64, 176, 249, 57, 62, 113, 118, 21, 109, 37, 4, 70, 172, 53, 37, 237, 20, 46, 46, 172, 251, 205, 56, 114, 177, 251, 136, 205, 167, 237, 141, 58, 182, 11, 16, 229, 42, 183, 93, 121, 42 }, new byte[] { 81, 235, 100, 190, 135, 92, 182, 83, 83, 226, 198, 45, 41, 186, 130, 39, 136, 150, 217, 231, 223, 190, 151, 19, 109, 183, 7, 151, 193, 197, 219, 161, 0, 5, 143, 89, 194, 232, 41, 68, 194, 172, 74, 149, 40, 93, 102, 72, 105, 230, 167, 211, 111, 251, 49, 60, 63, 0, 41, 134, 123, 81, 230, 67, 110, 143, 13, 113, 18, 144, 75, 167, 72, 99, 116, 17, 98, 93, 177, 10, 239, 249, 71, 83, 234, 181, 138, 199, 91, 229, 105, 112, 193, 188, 49, 32, 159, 108, 43, 178, 11, 127, 166, 1, 148, 175, 49, 235, 144, 67, 18, 205, 204, 240, 227, 106, 158, 46, 142, 21, 64, 185, 189, 229, 25, 84, 166, 79 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5578), new byte[] { 94, 202, 76, 156, 222, 145, 87, 148, 8, 205, 190, 140, 109, 155, 227, 108, 59, 141, 249, 227, 109, 146, 23, 64, 176, 249, 57, 62, 113, 118, 21, 109, 37, 4, 70, 172, 53, 37, 237, 20, 46, 46, 172, 251, 205, 56, 114, 177, 251, 136, 205, 167, 237, 141, 58, 182, 11, 16, 229, 42, 183, 93, 121, 42 }, new byte[] { 81, 235, 100, 190, 135, 92, 182, 83, 83, 226, 198, 45, 41, 186, 130, 39, 136, 150, 217, 231, 223, 190, 151, 19, 109, 183, 7, 151, 193, 197, 219, 161, 0, 5, 143, 89, 194, 232, 41, 68, 194, 172, 74, 149, 40, 93, 102, 72, 105, 230, 167, 211, 111, 251, 49, 60, 63, 0, 41, 134, 123, 81, 230, 67, 110, 143, 13, 113, 18, 144, 75, 167, 72, 99, 116, 17, 98, 93, 177, 10, 239, 249, 71, 83, 234, 181, 138, 199, 91, 229, 105, 112, 193, 188, 49, 32, 159, 108, 43, 178, 11, 127, 166, 1, 148, 175, 49, 235, 144, 67, 18, 205, 204, 240, 227, 106, 158, 46, 142, 21, 64, 185, 189, 229, 25, 84, 166, 79 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5579), new byte[] { 94, 202, 76, 156, 222, 145, 87, 148, 8, 205, 190, 140, 109, 155, 227, 108, 59, 141, 249, 227, 109, 146, 23, 64, 176, 249, 57, 62, 113, 118, 21, 109, 37, 4, 70, 172, 53, 37, 237, 20, 46, 46, 172, 251, 205, 56, 114, 177, 251, 136, 205, 167, 237, 141, 58, 182, 11, 16, 229, 42, 183, 93, 121, 42 }, new byte[] { 81, 235, 100, 190, 135, 92, 182, 83, 83, 226, 198, 45, 41, 186, 130, 39, 136, 150, 217, 231, 223, 190, 151, 19, 109, 183, 7, 151, 193, 197, 219, 161, 0, 5, 143, 89, 194, 232, 41, 68, 194, 172, 74, 149, 40, 93, 102, 72, 105, 230, 167, 211, 111, 251, 49, 60, 63, 0, 41, 134, 123, 81, 230, 67, 110, 143, 13, 113, 18, 144, 75, 167, 72, 99, 116, 17, 98, 93, 177, 10, 239, 249, 71, 83, 234, 181, 138, 199, 91, 229, 105, 112, 193, 188, 49, 32, 159, 108, 43, 178, 11, 127, 166, 1, 148, 175, 49, 235, 144, 67, 18, 205, 204, 240, 227, 106, 158, 46, 142, 21, 64, 185, 189, 229, 25, 84, 166, 79 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5581), new byte[] { 94, 202, 76, 156, 222, 145, 87, 148, 8, 205, 190, 140, 109, 155, 227, 108, 59, 141, 249, 227, 109, 146, 23, 64, 176, 249, 57, 62, 113, 118, 21, 109, 37, 4, 70, 172, 53, 37, 237, 20, 46, 46, 172, 251, 205, 56, 114, 177, 251, 136, 205, 167, 237, 141, 58, 182, 11, 16, 229, 42, 183, 93, 121, 42 }, new byte[] { 81, 235, 100, 190, 135, 92, 182, 83, 83, 226, 198, 45, 41, 186, 130, 39, 136, 150, 217, 231, 223, 190, 151, 19, 109, 183, 7, 151, 193, 197, 219, 161, 0, 5, 143, 89, 194, 232, 41, 68, 194, 172, 74, 149, 40, 93, 102, 72, 105, 230, 167, 211, 111, 251, 49, 60, 63, 0, 41, 134, 123, 81, 230, 67, 110, 143, 13, 113, 18, 144, 75, 167, 72, 99, 116, 17, 98, 93, 177, 10, 239, 249, 71, 83, 234, 181, 138, 199, 91, 229, 105, 112, 193, 188, 49, 32, 159, 108, 43, 178, 11, 127, 166, 1, 148, 175, 49, 235, 144, 67, 18, 205, 204, 240, 227, 106, 158, 46, 142, 21, 64, 185, 189, 229, 25, 84, 166, 79 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5582), new byte[] { 94, 202, 76, 156, 222, 145, 87, 148, 8, 205, 190, 140, 109, 155, 227, 108, 59, 141, 249, 227, 109, 146, 23, 64, 176, 249, 57, 62, 113, 118, 21, 109, 37, 4, 70, 172, 53, 37, 237, 20, 46, 46, 172, 251, 205, 56, 114, 177, 251, 136, 205, 167, 237, 141, 58, 182, 11, 16, 229, 42, 183, 93, 121, 42 }, new byte[] { 81, 235, 100, 190, 135, 92, 182, 83, 83, 226, 198, 45, 41, 186, 130, 39, 136, 150, 217, 231, 223, 190, 151, 19, 109, 183, 7, 151, 193, 197, 219, 161, 0, 5, 143, 89, 194, 232, 41, 68, 194, 172, 74, 149, 40, 93, 102, 72, 105, 230, 167, 211, 111, 251, 49, 60, 63, 0, 41, 134, 123, 81, 230, 67, 110, 143, 13, 113, 18, 144, 75, 167, 72, 99, 116, 17, 98, 93, 177, 10, 239, 249, 71, 83, 234, 181, 138, 199, 91, 229, 105, 112, 193, 188, 49, 32, 159, 108, 43, 178, 11, 127, 166, 1, 148, 175, 49, 235, 144, 67, 18, 205, 204, 240, 227, 106, 158, 46, 142, 21, 64, 185, 189, 229, 25, 84, 166, 79 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5584), new byte[] { 94, 202, 76, 156, 222, 145, 87, 148, 8, 205, 190, 140, 109, 155, 227, 108, 59, 141, 249, 227, 109, 146, 23, 64, 176, 249, 57, 62, 113, 118, 21, 109, 37, 4, 70, 172, 53, 37, 237, 20, 46, 46, 172, 251, 205, 56, 114, 177, 251, 136, 205, 167, 237, 141, 58, 182, 11, 16, 229, 42, 183, 93, 121, 42 }, new byte[] { 81, 235, 100, 190, 135, 92, 182, 83, 83, 226, 198, 45, 41, 186, 130, 39, 136, 150, 217, 231, 223, 190, 151, 19, 109, 183, 7, 151, 193, 197, 219, 161, 0, 5, 143, 89, 194, 232, 41, 68, 194, 172, 74, 149, 40, 93, 102, 72, 105, 230, 167, 211, 111, 251, 49, 60, 63, 0, 41, 134, 123, 81, 230, 67, 110, 143, 13, 113, 18, 144, 75, 167, 72, 99, 116, 17, 98, 93, 177, 10, 239, 249, 71, 83, 234, 181, 138, 199, 91, 229, 105, 112, 193, 188, 49, 32, 159, 108, 43, 178, 11, 127, 166, 1, 148, 175, 49, 235, 144, 67, 18, 205, 204, 240, 227, 106, 158, 46, 142, 21, 64, 185, 189, 229, 25, 84, 166, 79 } });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateCreated", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2023, 5, 24, 15, 35, 11, 151, DateTimeKind.Local).AddTicks(5585), new byte[] { 94, 202, 76, 156, 222, 145, 87, 148, 8, 205, 190, 140, 109, 155, 227, 108, 59, 141, 249, 227, 109, 146, 23, 64, 176, 249, 57, 62, 113, 118, 21, 109, 37, 4, 70, 172, 53, 37, 237, 20, 46, 46, 172, 251, 205, 56, 114, 177, 251, 136, 205, 167, 237, 141, 58, 182, 11, 16, 229, 42, 183, 93, 121, 42 }, new byte[] { 81, 235, 100, 190, 135, 92, 182, 83, 83, 226, 198, 45, 41, 186, 130, 39, 136, 150, 217, 231, 223, 190, 151, 19, 109, 183, 7, 151, 193, 197, 219, 161, 0, 5, 143, 89, 194, 232, 41, 68, 194, 172, 74, 149, 40, 93, 102, 72, 105, 230, 167, 211, 111, 251, 49, 60, 63, 0, 41, 134, 123, 81, 230, 67, 110, 143, 13, 113, 18, 144, 75, 167, 72, 99, 116, 17, 98, 93, 177, 10, 239, 249, 71, 83, 234, 181, 138, 199, 91, 229, 105, 112, 193, 188, 49, 32, 159, 108, 43, 178, 11, 127, 166, 1, 148, 175, 49, 235, 144, 67, 18, 205, 204, 240, 227, 106, 158, 46, 142, 21, 64, 185, 189, 229, 25, 84, 166, 79 } });
        }
    }
}
