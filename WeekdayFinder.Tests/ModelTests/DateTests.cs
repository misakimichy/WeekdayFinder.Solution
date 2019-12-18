using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;

namespace WeekdayFinder.Test
{
    [TestClass]
    public class DateTests
    {
        [TestMethod]
        public void Date_GetDate_Monday()
        {
            string result = Date.GetDate(2, 12, 2019);
            Assert.AreEqual(result, "Monday");
        }
    }
}
