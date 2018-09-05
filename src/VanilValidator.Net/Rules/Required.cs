namespace VanilValidator.Net.Rules
{
    public class Required : RuleBase
    {
        public Required():base("REQUIRED") { }

        private const string FAIL_MESSAGE = "cannot be empty.";
    
        internal override ValidationResult Validate(string inputName, string inputVal)
        {
            return inputVal.Trim().Length > 0 ? ValidationResult.CreateSuccess() : ValidationResult.CreateFail(RuleName, inputName, $"{inputName} {FAIL_MESSAGE}");
        }
    }
}
