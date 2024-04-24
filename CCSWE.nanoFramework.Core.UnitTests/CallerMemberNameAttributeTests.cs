using nanoFramework.TestFramework;
using System.Runtime.CompilerServices;

namespace CCSWE.nanoFramework.Core.UnitTests
{
    [TestClass]
    public class CallerMemberNameAttributeTests
    {
        [TestMethod]
        public void CallerMemberNameAttribute_gets_caller_member_name()
        {
            const string expect = nameof(CallerMemberNameAttribute_gets_caller_member_name);
            var actual = TestCallerMemberName();

            Assert.AreEqual(expect, actual);
        }

        // ReSharper disable once EntityNameCapturedOnly.Local
#pragma warning disable IDE0060
        private static string TestCallerMemberName([CallerMemberName] string memberName = null) => memberName;
#pragma warning restore IDE0060
    }
}
