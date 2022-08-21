using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class Add_State_SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 1,
                columns: new[] { "Abbr", "Name" },
                values: new object[] { "AL", "Alabama" });

            migrationBuilder.InsertData(
                table: "States",
                columns: new[] { "StateId", "Abbr", "Name" },
                values: new object[,]
                {
                    { 32, "NV", "Nevada" },
                    { 33, "NH", "New Hampshire" },
                    { 34, "NJ", "New Jersey" },
                    { 35, "NM", "New Mexico" },
                    { 36, "NY", "New York" },
                    { 37, "NC", "North Carolina" },
                    { 38, "ND", "North Dakota	" },
                    { 39, "OH", "Ohio" },
                    { 40, "OK", "Oklahoma" },
                    { 41, "OR", "Oregon" },
                    { 31, "NE", "Nebraska" },
                    { 42, "PA", "Pennsylvania" },
                    { 45, "SC", "South Carolina" },
                    { 46, "SD", "South Dakota	" },
                    { 47, "TN", "Tennessee" },
                    { 48, "TX", "Texas" },
                    { 49, "UT", "Utah" },
                    { 50, "VT", "Vermont" },
                    { 51, "VA", "Virgin Islands	" },
                    { 53, "WA", "Washington" },
                    { 54, "WV", "West Virginia	" },
                    { 55, "WI", "Wisconsin" },
                    { 44, "RI", "Rhode Island	" },
                    { 56, "WY", "Wyoming" },
                    { 30, "MT", "Montana" },
                    { 28, "MS", "Mississippi" },
                    { 4, "AZ", "Arizona" },
                    { 5, "AR", "Arkansas" },
                    { 6, "CA", "California" },
                    { 8, "CO", "Colorado" },
                    { 9, "CT", "Connecticut" },
                    { 10, "DE", "Delaware" },
                    { 11, "DC", "District of Columbia" },
                    { 12, "FL", "Florida" },
                    { 13, "13", "Georgia" },
                    { 15, "15", "Hawaii" },
                    { 29, "MO", "Missouri" },
                    { 16, "ID", "Idaho" },
                    { 18, "IN", "Indiana" },
                    { 19, "IA", "Iowa" },
                    { 20, "KS", "Kansas" },
                    { 21, "21", "Kentucky" },
                    { 22, "LA", "Louisiana" },
                    { 23, "ME", "Maine" },
                    { 24, "MD", "Maryland" },
                    { 25, "MA", "Massachusetts" },
                    { 26, "MI", "Michigan" },
                    { 27, "MN", "Minnesota" },
                    { 17, "IL", "Illinois" },
                    { 2, "AK", "Alaska" }
                });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                column: "StateId",
                value: 53);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 56);

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                column: "StateId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "States",
                keyColumn: "StateId",
                keyValue: 1,
                columns: new[] { "Abbr", "Name" },
                values: new object[] { "WA", "Washington" });
        }
    }
}
