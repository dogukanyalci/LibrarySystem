using Library_Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_DataAccess.SeedData.EntitySeedData
{
    public class AuthorSeedData : IEntityTypeConfiguration
        <Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData
                (
                new Author
                {
                    Id = 1,
                    Name = "J.K. Rowling",
                    Description
                        = "Joanne Rowling CH, OBE, HonFRSE, FRCPE, FRSL, better known by her pen name J. K. Rowling, is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series, which has won multiple awards and sold more than 500 million copies, becoming the best-selling book series in history. The books are the basis of a popular film series, over which Rowling had overall approval on the scripts and was a producer on the final films. She also writes crime novels under the pen name Robert Galbraith."
                },
                new Author
                {
                    Id = 2,
                    Name = "Stephen King",
                    Description
                    = "Stephen Edwin King is an American author of horror, supernatural fiction, suspense, crime, science-fiction, and fantasy novels. His books have sold more than 350 million copies, and many have been adapted into films, television series, miniseries, and comic books. King has published 61 novels, including seven under the pen name Richard Bachman, and five non-fiction books. He has also written approximately 200 short stories, most of which have been published in book collections."
                },
                new Author
                {
                    Id = 3,
                    Name = "J.R.R. Tolkien",
                    Description
                    = "John Ronald Reuel Tolkien was an English writer, poet, philologist, and academic, best known as the author of the high fantasy works The Hobbit, The Lord of the Rings, and The Silmarillion."
                },
                new Author
                {
                    Id = 4,
                    Name = "George R.R. Martin",
                    Description
                    = "George Raymond Richard Martin, also known as GRRM, is an American novelist and short story writer in the fantasy, horror, and science fiction genres, screenwriter, and television producer. He is best known for his series of epic fantasy novels, A Song of Ice and Fire, which was adapted into the HBO series Game of Thrones."
                },
                new Author
                {
                    Id = 5,
                    Name = "Agatha Christie",
                    Description
                    = "Dame Agatha Mary Clarissa Christie, Lady Mallowan, was an English writer known for her sixty-six detective novels and fourteen short story collections, particularly those revolving around fictional detectives Hercule Poirot and Miss Marple. She also wrote the world's longest-running"
                },
                new Author
                {
                    Id = 6,
                    Name = "Dan Brown",
                    Description
                    = "Daniel Gerhard Brown is an American author best known for his thriller novels, including the Robert Langdon novels Angels & Demons, The Da Vinci Code, The Lost Symbol, Inferno, and Origin. His novels are treasure hunts that usually take place over a period of 24 hours. They feature recurring themes of cryptography, art, and conspiracy theories. His books have been translated into 57 languages and, as of 2012, have sold over 200 million copies. Three of them, Angels & Demons, The Da Vinci Code, and Inferno, have been adapted into films."
                },
                new Author
                {
                    Id = 7,
                    Name = "Arthur Conan Doyle",
                    Description
                    = "Sir Arthur Ignatius Conan Doyle KStJ DL was a British writer and physician. He created the character Sherlock Holmes in 1887 for A Study in Scarlet, the first of four novels and fifty-six short stories about Holmes and Dr. Watson. The Sherlock Holmes stories are considered milestones in the field of crime fiction."
                },
                new Author
                {
                    Id = 8,
                    Name = "Mark Twain",
                    Description
                    = "Samuel Langhorne Clemens, known by his pen name Mark Twain, was an American writer, humorist, entrepreneur, publisher, and lecturer. He was lauded as the 'greatest humorist the United States has produced,' and William Faulkner called him 'the father of American literature'. His novels include The Adventures of Tom Sawyer and its sequel, the Adventures of Huckleberry Finn, the latter often called 'The Great American Novel'."
                },
                new Author
                {
                    Id = 9,
                    Name = "Leo Tolstoy",
                    Description
                    = "Count Lev Nikolayevich Tolstoy, usually referred to in English as Leo Tolstoy, was a Russian writer who is regarded as one of the greatest authors of all time. He received multiple nominations for the Nobel Prize in Literature every year from 1902 to 1906 and nominations for the Nobel Peace Prize in 1901, 1902, and 1910, and his miss of the prize is a major Nobel prize controversy."
                },
                new Author
                {
                    Id = 10,
                    Name = "Fyodor Dostoevsky",
                    Description
                    = "Fyodor Mikhailovich Dostoevsky, sometimes transliterated Dostoyevsky, was a Russian novelist, philosopher, short story writer, essayist, and journalist. Dostoevsky's literary works explore human psychology in the troubled political, social, and spiritual atmospheres of 19th-century Russia, and engage with a variety of philosophical and religious themes. His most acclaimed works include Crime and Punishment, The Idiot, Demons, and The Brothers Karamazov. Dostoevsky's body of works consists of 12 novels, four novellas, 16 short stories, and numerous other works."
                },
                new Author
                {
                    Id = 11,
                    Name = "Ernest Hemingway",
                    Description
                    = "Ernest Miller Hemingway was an American novelist, short-story writer, journalist, and sportsman. His economical and understated style—which he termed the iceberg theory—had a strong influence on 20th-century fiction, while his adventurous lifestyle and his public image brought him admiration from later generations. Hemingway produced most of his work between the mid-1920s and the mid-1950s, and he was awarded the Nobel Prize in Literature in 1954."
                },
                new Author
                {
                    Id = 12,
                    Name = "Sabahattin Ali",
                    Description = "Sabahattin Ali was a Turkish novelist, short-story writer, poet, and journalist. He was born in 1907 in Eğridere township of the Sanjak of Gümülcine (now Komotini in Greece), in the Ottoman Empire, to an Albanian family. He was killed by Ali Ertekin, a government official, on 2 July 1948."
                },
                new Author
                {
                    Id = 13,
                    Name = "Orhan Pamuk",
                    Description
                    = "Ferit Orhan Pamuk is a Turkish novelist, screenwriter, academic, and recipient of the 2006 Nobel Prize in Literature. One of Turkey's most prominent novelists, his work has sold over thirteen million books in sixty-three languages, making him the country's best-selling writer."
                },
                new Author
                {
                    Id = 14,
                    Name = "Franz Kafka",
                    Description
                    = "Franz Kafka was a German-speaking Bohemian writer of novels and short stories, regarded by critics as one of the most significant writers of the 20th century. His work, which fuses elements of realism and the fantastic, typically features isolated protagonists facing bizarre or surrealistic predicaments and incomprehensible socio-bureaucratic powers, and has been interpreted as exploring themes of alienation, existential anxiety, guilt, and absurdity. His best known works include 'Die Verwandlung' ('The Metamorphosis'), Der Process (The Trial), and Das Schloss (The Castle)."
                },
                new Author
                {
                    Id = 15,
                    Name = "Albert Camus",
                    Description
                    = "Albert Camus was a French philosopher, author, and journalist. He won the Nobel Prize in Literature at the age of 44 in 1957, the second-youngest recipient in history. His works include The Stranger, The Plague, The Myth of Sisyphus, The Fall, and The Rebel."
                },
                new Author
                {
                    Id = 16,
                    Name = "Hermann Hesse",
                    Description
                    = "Hermann Karl Hesse was a German-born Swiss poet, novelist, and painter. His best-known works include Demian, Steppenwolf, Siddhartha, and The Glass Bead Game, each of which explores an individual's search for authenticity, self-knowledge and spirituality. In 1946, he received the Nobel Prize in Literature."
                },
                new Author
                {
                    Id = 17,
                    Name = "Halide Edib Adıvar",
                    Description = "Halide Edib Adıvar was a Turkish novelist, nationalist, and political leader. "

                },
                new Author
                {
                    Id = 18,
                    Name = "Nazım Hikmet",
                    Description
                    = "Nazım Hikmet Ran, commonly known as Nazım Hikmet, was a Turkish poet, playwright, novelist, screenwriter, director, and memoirist. He was acclaimed for the 'lyrical flow of his statements'."
                },
                new Author
                {
                    Id = 19,
                    Name = "Ahmet Hamdi Tanpınar",
                    Description
                    = "Ahmet Hamdi Tanpınar was a Turkish poet, novelist, literary historian, and essayist widely regarded as one of the most important representatives of modernism in Turkish literature. He was also a member of the Turkish Parliament."
                },
                new Author
                {
                    Id = 20,
                    Name = "Yusuf Atılgan",
                    Description
                    = "Yusuf Atılgan was a Turkish novelist and playwright. He is best known for his novels Aylak Adam and Anayurt Oteli."
                },
                new Author
                {
                    Id = 21,
                    Name = "Yaşar Kemal",
                    Description
                    = "Yaşar Kemal was a Turkish writer and human rights activist. He received 38 awards during his lifetime and had been a candidate for the Nobel Prize in Literature on the strength of Memed, My Hawk."
                },
                new Author
                {
                    Id = 22,
                    Name = "Orhan Veli Kanık",
                    Description
                    = "Orhan Veli Kanık was a Turkish poet. He is considered one of the pioneers of modern poetry in Turkey."
                },
                new Author
                {
                    Id = 23,
                    Name = "Cemal Süreya",
                    Description
                    = "Cemal Süreya was a Turkish poet and writer. He was one of the greatest Turkish poets of the 20th century."
                },
                new Author
                {
                    Id = 24,
                    Name = "Attilâ İlhan",
                    Description
                    = "Attilâ İlhan was a Turkish poet, novelist, essayist, journalist, and reviewer. He was a prominent member of the Turkish literary scene in the 20th century."
                },
                new Author
                {
                    Id = 25,
                    Name = "Oğuz Atay",
                    Description
                    = "Oğuz Atay was a Turkish novelist, playwright, and engineer. He is best known for his novels Tutunamayanlar and Tehlikeli Oyunlar."
                },
                new Author
                {
                    Id = 26,
                    Name = "Necip Fazıl Kısakürek",
                    Description
                    = "Necip Fazıl Kısakürek was a Turkish poet, novelist, playwright, and philosopher. He was also a political activist, supporting the ideology of Turkish nationalism and Islamism, and was a prominent member of the Turkish Hearth Party."
                },
                new Author
                {
                    Id = 27,
                    Name = "Peyami Safa",
                    Description
                    = "Peyami Safa was a Turkish novelist, storywriter, playwright, essayist, and poet. He is considered one of the greatest Turkish novelists of the 20th century."
                },
                new Author
                {
                    Id = 28,
                    Name = "Reşat Nuri Güntekin",
                    Description
                    = "Reşat Nuri Güntekin was a Turkish novelist, storywriter, playwright, and poet. He was also a prominent and pioneering academic, journalist, and essayist. He is best known for his novels Çalıkuşu and Yaprak Dökümü."
                },
                new Author
                {
                    Id = 29,
                    Name = "Yakup Kadri",
                    Description = "Yakup Kadri Karaosmanoğlu was a Turkish novelist, playwright, and journalist. He was one of the leading Turkish novelists of the Republican era." 
                },
                new Author
                {
                    Id = 30,
                    Name = "Ömer Seyfettin",
                    Description = "Ömer Seyfettin was a Turkish writer, known primarily for his short stories and articles. His stories are written in a clear and precise style and are realistic in nature. They avoid sentimentality and melodrama, and are often concerned with the relationship between people and their environment."
                }
                );
        }
    }
}
