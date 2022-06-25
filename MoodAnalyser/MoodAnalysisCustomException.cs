using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalysisCustomException: Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE,EMPTY_MESSAGE,
            NO_SUCH_FIELD,NO_SUCH_METHOD,
            NO_SUCH_CLASS,OBJECT_CREATION_ISSUE
        }
        private readonly ExceptionType type;

        public MoodAnalysisCustomException(ExceptionType type, string message)
        {
            this.type = type;
        }
    }
}
