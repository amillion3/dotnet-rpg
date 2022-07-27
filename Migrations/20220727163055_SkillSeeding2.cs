using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_rpg.Migrations
{
    public partial class SkillSeeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSkill_SKills_SkillsId",
                table: "CharacterSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SKills",
                table: "SKills");

            migrationBuilder.RenameTable(
                name: "SKills",
                newName: "Skills");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skills",
                table: "Skills",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSkill_Skills_SkillsId",
                table: "CharacterSkill",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterSkill_Skills_SkillsId",
                table: "CharacterSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skills",
                table: "Skills");

            migrationBuilder.RenameTable(
                name: "Skills",
                newName: "SKills");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SKills",
                table: "SKills",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterSkill_SKills_SkillsId",
                table: "CharacterSkill",
                column: "SkillsId",
                principalTable: "SKills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
