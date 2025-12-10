using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountDets",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Account_No = table.Column<int>(type: "int", nullable: false),
                    Balance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountDets", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "TransferViaAccountnos",
                columns: table => new
                {
                    Sender_Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Sender_AccountNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_AccountNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transfer_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferViaAccountnos", x => x.Sender_Name);
                });

            migrationBuilder.CreateTable(
                name: "TransferViaPhonenos",
                columns: table => new
                {
                    Sender_Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Sender_PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Receiver_PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transfer_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferViaPhonenos", x => x.Sender_Name);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Name);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountDets");

            migrationBuilder.DropTable(
                name: "TransferViaAccountnos");

            migrationBuilder.DropTable(
                name: "TransferViaPhonenos");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
