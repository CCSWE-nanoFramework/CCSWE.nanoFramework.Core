using System;
using System.Diagnostics;
using nanoFramework.TestFramework;

namespace CCSWE.nanoFramework.Core.UnitTests
{
    [TestClass]
    public class ThrowHelperTests
    {
        [TestMethod]
        public void ThrowIfNull_throws_ArgumentNullException()
        {
            Assert.ThrowsException(typeof(ArgumentNullException), () => ThrowHelper.ThrowIfNull(null));

        }

        [TestMethod]
        public void ThrowIfNull_throws_ArgumentNullException_with_correct_ParamName()
        {
            object unitTestParameter = null;
            const string expect = nameof(unitTestParameter);
            var testExecuted = false;

            try
            {
                ThrowHelper.ThrowIfNull(unitTestParameter);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual(expect, ex.ParamName);
                testExecuted = true;

                Debug.WriteLine(ex.Message);
            }

            Assert.IsTrue(testExecuted);
        }
    }
}
