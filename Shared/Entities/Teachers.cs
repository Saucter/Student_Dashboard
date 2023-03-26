using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_Project.Shared.Entities
{
    public class Teachers
    {
        public int id {get; set;}
        public string Name {get; set;}
        private string Username {get; set;}
        private string Password {get; set;} = "rgotc123";
        public List<CLasses> TeacherClases {get; set;}
    }
}