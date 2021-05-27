using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExaminationSystem.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "VARBINARY(500)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserExams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    AnswerSheet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserExams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserExams_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserExams_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserOperationClaims",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    OperationClaimId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserOperationClaims", x => new { x.UserId, x.OperationClaimId });
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_OperationClaims_OperationClaimId",
                        column: x => x.OperationClaimId,
                        principalTable: "OperationClaims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserOperationClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Choices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correct = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Choices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Choices_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Yönetici" },
                    { 2, "Öğrenci" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Status" },
                values: new object[,]
                {
                    { 2, "meral@gmail.com", "Meral", "Taşdemir", new byte[] { 194, 235, 176, 64, 44, 213, 99, 231, 66, 184, 19, 128, 73, 201, 201, 193, 5, 169, 61, 24, 157, 68, 144, 168, 125, 255, 232, 87, 146, 9, 177, 98, 48, 204, 178, 130, 239, 135, 124, 154, 32, 85, 96, 200, 172, 127, 144, 60, 48, 241, 117, 139, 189, 206, 252, 92, 126, 231, 86, 86, 32, 87, 118, 24 }, new byte[] { 206, 90, 177, 53, 97, 156, 201, 162, 189, 110, 18, 67, 53, 70, 216, 113, 146, 143, 179, 242, 140, 34, 63, 232, 127, 89, 11, 91, 132, 252, 75, 226, 164, 40, 158, 130, 96, 59, 166, 123, 26, 107, 182, 140, 27, 255, 234, 7, 231, 186, 186, 174, 57, 194, 141, 83, 142, 199, 231, 48, 97, 217, 24, 101, 254, 196, 168, 120, 113, 82, 119, 28, 124, 84, 233, 66, 139, 35, 155, 195, 232, 148, 201, 218, 222, 244, 54, 67, 162, 193, 50, 228, 110, 128, 201, 161, 111, 60, 236, 81, 38, 139, 83, 177, 228, 5, 29, 182, 93, 153, 249, 134, 96, 186, 122, 103, 67, 39, 190, 224, 29, 84, 122, 196, 132, 26, 10, 160 }, false },
                    { 1, "fikret@gmail.com", "Fikret", "Yeşilyayla", new byte[] { 91, 5, 224, 205, 85, 182, 78, 37, 135, 138, 42, 193, 166, 234, 143, 255, 64, 222, 105, 251, 26, 222, 254, 161, 69, 85, 245, 50, 34, 19, 136, 117, 166, 40, 239, 181, 241, 90, 62, 26, 55, 142, 170, 0, 58, 29, 255, 78, 227, 7, 116, 213, 33, 200, 138, 176, 160, 67, 0, 221, 78, 192, 165, 116 }, new byte[] { 43, 184, 60, 35, 4, 89, 223, 134, 38, 144, 237, 165, 46, 179, 192, 154, 145, 127, 46, 135, 94, 110, 195, 13, 248, 235, 200, 13, 234, 234, 97, 94, 186, 10, 79, 239, 202, 225, 192, 111, 150, 144, 227, 205, 173, 209, 229, 62, 31, 89, 115, 71, 31, 214, 52, 117, 210, 232, 152, 201, 246, 196, 20, 65, 56, 103, 196, 246, 222, 88, 179, 109, 92, 244, 15, 67, 151, 228, 18, 17, 151, 178, 36, 230, 77, 81, 230, 7, 111, 172, 103, 171, 161, 211, 199, 159, 227, 67, 208, 149, 201, 242, 12, 20, 170, 42, 232, 30, 136, 194, 220, 6, 35, 222, 223, 29, 182, 129, 88, 110, 65, 146, 251, 93, 105, 67, 142, 144 }, false }
                });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "OperationClaimId", "UserId", "Id" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "OperationClaimId", "UserId", "Id" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Choices_QuestionId",
                table: "Choices",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ExamId",
                table: "Questions",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExams_ExamId",
                table: "UserExams",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExams_UserId",
                table: "UserExams",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserOperationClaims_OperationClaimId",
                table: "UserOperationClaims",
                column: "OperationClaimId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Choices");

            migrationBuilder.DropTable(
                name: "UserExams");

            migrationBuilder.DropTable(
                name: "UserOperationClaims");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "OperationClaims");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Exams");
        }
    }
}
