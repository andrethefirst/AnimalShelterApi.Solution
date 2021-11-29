using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Type = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Species = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Size = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Gender", "Name", "Size", "Species", "Type" },
                values: new object[,]
                {
                    { 1, "Male", "Zeus", "Large", "German Shepherd", "Dog" },
                    { 2, "Male", "Poseidon", "Large", "Rottweiler", "Dog" },
                    { 3, "Male", "Hades", "Large", "Doberman", "Dog" },
                    { 4, "Female", "Jones", "Tiny", "Chihuahua", "Dog" },
                    { 5, "Female", "Rose", "Medium", "Bulldog", "Dog" },
                    { 6, "Female", "Swift", "Tiny", "Persian", "Cat" },
                    { 7, "Male", "Bonkers", "Tiny", "Siamese", "Cat" },
                    { 8, "Female", "Jordan", "Tiny", "Siberian", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
