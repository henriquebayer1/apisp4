using API4SP.Context;
using API4SP.Domains;
using API4SP.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API4SP.Repositories
{
    public class ProductRepositorie : IProductRepositorie
    {

        public APISp4Context ctx = new APISp4Context();
       
        public void Atualizar(Guid id, Product newProduct)
        {
            try
            {
                Product produtoAchado = ctx.Product.FirstOrDefault(p => p.Id == id)!;

                 produtoAchado.Name = newProduct.Name;
                 produtoAchado.Price = newProduct.Price;

                ctx.Product.Update(produtoAchado);
                ctx.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product BuscarPorId(Guid id)
        {
            try
            {
               Product produtoAchado = ctx.Product.FirstOrDefault(p => p.Id == id)!;    

                return produtoAchado;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Product produto)
        {
            
            ctx.Product.Add(produto);
            ctx.SaveChanges();

        }

        public void Deletar(Guid id)   
        {

            try
            {
                Product produtoAchado = ctx.Product.FirstOrDefault(x => x.Id == id)!;

                if (produtoAchado != null)
                {
                    ctx.Product.Remove(produtoAchado);
                    ctx.SaveChanges();
                }
             
            }
            catch (Exception)
            {
                throw;
               
            }

        }

        public List<Product> Listar()
        {
            try
            {
                return ctx.Product.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
