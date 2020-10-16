﻿using System.Linq;
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
            var java = PathUtilities.LocateFileFromEnvironmentPath("javaw.exe");
            var counterDisplayJar = PathUtilities.GetAdjacentFile("CounterDisplay.jar");

            TestCounter.ResetAndLaunch(java.FirstOrDefault(), counterDisplayJar); // Comment out after 1st run
            TestCounter.Track(Check20);
        }

        private static void Check20()
        {
            const string expected = "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,19,Buzz";
            Assert.AreEqual(expected, FizzBuzz.Print(20));
        }
    }

    public static class FizzBuzz
    {
        public static string Print(int top)
        {
            return "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,19,Buzz";
        }
    }
}