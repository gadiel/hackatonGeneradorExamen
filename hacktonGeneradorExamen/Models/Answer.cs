using System;

namespace hacktonGeneradorExamen.Models
{
    public class Answer
    {
        public long AnswerId { get; set; }
        public String SAnswer { get; set; }
        public bool IsTheCorrect { get; set; }
    }
}