using Microsoft.EntityFrameworkCore;
using Moq;
using PhoenixTheatre.DataInfrastructure;
using PhoenixTheatreAPI.Controllers;
using PhoenixTheatreAPI.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace PhoenixTheatreApiTests
{
    public class UnitTest1
    {
        [Fact]
        public void GetAllFilmShowings()
        {
            DateTime showDate = DateTime.Today;
            DateTime showTime = default(DateTime).Add(showDate.TimeOfDay);

            List<FilmShowing> filmTime = new List<FilmShowing>();
            filmTime.Add(new()
            {
                FilmShowingsId = 1,
                TheatreId = 1,
                FilmId = 1,
                ShowDate = showDate,
                Showtime = showTime,
                TicketsAvailable = 40
            });
            filmTime.Add(new()
            {
                FilmShowingsId = 2,
                TheatreId = 1,
                FilmId = 2,
                ShowDate = showDate,
                Showtime = showTime,
                TicketsAvailable = 40
            });

            IEnumerable<FilmShowing> filmShowings = filmTime;
              

            var mockSet = new Mock<DbSet<FilmShowing>>();

            var mockContext = new Mock<Team_A_P2Context>();

            mockContext.Setup(x => x.FilmShowings).Returns(mockSet.Object);

            var mockService = new Mock<PhoenixTheatreService>();

            mockService.Setup(x => x.GetAllFilmShowings()).Returns((Task<IEnumerable<FilmShowing>>)filmShowings);

            var controller = new PhoenixTheatreController(mockService.Object);

            var actual = controller.GetAllFilmShowings();

            Assert.Same(filmShowings, actual);
            Assert.Equal(filmShowings.GetEnumerator(), actual.Result.GetEnumerator());
        }
        //[Fact]
        //public void GetCustomerByNameTest()
        //{
            //Guid customerId = Guid.NewGuid();
            //string firstName = "SomeFirstName";
            //string lastName = "SomeLastName";
            //string userName = "username1";
            //string password = "p@ssword!";

            //Customer customer =
            //    new()
            //    {
            //        CustomerId = customerId,
            //        FirstName = firstName,
            //        LastName = lastName,
            //        Username = userName,
            //        UserPassword = password
            //    };

            //var mockSet = new Mock<DbSet<Customer>>();

            //var mockContext = new Mock<Team_A_P2Context>();

            //mockContext.Setup(x => x.Customers).Returns(mockSet.Object);

            //var mockService = new Mock<PhoenixTheatreService>();

            //mockService.Setup(x => x.GetCustomerByName(firstName, lastName)).Returns(customer);

            //var controller = new PhoenixTheatreController(mockService.Object);

            //var actual = controller.GetCustomerByName(firstName, lastName);

            //Assert.Same(customer, actual.Value);
            //Assert.Equal(customer.CustomerId, actual.Value?.CustomerId);
            //Assert.Equal(customer.FirstName, actual.Value?.FirstName);
            //Assert.Equal(customer.LastName, actual.Value?.LastName);
            //Assert.Equal(customer.Username, actual.Value?.Username);
            //Assert.Equal(customer.UserPassword, actual.Value?.UserPassword);
        //}

        //[Fact]
        //public void GetEmployeeByNameTest()
        //{
            //Guid employeeId = Guid.NewGuid();
            //string firstName = "SomeFirstName";
            //string lastName = "SomeLastName";
            //string userName = "username1";
            //string password = "p@ssword!";
            //string isManager = "yes";
            //int theatreId = 1;

            //Employee employee =
            //    new()
            //    {
            //        EmployeeId = employeeId,
            //        FirstName = firstName,
            //        LastName = lastName,
            //        Username = userName,
            //        UserPassword = password,
            //        IsManager = isManager,
            //        TheatreId = theatreId
            //    };

            //var mockSet = new Mock<DbSet<Employee>>();

            //var mockContext = new Mock<Team_A_P2Context>();

            //mockContext.Setup(x => x.Employees).Returns(mockSet.Object);

            //var mockService = new Mock<PhoenixTheatreService>();

            //mockService.Setup(x => x.GetEmployeeByName(firstName, lastName)).Returns(employee);

            //var controller = new PhoenixTheatreController(mockService.Object);

            //var actual = controller.GetEmployeeByName(firstName, lastName);

            //Assert.Same(employee, actual.Value);
            //Assert.Equal(employee.EmployeeId, actual.Value?.EmployeeId);
            //Assert.Equal(employee.FirstName, actual.Value?.FirstName);
            //Assert.Equal(employee.LastName, actual.Value?.LastName);
            //Assert.Equal(employee.Username, actual.Value?.Username);
            //Assert.Equal(employee.UserPassword, actual.Value?.UserPassword);
            //Assert.Equal(employee.IsManager, actual.Value?.IsManager);
            //Assert.Equal(employee.TheatreId, actual.Value?.TheatreId);
        //}
    }
}