using System;
using System.Collections.Generic;

namespace hacktonGeneradorExamen.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public String Name { get; set; }
        virtual public ICollection<Theme> Themes { get; set; }  
    }
}