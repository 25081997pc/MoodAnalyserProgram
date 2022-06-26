using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class CustomExceptionHandler
    {
        public void shownullException( )
        {
             throw (new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NULL_MESSAGE,"Mood should not be null"));

        }
        public void showEmptyException( )
        {
             throw (new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.EMPTY_MESSAGE,"Mood should not be Empty"));
            
        }
    }
}
