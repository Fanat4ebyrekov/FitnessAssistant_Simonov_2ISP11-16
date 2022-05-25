using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FitnessAssistant_Simonov_2ISP11_16.EF;
using static FitnessAssistant_Simonov_2ISP11_16.Classes.Validation;


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
        public void ValidationPassword_NonToApper_returnfalse()
        {
            // Arange - вх. параметр
            string password = "aaaaaa1@";
            bool ex = false;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationPassword(password);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_NonToSmaller_returnfalse()
        {
            // Arange - вх. параметр
            string password = "AAAAAA1@";
            bool ex = false;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationPassword(password);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_NonSpecSymbols_returnfalse()
        {
            // Arange - вх. параметр
            string password = "Aa1aaaaa";
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
            DateTime str = new DateTime(2002-2-25);
            bool ex = true;
            // Act - вызов метода тестируемого 
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationBirthday(str);
            // Assert - сравнение 
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBirthday_UnCorrectBirthday_ReturnFalse()
        {
            // Arange - вх. параметр
            DateTime str = DateTime.Now;
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

        [TestMethod]
        public void ValidationLogin_LoginRepeat_returnFalse()
        {
            //Arrange
            string login = "KrytoiNikita";
            bool ex = false;
            //Act
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationLogin(login);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationLogin_LoginCorrect_returnTrue()
        {
            //Arrange
            string login = "9";
            bool ex = true;
            //Act
            bool act = FitnessAssistant_Simonov_2ISP11_16.Classes.Validation.ValidationLogin(login);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMI_Error_returnFalse()
        {
            //Arrange
            double height = 0;
            double weight = 0;
            var ex = "Ошибка";
            //Act
            var act = FitnessAssistant_Simonov_2ISP11_16.Classes.Calculation.BMI(height,weight);
            //Assert
            Assert.AreEqual(ex, act);
        }
        
        [TestMethod]
        public void ValidationBMI_Deficit_returnFalse()
        {
             
            //Arrange
            double height = 1.70;
            double weight = 50;
            var ex = "Выражение дефицит массы тела";
            //Act
            var act = FitnessAssistant_Simonov_2ISP11_16.Classes.Calculation.BMI(height, weight);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMI_NormVes_returnTrue()
        {

            //Arrange
            double height = 1.90;
            double weight = 70.5;
            var ex = "Нормальная масса тела";
            //Act
            var act = FitnessAssistant_Simonov_2ISP11_16.Classes.Calculation.BMI(weight, height);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_SexMan_returnTrue()
        {

            //Arrange
            string g = "Mуж";
            int age = 35;
            double weight = 80;
            double height = 1.80;
            var ex = "672,24";
            //Act
            var act = FitnessAssistant_Simonov_2ISP11_16.Classes.Calculation.BMR(age, weight, height, g);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_SexWoman_returnTrue()
        {

            //Arrange
            string g = "Жен";
            int age = 17;
            double weight = 60;
            double height = 1.60;
            var ex = "564,48";
            //Act
            var act = FitnessAssistant_Simonov_2ISP11_16.Classes.Calculation.BMR(age, weight, height, g);
            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_ZeroWeightBMR_returnFalse()
        {

            //Arrange
            string g = "Жен";
            int age = 17;
            double weight = 0;
            double height = 1.60;
            var ex = "Ошибка";
            //Act
            var act = FitnessAssistant_Simonov_2ISP11_16.Classes.Calculation.BMR(age, weight, height, g);
            //Assert
            Assert.AreEqual(ex, act);
        }

    }
}
