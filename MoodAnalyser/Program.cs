namespace MoodAnalyser
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mood Analyser Program");
            MoodAnalyse moodAnalyse = new MoodAnalyse("");
            string s = moodAnalyse.AnalyseMood();
            
        }
    }
}