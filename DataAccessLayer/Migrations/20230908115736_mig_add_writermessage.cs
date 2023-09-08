using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_add_writermessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WriterMessages",
                columns: table => new
                {
                    WriterMessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterMessageSender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterMessageReceiver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterMessageSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterMessageContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterMessageDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WriterMessages", x => x.WriterMessageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WriterMessages");
        }
    }
}
