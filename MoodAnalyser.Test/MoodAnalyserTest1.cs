namespace MoodAnalyser.Test
{
    [TestClass]
    public class MoodAnalyserTest1
    {
        [TestMethod]
        public void TestanalyseMoodSad()
        {
            //Arrange

            string message = "I am in Sad Mood";
            string expexted_Output = "Sad Mood";
            string actual_Output;

            MoodAnalyse moodAnalyse = new MoodAnalyse(message.ToLower());

            //Act
            actual_Output = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expexted_Output, actual_Output);

        }
        [TestMethod]
        public void TestanalyseMoodHappy()
        {
            //Arrange

            string message = "I am in any Mood";
            string expexted_Output = "Happy Mood";
            string actual_Output;

            MoodAnalyse moodAnalyse = new MoodAnalyse(message.ToLower());

            //Act
            actual_Output = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expexted_Output, actual_Output);

        }
        [TestMethod]
        public void AnalysemoodNullTest()
        {
            //Arrange
            string message = null;
            string expexted_Output = "Enter Null Input";
            string actual_Output;

            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            //Act
            actual_Output = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expexted_Output, actual_Output);


        }
    }
}