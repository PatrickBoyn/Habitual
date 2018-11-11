using Habitual.Controllers;
using Habitual.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace Habitual.Tests
{
    [TestFixture]
    public class ControllerTests
    {
        [Test]
        public  void GetValuesTest()
        {
            var controller = new ValuesController(new HabitContext(new DbContextOptions<HabitContext>()));

            var result = controller.GetValues();
            Assert.That(result, Is.Not.Null);
        }
    }
}