using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormiWebshop.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "A \"Mária a kisdeddel\" kép egy hagyományos keresztény ábrázolás, mely Máriát, Jézus Krisztus anyját mutatja, ahogy gyermekét, a kisded Jézust tartja. Ez a téma rendkívül népszerű a keresztény művészetben, különösen a középkorban és a reneszánsz korban.", "https://scontent.fosl3-1.fna.fbcdn.net/v/t1.18169-9/1926658_523142377794916_1845919539_n.jpg?_nc_cat=107&ccb=1-7&_nc_sid=4dc865&_nc_ohc=MhX_FG2GyskAX-XuLIN&_nc_ht=scontent.fosl3-1.fna&oh=00_AfDnqRsn_zr273ywekZ7VCxSCnilnHClcM9R5eFAEXUopQ&oe=65DBB0DD", 999.99m, "Mária a kisdeddel" },
                    { 2, "Az \"Életfa\" című kép egy mélyen szimbolikus alkotás, amely az élet, a növekedés, és a természet örök ciklusát ábrázolja. Gyakran előfordul különböző kultúrák mítoszaiban és hiedelmeiben, az életfa a kapcsolatot szimbolizálja az ég és a föld között, gyökereivel a földbe mélyedve és ágaival az ég felé törve.", "https://scontent.fosl3-1.fna.fbcdn.net/v/t31.18172-8/1965663_523143624461458_1276340583_o.jpg?_nc_cat=105&ccb=1-7&_nc_sid=4dc865&_nc_ohc=DyWTtiRlcl0AX8Nxzcu&_nc_ht=scontent.fosl3-1.fna&oh=00_AfAm6Aet5DjhthAUqdBv0qcNv5L8exN-bV7KvM1xuAVUQw&oe=65DB92E9", 799.99m, "Életfa" },
                    { 3, "A \"Szerencse lovai\" című kép egy dinamikus és élettel teli alkotás, amely a mozgás, erő és szerencse témáit ötvözi. A kompozíció középpontjában álló lovak, amelyeket gyakran vad, szabad szellemű lényekként ábrázolnak, ezen a képen a szerencse és a sors fordulatos útjait szimbolizálják.", "https://scontent.fosl3-2.fna.fbcdn.net/v/t1.18169-9/1926668_523142884461532_1016400965_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=4dc865&_nc_ohc=fqFgPIYsG6UAX8qPKJa&_nc_ht=scontent.fosl3-2.fna&oh=00_AfBQwQA9PvCzcpgn3LBeOlzq59Yd4SwUgqUKSa5-BIeZCw&oe=65DB86F7", 699.99m, "A szerencse lovai" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
