using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolHelperForChildren
{
    struct StudentStruct
    {
        private static string name;
        private float mathScore;
        private float englishScore;
        private float scienceScore;

        // Getters
        public string GetName()
        {
            return name;
        }
        public float GetMathScore()
        {
            return mathScore;
        }
        public float GetEnglishScore()
        {
            return englishScore;
        }
        public float GetScienceScore()
        {
            return scienceScore;
        }
        // Setters
        public void SetName(string nameTemp)
        {
            name = nameTemp;
        }
        public void SetMathScore(float mathScore)
        {
            this.mathScore = mathScore;
        }
        public void SetEnglishScore(float englishScore)
        {
            this.englishScore = englishScore;
        }
        public void SetScienceScore(float scienceScore)
        {
            this.scienceScore = scienceScore;
        }
    }
}
