namespace VanilValidator.Net.Rules
{
    public class MinLength : RuleBase
    {
        public MinLength(int minLength):base("MINLENGTH")
        {
            Minlength = minLength;
        }

        public int Minlength { get; private set; }

        internal override ValidationResult Validate(string inputName, string inputVal)
        {
            return inputVal.Trim().Length >= Minlength ? ValidationResult.CreateSuccess() : ValidationResult.CreateFail(RuleName, inputName, $"Value must be {Minlength.ToString()} character(s) at least.");
        }
    }
}
