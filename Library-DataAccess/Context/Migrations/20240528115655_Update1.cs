using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library_DataAccess.Context.Migrations
{
    /// <inheritdoc />
    public partial class Update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuthorPublishers",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorPublishers", x => new { x.AuthorId, x.PublisherId });
                    table.ForeignKey(
                        name: "FK_AuthorPublishers_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorPublishers_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    PublisherId = table.Column<int>(type: "int", nullable: false),
                    PublishYear = table.Column<int>(type: "int", nullable: false),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    StockCount = table.Column<int>(type: "int", nullable: false),
                    BorrowedCount = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserBooks",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    IsFavorited = table.Column<bool>(type: "bit", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBooks", x => new { x.UserId, x.BookId });
                    table.ForeignKey(
                        name: "FK_UserBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBooks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1078), null, "Joanne Rowling CH, OBE, HonFRSE, FRCPE, FRSL, better known by her pen name J. K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series, which has won multiple awards and sold more than 500 million copies, becoming the best-selling book series in history. The books are the basis of a popular film series, over which Rowling had overall approval on the scripts and was a producer on the final films. She also writes crime novels under the pen name Robert Galbraith.", "J.K. Rowling", 1, null },
                    { 2, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1091), null, "Stephen Edwin King is an American author of horror, supernatural fiction, suspense, crime, science-fiction, and fantasy novels. His books have sold more than 350 million copies, and many have been adapted into films, television series, miniseries, and comic books. King has published 61 novels, including seven under the pen name Richard Bachman, and five non-fiction books. He has also written approximately 200 short stories, most of which have been published in book collections.", "Stephen King", 1, null },
                    { 3, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1092), null, "John Ronald Reuel Tolkien was an English writer, poet, philologist, and academic, best known as the author of the high fantasy works The Hobbit, The Lord of the Rings, and The Silmarillion.", "J.R.R. Tolkien", 1, null },
                    { 4, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1092), null, "George Raymond Richard Martin, also known as GRRM, is an American novelist and short story writer in the fantasy, horror, and science fiction genres, screenwriter, and television producer. He is best known for his series of epic fantasy novels, A Song of Ice and Fire, which was adapted into the HBO series Game of Thrones.", "George R.R. Martin", 1, null },
                    { 5, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1093), null, "Dame Agatha Mary Clarissa Christie, Lady Mallowan, was an English writer known for her sixty-six detective novels and fourteen short story collections, particularly those revolving around fictional detectives Hercule Poirot and Miss Marple. She also wrote the world's longest-running", "Agatha Christie", 1, null },
                    { 6, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1094), null, "Daniel Gerhard Brown is an American author best known for his thriller novels, including the Robert Langdon novels Angels & Demons, The Da Vinci Code, The Lost Symbol, Inferno, and Origin. His novels are treasure hunts that usually take place over a period of 24 hours. They feature recurring themes of cryptography, art, and conspiracy theories. His books have been translated into 57 languages and, as of 2012, have sold over 200 million copies. Three of them, Angels & Demons, The Da Vinci Code, and Inferno, have been adapted into films.", "Dan Brown", 1, null },
                    { 7, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1094), null, "Sir Arthur Ignatius Conan Doyle KStJ DL was a British writer and physician. He created the character Sherlock Holmes in 1887 for A Study in Scarlet, the first of four novels and fifty-six short stories about Holmes and Dr. Watson. The Sherlock Holmes stories are considered milestones in the field of crime fiction.", "Arthur Conan Doyle", 1, null },
                    { 8, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1095), null, "Samuel Langhorne Clemens, known by his pen name Mark Twain, was an American writer, humorist, entrepreneur, publisher, and lecturer. He was lauded as the 'greatest humorist the United States has produced,' and William Faulkner called him 'the father of American literature'. His novels include The Adventures of Tom Sawyer and its sequel, the Adventures of Huckleberry Finn, the latter often called 'The Great American Novel'.", "Mark Twain", 1, null },
                    { 9, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1096), null, "Count Lev Nikolayevich Tolstoy, usually referred to in English as Leo Tolstoy, was a Russian writer who is regarded as one of the greatest authors of all time. He received multiple nominations for the Nobel Prize in Literature every year from 1902 to 1906 and nominations for the Nobel Peace Prize in 1901, 1902, and 1910, and his miss of the prize is a major Nobel prize controversy.", "Leo Tolstoy", 1, null },
                    { 10, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1097), null, "Fyodor Mikhailovich Dostoevsky, sometimes transliterated Dostoyevsky, was a Russian novelist, philosopher, short story writer, essayist, and journalist. Dostoevsky's literary works explore human psychology in the troubled political, social, and spiritual atmospheres of 19th-century Russia, and engage with a variety of philosophical and religious themes. His most acclaimed works include Crime and Punishment, The Idiot, Demons, and The Brothers Karamazov. Dostoevsky's body of works consists of 12 novels, four novellas, 16 short stories, and numerous other works.", "Fyodor Dostoevsky", 1, null },
                    { 11, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1097), null, "Ernest Miller Hemingway was an American novelist, short-story writer, journalist, and sportsman. His economical and understated style—which he termed the iceberg theory—had a strong influence on 20th-century fiction, while his adventurous lifestyle and his public image brought him admiration from later generations. Hemingway produced most of his work between the mid-1920s and the mid-1950s, and he was awarded the Nobel Prize in Literature in 1954.", "Ernest Hemingway", 1, null },
                    { 12, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1098), null, "Sabahattin Ali was a Turkish novelist, short-story writer, poet, and journalist. He was born in 1907 in Eğridere township of the Sanjak of Gümülcine (now Komotini in Greece), in the Ottoman Empire, to an Albanian family. He was killed by Ali Ertekin, a government official, on 2 July 1948.", "Sabahattin Ali", 1, null },
                    { 13, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1099), null, "Ferit Orhan Pamuk is a Turkish novelist, screenwriter, academic, and recipient of the 2006 Nobel Prize in Literature. One of Turkey's most prominent novelists, his work has sold over thirteen million books in sixty-three languages, making him the country's best-selling writer.", "Orhan Pamuk", 1, null },
                    { 14, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1099), null, "Franz Kafka was a German-speaking Bohemian writer of novels and short stories, regarded by critics as one of the most significant writers of the 20th century. His work, which fuses elements of realism and the fantastic, typically features isolated protagonists facing bizarre or surrealistic predicaments and incomprehensible socio-bureaucratic powers, and has been interpreted as exploring themes of alienation, existential anxiety, guilt, and absurdity. His best known works include 'Die Verwandlung' ('The Metamorphosis'), Der Process (The Trial), and Das Schloss (The Castle).", "Franz Kafka", 1, null },
                    { 15, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1100), null, "Albert Camus was a French philosopher, author, and journalist. He won the Nobel Prize in Literature at the age of 44 in 1957, the second-youngest recipient in history. His works include The Stranger, The Plague, The Myth of Sisyphus, The Fall, and The Rebel.", "Albert Camus", 1, null },
                    { 16, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1101), null, "Hermann Karl Hesse was a German-born Swiss poet, novelist, and painter. His best-known works include Demian, Steppenwolf, Siddhartha, and The Glass Bead Game, each of which explores an individual's search for authenticity, self-knowledge and spirituality. In 1946, he received the Nobel Prize in Literature.", "Hermann Hesse", 1, null },
                    { 17, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1101), null, "Halide Edib Adıvar was a Turkish novelist, nationalist, and political leader. ", "Halide Edib Adıvar", 1, null },
                    { 18, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1102), null, "Nazım Hikmet Ran, commonly known as Nazım Hikmet, was a Turkish poet, playwright, novelist, screenwriter, director, and memoirist. He was acclaimed for the 'lyrical flow of his statements'.", "Nazım Hikmet", 1, null },
                    { 19, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1103), null, "Ahmet Hamdi Tanpınar was a Turkish poet, novelist, literary historian, and essayist widely regarded as one of the most important representatives of modernism in Turkish literature. He was also a member of the Turkish Parliament.", "Ahmet Hamdi Tanpınar", 1, null },
                    { 20, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1104), null, "Yusuf Atılgan was a Turkish novelist and playwright. He is best known for his novels Aylak Adam and Anayurt Oteli.", "Yusuf Atılgan", 1, null },
                    { 21, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1104), null, "Yaşar Kemal was a Turkish writer and human rights activist. He received 38 awards during his lifetime and had been a candidate for the Nobel Prize in Literature on the strength of Memed, My Hawk.", "Yaşar Kemal", 1, null },
                    { 22, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1105), null, "Orhan Veli Kanık was a Turkish poet. He is considered one of the pioneers of modern poetry in Turkey.", "Orhan Veli Kanık", 1, null },
                    { 23, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1105), null, "Cemal Süreya was a Turkish poet and writer. He was one of the greatest Turkish poets of the 20th century.", "Cemal Süreya", 1, null },
                    { 24, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1106), null, "Attilâ İlhan was a Turkish poet, novelist, essayist, journalist, and reviewer. He was a prominent member of the Turkish literary scene in the 20th century.", "Attilâ İlhan", 1, null },
                    { 25, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1107), null, "Oğuz Atay was a Turkish novelist, playwright, and engineer. He is best known for his novels Tutunamayanlar and Tehlikeli Oyunlar.", "Oğuz Atay", 1, null },
                    { 26, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1107), null, "Necip Fazıl Kısakürek was a Turkish poet, novelist, playwright, and philosopher. He was also a political activist, supporting the ideology of Turkish nationalism and Islamism, and was a prominent member of the Turkish Hearth Party.", "Necip Fazıl Kısakürek", 1, null },
                    { 27, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1108), null, "Peyami Safa was a Turkish novelist, storywriter, playwright, essayist, and poet. He is considered one of the greatest Turkish novelists of the 20th century.", "Peyami Safa", 1, null },
                    { 28, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1109), null, "Reşat Nuri Güntekin was a Turkish novelist, storywriter, playwright, and poet. He was also a prominent and pioneering academic, journalist, and essayist. He is best known for his novels Çalıkuşu and Yaprak Dökümü.", "Reşat Nuri Güntekin", 1, null },
                    { 29, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1109), null, "Yakup Kadri Karaosmanoğlu was a Turkish novelist, playwright, and journalist. He was one of the leading Turkish novelists of the Republican era.", "Yakup Kadri", 1, null },
                    { 30, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1110), null, "Ömer Seyfettin was a Turkish writer, known primarily for his short stories and articles. His stories are written in a clear and precise style and are realistic in nature. They avoid sentimentality and melodrama, and are often concerned with the relationship between people and their environment.", "Ömer Seyfettin", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1325), null, "Story", 1, null },
                    { 2, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1325), null, "Novel", 1, null },
                    { 3, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1326), null, "Poem", 1, null },
                    { 4, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1327), null, "Drama", 1, null },
                    { 5, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1327), null, "Comedy", 1, null },
                    { 6, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1356), null, "Tragedy", 1, null },
                    { 7, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1357), null, "Fiction", 1, null },
                    { 8, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1358), null, "Non-Fiction", 1, null },
                    { 9, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1358), null, "Fantasy", 1, null },
                    { 10, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1359), null, "Science Fiction", 1, null },
                    { 11, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1359), null, "Mystery", 1, null },
                    { 12, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1360), null, "Horror", 1, null },
                    { 13, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1360), null, "Romance", 1, null },
                    { 14, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1361), null, "Biography", 1, null },
                    { 15, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1361), null, "Autobiography", 1, null },
                    { 16, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1362), null, "Memoir", 1, null },
                    { 17, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1363), null, "Self-Help", 1, null },
                    { 18, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1363), null, "History", 1, null },
                    { 19, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1364), null, "Travel", 1, null },
                    { 20, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1364), null, "Cooking", 1, null },
                    { 21, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1365), null, "Art", 1, null },
                    { 22, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1365), null, "Photography", 1, null },
                    { 23, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1366), null, "Children", 1, null },
                    { 24, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1366), null, "Young Adult", 1, null },
                    { 25, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1367), null, "Adult", 1, null },
                    { 26, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1367), null, "Science", 1, null },
                    { 27, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1368), null, "Mathematics", 1, null },
                    { 28, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1368), null, "Physics", 1, null },
                    { 29, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1370), null, "Chemistry", 1, null },
                    { 30, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1371), null, "Biology", 1, null },
                    { 31, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1372), null, "Astronomy", 1, null },
                    { 32, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1374), null, "Geology", 1, null },
                    { 33, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1374), null, "Meteorology", 1, null },
                    { 34, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1375), null, "Psychology", 1, null },
                    { 35, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1375), null, "Sociology", 1, null },
                    { 36, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1376), null, "Philosophy", 1, null },
                    { 37, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1376), null, "Religion", 1, null },
                    { 38, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1377), null, "Mythology", 1, null },
                    { 39, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1377), null, "Folklore", 1, null },
                    { 40, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1378), null, "Fairy Tale", 1, null },
                    { 41, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1378), null, "Legend", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "Status", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1448), null, "Penguin Random House", 1, null },
                    { 2, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1449), null, "HarperCollins", 1, null },
                    { 3, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1450), null, "Simon & Schuster", 1, null },
                    { 4, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1450), null, "Hachette Livre", 1, null },
                    { 5, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1451), null, "Macmillan Publishers", 1, null },
                    { 6, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1451), null, "Pearson Education", 1, null },
                    { 7, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1452), null, "Scholastic", 1, null },
                    { 8, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1453), null, "Cengage Learning", 1, null },
                    { 9, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1453), null, "Wiley", 1, null },
                    { 10, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1454), null, "McGraw-Hill Education", 1, null },
                    { 11, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1454), null, "Houghton Mifflin Harcourt", 1, null },
                    { 12, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1455), null, "Harlequin Enterprises", 1, null },
                    { 13, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1455), null, "Bloomsbury Publishing", 1, null },
                    { 14, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1456), null, "Cambridge University Press", 1, null },
                    { 15, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1457), null, "Oxford University Press", 1, null },
                    { 16, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1457), null, "Elsevier", 1, null },
                    { 17, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1458), null, "Taylor & Francis", 1, null },
                    { 18, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1458), null, "Springer", 1, null },
                    { 19, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1459), null, "John Wiley & Sons", 1, null },
                    { 20, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1460), null, "SAGE Publications", 1, null },
                    { 21, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1460), null, "Kapra Yayıncılık", 1, null },
                    { 22, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1461), null, "Doğan Kitap", 1, null },
                    { 23, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1462), null, "İthaki Yayınları", 1, null },
                    { 24, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1462), null, "Koridor Yayıncılık", 1, null },
                    { 25, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1463), null, "Can Yayınları", 1, null },
                    { 26, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1463), null, "Kırmızı Kedi Yayınevi", 1, null },
                    { 27, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1464), null, "Pegasus Yayınları", 1, null },
                    { 28, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1464), null, "İnkılap Kitabevi", 1, null },
                    { 29, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1465), null, "Everest Yayınları", 1, null },
                    { 30, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1465), null, "Yapı Kredi Yayınları", 1, null },
                    { 31, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1466), null, "Metis Yayınları", 1, null },
                    { 32, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1466), null, "İletişim Yayınları", 1, null },
                    { 33, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1467), null, "Can Çocuk Yayınları", 1, null },
                    { 34, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1468), null, "Timaş Yayınları", 1, null },
                    { 35, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1468), null, "Domingo Yayınevi", 1, null },
                    { 36, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1498), null, "Kolektif Kitap", 1, null },
                    { 37, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1499), null, "İş Bankası Kültür Yayınları", 1, null },
                    { 38, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1499), null, "Remzi Kitabevi", 1, null },
                    { 39, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1500), null, "Yordam Kitap", 1, null },
                    { 40, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1500), null, "Liberus", 1, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "CreatedDate", "DeletedDate", "Email", "FirstName", "LastName", "Password", "Status", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1572), null, "johndoe@test.com", "John", "Doe", "123", 1, null, "johndoe" },
                    { 2, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1578), null, "janedoe@test.com", "Jane", "Doe", "123", 1, null, "janedoe" },
                    { 3, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1579), null, "jackdoe@test.com", "Jack", "Doe", "123", 1, null, "jackdoe" }
                });

            migrationBuilder.InsertData(
                table: "AuthorPublishers",
                columns: new[] { "AuthorId", "PublisherId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 6, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 },
                    { 11, 11 },
                    { 12, 12 }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BorrowedCount", "CreatedDate", "DeletedDate", "Description", "GenreId", "ImageUrl", "Language", "Name", "PageCount", "PublishYear", "PublisherId", "Rating", "Status", "StockCount", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 0, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1203), null, "Harry Potter has never even heard of Hogwarts when the letters start dropping on the doormat at number four, Privet Drive. Addressed in green ink on yellowish parchment with a purple seal, they are swiftly confiscated by his grisly aunt and uncle.", 1, "https://images-na.ssl-images-amazon.com/images/I/51UoqRAxwEL._SX331_BO1,204,203,200_.jpg", "English", "Harry Potter and the Philosopher’s Stone", 223, 1997, 1, 5, 1, 10, null },
                    { 2, 1, 0, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1206), null, "The Dursleys were so mean and hideous that summer that all Harry Potter wanted was to get back to the Hogwarts School for Witchcraft and Wizardry. But just as he’s packing his bags, Harry receives a warning from a strange, impish creature named Dobby who says that if Harry Potter returns to Hogwarts, disaster will strike.", 1, "https://images-na.ssl-images-amazon.com/images/I/51UoqRAxwEL._SX331_BO1,204,203,200_.jpg", "English", "Harry Potter and the Chamber of Secrets", 251, 1998, 1, 5, 1, 10, null },
                    { 3, 2, 0, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1208), null, "To the children, the town was their whole world. To the adults, knowing better, Derry, Maine was just their home town: familiar, well-ordered for the most part. A good place to live.", 2, "https://www.rollingstone.com/wp-content/uploads/2018/06/rs-173540-IT.jpg?w=1280", "English", "It", 1138, 1986, 2, 5, 1, 10, null },
                    { 4, 2, 0, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1209), null, "Jack Torrance’s new job at the Overlook Hotel is the perfect chance for a fresh start. As the off-season caretaker at the atmospheric old hotel, he’ll have plenty of time to spend reconnecting with his family and working on his writing.", 2, "https://www.rollingstone.com/wp-content/uploads/2018/06/rs-173546-The-Shining.jpg?w=1280", "English", "The Shining", 447, 1977, 2, 5, 1, 10, null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "BookId", "CreatedDate", "DeletedDate", "Status", "UpdatedDate", "UserComment", "UserId", "Username" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1266), null, 1, null, "Great book!", null, "johndoe" },
                    { 2, 2, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1268), null, 1, null, "I loved it!", null, "janedoe" },
                    { 3, 3, new DateTime(2024, 5, 28, 14, 56, 55, 346, DateTimeKind.Local).AddTicks(1269), null, 1, null, "I couldn't put it down!", null, "jackdoe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorPublishers_PublisherId",
                table: "AuthorPublishers",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_GenreId",
                table: "Books",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BookId",
                table: "Comments",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_BookId",
                table: "UserBooks",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorPublishers");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "UserBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
