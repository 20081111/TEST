using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Farmland.Framework.Tests
{
    [TestFixture]
    public class ValidatorTest
    {
        private int a;
        private int b;
        private Validation.Validator validate;

        //[TestFixtureSetUp]    初始化资源
        //[TestFixtureTearDown] 释放资源
        [SetUp]//全局变量可以使用SETUP进行初始化
        public void Initial()
        {
            validate = new Validation.Validator();
            a = 4;
            b = 2;
        }
        [Test, Category("Adds")]
        public void Add()
        {
            int value = validate.Add(a, b);
            Assert.AreEqual(value, 6);
        }

        /// <summary>
        /// 
        /// </summary>
        [Test, Category("divs")]
        public void div() {

            int value = validate.div(a, b);
            Assert.AreEqual(value, 2);
           
        }

        [Test, Category("Multiplys")]
        public void Multiply()
        {
            int value = validate.Multiply(a, b);
            Assert.AreEqual(value, 8);
        }
         
        /// <summary>
        /// 忽略的用法
        /// </summary>
        [Test,Ignore("this is a Test Ignore Ex"),Category("Subtractions")]
        public void Subtraction()
        {

            int value = validate.Subtraction(a, b);
            Assert.AreEqual(value, 2);
        }

        [Test]
        public void Colletion()
        {
            Console.Out.WriteLine("Test 1");
        }
    }
}
