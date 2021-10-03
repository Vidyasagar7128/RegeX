using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regx;
using System.Text.RegularExpressions;

namespace RegexTest
{
    [TestClass]
    public class UnitTest1
    {
        Patterns patterns = new Patterns();
        happyOrSad happyOrSad = new happyOrSad("happy");
        /// <summary>
        /// Objects Created for both classe 
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            /// FirstName
            string firstName = "John";
            Regex rxN = new Regex(@"^[A-Z]{1}[a-z]{3,}$");
            bool result = rxN.IsMatch(firstName);
            Assert.AreEqual(result,true);
            /// LastName
            string lastName = "Cena";
            Regex rxL = new Regex(@"^[A-Z]{1}[a-z]{3,}$");
            bool result1 = rxL.IsMatch(lastName);
            Assert.AreEqual(result1,true);
            ///Email
            string email = "john.doe@gmail.co.in";
            Regex rxE = new Regex(@"^[a-z]+[.]?[a-z]+[@]+[a-z]+[.]+[a-z]+[.]?[a-z]+$");
            bool resultE = rxE.IsMatch(email);
            Assert.AreEqual(resultE, true);
            ///Mobile
            Regex rxMobile = new Regex(@"^[1-9]+\s[0-9]{10,10}$");
            bool resultM = rxMobile.IsMatch("91 9876543210");
            Assert.AreEqual(resultM, true);
            ///Password
            Regex rxPassword = new Regex(@"^(?=.*[a-zA-Z])(?=.*[0-9]){8,}.+$");
            bool resultP = rxPassword.IsMatch("Pass@1234");
            Assert.AreEqual(resultP, true);
        }
        /// Sad or Happy Entry
        [TestMethod]
        public void HappyOrSadMood()
        {
            string mood = happyOrSad.ChangeMood();
            Assert.AreEqual(mood, "happy");
        }
    }
}
