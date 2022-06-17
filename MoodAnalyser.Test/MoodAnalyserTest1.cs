namespace MoodAnalyser.Test
{
    [TestClass]
    public class MoodAnalyserTest1
    {
        [TestMethod]
        public void TestanalyseMoodSad()
        {
            MoodAnalyse moodAnalyse = new MoodAnalyse();

            //Arrange
            string messege = "I am in Sad Mood";
            string expexted_Output = "Sad Mood";
            string actual_Output;

            //Act
            actual_Output = moodAnalyse.AnalyseMood(messege.ToLower());

            //Assert
            Assert.AreEqual(expexted_Output, actual_Output);

        }
        [TestMethod]
        public void TestanalyseMoodHappy()
        {
            MoodAnalyse moodAnalyse = new MoodAnalyse();

            //Arrange
            string messege = "I am in any Mood";
            string expexted_Output = "Happy Mood";
            string actual_Output;

            //Act
            actual_Output = moodAnalyse.AnalyseMood(messege.ToLower());

            //Assert
            Assert.AreEqual(expexted_Output, actual_Output);

        }
    }
}