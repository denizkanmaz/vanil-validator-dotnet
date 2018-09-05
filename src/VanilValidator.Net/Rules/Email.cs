using System.Text.RegularExpressions;

namespace VanilValidator.Net.Rules
{
    public class Email : RuleBase
    {
        public Email():base("EMAIL") { }

        private const string FAIL_MESSAGE = "Incorrect email format.";
    
        internal override ValidationResult Validate(string inputName, string inputVal)
        {
            string patt = @"^(([^<>()\[\]\\.,;:\s@/""]+(\.[^<>()\[\]\\.,;:\s@/""]+)*)|(/"".+/""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$";

            if (!new Regex(patt, RegexOptions.IgnoreCase).IsMatch(inputVal))
            {
                return ValidationResult.CreateFail(RuleName, inputName, FAIL_MESSAGE);
            }

            return ValidationResult.CreateSuccess();
        }
    }
}
