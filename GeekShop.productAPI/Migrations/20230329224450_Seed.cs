using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace geekShop.productAPI.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("02470810-6887-454d-bfa7-78e45cd6bb05"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("15851313-64ab-40eb-a087-cff9c6951095"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("330720ce-cc2e-48dc-b59f-ba1b3ce9c005"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("345d9bda-76d2-4474-8506-c0c4f878533b"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("4c8a3569-15c9-4949-b7eb-a2d918c17904"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("7ba423fd-2ca5-4cc0-9f0b-45053d225e3d"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("8623daaa-0f3c-4d90-9d78-17d5ca82c14f"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("a2bada78-09ad-4f4a-9268-3a1dda344435"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("c6ec0db0-c9d7-4079-baf9-aafacd5873cc"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("d5fed05d-e2a0-42d5-8d8a-9c29f41ba67b"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("ef7d8225-3d56-4dd8-9b36-cde569d34e42"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("f8dccff1-0a94-4a7d-b094-589f43d27453"));

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { new Guid("3b3db642-f237-421e-9123-56a07ffdeaa4"), "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true", "Camiseta Gamer", 69.99m },
                    { new Guid("5bbba308-620f-484e-acfd-69181248012e"), "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true", "Camiseta SpaceX", 49.99m },
                    { new Guid("6aa300b7-454e-41a7-ac14-5dc5ecb87976"), "Action Figure", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true", "Star Wars The Black Series Hasbro - Stormtrooper Imperial", 189.99m },
                    { new Guid("6d805198-db84-4515-99dc-0ea4d907dc30"), "Action Figure", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true", "Star Wars Mission Fleet Han Solo Nave Milennium Falcon", 359.99m },
                    { new Guid("71e39d58-f158-4b2f-8eb4-e72b067fae31"), "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true", "Camiseta GNU Linux Programador Masculina", 59.99m },
                    { new Guid("9b20cbc9-e677-499f-8ace-bd0aa1d7fc62"), "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg?raw=true", "Camiseta No Internet", 69.9m },
                    { new Guid("aca9e8cc-39cd-4466-ab04-2df067d022ad"), "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true", "Camiseta Elon Musk Spacex Marte Occupy Mars", 59.99m },
                    { new Guid("ad9446f6-3a56-4b12-9567-ddde35d41b80"), "Sweatshirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true", "Moletom Com Capuz Cobra Kai", 159.9m },
                    { new Guid("cda81e7b-3d35-4e6b-8159-19e2abbf2d2a"), "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg", "Camiseta Goku Fases", 59.99m },
                    { new Guid("d9fc26cf-6d13-4f93-a7d9-008f5339b286"), "Book", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true", "Livro Star Talk – Neil DeGrasse Tyson", 49.9m },
                    { new Guid("eae8668e-835d-4fc7-b0f9-6cf56e1a793e"), "Action Figure", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true", "Capacete Darth Vader Star Wars Black Series", 999.99m },
                    { new Guid("ef535130-9f42-441d-abcf-f47e5939c782"), "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true", "Camiseta Feminina Coffee Benefits", 69.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("3b3db642-f237-421e-9123-56a07ffdeaa4"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("5bbba308-620f-484e-acfd-69181248012e"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("6aa300b7-454e-41a7-ac14-5dc5ecb87976"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("6d805198-db84-4515-99dc-0ea4d907dc30"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("71e39d58-f158-4b2f-8eb4-e72b067fae31"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("9b20cbc9-e677-499f-8ace-bd0aa1d7fc62"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("aca9e8cc-39cd-4466-ab04-2df067d022ad"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("ad9446f6-3a56-4b12-9567-ddde35d41b80"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("cda81e7b-3d35-4e6b-8159-19e2abbf2d2a"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("d9fc26cf-6d13-4f93-a7d9-008f5339b286"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("eae8668e-835d-4fc7-b0f9-6cf56e1a793e"));

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: new Guid("ef535130-9f42-441d-abcf-f47e5939c782"));

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { new Guid("02470810-6887-454d-bfa7-78e45cd6bb05"), "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/7_coffee.jpg?raw=true", "Camiseta Feminina Coffee Benefits", 69.9m },
                    { new Guid("15851313-64ab-40eb-a087-cff9c6951095"), "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/5_100_gamer.jpg?raw=true", "Camiseta Gamer", 69.99m },
                    { new Guid("330720ce-cc2e-48dc-b59f-ba1b3ce9c005"), "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/13_dragon_ball.jpg", "Camiseta Goku Fases", 59.99m },
                    { new Guid("345d9bda-76d2-4474-8506-c0c4f878533b"), "Sweatshirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/8_moletom_cobra_kay.jpg?raw=true", "Moletom Com Capuz Cobra Kai", 159.9m },
                    { new Guid("4c8a3569-15c9-4949-b7eb-a2d918c17904"), "Book", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/9_neil.jpg?raw=true", "Livro Star Talk – Neil DeGrasse Tyson", 49.9m },
                    { new Guid("7ba423fd-2ca5-4cc0-9f0b-45053d225e3d"), "Action Figure", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/4_storm_tropper.jpg?raw=true", "Star Wars The Black Series Hasbro - Stormtrooper Imperial", 189.99m },
                    { new Guid("8623daaa-0f3c-4d90-9d78-17d5ca82c14f"), "Action Figure", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/10_milennium_falcon.jpg?raw=true", "Star Wars Mission Fleet Han Solo Nave Milennium Falcon", 359.99m },
                    { new Guid("a2bada78-09ad-4f4a-9268-3a1dda344435"), "Action Figure", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/3_vader.jpg?raw=true", "Capacete Darth Vader Star Wars Black Series", 999.99m },
                    { new Guid("c6ec0db0-c9d7-4079-baf9-aafacd5873cc"), "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/11_mars.jpg?raw=true", "Camiseta Elon Musk Spacex Marte Occupy Mars", 59.99m },
                    { new Guid("d5fed05d-e2a0-42d5-8d8a-9c29f41ba67b"), "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/2_no_internet.jpg?raw=true", "Camiseta No Internet", 69.9m },
                    { new Guid("ef7d8225-3d56-4dd8-9b36-cde569d34e42"), "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/6_spacex.jpg?raw=true", "Camiseta SpaceX", 49.99m },
                    { new Guid("f8dccff1-0a94-4a7d-b094-589f43d27453"), "T-shirt", "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/>The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.<br/>Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/blob/main/ShoppingImages/12_gnu_linux.jpg?raw=true", "Camiseta GNU Linux Programador Masculina", 59.99m }
                });
        }
    }
}
