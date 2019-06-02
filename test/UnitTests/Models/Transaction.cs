using NUnit.Framework;
using FluentAssertions;
using WebApi.Models;

namespace UnitTests.Models {
    [TestFixture]
    public class Transaction {
        [Test]
        public void ShouldBeCreated() {
            var transaction = new Transaction();
            transaction.Should().NotBeNull();
        }
    }
}