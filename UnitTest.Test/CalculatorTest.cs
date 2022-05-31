using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.APP;
using Xunit;

namespace UnitTest.Test
{
    public  class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            //// Arrange
            //// Biz burada değişkenleri initilaize ettiğimiz yerdir. Nesne örneğini de burada oluşturmaktadyız.
            //int a = 5;
            //int b = 5;
            //var calculator = new Calculator();

            ////Act
            //var total = calculator.Add(a, b);

            ////Assert
            //// Doğrulama Evresidir. Act den çıkan testin doğruluğunu sorgulamaktadır.
            //Assert.Equal<int>(10, total);




            // ilk parametre beklenne , ikincisi ise gerçek değeri karşılamaktadır.
            //Assert.Contains("ahmet", " Berkan Çelik");

            var names = new List<string>() { "Berkan", "Ahmet", "Mehmet" };

            Assert.Contains(names, x => x == "Berkan");

            








        }
    }
}
