using System.Linq;
using ApprovalTests.Utilities;
using ApprovalUtilities.Utilities;
using NUnit.Framework;

namespace FakeItTillYouMakeIt
{
    public class FizzBuzzTest
    {
        [Test]
        public void TestFizzBuzz()
        {
            // TODO: Delete this after the first tun
            // ---------------------------------------------------------------------------------------------------------
            var java = PathUtilities.LocateFileFromEnvironmentPath("javaw.exe");
            var counterDisplayJar = PathUtilities.GetAdjacentFile("CounterDisplay.jar");
            TestCounter.ResetAndLaunch(java.FirstOrDefault(), counterDisplayJar); // Comment out after 1st run
            // ---------------------------------------------------------------------------------------------------------

            TestCounter.Track(Check20);
        }

        private static void Check20()
        {
            Assert.That("expected", Is.EqualTo("expected"));
        }
    }
}