using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard_Project.Shared.Helpers
{
    public enum SubjectsList
    {
        //GED non-STEM subjects 
        English,
        Arabic,
        Islamic,
        Life_Skills,
        Social_Studies,

        //GED STEM subjects
        Math,
        ICT,
        Science,
        Physics,
        Chemistry,
        
        //RGOTC Exclusive subjects 
        Workshop,
        Candidates,
        Electronics,

        //BTEC Subjects
        Thermodynamics,
        Additive_Manufacturing,
        Microcontrollers,
        Delivery,
        BTEC_Electronics,
        Product_Design,
        Project,
        BTEC_ICT
    }
}