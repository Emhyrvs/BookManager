using BookManager.Models;

namespace BookManager.Data
{
    public class PrepDbcs
    {
        public static async Task PrepPopulation(IApplicationBuilder app, bool isProduction)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {


                await SeedData(serviceScope.ServiceProvider.GetRequiredService<DataDbContext>());
            }
        }

        private static async Task SeedData(DataDbContext context)
        {

            if (!context.Books.Any())
            {
                Console.WriteLine("Seeding data...");

                context.Books.AddRange(
                    new Book
                    {
                        Id = Guid.NewGuid(),
                        Title = "The Great Gatsby",
                        Author = "F. Scott Fitzgerald",
                        YearOfPublication = 1925,
                        ISBN = "978-0743273565",
                        NumberOFPages = 180
                    },
                    new Book
                    {
                        Id = Guid.NewGuid(),
                        Title = "To Kill a Mockingbird",
                        Author = "Harper Lee",
                        YearOfPublication = 1960,
                        ISBN = "978-0060935467",
                        NumberOFPages = 324
                    },
                    new Book
                    {
                        Id = Guid.NewGuid(),
                        Title = "1984",
                        Author = "George Orwell",
                        YearOfPublication = 1949,
                        ISBN = "978-0451524935",
                        NumberOFPages = 328
                    },
                    new Book
                    {
                        Id = Guid.NewGuid(),
                        Title = "Pride and Prejudice",
                        Author = "Jane Austen",
                        YearOfPublication = 1813,
                        ISBN = "978-1503290563",
                        NumberOFPages = 279
                    },
                    new Book
                    {
                        Id = Guid.NewGuid(),
                        Title = "The Catcher in the Rye",
                        Author = "J.D. Salinger",
                        YearOfPublication = 1951,
                        ISBN = "978-0316769488",
                        NumberOFPages = 214
                    }
                );

                await context.SaveChangesAsync();
                Console.WriteLine("Seeding completed.");
            }
            else
            {
                Console.WriteLine("Database already contains data.");
            }




        }
    }
}
