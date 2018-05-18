using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Data1s",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntityId = table.Column<Guid>(nullable: false),
                    Prop1_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop1 = table.Column<bool>(nullable: true),
                    Prop2_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop3_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop3 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop4_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop4 = table.Column<double>(nullable: true),
                    Prop5_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop5 = table.Column<double>(nullable: true),
                    Prop6_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop6 = table.Column<int>(nullable: true),
                    Prop7_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop7 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop8_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop8 = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop9_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop9 = table.Column<double>(nullable: true),
                    Prop10_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop10 = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop11_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop11 = table.Column<int>(nullable: true),
                    Prop12_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop12 = table.Column<double>(nullable: true),
                    Prop13_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop13 = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop14_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop14 = table.Column<int>(nullable: true),
                    Prop15_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop15 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop16_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop16 = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop17_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop17 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop18_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop18 = table.Column<double>(nullable: true),
                    Prop19_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop19 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop20_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop20 = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Data2s",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntityId = table.Column<Guid>(nullable: false),
                    Prop1_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop1 = table.Column<bool>(nullable: true),
                    Prop2_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop3_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop3 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop4_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop4 = table.Column<double>(nullable: true),
                    Prop5_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop5 = table.Column<double>(nullable: true),
                    Prop6_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop6 = table.Column<int>(nullable: true),
                    Prop7_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop7 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop8_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop8 = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop9_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop9 = table.Column<double>(nullable: true),
                    Prop10_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop10 = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop11_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop11 = table.Column<int>(nullable: true),
                    Prop12_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop12 = table.Column<double>(nullable: true),
                    Prop13_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop13 = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop14_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop14 = table.Column<int>(nullable: true),
                    Prop15_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop15 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop16_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop16 = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop17_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop17 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop18_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop18 = table.Column<double>(nullable: true),
                    Prop19_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop19 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop20_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop20 = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Data3s",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EntityId = table.Column<Guid>(nullable: false),
                    Prop1_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop1 = table.Column<bool>(nullable: true),
                    Prop2_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop2 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop3_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop3 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop4_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop4 = table.Column<double>(nullable: true),
                    Prop5_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop5 = table.Column<double>(nullable: true),
                    Prop6_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop6 = table.Column<int>(nullable: true),
                    Prop7_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop7 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop8_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop8 = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop9_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop9 = table.Column<double>(nullable: true),
                    Prop10_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop10 = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop11_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop11 = table.Column<int>(nullable: true),
                    Prop12_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop12 = table.Column<double>(nullable: true),
                    Prop13_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop13 = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop14_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop14 = table.Column<int>(nullable: true),
                    Prop15_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop15 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop16_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop16 = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop17_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop17 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop18_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop18 = table.Column<double>(nullable: true),
                    Prop19_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop19 = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop20_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop20 = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Data3s", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Data1s");

            migrationBuilder.DropTable(
                name: "Data2s");

            migrationBuilder.DropTable(
                name: "Data3s");
        }
    }
}
