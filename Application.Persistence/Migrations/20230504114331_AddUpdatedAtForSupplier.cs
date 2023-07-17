﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Application.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddUpdatedAtForSupplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Supplier",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Supplier");
        }
    }
}
