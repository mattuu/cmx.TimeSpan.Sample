using Ploeh.AutoFixture.Xunit2;
using Shouldly;
using Xunit;

namespace cmx.TimeSpan.Sample.Tests
{
    public class TimeManagerTests
    {
        [Theory]
        [InlineAutoData("20:00", true)]
        [InlineAutoData("20:01", true)]
        [InlineAutoData("07:59", true)]
        [InlineAutoData("08:00", true)]
        [InlineAutoData("08:01", false)]
        [InlineAutoData("19:59", false)]
        public void CheckTimeSpan_ShouldReturnCorrectValue(string nowTimeString, bool expectedResult, TimeManager sut)
        {
            // arrange..
            var nowTimeSpan = System.TimeSpan.Parse(nowTimeString);

            // act..
            var actual = sut.CheckTimeSpan(nowTimeSpan);

            // assert..
            actual.ShouldBe(expectedResult);
        }
    }
}
