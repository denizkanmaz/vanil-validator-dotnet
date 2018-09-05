using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace VanilValidator.Net.Rules
{
    public class Phone : RuleBase
    {
        public Phone() : base("PHONE") { }

        private const string FAIL_MESSAGE = "Incorrect phone format.";

        internal override ValidationResult Validate(string inputName, string inputVal)
        {
            string patt = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";

            if (!new Regex(patt, RegexOptions.IgnoreCase).IsMatch(inputVal))
            {
                return ValidationResult.CreateFail(RuleName, inputName, FAIL_MESSAGE);
            }

            return ValidationResult.CreateSuccess();
        }
    }
}
