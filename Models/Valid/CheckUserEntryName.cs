using NFP_MVAA.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NFP_MVAA.Models.Valid
{
    public class CheckUserEntryName : ValidationRule
    {

        public object UserName { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var name = UserName as string;

            if(DateWork.UserEntry_Name(name))
                return new ValidationResult(false, $"{name} - имя занято");                    
            return new ValidationResult(true, null);
        }
    }
}
