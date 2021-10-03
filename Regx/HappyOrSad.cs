using System;
using System.Collections.Generic;
using System.Text;

namespace Regx
{
    public class HappyOrSad
    {
        string mood = "";
        public HappyOrSad(string mood)
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
