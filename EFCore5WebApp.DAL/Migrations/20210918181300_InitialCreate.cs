using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore5WebApp.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LookUps",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LookUpType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUps", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonPerson",
                columns: table => new
                {
                    ChildrenId = table.Column<int>(type: "int", nullable: false),
                    ParentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPerson", x => new { x.ChildrenId, x.ParentsId });
                    table.ForeignKey(
                        name: "FK_PersonPerson_Persons_ChildrenId",
                        column: x => x.ChildrenId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonPerson_Persons_ParentsId",
                        column: x => x.ParentsId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "LookUps",
                columns: new[] { "Code", "Description", "LookUpType" },
                values: new object[,]
                {
                    { "AL", "Alabama", 0 },
                    { "NJ", "New Jersey", 0 },
                    { "NM", "New Mexico", 0 },
                    { "NY", "New York", 0 },
                    { "NC", "New Carolina", 0 },
                    { "ND", "North Dakota", 0 },
                    { "OH", "Ohio", 0 },
                    { "OK", "Oklahoma", 0 },
                    { "OR", "Oregon", 0 },
                    { "PA", "Pennsylvania", 0 },
                    { "RI", "Rhode Island", 0 },
                    { "SC", "South Carolina", 0 },
                    { "SD", "South Dakota", 0 },
                    { "TN", "Tennessee", 0 },
                    { "TX", "Texas", 0 },
                    { "UT", "Utah", 0 },
                    { "VT", "Vermont", 0 },
                    { "VA", "Virginia", 0 },
                    { "WA", "Washington", 0 },
                    { "WV", "West Virginia", 0 },
                    { "WI", "Wisconsis", 0 },
                    { "WY", "Wyoming", 0 },
                    { "PR", "Puerto Rico", 0 },
                    { "USA", "United States of America", 1 },
                    { "NH", "New Hampshire", 0 },
                    { "NV", "Nevada", 0 },
                    { "NE", "Nebraska", 0 },
                    { "IL", "Illinois", 0 },
                    { "AR", "Arkansas", 0 },
                    { "CA", "California", 0 },
                    { "CO", "Colorado", 0 },
                    { "CT", "Connecticut", 0 },
                    { "DE", "Delaware", 0 },
                    { "DC", "District of Columbia", 0 },
                    { "FL", "Florida", 0 },
                    { "GA", "Georgia", 0 },
                    { "HI", "Hawaii", 0 },
                    { "ID", "Idaho", 0 },
                    { "MT", "Montana", 0 },
                    { "IN", "Indiana", 0 },
                    { "IA", "Iowa", 0 },
                    { "KS", "Kansas", 0 }
                });

            migrationBuilder.InsertData(
                table: "LookUps",
                columns: new[] { "Code", "Description", "LookUpType" },
                values: new object[,]
                {
                    { "KY", "Kentucky", 0 },
                    { "LA", "Louisiana", 0 },
                    { "ME", "Maine", 0 },
                    { "MD", "Maryland", 0 },
                    { "MA", "Massachusetts", 0 },
                    { "MI", "Michigan", 0 },
                    { "MN", "Minnesota", 0 },
                    { "MS", "Mississippi", 0 },
                    { "MO", "Missouri", 0 },
                    { "AZ", "Arizona", 0 },
                    { "AK", "Alaska", 0 }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Age", "CreatedOn", "EmailAddress", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "John", "Smith" },
                    { 2, 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "john@smith.com", "Susan", "Jones" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Country", "PersonId", "State", "ZipCode" },
                values: new object[] { 1, "123 Test St", "", "Beverly Hills", "USA", 1, "CA", "90210" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Country", "PersonId", "State", "ZipCode" },
                values: new object[] { 2, "123 Michigan Ave", "", "Chicago", "USA", 2, "IL", "60612" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressLine1", "AddressLine2", "City", "Country", "PersonId", "State", "ZipCode" },
                values: new object[] { 3, "100 1St St", "", "Chicago", "USA", 2, "IL", "60612" });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PersonId",
                table: "Addresses",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonPerson_ParentsId",
                table: "PersonPerson",
                column: "ParentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "LookUps");

            migrationBuilder.DropTable(
                name: "PersonPerson");

            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
