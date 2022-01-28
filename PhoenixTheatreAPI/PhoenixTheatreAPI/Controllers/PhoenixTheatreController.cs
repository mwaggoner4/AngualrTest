using Microsoft.AspNetCore.Mvc;
using PhoenixTheatre.DataInfrastructure;
using PhoenixTheatreAPI.Services;

namespace PhoenixTheatreAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PhoenixTheatreController : ControllerBase
    {
        PhoenixTheatreService _service;

        public PhoenixTheatreController(PhoenixTheatreService service)
        {
            _service = service;
        }

        [HttpGet("filmShowings")]
        public async Task<IEnumerable<FilmShowing>> GetAllFilmShowings()
        {
            return await _service.GetAllFilmShowings();
        }

        [HttpGet("movies")]
        public async Task<IEnumerable<TheatreFilm>> GetAllTheatreFilms()
        {
            return await _service.GetAllTheatreFilms();
        }

        [HttpGet("orderId")]
        public async Task<ActionResult<CustomerOrder>> GetOrderById(Guid orderId)
        {
            var order = await _service.GetOrderById(orderId);

            if(order != null)
            {
                return order;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("customer")]
        public async Task<ActionResult<Customer>> GetCustomerByName(string firstName, string lastName)
        {
            var customer = await _service.GetCustomerByName(firstName, lastName);

            if(customer != null)
            {
                return customer;
            }
            else
            {
                return NotFound();
            }
                
        }

        [HttpGet("customer/username")]
        public async Task<ActionResult<Customer>> GetCustomerByUsername(string username, string password)
        {
            var customer = await _service.GetCustomerByUsername(username, password);

            if (customer != null)
            {
                return customer;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("employee")]
        public async Task<ActionResult<Employee>> GetEmployeeByName(string firstName, string lastName)
        {
            var employee = await _service.GetEmployeeByName(firstName, lastName);
            if(employee != null)
            {
                return employee;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("employee/username")]
        public async Task<ActionResult<Employee>> GetEmployeeByUsername(string username, string password)
        {
            var employee = await _service.GetEmployeeByUsername(username, password);

            if (employee != null)
            {
                return employee;
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost("createCustomer")]
        public IActionResult CreateCustomer(string firstName, string lastName, string username, string userPassword)
        {
            Customer newCustomer = new Customer
            {
                CustomerId = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                UserPassword = userPassword
            };
            var customer = _service.CreateCustomer(newCustomer);
            return CreatedAtAction(nameof(GetCustomerByUsername), new { username = customer!.Username }, customer);
        }

        [HttpPost("createEmployee")]
        public IActionResult CreateEmployee(string firstName, string lastName, string username, string userPassword, string IsManager, int theatreId)
        {
            Employee newEmployee = new Employee
            {
                EmployeeId = Guid.NewGuid(),
                FirstName = firstName,
                LastName = lastName,
                Username = username,
                UserPassword = userPassword,
                IsManager = IsManager,
                TheatreId = theatreId
            };
            var employee = _service.CreateEmployee(newEmployee);
            return CreatedAtAction(nameof(GetEmployeeByUsername), new { username = employee!.Username }, employee);
        }

        [HttpPost("{order}")]
        public IActionResult CreateOrder(string username, string password, int theatreId, List<InvoiceLineItem> invoiceLineItems)
        {
            var customer = GetCustomerByUsername(username, password);
            CustomerOrder newOrder = new CustomerOrder
            {
                OrderId = Guid.NewGuid(),
                CustomerId = customer.Result.Value.CustomerId,
                TheatreId = theatreId,
            };
            throw new NotImplementedException();
        }
    }
}
