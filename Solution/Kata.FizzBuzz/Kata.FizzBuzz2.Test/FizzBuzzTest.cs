using Kata.FizzBuzz.Factories;

namespace Kata.FizzBuzz2.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldGetDefault()
        {
           var reponse = WholeNumberFactory.CreateDefault().ToString();

            Assert.That(reponse, Is.EqualTo("1"));
        }

        [Test]
        public void ShouldGet2()
        {
            var reponse = WholeNumberFactory.Create(2).ToString();

            Assert.That(reponse, Is.EqualTo("2"));
        }

        [Test]
        public void ShouldGetFizzWith3()
        {
            var reponse = WholeNumberFactory.Create(3).ToString();

            Assert.That (reponse, Is.EqualTo("Fizz"));
        }

        [Test]
        public void ShouldGetFizzWith6()
        {
            var reponse = WholeNumberFactory.Create(6).ToString();

            Assert.That(reponse, Is.EqualTo("Fizz"));
        }

        [Test]
        public void ShouldGetBuzzWith5()
        {
            var reponse = WholeNumberFactory.Create(5).ToString();

            Assert.That(reponse, Is.EqualTo("Buzz"));
        }  
        
        [Test]
        public void ShouldGetBuzzWith10()
        {
            var reponse = WholeNumberFactory.Create(10).ToString();

            Assert.That(reponse, Is.EqualTo("Buzz"));
        }  
        
        [Test]
        public void ShouldGetBuzzWith15()
        {
            var reponse = WholeNumberFactory.Create(15).ToString();

            Assert.That(reponse, Is.EqualTo("FizzBuzz"));
        } 
        
        [Test]
        public void ShouldGetBuzzWith30()
        {
            var reponse = WholeNumberFactory.Create(30).ToString();

            Assert.That(reponse, Is.EqualTo("FizzBuzz"));
        }
    }
}