using Microsoft.EntityFrameworkCore;
using BlazorHRM.Shared.Domain;
namespace BlazorHRM.Api.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 1, Name = "Sweden" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 2, Name = "Russia" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 3, Name = "Netherlands" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 4, Name = "USA" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 5, Name = "Japan" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 6, Name = "China" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 7, Name = "UK" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 8, Name = "France" });
            modelBuilder.Entity<Country>().HasData(new Country { CountryId = 9, Name = "Brazil" });

            modelBuilder.Entity<JobCategory>().HasData(new JobCategory(){JobCategoryId = 1, JobCategoryName = "Research"});
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory(){JobCategoryId = 2, JobCategoryName = "Sales"});
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory(){JobCategoryId = 3, JobCategoryName = "Management"});
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory(){JobCategoryId = 4, JobCategoryName = "Store staff"});
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory(){JobCategoryId = 5, JobCategoryName = "Finance"});
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory(){JobCategoryId = 6, JobCategoryName = "QA"});
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory(){JobCategoryId = 7, JobCategoryName = "IT"});
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory(){JobCategoryId = 8, JobCategoryName = "Cleaning"});
            modelBuilder.Entity<JobCategory>().HasData(new JobCategory(){JobCategoryId = 9, JobCategoryName = "Bakery"});

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                MaritalStatus = MaritalStatus.Single,
                BirthDate = new DateTime(1999, 3, 11),
                City = "Stockholm",
                Email = "christina@mail.com",
                EmployeeId = 1,
                FirstName = "Christina",
                LastName = "Berg",
                Gender = Gender.Female,
                PhoneNumber = "0702341212",
                Smoker = false,
                Street = "Drottninggatan 12",
                Zip = "13321",
                JobCategoryId = 2,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2019, 3, 1),
                CountryId = 1
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                MaritalStatus = MaritalStatus.Married,
                BirthDate = new DateTime(1986, 4, 16),
                City = "Moscow",
                Email = "ali@gmail.com",
                EmployeeId = 2,
                FirstName = "Ali",
                LastName = "Caceres",
                Gender = Gender.Male,
                PhoneNumber = "0703452121",
                Smoker = false,
                Street = "Alfred Nobel Str 10",
                Zip = "13345",
                JobCategoryId = 1,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2021, 12, 24),
                CountryId = 2
            });
        }
}