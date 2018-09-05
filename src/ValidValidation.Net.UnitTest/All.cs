using VanilValidator.Net;
using VanilValidator.Net.Rules;
using Xunit;

namespace ValidValidation.Net.UnitTest
{
    public class All
    {
        #region Required
        [Fact]
        public void Should_pass_the_required_rule()
        {
            Validator v = new Validator();
            var vr = v.Validate("Hello there!", new Required());

            Assert.True(vr.Valid);
        }

        [Fact]
        public void Should_stack_at_required_rule()
        {
            Validator v = new Validator();

            var vr = v.Validate("", new Required());
            Assert.False(vr.Valid);
            Assert.Equal("REQUIRED", vr.StackedAt);

            vr = v.Validate(null, new Required());
            Assert.False(vr.Valid);
            Assert.Equal("REQUIRED", vr.StackedAt);
        }
        #endregion

        #region Email
        [Fact]
        public void Should_stack_at_email_rule()
        {
            Validator v = new Validator();

            var vr = v.Validate("hello@there", new Email());
            Assert.False(vr.Valid);
            Assert.Equal("EMAIL", vr.StackedAt);
        }

        [Fact]
        public void Should_pass_the_email_rule()
        {
            Validator v = new Validator();

            var vr = v.Validate("hello@there.com", new Email());
            Assert.True(vr.Valid);
        }
        #endregion

        #region MinLength
        [Fact]
        public void Should_stack_at_min_length_rule()
        {
            Validator v = new Validator();

            var vr = v.Validate("Hel", new MinLength(4));
            Assert.False(vr.Valid);
            Assert.Equal("MINLENGTH", vr.StackedAt);
        }

        [Fact]
        public void Should_pass_the_min_length_rule()
        {
            Validator v = new Validator();

            var vr = v.Validate("Hello there!", new MinLength(4));
            Assert.True(vr.Valid);
        }
        #endregion

        #region MaxLength
        [Fact]
        public void Should_stack_at_max_length_rule()
        {
            Validator v = new Validator();

            var vr = v.Validate("Hello there!", new MaxLength(4));
            Assert.False(vr.Valid);
            Assert.Equal("MAXLENGTH", vr.StackedAt);
        }

        [Fact]
        public void Should_pass_the_max_length_rule()
        {
            Validator v = new Validator();

            var vr = v.Validate("Hel!", new MaxLength(4));
            Assert.True(vr.Valid);
        }
        #endregion

        #region Phone
        [Fact]
        public void Should_stack_at_phone_rule()
        {
            Validator v = new Validator();
            var vr = v.Validate("+905301112", new Phone());
            Assert.False(vr.Valid);
            Assert.Equal("PHONE", vr.StackedAt);
        }

        [Fact]
        public void Should_pass_the_phone_rule()
        {
            Validator v = new Validator();

            var vr = v.Validate("+905301112233", new Phone());
            Assert.True(vr.Valid);
        }
        #endregion

        #region Equivalent
        [Fact]
        public void Should_stack_at_equivalent_rule()
        {
            Validator v = new Validator();
            var vr = v.Validate("my_awesome_password", new Equivalent("my_awesome_confirmed_password"));
            Assert.False(vr.Valid);
            Assert.Equal("EQUIVALENT", vr.StackedAt);
        }

        [Fact]
        public void Should_pass_the_equivalent_rule()
        {
            Validator v = new Validator();

            var vr = v.Validate("my_awesome_password", new Equivalent("my_awesome_password"));
            Assert.True(vr.Valid);
        }
        #endregion
    }
}
