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
                    Prop1_Value = table.Column<bool>(nullable: true),
                    Prop2_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop2_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop3_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop3_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop4_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop4_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop5_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop5_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop6_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop6_Value = table.Column<int>(nullable: true),
                    Prop7_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop7_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop8_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop8_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop9_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop9_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop10_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop10_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop11_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop11_Value = table.Column<int>(nullable: true),
                    Prop12_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop12_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop13_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop13_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop14_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop14_Value = table.Column<int>(nullable: true),
                    Prop15_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop15_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop16_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop16_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop17_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop17_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop18_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop18_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop19_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop19_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop20_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop20_Value = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Prop1_Value = table.Column<bool>(nullable: true),
                    Prop2_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop2_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop3_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop3_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop4_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop4_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop5_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop5_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop6_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop6_Value = table.Column<int>(nullable: true),
                    Prop7_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop7_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop8_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop8_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop9_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop9_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop10_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop10_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop11_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop11_Value = table.Column<int>(nullable: true),
                    Prop12_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop12_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop13_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop13_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop14_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop14_Value = table.Column<int>(nullable: true),
                    Prop15_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop15_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop16_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop16_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop17_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop17_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop18_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop18_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop19_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop19_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop20_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop20_Value = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Prop1_Value = table.Column<bool>(nullable: true),
                    Prop2_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop2_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop3_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop3_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop4_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop4_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop5_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop5_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop6_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop6_Value = table.Column<int>(nullable: true),
                    Prop7_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop7_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop8_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop8_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop9_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop9_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop10_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop10_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop11_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop11_Value = table.Column<int>(nullable: true),
                    Prop12_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop12_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop13_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop13_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop14_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop14_Value = table.Column<int>(nullable: true),
                    Prop15_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop15_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop16_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop16_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop17_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop17_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop18_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop18_Value = table.Column<decimal>(type: "decimal(32,12)", nullable: true),
                    Prop19_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop19_Value = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Prop20_Source = table.Column<string>(maxLength: 64, nullable: true),
                    Prop20_Value = table.Column<DateTime>(type: "datetime2", nullable: true)
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
