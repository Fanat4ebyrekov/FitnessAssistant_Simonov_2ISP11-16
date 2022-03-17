using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FitnessAssistentTests
{
    [TestClass]
    public class ValidationTest
    {


        [TestMethod]
        public void ValidationPassword_Length7_returnfalse()
        {
            // Arange - вх. параметр
            string password = "Aa1@aaa";
            bool ex = false;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationPassword(password);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);    
        }

        [TestMethod]
        public void ValidationPassword_Length21_returnfalse()
        {
            // Arange - вх. параметр
            string password = "Aa1@wwefwageqrgqrghqe";
            bool ex = false;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationPassword(password);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_Space_returnfalse()
        {
            // Arange - вх. параметр
            string password = " ";
            bool ex = false;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationPassword(password);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_Pustota_returnfalse()
        {
            // Arange - вх. параметр
            string password = "";
            bool ex = false;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationPassword(password);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_SmallLatter_returnfalse()
        {
            // Arange - вх. параметр
            string password = "aaaaaaaa";
            bool ex = false;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationPassword(password);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_BigLatter_returnfalse()
        {
            // Arange - вх. параметр
            string password = "AAAAAAAA";
            bool ex = false;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationPassword(password);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_SpecSymbols_returnfalse()
        {
            // Arange - вх. параметр
            string password = "aa1aaaaa";
            bool ex = false;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationPassword(password);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }


        [TestMethod]
        public void ValidationPassword_Length8_ReturnTrua()
        {
            // Arange - вх. параметр
            string password = "A1@aaaaa";
            bool ex = true;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationPassword(password);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_Length20_ReturnTrue()
        {
            // Arange - вх. параметр
            string password = "a1@aaaaaAa1@aaaaaaaa";
            bool ex = true;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationPassword(password);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_CorrectPAssword_ReturnTrua()
        {
            // Arange - вх. параметр
            string password = "Aa1@aaaaa";
            bool ex = true;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationPassword(password);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFNameLName_CorrectFName_ReturnTrua()
        {
            // Arange - вх. параметр
            string FNameLName = "Nikita-Nikita";
            bool ex = true;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationFName(FNameLName);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFNameLName_CorrectLName_ReturnTrua()
        {
            // Arange - вх. параметр
            string LName = "Nikita-Nikita";
            bool ex = true;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationLName(LName);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBirthday_CorrectBirthday_ReturnTrua()
        {
            // Arange - вх. параметр
            DateTime str = new DateTime(2032-2-25);
            bool ex = true;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationBirthday(str);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBirthday_CorrectBirthday_ReturnFalse()
        {
            // Arange - вх. параметр
            DateTime str = new DateTime(25-01-2032);
            bool ex = false;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationBirthday(str);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }


        [TestMethod]
        public void ValidationWeight_IsSpaced_ReturnFalse()
        {
            //Arrange
            string code = " ";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationVes(code);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationWeight_Value300_ReturnFalse()
        {
            //Arrange
            string code = "301";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationVes(code);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationWeight_Value300_ReturnTrue()
        {
            //Arrange
            string code = "300";
            bool ex = true;
            //Act
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationVes(code);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationWeight_Value0_ReturnFalse()
        {
            //Arrange
            string code = "0";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationVes(code);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationWeight_SpecSymb_ReturnFalse()
        {
            //Arrange
            string code = "@";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationVes(code);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationHeight_IsSpaced_ReturnFalse()
        {
            //Arrange
            string code = " ";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationHeight(code);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationHeight_Value300_ReturnFalse()
        {
            //Arrange
            string code = "301";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationHeight(code);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationHeight_Value300_ReturnTrue()
        {
            //Arrange
            string code = "300";
            bool ex = true;
            //Act
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationHeight(code);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationHeight_Value0_ReturnFalse()
        {
            //Arrange
            string code = "0";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationHeight(code);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationHeight_SpecSymb_ReturnFalse()
        {
            //Arrange
            string code = "@";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationHeight(code);
            //Assert
            Assert.AreEqual(ex, act);
        }

    }
}
