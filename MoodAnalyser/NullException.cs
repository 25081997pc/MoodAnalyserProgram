using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class NullException
    {
        public void shownullException(string message)
        {
            if(message == null)
            {
                throw (new MoodAnalysisException("Enter Invalid Input"));
            }
           
        }
    }
}
