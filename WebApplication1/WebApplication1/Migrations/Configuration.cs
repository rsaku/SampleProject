namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication1.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Models.MovieDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "�m�`�Ȃ��킢",
                    Director = "�[��ӓ�",
                    ReleaseDate = DateTime.Parse("1979-1-13"),
                    Genre = "�₭��",
                    Price = 7990M
                },
                new Movie
                {
                    Title = "�f��P",
                    Director = "�W�����E�X�~�X",
                    ReleaseDate = DateTime.Parse("2017-1-10"),
                    Genre = "�z���[",
                    Price = 2000M

                },
                new Movie
                {
                    Title = "�f��Q",
                    Director = "�W�����E�X�~�X",
                    ReleaseDate = DateTime.Parse("2017-1-20"),
                    Genre = "�R���f�B",
                    Price = 2000M

                }
                );
                
        }
    }
}
