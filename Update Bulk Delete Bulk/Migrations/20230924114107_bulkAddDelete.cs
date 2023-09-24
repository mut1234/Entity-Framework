using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Update_Bulk_Delete_Bulk.Migrations
{
    /// <inheritdoc />
    public partial class bulkAddDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Email", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, "Ahmad3223@gmail.com", false, "Ahmad" },
                    { 2, "Ali3323@gmail.com", false, "Ali" },
                    { 3, "Yaser4323@gmail.com", false, "Yaser" },
                    { 4, "khaled4323@gmail.com", false, "khaled" },
                    { 5, "mhmod4323@gmail.com", false, "mhmod" },
                    { 6, "mustafa4323@gmail.com", false, "mustafa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
