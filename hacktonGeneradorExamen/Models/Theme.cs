using System;

namespace hacktonGeneradorExamen.Models
{
    public class Theme
    {
        public int ThemeId { get; set; }
        public Subject Subject { get; set; }
        public String StudyInfo { get; set; }
        public String Description { get; set; }
    }
}