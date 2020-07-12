using Microsoft.EntityFrameworkCore.Migrations;

namespace Charity.Mvc.Migrations
{
    public partial class ChangeTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryModel_DonationModel_GiftId1",
                table: "CategoryModel");

            migrationBuilder.DropForeignKey(
                name: "FK_DonationModel_InstitutionModel_InstitutionId",
                table: "DonationModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstitutionModel",
                table: "InstitutionModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DonationModel",
                table: "DonationModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryModel",
                table: "CategoryModel");

            migrationBuilder.RenameTable(
                name: "InstitutionModel",
                newName: "Institutions");

            migrationBuilder.RenameTable(
                name: "DonationModel",
                newName: "Donations");

            migrationBuilder.RenameTable(
                name: "CategoryModel",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_DonationModel_InstitutionId",
                table: "Donations",
                newName: "IX_Donations_InstitutionId");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryModel_GiftId1",
                table: "Categories",
                newName: "IX_Categories_GiftId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Institutions",
                table: "Institutions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Donations",
                table: "Donations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Donations_GiftId1",
                table: "Categories",
                column: "GiftId1",
                principalTable: "Donations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Donations_Institutions_InstitutionId",
                table: "Donations",
                column: "InstitutionId",
                principalTable: "Institutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Donations_GiftId1",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Donations_Institutions_InstitutionId",
                table: "Donations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Institutions",
                table: "Institutions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Donations",
                table: "Donations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Institutions",
                newName: "InstitutionModel");

            migrationBuilder.RenameTable(
                name: "Donations",
                newName: "DonationModel");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "CategoryModel");

            migrationBuilder.RenameIndex(
                name: "IX_Donations_InstitutionId",
                table: "DonationModel",
                newName: "IX_DonationModel_InstitutionId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_GiftId1",
                table: "CategoryModel",
                newName: "IX_CategoryModel_GiftId1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstitutionModel",
                table: "InstitutionModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DonationModel",
                table: "DonationModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryModel",
                table: "CategoryModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryModel_DonationModel_GiftId1",
                table: "CategoryModel",
                column: "GiftId1",
                principalTable: "DonationModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DonationModel_InstitutionModel_InstitutionId",
                table: "DonationModel",
                column: "InstitutionId",
                principalTable: "InstitutionModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
