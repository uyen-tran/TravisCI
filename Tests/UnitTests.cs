using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        //Unit Tests for Subtract method
        [Test]
        public void Subtract_Valid_Tran()
        {
            Assert.AreEqual(1, Program.Subtract("2", "1"));
            Assert.AreEqual(5, Program.Subtract("7", "2"));
            Assert.AreEqual(3, Program.Subtract("10", "7"));
        }
        
        [Test]
        public void Subtract_Invalid_Tran()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }
        
        [Test]
        public void Subtract_Null_Tran()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }
        
        //Unit tests for Multiply method
        [Test]
        public void Multiply_Valid_Tran()
        {
            Assert.AreEqual(2, Program.Multiply("2", "1"));
            Assert.AreEqual(14, Program.Multiply("7", "2"));
            Assert.AreEqual(70, Program.Multiply("10", "7"));
        }
       
        [Test]
        public void Multiply_Invalid_Tran()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }
        
        [Test]
        public void Multiply_Null_Tran()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }
        
        //Unit tests for Divide method
        [Test]
        public void Divide_Valid_Tran()
        {
            Assert.AreEqual(2, Program.Divide("2", "1"));
            Assert.AreEqual(10, Program.Divide("20", "2"));
            Assert.AreEqual(11, Program.Divide("77", "7"));
        }
        
        [Test]
        public void Divide_Invalid_Tran()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }
        
        [Test]
        public void Divide_Null_Tran()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }
        
        //Unit tests for Power method
        public void Power_Valid_Tran()
        {
            Assert.AreEqual(8, Program.Power("2", "3"));
            Assert.AreEqual(1, Program.Power("4", "0"));
            Assert.AreEqual(3, Program.Power("3", "1"));
        }
        
        [Test]
        public void Power_Invalid_Tran()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }
        
        [Test]
        public void Power_Null_Tran()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
