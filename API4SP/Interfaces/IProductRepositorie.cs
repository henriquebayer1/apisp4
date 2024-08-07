using API4SP.Domains;

namespace API4SP.Interfaces
{
    public interface IProductRepositorie
    {

        void Cadastrar(Product produto);

        List<Product> Listar();

        Product BuscarPorId(Guid id);

        void Atualizar(Guid id, Product product);

        void Deletar(Guid id);

    }
}
