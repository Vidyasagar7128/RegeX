using System;
using System.Collections.Generic;
using System.Text;

namespace RegexTest
{
    class happyOrSad
    {
        string mood = "";
        public happyOrSad(string mood)
        {
            this.mood = mood;
        }
        public string ChangeMood()
        {
            if (mood == "sad")
                mood = "sad";
            else
                mood = "happy";
            return mood;
        }
    }
}
