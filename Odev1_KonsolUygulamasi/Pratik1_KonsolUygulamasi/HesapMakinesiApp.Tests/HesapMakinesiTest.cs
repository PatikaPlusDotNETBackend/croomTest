using Xunit;
using Pratik1.HesapMakinesiApp; // Test projesi ile aynı namespace'i kullanıyoruz

namespace Pratik1.HesapMakinesiApp.Tests
{
    public class HesapMakinesiTest
    {
        [Fact]
        public void Topla_Test()
        {
            // Arrange
            var hesap = new HesapMakinesi();

            // Act
            var sonuc = hesap.Topla(5, 3);

            // Assert
            Assert.Equal(8, sonuc); // Beklenen sonuç 8 olmalı
        }

        [Fact]
        public void Cikar_Test()
        {
            // Arrange
            var hesap = new HesapMakinesi();

            // Act
            var sonuc = hesap.Cikar(5, 3);

            // Assert
            Assert.Equal(2, sonuc); // Beklenen sonuç 2 olmalı
        }
    }
}
