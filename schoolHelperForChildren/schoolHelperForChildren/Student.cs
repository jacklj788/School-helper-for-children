﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolHelperForChildren
{
    class Student
    {
        private string name;
        private float mathScore;
        private float englishScore;
        private float scienceScore;

        public Student()
        {
            name = "Bob Ross";
            mathScore = 0;
            englishScore = 0;
            scienceScore = 0;
        }

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
        public void SetName(string name)
        {
            this.name = name;
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
