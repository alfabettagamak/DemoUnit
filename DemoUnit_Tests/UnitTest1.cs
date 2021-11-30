using DemoUnit;
using NUnit.Framework;

namespace DemoUnit_Tests
{
    public class Tests
    {

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void CheckSomeMethodByEmptyStringTesting(string message)
        {
            var actual = NewClass.SomeMethod(message);
            var expected = "Вы ничего не ввели";
            Assert.AreEqual(expected, actual, $"SomeMethod отработал некорректно. Ожидали: {expected}. Получено: {actual}.");
        }
        
        [Test]
        [TestCase("message")]
        public void CheckSomeMethodByNonEmptyStringTesting(string message)
        {
            var actual = NewClass.SomeMethod(message);
            var expected = "Вы ввели " + message;
            Assert.AreEqual(expected, actual, $"SomeMethod отработал некорректно. Ожидали: {expected}. Получено: {actual}.");
        }
    }
}