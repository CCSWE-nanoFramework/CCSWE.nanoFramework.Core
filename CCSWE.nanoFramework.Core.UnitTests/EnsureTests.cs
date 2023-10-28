using nanoFramework.TestFramework;
using System;

namespace CCSWE.nanoFramework.Core.UnitTests
{
    [TestClass]
    public class EnsureTests
    {
        [TestMethod]
        public void IsInRange_throws_ArgumentOutOfRangeException()
        {
            Assert.ThrowsException(typeof(ArgumentOutOfRangeException), () => Ensure.IsInRange(nameof(EnsureTests), false));
        }

        [TestMethod]
        public void IsNotNull_throws_ArgumentNullException()
        {
            Assert.ThrowsException(typeof(ArgumentNullException), () => Ensure.IsNotNull(nameof(EnsureTests), null));
        }

        [TestMethod]
        public void IsNotNullOrEmpty_throws_ArgumentException()
        {
            Assert.ThrowsException(typeof(ArgumentException), () => Ensure.IsNotNullOrEmpty(nameof(EnsureTests), null));
            Assert.ThrowsException(typeof(ArgumentException), () => Ensure.IsNotNullOrEmpty(nameof(EnsureTests), string.Empty));
        }

        [TestMethod]
        public void IsValid_throws_ArgumentException()
        {
            Assert.ThrowsException(typeof(ArgumentException), () => Ensure.IsValid(nameof(EnsureTests), false));
        }

        [TestMethod]
        public void IsValid_throws_Exception()
        {
            Assert.ThrowsException(typeof(ArgumentException), () => Ensure.IsValid(typeof(ArgumentException), nameof(EnsureTests), false));
            Assert.ThrowsException(typeof(ArgumentNullException), () => Ensure.IsValid(typeof(ArgumentNullException), nameof(EnsureTests), false));
            Assert.ThrowsException(typeof(ArgumentOutOfRangeException), () => Ensure.IsValid(typeof(ArgumentOutOfRangeException), nameof(EnsureTests), false));
            Assert.ThrowsException(typeof(IndexOutOfRangeException), () => Ensure.IsValid(typeof(IndexOutOfRangeException), nameof(EnsureTests), false));
            Assert.ThrowsException(typeof(InvalidOperationException), () => Ensure.IsValid(typeof(InvalidOperationException), nameof(EnsureTests), false));
        }
    }
}
