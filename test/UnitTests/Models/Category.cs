using NUnit.Framework;
using FluentAssertions;
using WebApi.Models;

namespace UnitTests.Models {
    [TestFixture]
    public class Category {
        [Test]
        public void ShouldBeCreated() {
            var transaction = new Category();
            transaction.Should().NotBeNull();
        }
    }
}