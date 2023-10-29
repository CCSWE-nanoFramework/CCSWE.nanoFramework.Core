﻿using System;
using nanoFramework.TestFramework;

namespace CCSWE.nanoFramework.Core.UnitTests
{
    [TestClass]
    public class StringsTest
    {
        [TestMethod]
        public void Join_should_throw_if_values_is_null()
        {
            Assert.ThrowsException(typeof(ArgumentNullException), () => Strings.Join(string.Empty, null));
        }
    }
}
