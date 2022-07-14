using Microsoft.EntityFrameworkCore;
using Orinov.Domain.Entities;

namespace Orinov.Data.Context
{
    public class OrinovDbContext : DbContext
    {
        public OrinovDbContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Cvmodel> Cvmodels { get; set; }
        public DbSet<EducationalBackground> EducationalBackgrounds { get; set; }
        public DbSet<Employment> Employments { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<FileModel> FileModels { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PersonalInformation> PersonalInformations { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<ResearchInterest> ResearchInterests { get; set;}
    }
}
