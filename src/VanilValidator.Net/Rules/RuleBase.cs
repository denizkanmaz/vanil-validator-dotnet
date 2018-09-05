using System;
using System.Collections.Generic;
using System.Text;

namespace VanilValidator.Net.Rules
{
    public abstract class RuleBase
    {
        #region Constructor
        public RuleBase(string ruleName)
        { RuleName = ruleName; }
        #endregion

        protected string RuleName { get; private set; }

        internal abstract ValidationResult Validate(string inputName, string inputVal);
    }
}
