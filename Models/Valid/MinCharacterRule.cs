using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NFP_MVAA.Models.Valid
{
    public class MinCharacterRule : ValidationRule
    {

        public int MinCharacter { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var charstring=value as string;
            if (charstring.Length < MinCharacter)
                return new ValidationResult(false, $"Минимальное количество символов {MinCharacter}");
            return new ValidationResult(true, null);
        }
    }
}
