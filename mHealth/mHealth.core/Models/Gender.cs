using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mHealth.core.Models
{
    public enum Gender
    {
        mand = 1,
        kvinde = 2
    }

    public static class GenderConverter
    {
        public static int Convert(Gender gender)
        {

            return (int)Enum.Parse(gender.GetType(), gender.ToString());

            //foreach (Gender genderTemp in Enum.GetValues(typeof(Gender)))
            //{
            //    if (Enum.GetUnderlyingType(gender.GetType()) == Enum.GetUnderlyingType(genderTemp.GetType()))
            //    {

            //    }
            //}           return 0;
        }            

        

    }

}
