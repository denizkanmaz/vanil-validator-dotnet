namespace VanilValidator.Net.Rules
{
    public class MaxLength : RuleBase
    {
        public MaxLength(int maxLength):base("MAXLENGTH")
        {
            Maxlength = maxLength;
        }

        public int Maxlength { get; private set; }

        internal override ValidationResult Validate(string inputName, string inputVal)
        {
            return inputVal.Trim().Length <= Maxlength ? ValidationResult.CreateSuccess() : ValidationResult.CreateFail(RuleName, inputName, $"Value can be {Maxlength.ToString()} character(s) maximum.");
        }
    }
}
