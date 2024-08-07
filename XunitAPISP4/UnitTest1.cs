using API4SP.Domains;
using API4SP.Interfaces;
using Moq;


namespace XunitAPISP4
{
    public class UnitTest1
    {

        //FACT TESTE UNITARIO
        [Fact]
        public void ListAll()
        {

            //ARRANGE - ORGANIZAR CENARIO
            var products = new List<Product>

            {

            new Product
            {Id = Guid.NewGuid(),
             Name = "Test",
             Price = 200

            },

            new Product
            {
             Id = Guid.NewGuid(),
             Name = "Test2",
             Price = 300
                },

            new Product
            {
             Id = Guid.NewGuid(),
             Name = "Test3",
             Price = 400
                }};

            var mockRepositorie = new Mock<IProductRepositorie>();

            mockRepositorie.Setup(x => x.Listar()).Returns(products);


            //ACT - AGIR

            var result = mockRepositorie.Object.Listar();

            //ASSERT - PROVA DE TESTE

            Assert.Equal(3, result.Count);
        }

        [Fact]
        public void Post()
        {

            var product = new Product

            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Price = 200
            };

            var mockRepositorie = new Mock<IProductRepositorie>();



          var res =  mockRepositorie.Setup(x => x.Cadastrar(product));

            mockRepositorie.Object.Cadastrar(product);

            //mockRepositorie.Object.Cadastrar(product);

            //mockRepositorie.Verify(x => x.Cadastrar(product));

            Assert.NotNull(res);



        }


        [Fact]
        public void Delete()
        {

            var product = new Product

            {
                Id = Guid.NewGuid(),
                Name = "Test",
                Price = 200
            };

            var mockRepositorie = new Mock<IProductRepositorie>();

            mockRepositorie.Setup(x => x.Deletar(product.Id)).Verifiable();




            



        }


    }
}