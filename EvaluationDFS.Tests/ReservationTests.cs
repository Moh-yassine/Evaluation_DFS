using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EvaluationDFS.Tests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_AdminUser_ReturnsTrue()
        {
            // Arrange
            var adminUser = new User { IsAdmin = true };
            var reservation = new Reservation(new User());

            // Act
            var result = reservation.CanBeCancelledBy(adminUser);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_SameUser_ReturnsTrue()
        {
            // Arrange
            var user = new User { IsAdmin = false };
            var reservation = new Reservation(user);

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanBeCancelledBy_AnotherUser_ReturnsFalse()
        {
            // Arrange
            var user = new User { IsAdmin = false };
            var anotherUser = new User { IsAdmin = false };
            var reservation = new Reservation(user);

            // Act
            var result = reservation.CanBeCancelledBy(anotherUser);

            // Assert
            Assert.IsFalse(result);
        }
    }
}