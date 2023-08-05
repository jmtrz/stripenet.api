using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace stripenet.api.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMIgration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { "0e8546c7-f008-4bc2-ba17-00205de95213", "Product 8 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/8/500", 8000L, "Product 8" },
                    { "1e4ecfe6-3771-4bfa-9029-cf69d8f2a491", "Product 4 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/4/500", 4000L, "Product 4" },
                    { "24ba05f6-0bed-41df-ab0d-4efb796f37e6", "Product 19 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/19/500", 19000L, "Product 19" },
                    { "2c9ead5b-ddca-41b8-a1a0-d5881f6e31b5", "Product 1 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/1/500", 1000L, "Product 1" },
                    { "2ee94678-9c62-4aa2-9928-fd2b0ffb96df", "Product 3 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/3/500", 3000L, "Product 3" },
                    { "4c8d1f5b-582b-4a16-98d2-a74511d0b55a", "Product 9 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/9/500", 9000L, "Product 9" },
                    { "4e08a24f-ab26-462b-a0b1-24e39cd7967d", "Product 15 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/15/500", 15000L, "Product 15" },
                    { "600f8db8-3126-495a-b9a7-25cae3339aee", "Product 2 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/2/500", 2000L, "Product 2" },
                    { "6159b129-9d86-4cfe-b8c5-d791266ed302", "Product 6 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/6/500", 6000L, "Product 6" },
                    { "a1a09168-e8a9-4e9e-8dca-a17d9ad8a0fb", "Product 7 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/7/500", 7000L, "Product 7" },
                    { "b304dc7e-5801-4574-841b-e2513e27fe20", "Product 13 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/13/500", 13000L, "Product 13" },
                    { "bc0a3abb-cca1-4bc1-8982-4262cc31835c", "Product 5 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/5/500", 5000L, "Product 5" },
                    { "bcb6adb6-6421-4e5b-96f8-ca7b598c50c3", "Product 20 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/20/500", 20000L, "Product 20" },
                    { "cac7c957-18e0-412e-87bc-5088b30abef4", "Product 18 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/18/500", 18000L, "Product 18" },
                    { "cd78b7e4-249d-4908-a18c-3d22996c9500", "Product 11 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/11/500", 11000L, "Product 11" },
                    { "e2993bab-26ab-4044-868e-05b73c807245", "Product 16 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/16/500", 16000L, "Product 16" },
                    { "ece1871c-4ba0-4427-8257-0dbf8b96a89b", "Product 10 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/10/500", 10000L, "Product 10" },
                    { "f538b5b8-9f63-4d03-913c-1fce11c5ab1a", "Product 12 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/12/500", 12000L, "Product 12" },
                    { "f944e85f-e61f-41bb-bcee-0522d42bfa64", "Product 17 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/17/500", 17000L, "Product 17" },
                    { "f97c41ba-6891-4767-b10c-7633a0f71036", "Product 14 description.This is an amazing product with a price-quality balance you won't find anywhere ele.", "https://picsum.photos/id/14/500", 14000L, "Product 14" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
