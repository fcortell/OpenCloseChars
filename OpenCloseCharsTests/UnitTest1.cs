
namespace OpenCloseCharsTests
{
    public class UnitTest1
    {
        Dictionary<char, char> _openCloseChars = new()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        [Fact]
        public void Test1()
        {
            var result = Program.Validate(_openCloseChars, "({})");
            Assert.True(result);
        }

        [Fact]
        public void Test2()
        {
            var result = Program.Validate(_openCloseChars, "({[]})");
            Assert.True(result);
        }

        [Fact]
        public void Test3()
        {
            var result = Program.Validate(_openCloseChars, "()[]{}");
            Assert.True(result);
        }

        [Fact]
        public void Test4()
        {
            var result = Program.Validate(_openCloseChars, "()");
            Assert.True(result);
        }

        [Fact]
        public void Test5()
        {
            var result = Program.Validate(_openCloseChars, "(({}))");
            Assert.True(result);
        }

        [Fact]
        public void Test6()
        {
            var result = Program.Validate(_openCloseChars, "({)}");
            Assert.False(result);
        }

        [Fact]
        public void Test7()
        {
            var result = Program.Validate(_openCloseChars, "({}");
            Assert.False(result);
        }

        [Fact]
        public void Test8()
        {
            var result = Program.Validate(_openCloseChars, "(]");
            Assert.False(result);
        }

        [Fact]
        public void Test9()
        {
            var result = Program.Validate(_openCloseChars, "(](]");
            Assert.False(result);
        }

        [Fact]
        public void Test10()
        {
            var result = Program.Validate(_openCloseChars, "([)]");
            Assert.False(result);
        }

        [Fact]
        public void Test11()
        {
            var result = Program.Validate(_openCloseChars, "]");
            Assert.False(result);
        }
        [Fact]
        public void Test12()
        {
            var result = Program.Validate(_openCloseChars, "(]]");
            Assert.False(result);
        }
        [Fact]
        public void Test13()
        {
            var result = Program.Validate(_openCloseChars, "(((]]");
            Assert.False(result);
        }

        [Fact]
        public void Test14()
        {
            var result = Program.Validate(_openCloseChars, "((()]]");
            Assert.False(result);
        }

        [Fact]
        public void Test15()
        {
            var result = Program.Validate(_openCloseChars, "((()))))");
            Assert.False(result);
        }

        [Fact]
        public void Test16()
        {
            var result = Program.Validate(_openCloseChars, "(((a)))a))");
            Assert.False(result);
        }
    }
}