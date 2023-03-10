using TDDPractice;

namespace xUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Validate_GivenLongerThan8Chars_ReturnsTrue()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = "MakeString(9)";
            var validateResult = testTarget.Validate(password);

            Assert.True(validateResult);
        }

        [Fact]
        public void Validate_GivenShorterThan8Chars_ReturnsFalse()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = MakeString(6) + "A";
            var validateResult = testTarget.Validate(password);

            Assert.False(validateResult);
        }

        [Fact]
        public void Validate_GivenNoUpperCase_ReturnsFalse()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = MakeString(9); // all lower case
            var validateResult = testTarget.Validate(password);

            Assert.False(validateResult);
        }
        [Fact]
        public void Validate_GivenOneUpperCase_ReturnsTrue()
        {
            var testTarget = new DefaultPasswordValidator();
            var password = MakeString(8) + "A"; // at least one upper case
            var validateResult = testTarget.Validate(password);

            Assert.True(validateResult);
        }
        private string MakeString(int length)
        {
            string result = "";
            for (int i = 0; i < length; i++)
            {
                result += "a";
            }
            return result;
        }

    }
}