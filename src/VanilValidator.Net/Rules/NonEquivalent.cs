using System;
using System.Collections.Generic;
using System.Text;

namespace VanilValidator.Net.Rules
{
    public class NonEquivalent : RuleBase
    {
        public NonEquivalent(string notExpected) : base("NON-EQUIVALENT")
        {
            NotExpected = notExpected;
        }

        private const string FAIL_MESSAGE = "value must not be equal with the other.";

        public string NotExpected { get; private set; }
        
        internal override ValidationResult Validate(string inputName, string inputVal)
        {
            return inputVal != NotExpected ? ValidationResult.CreateSuccess() : ValidationResult.CreateFail(RuleName, inputName, $"{inputName} {FAIL_MESSAGE}");
        }
    }
}
