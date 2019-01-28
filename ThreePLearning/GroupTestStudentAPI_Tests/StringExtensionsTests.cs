using Xunit;
using GroupTestStudentAPI.Extensions;

namespace GroupTestStudentAPI_Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void Given_Valid_RawString_Should_ReturnValidMatrix()
        {
            string rawString = @"{
{'','',’Simon’,'',''},
{'',’Sergey', '','Thomas’,''},
{'','','','',''},
{'','Chris','','',''},
{'','Harry','', 'Roger',''},
{'','','','',''}
}";

            string[,] matrix = rawString.ToTimeMarksMatrix();

            Assert.NotNull(matrix);
        }

        [Fact]
        public void Given_NULL_RawString_Should_ReturnMatrixWithNulls()
        {
            string rawString = null;

            string[,] matrix = rawString.ToTimeMarksMatrix();

            Assert.NotNull(matrix);
        }
    }
}
