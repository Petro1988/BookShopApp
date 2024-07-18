using Microsoft.EntityFrameworkCore;

namespace BookShopApp.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "You Like It Darker",
                        Author = "Stephen King",
                        Category = "Horror",
                        Price = 14.83m,
                        Description = "From legendary storyteller and master of short fiction Stephen King comes an extraordinary new collection of twelve short stories, many never-before-published, and some of his best EVER. \"You like it darker? Fine, so do I,\" writes Stephen King...",
                        ImageUrl = "img/1.webp"
                    },
                    new Product
                    {
                        Name = "Percy Jackson and the Lightning Thief - The Graphic Novel (Book 1 of Percy Jackson)",
                        Author = "Rick Riordan",
                        Category = "Comics & Manga",
                        Price = 14.99m,
                        Description = "Percy Jackson - now in stunning graphic novel e-book form! Look, I didn't want to be a half-blood. I never asked to be the son of a Greek God. I was just a normal kid, going to school, playing basketball, skateboarding. The usual. Until I accidentally...",
                        ImageUrl = "img/2.jpeg"
                    },
                    new Product
                    {
                        Name = "Samurai",
                        Author = "Jean-Francois Di Giorgio",
                        Category = "Comics & Manga",
                        Price = 28.49m,
                        Description = "Takeo has finally achieved his dream; he has left behind the darkness of his past and become a Samurai. But now, with the courage that comes from knowing you are worthy, he finally feels ready to confront his demons. Yet Imperial Japan is in turmoil;...",
                        ImageUrl = "img/3.jpeg"
                    },
                    new Product
                    {
                        Name = "Two Generals",
                        Author = "Scott Chantler",
                        Category = "Comics & Manga",
                        Price = 19.99m,
                        Description = "A beautifully illustrated and poignant graphic memoir that tells the story of World War II from an Everyman's perspective. In March of 1943, Scott Chantler's grandfather, Law Chantler, shipped out across the Atlantic for active service with the Highland...",
                        ImageUrl = "img/4.webp"
                    },
                    new Product
                    {
                        Name = "Sunset",
                        Author = "Christos N. Gage",
                        Category = "Comics & Manga",
                        Price = 14.83m,
                        Description = "SOMETIMES ALL YOU CAN DO IS GO OUT WITH GUNS BLAZING. In the noir tradition of Chandler and Spillane comes SUNSET, a two-fisted tale of revenge and redemption. On the surface, Nick Bellamy looks like any other veteran retiree left behind by a modern...",
                        ImageUrl = "img/5.webp"
                    },
                    new Product
                    {
                        Name = "Fantastic Four: Full Circle",
                        Author = "Jean-Francois Di Giorgio",
                        Category = "Comics & Manga",
                        Price = 18.99m,
                        Description = "Takeo has finally achieved his dream; he has left behind the darkness of his past and become a Samurai. But now, with the courage that comes from knowing you are worthy, he finally feels ready to confront his demons. Yet Imperial Japan is in turmoil;...",
                        ImageUrl = "img/6.jpeg"
                    },
                    new Product
                    {
                        Name = "The Death Watcher",
                        Author = "Chris Carter",
                        Category = "Horror",
                        Price = 15.48m,
                        Description = "From legendary storyteller and master of short fiction Stephen King comes an extraordinary new collection of twelve short stories, many never-before-published, and some of his best EVER. \"You like it darker? Fine, so do I,\" writes Stephen King...",
                        ImageUrl = "img/7.webp"
                    },
                    new Product
                    {
                        Name = "The Complete Felse Investigations",
                        Author = "Ellis Peters",
                        Category = "Krimis & Thriller",
                        Price = 18.99m,
                        Description = "THE COMPLETE FELSE INVESTIGATIONS - 13 novels in one! No case is too strange or too baffling for the policeman George Felse and his son, Dominic. Over 13 instalments and two decades, the Felse Investigations will take them from their home on...",
                        ImageUrl = "img/8.webp"
                    },
                    new Product
                    {
                        Name = "Forth wing",
                        Author = "Rebecca Yarros",
                        Category = "Fantasy & Science Fiction",
                        Price = 5.99m,
                        Description = "Don't miss out on the series that everyone can't stop talking about! 'Pure escapism - think Hunger Games meets Fifty Shades' - The Sun 'We weren't expecting to become obsessed with Rebecca Yarros's Fourth Wing, but we very much...",
                        ImageUrl = "img/9.jpeg"
                    },
                    new Product
                    {
                        Name = "A Court of Thorns and Roses",
                        Author = "Sarah J. Maas",
                        Category = "Fantasy & Science Fiction",
                        Price = 7.69m,
                        Description = "The first instalment of the GLOBAL PHENOMENON and TikTok sensation, from multi-million selling and #1 Sunday Times bestselling author Sarah J. Maas Maas has established herself as a fantasy fiction titan - Time Harry Potter...",
                        ImageUrl = "img/10.jpeg"
                    },
                    new Product
                    {
                        Name = "Babel",
                        Author = "R. F. Kuang",
                        Category = "Fantasy & Science Fiction",
                        Price = 10.99m,
                        Description = "Instant #1 New York Times Bestseller from the author of The Poppy War. Absolutely phenomenal. One of the most brilliant, razor-sharp books I've had the pleasure of reading that isn't just an alternative fantastical history, but an interrogative one;...",
                        ImageUrl = "img/11.jpeg"
                    },
                    new Product
                    {
                        Name = "Queen of Shadows",
                        Author = "Sarah J. Maas",
                        Category = "Fantasy & Science Fiction",
                        Price = 7.69m,
                        Description = "'One of the best fantasy book series of the past decade' TIME No masters. No limits. No regrets. Aelin Galathynius takes her place as queen in the fourth book of the #1 bestselling Throne of Glass series by Sarah J. Maas....",
                        ImageUrl = "img/12.webp"
                    },
                    new Product
                    {
                        Name = "How To Solve Your Own Murder",
                        Author = "Kristen Perrin",
                        Category = "Historische Krimis",
                        Price = 9.99m,
                        Description = "'VERY funny' Jennie Godfrey 'Smart, twisty, and original' Heat 'Terrific' J. M. Hall 'Superb' Glamour 'Wildly original' Elly Griffiths 'Delightfully refreshing' Daily Mail FRANCES ALWAYS SAID SHE'D BE MURDERED....",
                        ImageUrl = "img/13.webp"
                    },
                    new Product
                    {
                        Name = "The Silent Patient",
                        Author = "Alex Michaelides",
                        Category = "Historische Krimis",
                        Price = 5.49m,
                        Description = "WITH OVER THREE MILLION COPIES SOLD, read the Sunday Times and No.1 New York Times bestselling, record-breaking thriller that everyone is talking about - soon to be a major film. 'The perfect thriller' AJ FINN 'Terrific' - THE...",
                        ImageUrl = "img/14.webp"
                    },
                    new Product
                    {
                        Name = "The Alchemist",
                        Author = "Paulo Coelho",
                        Category = "Historische Krimis",
                        Price = 9.99m,
                        Description = "Paulo Coelho's enchanting novel has inspired a devoted following around the world. This story, dazzling in its powerful simplicity and inspiring wisdom, is about an Andalusian shepherd boy named Santiago who travels from his homeland in Spain to the Egyptian...",
                        ImageUrl = "img/15.webp"
                    }
            
            );
                
                context.SaveChanges();
            }
        }
    }
}
