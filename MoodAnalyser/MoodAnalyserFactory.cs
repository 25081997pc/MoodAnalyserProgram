﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalysis(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if(result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch(ArgumentNullException)
                {
                    throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NO_SUCH_CLASS, "No class found");
                }
            }
            else
            {
                throw new MoodAnalysisCustomException(MoodAnalysisCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");
            }
        }
    }
}
