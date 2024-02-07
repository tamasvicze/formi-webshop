using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FormiWebshop.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 1, "A \"Harcsa\" című kép egy lenyűgöző vizuális alkotás, amely a víz alatti világ egyik legérdekesebb és legmisztikusabb lakóját, a harcsát állítja középpontba. A harcsa, mint téma, ritkábban fordul elő a művészetben, ami különlegessé és figyelemfelkeltővé teszi ezt a művet. A képen a harcsa általában hatalmas, izmos testével és jellegzetes, bajuszszerű úszóival tűnik ki, amelyek azonnal felismerhetővé teszik ezt a vízi ragadozót.", "https://scontent.fosl3-2.fna.fbcdn.net/v/t1.18169-9/1948202_523141641128323_1230882181_n.jpg?_nc_cat=111&ccb=1-7&_nc_sid=4dc865&_nc_ohc=ikaauvVmcSsAX_ZBz-n&_nc_ht=scontent.fosl3-2.fna&oh=00_AfC3dputgHv8qhnf9h5kpRvaiPTLhUzbekoU3vpFIa_FVQ&oe=65DB7D68", 499.99m, "Harcsa" },
                    { 5, 1, "A \"Margaréta\" című kép egy bájos és finom alkotás, amely a természet egyik legkedveltebb virágát, a margarétát ünnepli. A margaréta a tisztaság, ártatlanság és valódi szeretet szimbóluma. A képen ábrázolt virágok frissessége és egyszerű szépsége közvetlenül szólítja meg a nézőt, miközben a művész által választott kompozíció és színpaletta a természetes szépség és a harmónia érzetét kelti.", "https://scontent.fosl3-1.fna.fbcdn.net/v/t1.18169-9/1006045_523139247795229_57350582_n.jpg?_nc_cat=102&ccb=1-7&_nc_sid=4dc865&_nc_ohc=Ihbt_rqgbBUAX81bdPb&_nc_ht=scontent.fosl3-1.fna&oh=00_AfDjDqQpqQmHbrDZnaJjCVgfmi8drN6ufEv2EAzFgCI-cg&oe=65DB8E34", 399.99m, "Margaréta" },
                    { 6, 2, "Ez a szett egy dinamikus és élénk színkombinációt tartalmaz, beleértve a fehér, sárga, piros, kék és zöld árnyalatokat. A színek sokoldalúsága lehetővé teszi a felhasználók számára, hogy szabadon kísérletezzenek és színes alkotásokat hozzanak létre, legyen szó akár tájképekről, állatfigurákról vagy akár absztrakt művekről.", "https://scontent.fbud6-4.fna.fbcdn.net/v/t31.18172-8/1966061_523163521126135_466461706_o.jpg?_nc_cat=105&ccb=1-7&_nc_sid=4dc865&_nc_ohc=m6U10Lds47AAX826HSM&_nc_ht=scontent.fbud6-4.fna&oh=00_AfBVG0DqcTV2lOFeezlbX_pfKYNuiquFosB8W-RUV1Rk0g&oe=65B425FC", 299.99m, "Dobozos gyurma 1. szín" },
                    { 7, 2, "Ebben a szettben a fehér mellett a test szín, lila, barna és fekete árnyalatok dominálnak, amelyek tökéletesen alkalmasak emberi alakok és természeti elemek modellezésére. Ez a paletta különösen jól használható a realisztikusabb, részletgazdag alkotásokhoz, amelyek finom árnyalatokkal és átmenetekkel dolgoznak.", "https://scontent.fosl3-1.fna.fbcdn.net/v/t31.18172-8/10001106_523163627792791_943319837_o.jpg?_nc_cat=105&ccb=1-7&_nc_sid=4dc865&_nc_ohc=GTfbWV9OrQUAX_csRP3&_nc_ht=scontent.fosl3-1.fna&oh=00_AfAWSDH-exYdoY24LBJ3A6vWwz2KGqzf9vVsIuHQS3MG4Q&oe=65DBADF1", 299.99m, "Dobozos gyurma 2. szín" },
                    { 8, 2, "Fehér, narancs, türkiz, ciklámen és szürke színeket tartalmaz, amelyek egyedi és modern alkotások létrehozására inspirálnak. A friss és élénk színek, mint a türkiz és a ciklámen, mellett a narancs és a szürke árnyalatok kiegyensúlyozott kontrasztot nyújtanak, lehetővé téve a felhasználók számára, hogy élénk és figyelemfelkeltő műveket hozzanak létre.", "https://scontent.fosl3-1.fna.fbcdn.net/v/t31.18172-8/1529758_523163694459451_1282257657_o.jpg?_nc_cat=108&ccb=1-7&_nc_sid=4dc865&_nc_ohc=3c8hUGXM3cIAX-Hkmim&_nc_ht=scontent.fosl3-1.fna&oh=00_AfD4xQGGIH_oot7sTWpnjFPMphVBJtjvGo9aM-XLzki5vQ&oe=65DB93A0", 299.99m, "Dobozos gyurma 3. szín" },
                    { 9, 2, "Ez a készlet finomabb, pasztellszínű választékot kínál, beleértve a fehér, világos zöld, meggy piros, világos rózsaszín és világos kék árnyalatokat. A lágy és nyugtató színek ideálisak a békés és harmonikus jelenetek megalkotásához, kiválóan alkalmasak a gyengédebb érzelmek és hangulatok kifejezésére.", "https://scontent.fosl3-1.fna.fbcdn.net/v/t31.18172-8/1597214_523163817792772_1796134464_o.jpg?_nc_cat=105&ccb=1-7&_nc_sid=4dc865&_nc_ohc=mBeu6SLPaloAX_P1Rwx&_nc_oc=AQmdzVaxVEDd6RtMoPtledUgkJ9bGN8v5hRnzcKoGmeUvHmdzfd-It84XqVq2MBnmW0&_nc_ht=scontent.fosl3-1.fna&oh=00_AfAf2KVOdX1aBNlGjtaftkrI4yjQJ4fi_YhcEIBvzzYDFg&oe=65DBB01A", 299.99m, "Dobozos gyurma 4. szín" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
