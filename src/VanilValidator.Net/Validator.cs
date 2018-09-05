using VanilValidator.Net.Rules;

namespace VanilValidator.Net
{
    public class Validator
    {
        
        public Validator() {}

        public ValidationResult Validate(string inputVal, params RuleBase[] rules)
        {
            return Validate("__UNKNOWN__", inputVal, rules);
        }

        public ValidationResult Validate(string inputName, string inputVal, params RuleBase[] rules)
        {
            inputVal = inputVal == null ? string.Empty : inputVal;

            foreach (var itemRule in rules)
            {
                var vr = itemRule.Validate(inputName, inputVal);
                if (!vr.Valid)
                {
                    return vr;
                }
            }
            return ValidationResult.CreateSuccess();
        }
    }
}
