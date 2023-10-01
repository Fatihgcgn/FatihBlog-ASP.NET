using FatihBlog.Entity;
using Microsoft.EntityFrameworkCore;

namespace FatihBlog.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void TestVerileriniDoldur(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<FatihBlogContext>();

            if(context != null)
            {
                if(context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if(!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Tag {Text = "web programlama"},
                        new Tag {Text = "backend"},
                        new Tag {Text = "frontend"},
                        new Tag {Text = "fullstack"},
                        new Tag {Text = "php"}
                    );
                    context.SaveChanges();
                }

                if(!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User {UserName = "fatihgecgin"},
                        new User {UserName = "furkanenes"}
                    );
                    context.SaveChanges();
                }

                if(!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post {
                            Title = "Asp.net core",
                            Content = "Asp.net core projesi",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(3).ToList(),
                            UserId = 1,
                            },
                            new Post {
                            Title = "PHP",
                            Content = "Asp.net core projesi",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Tags = context.Tags.Take(2).ToList(),
                            UserId = 1,
                            },
                            new Post {
                            Title = "Django",
                            Content = "Django projesi",
                            IsActive = true,
                            PublishedOn = DateTime.Now.AddDays(-5),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2,
                            }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}