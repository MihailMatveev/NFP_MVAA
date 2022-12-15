using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NFP_MVAA.Models.Valid
{
    public class MaxCharcterRule : ValidationRule
    {

        public int MaxCharacter { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var charstring = value as string;
            if (charstring.Length > MaxCharacter)
                return new ValidationResult(false, $"Максимальное количество символов {MaxCharacter}");
            return new ValidationResult(true, null);
        }
    }
}
