using System;
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
                // ReSharper disable once ExpressionIsAlwaysNull
                ThrowHelper.ThrowIfNull(unitTestParameter);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual(expect, ex.ParamName);
                testExecuted = true;
            }

            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            Assert.IsTrue(testExecuted);
        }

        [TestMethod]
        public void ThrowIfNullOrEmpty_throws_ArgumentNullException()
        {
            Assert.ThrowsException(typeof(ArgumentNullException), () => ThrowHelper.ThrowIfNullOrEmpty(null));

        }

        [TestMethod]
        public void ThrowIfNullOrEmpty_throws_ArgumentNullException_with_correct_ParamName()
        {
            string unitTestParameter = null;
            const string expect = nameof(unitTestParameter);
            var testExecuted = false;

            try
            {
                // ReSharper disable once ExpressionIsAlwaysNull
                ThrowHelper.ThrowIfNullOrEmpty(unitTestParameter);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual(expect, ex.ParamName);
                testExecuted = true;
            }

            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            Assert.IsTrue(testExecuted);
        }

    }
}
