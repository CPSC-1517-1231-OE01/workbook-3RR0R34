using FluentAssertions;
using Hockey.Data;

namespace Hockey.Test
{
    public class HockeyPlayerTest
    {
        public HockeyPlayer GenerateTestPlayer()
        {
            return new HockeyPlayer();
        }
        [Fact]
        public void HockeyPlayer_FirstName_ReturnsGoodFirstName()
        {

            //arrange
            HockeyPlayer player = GenerateTestPlayer();
            const string NAME = "test";
            player.FirstName = "test";
            //act
            string actual = player.FirstName;
            //assert
            actual.Should().Be(NAME);
        }

        [Fact]
        public void HockeyPlayer_FirstName_ThrowsExeptionForEmptyArg()
        {
            //arrange
            HockeyPlayer player = GenerateTestPlayer();
            const string EmpName = "";
            //act
            Action act = () => player.FirstName = EmpName;
            player.FirstName = EmpName;
            //assert
            act.Should().Throw<ArgumentException>().WithMessage("No null or empty");
        }
    }
}