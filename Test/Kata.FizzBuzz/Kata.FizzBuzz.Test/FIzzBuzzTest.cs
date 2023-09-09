using Kata.FizzBuzz.Models;
using NUnit.Framework;

namespace Kata.FizzBuzz.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Should_Be_1()
        {
            Assert.That(WholeNatural.Create(1).ToFizzBuzz(), Is.EqualTo("1"));
        }
        [Test]
        public void Should_Be_Fizz()
        {
            Assert.That(WholeNatural.Create(6).ToFizzBuzz(), Is.EqualTo("Fizz"));
        } 
        
        [Test]
        public void Should_Be_Buzz()
        {
            Assert.That(WholeNatural.Create(10).ToFizzBuzz(), Is.EqualTo("Buzz"));
        }    
    }
}