using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        public string messege;
       
        public MoodAnalyse(string messege)
        {
            this.messege = messege;
        }
        public string AnalyseMood()
        {
            if(messege.Contains("sad"))
            {
                return "Sad Mood";
            }
            else
            {
                return "Happy Mood";
            }
        }
    }
}
