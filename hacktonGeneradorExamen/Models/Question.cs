using System;
using System.Collections;
using System.Collections.Generic;

namespace hacktonGeneradorExamen.Models
{
    public class Question
    {
        public long QuestionId { get; set; }
        public QuestionType QuestionType { get; set; }
        public QuestionFormat QuestionFormat { get; set; }
        public Int16 Year { get; set; }
        public int Points { get; set; }
        public String SQuestion { get; set; }
        public bool IsTrue;
        public ICollection<Answer> Answers { get; set; }
        public Theme Theme { get; set; }
    }
}