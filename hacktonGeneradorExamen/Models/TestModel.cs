using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace hacktonGeneradorExamen.Models
{

    public enum QuestionFormat
    {
        TrueFalse,
        MultiChoice,
        MultipleResponse
    }

    public enum QuestionType
    {
        Image,
        Text,
        Sound
    }

    public class Question
    {
        public long QuestionId { get; set; }
        public QuestionType QuestionType { get; set; }
        public QuestionFormat QuestionFormat { get; set; }
        public Int16 Year { get; set; }
        public int Points { get; set; }
        public String SQuestion { get; set; }
        public ICollection<String> Answers { get; set; }
        public Theme Theme { get; set; }
    }

    public class Theme
    {
        public int ThemeId { get; set; }
        public Subject Subject { get; set; }
        public String StudyInfo { get; set; }
        public String Description { get; set; }
    }

    public class Subject
    {
        public int SubjectId { get; set; }
        public String Name { get; set; }
        virtual public ICollection<Theme> Themes { get; set; }  
    }
}