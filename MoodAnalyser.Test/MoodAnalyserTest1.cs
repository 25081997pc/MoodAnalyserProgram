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
        [TestMethod]
        public void AnalysemoodEmptyTest()
        {
            //Arrange
            string message = "";
            string expexted_Output = "Empty Mood";
            string actual_Output;

            MoodAnalyse moodAnalyse = new MoodAnalyse(message);

            //Act
            actual_Output = moodAnalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expexted_Output, actual_Output);

        }
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            //Arrange
            string message = null;
            object expected = new MoodAnalyse(message);
            object obj;

            //Act
            obj = MoodAnalyserFactory.CreateMoodAnalysis("MoodAnalyser.MoodAnalyse", "MoodAnalyse");

            //Assert
            expected.Equals(obj);
        }
        [TestMethod]
        public void GivenImproperClassName_ShouldThrowMoodAnalysisCustomException()
        {
            //Arrange
            string messege = null;
            object expected = new MoodAnalyse(messege);
            object obj;

            //Act
            obj = MoodAnalyserFactory.CreateMoodAnalysis("MoodAnalyser.MoodClass", "MoodClass");

            //Assert
            expected.Equals(obj);
        }
        [TestMethod]
        public void GivenImproperConstructorName_ShouldThrowMoodAnalysisCustomException()
        {
            //Arrange
            string messege = null;
            object expected = new MoodAnalyse(messege);
            object obj;

            //Act
            obj = MoodAnalyserFactory.CreateMoodAnalysis("MoodAnalyser.MoodClass", "MoodAnalyser");

            //Assert
            expected.Equals(obj);
        }

        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
        {
            //Arrange
            object expected = new MoodAnalyse("HAPPY");
            object obj;

            //Act
            obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyser.MoodAnalyse", "MoodAnalyse", "HAPPY");

            //Assert
            expected.Equals(obj);
        }
    }
}