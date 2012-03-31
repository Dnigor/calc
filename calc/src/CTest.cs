// ****************************************************************
// This is free software licensed under the NUnit license. You
// may obtain a copy of the license as well as information regarding
// copyright ownership at http://nunit.org/?p=license&r=2.4.
// ****************************************************************
using System;
using NUnit.Framework;

namespace calc
{
    
  

    /// <summary>Some simple Tests.</summary>
    /// 
    [TestFixture]
    public class CTest:ccalc 
    {
         
        [Test]
        public void test2add4()
        {
            Assert.AreEqual(6, calculate(2,4,'+'), "Expected Success.");
        }
        
        [Test]
        public void test5minus2()
        {
            Assert.AreEqual(3, calculate(5, 2, '-'), "Expected Success.");
        }

        [Test]
        public void test7mul8()
        {
            Assert.AreEqual(56, calculate(7, 8, '*'), "Expected Success.");
        }

        [Test]
        public void test12div2()
        {
            Assert.AreEqual(6, calculate(12, 2, '/'), "Expected Success.");
        }
        
        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void test12div0()
        {
            Assert.Catch(delegate() { calculate(12, 0, '/'); }, "divide by zero", null);
                                  
        }
        /*
        [Test]
        [ExpectedException(typeof(FormatException))]
        public void WrongFormatTest()
        {
             
            Assert.Catch(delegate() { calculate('a', 'b', '/'); }, "wrong format", null); 
        }*/
              
    }
}