/*
 * LiteraryToutism context
 * Describes the interaction with the database
 * created by: Vlasov R.E.
 * e-mail: ryslanvlasov@mail.ru
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Literary_tourism.Models
{
    public class LiteraryTourismContext : DbContext
    {
        public LiteraryTourismContext(DbContextOptions<LiteraryTourismContext> options)
            : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Writers> Writers { get; set; }
        public DbSet<Museums> Museums { get; set; }
        public DbSet<Museum_writer> Museum_writer { get; set; }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Movie_writer> Movie_writer { get; set; }
        public DbSet<Works> Works { get; set; }
        public DbSet<Genres_of_literature> Genres_of_literature { get; set; }
        public DbSet<Spectacles> Spectacles { get; set; }
        public DbSet<Theaters> Theaters { get; set; }
        public DbSet<Spectacle_writer> Spectacle_writer { get; set; }
        public DbSet<Places> Places { get; set; }
        public DbSet<Types_of_place_relations> Types_of_place_relations { get; set; }
        public DbSet<Place_writer> Place_writer { get; set; }
        public DbSet<Place_work> Place_work { get; set; }
        public DbSet<Pictures> Pictures { get; set; }
        public DbSet<Picture_museum> Picture_museum { get; set; }
        public DbSet<Picture_place> Picture_place { get; set; }
        public DbSet<Picture_spectacle> Picture_spectacle { get; set; }
        public DbSet<Picture_theater> Picture_theater { get; set; }
        public DbSet<Picture_writer> Picture_writer { get; set; }
        public DbSet<Comment_movie> Comment_movie { get; set; }
        public DbSet<Comment_museum> Comment_museum { get; set; }
        public DbSet<Comment_place> Comment_place { get; set; }
        public DbSet<Comment_route> Comment_route { get; set; }
        public DbSet<Comment_spectacle> Comment_spectacle { get; set; }
        public DbSet<Comment_work> Comment_work { get; set; }
        public DbSet<Mark_of_movie> Mark_of_movie { get; set; }
        public DbSet<Mark_of_museum> Mark_of_museum { get; set; }
        public DbSet<Mark_of_place> Mark_of_place { get; set; }
        public DbSet<Mark_of_route> Mark_of_route { get; set; }
        public DbSet<Mark_of_spectacle> Mark_of_spectacle { get; set; }
        public DbSet<Mark_of_work> Mark_of_work { get; set; }
        public DbSet<Routes> Routes { get; set; }
        public DbSet<Route_movie> Route_movie { get; set; }
        public DbSet<Route_museum> Route_museum { get; set; }
        public DbSet<Route_place> Route_place { get; set; }
        public DbSet<Route_spectacle> Route_spectacle { get; set; }

        public LiteraryTourismContext()
        { 
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .HasKey(c => new { c.Id_user});
            modelBuilder.Entity<Writers>()
                .HasKey(c => new { c.Id_writer });
            modelBuilder.Entity<Museums>()
                .HasKey(c => new { c.Id_museum });
            modelBuilder.Entity<Museum_writer>()
                .HasKey(c => new { c.Id_museum, c.Id_writer });
            modelBuilder.Entity<Movies>()
                .HasKey(c => new { c.Id_movie });
            modelBuilder.Entity<Movie_writer>()
                .HasKey(c => new { c.Id_movie, c.Id_writer });
            modelBuilder.Entity<Works>()
                .HasKey(c => new { c.Id_work });
            modelBuilder.Entity<Genres_of_literature>()
                .HasKey(c => new { c.Id_genre });
            modelBuilder.Entity<Spectacles>()
                .HasKey(c => new { c.Id_spectacle });
            modelBuilder.Entity<Theaters>()
                .HasKey(c => new { c.Id_theater });
            modelBuilder.Entity<Spectacle_writer>()
                .HasKey(c => new { c.Id_spectacle, c.Id_writer });
            modelBuilder.Entity<Places>()
                .HasKey(c => new { c.Id_place });
            modelBuilder.Entity<Types_of_place_relations>()
                .HasKey(c => new { c.Id_type_relation });
            modelBuilder.Entity<Place_writer>()
                .HasKey(c => new { c.Id_place, c.Id_writer });
            modelBuilder.Entity<Place_work>()
                .HasKey(c => new { c.Id_place, c.Id_work });
            modelBuilder.Entity<Pictures>()
                .HasKey(c => new { c.Id_picture });
            modelBuilder.Entity<Picture_museum>()
                .HasKey(c => new { c.Id_picture, c.Id_museum });
            modelBuilder.Entity<Picture_place>()
                .HasKey(c => new { c.Id_picture, c.Id_place });
            modelBuilder.Entity<Picture_spectacle>()
                .HasKey(c => new { c.Id_picture, c.Id_spectacle });
            modelBuilder.Entity<Picture_theater>()
                .HasKey(c => new { c.Id_picture, c.Id_theater });
            modelBuilder.Entity<Picture_writer>()
                .HasKey(c => new { c.Id_picture, c.Id_writer });
            modelBuilder.Entity<Comment_movie>()
                .HasKey(c => new { c.Id_comment });
            modelBuilder.Entity<Comment_museum>()
                .HasKey(c => new { c.Id_comment});
            modelBuilder.Entity<Comment_place>()
                .HasKey(c => new { c.Id_comment });
            modelBuilder.Entity<Comment_route>()
                .HasKey(c => new { c.Id_comment});
            modelBuilder.Entity<Comment_spectacle>()
                .HasKey(c => new { c.Id_comment });
            modelBuilder.Entity<Comment_work>()
                .HasKey(c => new { c.Id_comment });
            modelBuilder.Entity<Mark_of_movie>()
                .HasKey(c => new { c.Id_mark });
            modelBuilder.Entity<Mark_of_museum>()
                .HasKey(c => new { c.Id_mark});
            modelBuilder.Entity<Mark_of_place>()
                .HasKey(c => new { c.Id_mark});
            modelBuilder.Entity<Mark_of_route>()
                .HasKey(c => new { c.Id_mark});
            modelBuilder.Entity<Mark_of_spectacle>()
                .HasKey(c => new { c.Id_mark });
            modelBuilder.Entity<Mark_of_work>()
                .HasKey(c => new { c.Id_mark });
            modelBuilder.Entity<Routes>()
                .HasKey(c => new { c.Id_route });
            modelBuilder.Entity<Route_movie>()
                .HasKey(c => new { c.Id_route, c.Id_movie });
            modelBuilder.Entity<Route_museum>()
                .HasKey(c => new { c.Id_route, c.Id_museum });
            modelBuilder.Entity<Route_place>()
                .HasKey(c => new { c.Id_route, c.Id_place });
            modelBuilder.Entity<Route_spectacle>()
                .HasKey(c => new { c.Id_route, c.Id_spectacle });


            //  modelBuilder.Entity<Users>()
            //     .HasIndex(u => u.Login)
            //     .IsUnique();
        }

       // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       // {
       //     optionsBuilder.UseMySql("server=localhost;UserId=user;Password=password;database=literary_tourism;");
       // }
    }
}
