using BlazorHRM.Shared.Domain;

namespace BlazorHRM.App.Services;

public class MockDataService
{
    private static List<Employee>? _employees = default!;
        private static List<JobCategory> _jobCategories = default!;
        private static List<Country> _countries = default!;

        public static List<Employee> Employees
        {
            get
            {
                //we will use these in initialization of Employees
                _countries ??= InitializeMockCountries();

                _jobCategories ??= InitializeMockJobCategories();

                _employees ??= InitializeMockEmployees();

                return _employees;
            }
        }

        private static List<Employee> InitializeMockEmployees()
        {
            var e1 = new Employee
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
                JobCategory = _jobCategories[2],
                JobCategoryId = _jobCategories[2].JobCategoryId,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2019, 3, 1),
                Country = _countries[0],
                CountryId = _countries[0].CountryId
            };

            var e2 = new Employee
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
                JobCategory = _jobCategories[1],
                JobCategoryId = _jobCategories[1].JobCategoryId,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2021, 12, 24),
                Country = _countries[1],
                CountryId = _countries[1].CountryId
            };
            var e3 = new Employee
            {
                MaritalStatus = MaritalStatus.Married,
                BirthDate = new DateTime(1984, 11, 3),
                City = "London",
                Email = "zahir@gmail.com",
                EmployeeId = 2,
                FirstName = "Zahir",
                LastName = "",
                Gender = Gender.Male,
                PhoneNumber = "0704329876",
                Smoker = false,
                Street = "Kings Str 10",
                Zip = "293845",
                JobCategory = _jobCategories[7],
                JobCategoryId = _jobCategories[7].JobCategoryId,
                Comment = "Lorem Ipsum",
                ExitDate = null,
                JoinedDate = new DateTime(2023, 12, 22),
                Country = _countries[6],
                CountryId = _countries[6].CountryId
            };

            return new List<Employee>() { e1, e2, e3 };
        }

        private static List<JobCategory> InitializeMockJobCategories()
        {
            return new List<JobCategory>()
            {
                new JobCategory{JobCategoryId = 1, JobCategoryName = "Research"},
                new JobCategory{JobCategoryId = 2, JobCategoryName = "Sales"},
                new JobCategory{JobCategoryId = 3, JobCategoryName = "Management"},
                new JobCategory{JobCategoryId = 4, JobCategoryName = "Store staff"},
                new JobCategory{JobCategoryId = 5, JobCategoryName = "Finance"},
                new JobCategory{JobCategoryId = 6, JobCategoryName = "QA"},
                new JobCategory{JobCategoryId = 7, JobCategoryName = "IT"},
                new JobCategory{JobCategoryId = 8, JobCategoryName = "Cleaning"},
                new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"},
                new JobCategory{JobCategoryId = 9, JobCategoryName = "Bakery"}
            };
        }

        private static List<Country> InitializeMockCountries()
        {
            return new List<Country>
            {
                new Country {CountryId = 1, Name = "Sweden"},
                new Country {CountryId = 2, Name = "Russia"},
                new Country {CountryId = 3, Name = "USA"},
                new Country {CountryId = 4, Name = "Japan"},
                new Country {CountryId = 5, Name = "China"},
                new Country {CountryId = 6, Name = "UK"},
                new Country {CountryId = 7, Name = "France"},
                new Country {CountryId = 8, Name = "Brazil"}
            };
        }
}