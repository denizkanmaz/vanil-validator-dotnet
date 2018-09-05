namespace VanilValidator.Net
{
    public sealed class ValidationResult
    {
        private ValidationResult() { }

        public bool Valid { get; private set; }
        public string StackedAt { get; private set; }
        public string InputName { get; private set; }
        public string Message { get; private set; }

        internal static ValidationResult CreateSuccess()
        {
            return new ValidationResult { Valid = true };
        }

        internal static ValidationResult CreateFail(string stackedAt, string inputName, string message)
        {
            return new ValidationResult { Valid = false, StackedAt = stackedAt, InputName = inputName, Message = message };
        }
    }
}
