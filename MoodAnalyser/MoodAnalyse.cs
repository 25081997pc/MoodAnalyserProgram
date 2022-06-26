using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        public MoodAnalyse()
        {

        }
        public string message;
       
        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            CustomExceptionHandler customExceptionhandler = new CustomExceptionHandler();

            try
            {
                if(message == null)
                {
                    customExceptionhandler.shownullException();
                }
                if(message == "")
                {
                    customExceptionhandler.showEmptyException();
                }
                if (message.Contains("sad"))
                {
                    return "Sad Mood";
                }
                else
                {
                    return "HAPPY";
                }
               
            }catch(MoodAnalysisCustomException e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }
        }
    }    
}
