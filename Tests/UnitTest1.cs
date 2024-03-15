using FluentAssertions;
using FluentAssertions.Equivalency;
using RamsonNoteProblem;

namespace Tests
{
    public class Tests
    {
        Solution solution;
        [SetUp]
        public void Setup()
        {
            solution = new Solution();
        }

        [Test]
        public void DifferentCasingShouldBeNo()
        {
            //Arrange
            var magazine = new string[] { "attack", "at", "dawn" };
            var note = new string[] { "Attack", "at", "dawn" };

            //Act
            var result = solution.CheckMagazineForWordsInNote(magazine, note);


            //Assert
            result.Should().Be("No");
        }

        [Test]
        public void EnoughWordsForNoteShouldBeYes()
        {
            //Arrange
            var magazine = new string[] { "give", "me", "one", "grand", "today", "night" };
            var note = new string[] { "give", "one", "grand", "today" };

            //Act
            var result = solution.CheckMagazineForWordsInNote(magazine, note);


            //Assert
            result.Should().Be("Yes");
        }

        [Test]
        public void LessWordsInMagazineForNoteShouldBeNo()
        {
            //Arrange
            var magazine = new string[] { "two", "times", "three", "is", "not", "four" };
            var note = new string[] { "two", "times", "two", "is", "four" };

            //Act
            var result = solution.CheckMagazineForWordsInNote(magazine, note);


            //Assert
            result.Should().Be("No");
        }
    }
}