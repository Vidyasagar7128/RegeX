using Microsoft.VisualStudio.TestTools.UnitTesting;
using Regx;
using System.Text.RegularExpressions;

namespace RegexTest
{
    [TestClass]
    public class UnitTest1
    {
        Patterns patterns = new Patterns();
        HappyOrSad happyOrSad = new HappyOrSad("happy");
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
            try
            {
                if (firstName == "")
                    throw new CustomE(CustomE.Errors.EmptyString, "Empty First Name");
                if (firstName.Length < 3)
                    throw new CustomE(CustomE.Errors.MinLength, "It's too Short");
                if (!rxN.IsMatch(firstName))
                    throw new CustomE(CustomE.Errors.InvalidName, "Invalid Name");
            }
            catch(CustomE e)
            {
                Assert.AreEqual("result", e.Message);
            }
            /// LastName
            string lastName = "Cena";
            Regex rxL = new Regex(@"^[A-Z]{1}[a-z]{3,}$");
            bool result1 = rxL.IsMatch(lastName);
            try
            {
                if (lastName == "")
                    throw new CustomE(CustomE.Errors.EmptyString, "Empty Last Name");
                if (lastName.Length < 3)
                    throw new CustomE(CustomE.Errors.MinLength, "It's too Short");
                if (!rxN.IsMatch(lastName))
                    throw new CustomE(CustomE.Errors.InvalidName, "Invalid Last Name");
            }
            catch (CustomE e)
            {
                Assert.AreEqual("result", e.Message);
            }
            ///Email
            string email = "john.doe@gmail.co.in";
            Regex rxE = new Regex(@"^[a-z]+[.]?[a-z]+[@]+[a-z]+[.]+[a-z]+[.]?[a-z]+$");
            bool resultE = rxE.IsMatch(email);
            try
            {
                if (email == "")
                    throw new CustomE(CustomE.Errors.EmptyString, "Email is Empty");
                if (!rxE.IsMatch(email))
                    throw new CustomE(CustomE.Errors.InvalidEmail, "Invalid Email");
            }
            catch (CustomE e)
            {
                Assert.AreEqual("result", e.Message);
            }
            ///Mobile
            string mobile = "91 9876543210";
            Regex rxMobile = new Regex(@"^[1-9]+\s[0-9]{10,10}$");
            bool resultM = rxMobile.IsMatch(mobile);
            try
            {
                if (mobile == "")
                    throw new CustomE(CustomE.Errors.EmptyString, "Empty Mobile Number");
                if (mobile.Length < 10)
                    throw new CustomE(CustomE.Errors.MinLength, "It's too Short");
                if (!rxMobile.IsMatch(mobile))
                    throw new CustomE(CustomE.Errors.InvalidNumber, "Invalid Mobile Number");
            }
            catch (CustomE e)
            {
                Assert.AreEqual("result", e.Message);
            }
            ///Password
            string pass = "Pass@1234";
            Regex rxPassword = new Regex(@"^(?=.*[a-zA-Z])(?=.*[0-9]){8,}.+$");
            bool resultP = rxPassword.IsMatch("Pass@1234");
            try
            {
                if (pass == "")
                    throw new CustomE(CustomE.Errors.EmptyString, "Empty Password");
                if (pass.Length < 8)
                    throw new CustomE(CustomE.Errors.MinLength, "It's too Short");
                if (!rxPassword.IsMatch(pass))
                    throw new CustomE(CustomE.Errors.InvalidPassword, "Invalid Mobile Number");
            }
            catch (CustomE e)
            {
                Assert.AreEqual("result", e.Message);
            }
        }
        /// Sad or Happy Entry
        [TestMethod]
        public void HappyOrSadMood()
        {
            string mood = happyOrSad.ChangeMood();
            Assert.AreEqual(mood, "happy");
        }
        /// Custom Exception
        //[TestMethod]
        //public void CustomException()
        //{
            
        //}
    }
}
