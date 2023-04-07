using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectSem3.Migrations
{
    /// <inheritdoc />
    public partial class MyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Account__3214EC27513CAE23", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Levers = table.Column<int>(type: "int", nullable: false),
                    Following = table.Column<double>(type: "float", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Category__3214EC2775695532", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Company__3214EC2785F75863", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Interview",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inter_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Static = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Intervie__3214EC270814A06A", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Candidate",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Literacy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Majors = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Graduate = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Vacancy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Candidat__3214EC2775A18902", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Candidate__Accou__398D8EEE",
                        column: x => x.AccountID,
                        principalTable: "Account",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Wage = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Date_create = table.Column<DateTime>(type: "date", nullable: false),
                    Modification = table.Column<DateTime>(type: "date", nullable: true),
                    Job_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vacancy = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CatID = table.Column<int>(type: "int", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Job__3214EC27E8E9D3A6", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Job__CatID__4222D4EF",
                        column: x => x.CatID,
                        principalTable: "Category",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Job__CompanyID__4316F928",
                        column: x => x.CompanyID,
                        principalTable: "Company",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Candidate_list",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    job_id = table.Column<int>(type: "int", nullable: true),
                    can_id = table.Column<int>(type: "int", nullable: true),
                    Interview_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Candidat__3214EC2768185F00", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Candidate__Inter__47DBAE45",
                        column: x => x.Interview_id,
                        principalTable: "Interview",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Candidate__can_i__46E78A0C",
                        column: x => x.can_id,
                        principalTable: "Candidate",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK__Candidate__job_i__45F365D3",
                        column: x => x.job_id,
                        principalTable: "Job",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_AccountID",
                table: "Candidate",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_list_can_id",
                table: "Candidate_list",
                column: "can_id");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_list_Interview_id",
                table: "Candidate_list",
                column: "Interview_id");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_list_job_id",
                table: "Candidate_list",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "IX_Job_CatID",
                table: "Job",
                column: "CatID");

            migrationBuilder.CreateIndex(
                name: "IX_Job_CompanyID",
                table: "Job",
                column: "CompanyID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidate_list");

            migrationBuilder.DropTable(
                name: "Interview");

            migrationBuilder.DropTable(
                name: "Candidate");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
