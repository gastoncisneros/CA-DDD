using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClearArchitecture.Domain.ValueObjects
{
    public partial record PhoneNumber
    {
        private const int DefaultLength = 9;
        private const string Pattern = @"^(?:-*\d-*){8}"; //Phone regex of Mexico

        // Encapsulation
        private PhoneNumber(string value) => Value = value;

        public static PhoneNumber? Create(string value)
        {
            if (string.IsNullOrEmpty(value) || !PhoneNumberRegex().IsMatch(value) || value.Length != DefaultLength) 
            {
                return null;
            }

            return new PhoneNumber(value);
        }

        public string Value { get; init; }

        [GeneratedRegex(Pattern)]
        private static partial Regex PhoneNumberRegex();
    }
}
