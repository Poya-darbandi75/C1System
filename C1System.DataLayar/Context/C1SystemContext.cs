
using C1System.DataLayar.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1System.DataLayar.Entities.Geo;
using C1System.DataLayar.Entities.Blog;
using C1System.DataLayar.Entities.CareerOpportunity;
using C1System.DataLayar.Entities.Faq;
using C1System.DataLayar.Entities.NewsLetter;
using C1System.DataLayar.Entities.Ticket;

namespace C1System.DataLayar.Context
{
    public class C1SystemContext : DbContext
    {
        public C1SystemContext(DbContextOptions<C1SystemContext> options) : base(options)
        {

        }

        public virtual DbSet<Slider> Sliders { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        public virtual DbSet<Introduction> Introductions { get; set; }
        public virtual DbSet<CustomerSpeech> CustomerSpeechs { get; set; }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryPackage> CategoryPackages { get; set; }
        public virtual DbSet<CategoryPackageItem> CategoryPackageItems { get; set; }
        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Podcast> Podcasts { get; set; }

        public virtual DbSet<Gender> Genders { get; set; }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<CareerOpportunity> CareerOpportunities { get; set; }
        public virtual DbSet<Faq> Faqs { get; set; }
        public virtual DbSet<NewsLetter> NewsLetters { get; set; }
        public virtual DbSet<DemoPortfolio> DemoPortfolios { get; set; }
        public virtual DbSet<TechnologyPortfolio> TechnologyPortfolios { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
        public virtual DbSet<TicketStatus> TicketStatuses { get; set; }

    }
}
