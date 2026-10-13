using Microsoft.EntityFrameworkCore;
using MyAcademy_PortfolioProject.Entities;

namespace MyAcademy_PortfolioProject.Context
{
    public class PortfolioContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//bu sınıf içinde yapılandırma yapacağım ve yapılandırma şöyle olacak diyoruz
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R264HR4; Database=PortfolioDbNight;integrated security=true; trust server certificate=true");
        }
        public DbSet<About>Abouts { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<HeroSection> HeroSections { get; set; }




    }
}
//override: işlemi gerçekleştiriyor ama benim istediğim gibi 

//Payment  --> Pay() --> Havale/Eft, Kredi Kartı, Kapıda Ödeme
