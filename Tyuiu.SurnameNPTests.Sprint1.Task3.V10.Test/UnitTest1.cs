using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SurnameNPTests.Sprint1.Task3.V10.Lib;

namespace Tyuiu.SurnameNPTests.Sprint1.Task3.V10.Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			DataService ds = new DataService();
			Assert.AreEqual(ds.NumberToMoney(305), "30.5 руб. - это 30 руб. 50 коп.");
		}
	}
}
