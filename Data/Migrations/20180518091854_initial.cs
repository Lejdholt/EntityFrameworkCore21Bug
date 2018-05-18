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
                    Prop1 = table.Column<bool>(nullable: false),
                    Prop1Source = table.Column<string>(nullable: true),
                    Prop2 = table.Column<DateTime>(nullable: false),
                    Prop2Source = table.Column<string>(nullable: true),
                    Prop3 = table.Column<DateTime>(nullable: false),
                    Prop3Source = table.Column<string>(nullable: true),
                    Prop4 = table.Column<double>(nullable: false),
                    Prop4Source = table.Column<string>(nullable: true),
                    Prop5 = table.Column<double>(nullable: false),
                    Prop5Source = table.Column<string>(nullable: true),
                    Prop6 = table.Column<int>(nullable: false),
                    Prop6Source = table.Column<string>(nullable: true),
                    Prop7 = table.Column<DateTime>(nullable: false),
                    Prop7Source = table.Column<string>(nullable: true),
                    Prop8 = table.Column<decimal>(nullable: false),
                    Prop8Source = table.Column<string>(nullable: true),
                    Prop9 = table.Column<double>(nullable: false),
                    Prop9Source = table.Column<string>(nullable: true),
                    Prop10 = table.Column<decimal>(nullable: false),
                    Prop10Source = table.Column<string>(nullable: true),
                    Prop11 = table.Column<int>(nullable: false),
                    Prop11Source = table.Column<string>(nullable: true),
                    Prop12 = table.Column<double>(nullable: false),
                    Prop12Source = table.Column<string>(nullable: true),
                    Prop13 = table.Column<decimal>(nullable: false),
                    Prop13Source = table.Column<decimal>(nullable: false),
                    Prop14 = table.Column<int>(nullable: false),
                    Prop14Source = table.Column<string>(nullable: true),
                    Prop15 = table.Column<DateTime>(nullable: false),
                    Prop15Source = table.Column<string>(nullable: true),
                    Prop16 = table.Column<decimal>(nullable: false),
                    Prop16Source = table.Column<string>(nullable: true),
                    Prop17 = table.Column<DateTime>(nullable: false),
                    Prop17Source = table.Column<string>(nullable: true),
                    Prop18 = table.Column<double>(nullable: false),
                    Prop18Source = table.Column<string>(nullable: true),
                    Prop19 = table.Column<DateTime>(nullable: false),
                    Prop19Source = table.Column<string>(nullable: true),
                    Prop20 = table.Column<DateTime>(nullable: false),
                    Prop20Source = table.Column<string>(nullable: true)
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
                    Prop1 = table.Column<bool>(nullable: false),
                    Prop1Source = table.Column<string>(nullable: true),
                    Prop2 = table.Column<DateTime>(nullable: false),
                    Prop2Source = table.Column<string>(nullable: true),
                    Prop3 = table.Column<DateTime>(nullable: false),
                    Prop3Source = table.Column<string>(nullable: true),
                    Prop4 = table.Column<double>(nullable: false),
                    Prop4Source = table.Column<string>(nullable: true),
                    Prop5 = table.Column<double>(nullable: false),
                    Prop5Source = table.Column<string>(nullable: true),
                    Prop6 = table.Column<int>(nullable: false),
                    Prop6Source = table.Column<string>(nullable: true),
                    Prop7 = table.Column<DateTime>(nullable: false),
                    Prop7Source = table.Column<string>(nullable: true),
                    Prop8 = table.Column<decimal>(nullable: false),
                    Prop8Source = table.Column<string>(nullable: true),
                    Prop9 = table.Column<double>(nullable: false),
                    Prop9Source = table.Column<string>(nullable: true),
                    Prop10 = table.Column<decimal>(nullable: false),
                    Prop10Source = table.Column<string>(nullable: true),
                    Prop11 = table.Column<int>(nullable: false),
                    Prop11Source = table.Column<string>(nullable: true),
                    Prop12 = table.Column<double>(nullable: false),
                    Prop12Source = table.Column<string>(nullable: true),
                    Prop13 = table.Column<decimal>(nullable: false),
                    Prop13Source = table.Column<decimal>(nullable: false),
                    Prop14 = table.Column<int>(nullable: false),
                    Prop14Source = table.Column<string>(nullable: true),
                    Prop15 = table.Column<DateTime>(nullable: false),
                    Prop15Source = table.Column<string>(nullable: true),
                    Prop16 = table.Column<decimal>(nullable: false),
                    Prop16Source = table.Column<string>(nullable: true),
                    Prop17 = table.Column<DateTime>(nullable: false),
                    Prop17Source = table.Column<string>(nullable: true),
                    Prop18 = table.Column<double>(nullable: false),
                    Prop18Source = table.Column<string>(nullable: true),
                    Prop19 = table.Column<DateTime>(nullable: false),
                    Prop19Source = table.Column<string>(nullable: true),
                    Prop20 = table.Column<DateTime>(nullable: false),
                    Prop20Source = table.Column<string>(nullable: true)
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
                    Prop1 = table.Column<bool>(nullable: false),
                    Prop1Source = table.Column<string>(nullable: true),
                    Prop2 = table.Column<DateTime>(nullable: false),
                    Prop2Source = table.Column<string>(nullable: true),
                    Prop3 = table.Column<DateTime>(nullable: false),
                    Prop3Source = table.Column<string>(nullable: true),
                    Prop4 = table.Column<double>(nullable: false),
                    Prop4Source = table.Column<string>(nullable: true),
                    Prop5 = table.Column<double>(nullable: false),
                    Prop5Source = table.Column<string>(nullable: true),
                    Prop6 = table.Column<int>(nullable: false),
                    Prop6Source = table.Column<string>(nullable: true),
                    Prop7 = table.Column<DateTime>(nullable: false),
                    Prop7Source = table.Column<string>(nullable: true),
                    Prop8 = table.Column<decimal>(nullable: false),
                    Prop8Source = table.Column<string>(nullable: true),
                    Prop9 = table.Column<double>(nullable: false),
                    Prop9Source = table.Column<string>(nullable: true),
                    Prop10 = table.Column<decimal>(nullable: false),
                    Prop10Source = table.Column<string>(nullable: true),
                    Prop11 = table.Column<int>(nullable: false),
                    Prop11Source = table.Column<string>(nullable: true),
                    Prop12 = table.Column<double>(nullable: false),
                    Prop12Source = table.Column<string>(nullable: true),
                    Prop13 = table.Column<decimal>(nullable: false),
                    Prop13Source = table.Column<decimal>(nullable: false),
                    Prop14 = table.Column<int>(nullable: false),
                    Prop14Source = table.Column<string>(nullable: true),
                    Prop15 = table.Column<DateTime>(nullable: false),
                    Prop15Source = table.Column<string>(nullable: true),
                    Prop16 = table.Column<decimal>(nullable: false),
                    Prop16Source = table.Column<string>(nullable: true),
                    Prop17 = table.Column<DateTime>(nullable: false),
                    Prop17Source = table.Column<string>(nullable: true),
                    Prop18 = table.Column<double>(nullable: false),
                    Prop18Source = table.Column<string>(nullable: true),
                    Prop19 = table.Column<DateTime>(nullable: false),
                    Prop19Source = table.Column<string>(nullable: true),
                    Prop20 = table.Column<DateTime>(nullable: false),
                    Prop20Source = table.Column<string>(nullable: true)
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
