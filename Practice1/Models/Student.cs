using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice1.Models
{
    public class Student
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Subjects { get; set; }
        public double Score { get; set; }

        public Student (long Id, string Name, string Class, string Subjects, double Score)
        {
            this.Id = Id;
            this.Name = Name;
            this.Class = Class;
            this.Subjects = Subjects;
            this.Score = Score;
        }

        
    }
}