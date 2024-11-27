using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using My_Project;
using My_Project.Controllers;

namespace UnitTests
{
    public class DriverControllerTests
    {


        [Fact]
        public void GetById_ReturnsOk()
        {
            var id = 1;

            var controller = new DriverController();
            var result = controller.Get(id);

            Assert.IsType<OkObjectResult>(result);
        }


        [Fact]
        public void GetAll_ReturnDriversList()
        {

            var controller = new DriverController();
            var result = controller.Get();

           Assert.IsType<List<Driver>>(result);
        }
    }
}
