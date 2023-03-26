using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_Project.Shared.Entities
{
    public class TeachersClasses
    {
        public int TeacherID {get; set;}
        public int ClassID {get; set;}
        public Teachers Teacher {get; set;}
        public CLasses Class {get; set;}

    }
}