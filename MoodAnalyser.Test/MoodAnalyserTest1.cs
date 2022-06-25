namespace MoodAnalyser.Test
{
    [TestClass]
    public class MoodAnalyserTest1
    {
        [TestMethod]
        public void TestanalyseMoodSad()
        {
            //Arrange
            string messege = "I am in Sad Mood";
            string expexted_Output = "Sad Mood";
            string actual_Output;

            MoodAnalyse moodAnalyse = new MoodAnalyse(messege.ToLower());

            //Act
            actual_Output = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expexted_Output, actual_Output);

        }
        [TestMethod]
        public void TestanalyseMoodHappy()
        {
            //Arrange
            string messege = "I am in any Mood";
            string expexted_Output = "Happy Mood";
            string actual_Output;

            MoodAnalyse moodAnalyse = new MoodAnalyse(messege.ToLower());

            //Act
            actual_Output = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expexted_Output, actual_Output);

        }
    }
}