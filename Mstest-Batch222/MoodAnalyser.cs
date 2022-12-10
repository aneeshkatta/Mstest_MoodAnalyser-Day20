﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mstest_Batch222
{
    public class MoodAnalyser
    {
        public string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public MoodAnalyser()
        {
           
        }
        public string AnalyseMood()
        {
            if (this.message.Equals(string.Empty))
            {
                return "Mood should not be empty";
            }
            if (this.message.ToLower().Contains("sad"))
            {
                Console.WriteLine("sad");
                return "sad";
            }
            else
            {
                Console.WriteLine("Happy");
                return "Happy";
            }
        }
    }
}
