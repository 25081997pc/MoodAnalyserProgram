using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        public string message;
       
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            NullException nullException = new NullException();

            try
            {
                if(message == null)
                {
                    nullException.shownullException(message);
                }
                if (message.Contains("sad"))
                {
                    return "Sad Mood";
                }
                else
                {
                    return "Happy Mood";
                }
               
            }catch(MoodAnalysisException e)
            {
                Console.WriteLine(e.Message);
                return "Happy";
            }
        }
    }
}
