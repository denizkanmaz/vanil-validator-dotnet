using System;
using System.Collections.Generic;
using System.Text;

namespace VanilValidator.Net.Rules
{
    public class Equivalent : RuleBase
    {
        public Equivalent(string expected) : base("EQUIVALENT")
        {
            Expected = expected;
        }

        private const string FAIL_MESSAGE = "value must be equal with the other.";

        public string Expected { get; private set; }
        
        internal override ValidationResult Validate(string inputName, string inputVal)
        {
            return inputVal == Expected ? ValidationResult.CreateSuccess() : ValidationResult.CreateFail(RuleName, inputName, $"{inputName} {FAIL_MESSAGE}");
        }
    }
}
