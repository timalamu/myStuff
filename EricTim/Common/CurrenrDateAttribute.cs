using System;
using System.ComponentModel.DataAnnotations;
namespace EricTim.Common
{
    public class CurrenrDateAttribute : ValidationAttribute
    {
       public override bool IsValid(object value)
        {
            DateTime dateTime = Convert.ToDateTime(value);

            return dateTime <= DateTime.Now;
        }
    }
}