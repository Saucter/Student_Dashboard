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
        Product_Design,
        Material_Science,

        //BTEC Subjects
        BTEC_Thermodynamics,
        BTEC_Additive_Manufacturing,
        BTEC_Microcontrollers,
        BTEC_Delivery,
        BTEC_Electronics,
        BTEC_Product_Design,
        BTEC_Project,
        BTEC_ICT
    }
}