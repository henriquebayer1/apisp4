using API4SP.Domains;
using API4SP.Interfaces;
using API4SP.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API4SP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        private IProductRepositorie _productRepositorie;

        public ProductController()
        {
            _productRepositorie = new ProductRepositorie();
        }


       [HttpGet]
        public IActionResult ListAll()
        {

            try
            {
                return Ok(_productRepositorie.Listar());

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

        [HttpGet("{id}")]
        public IActionResult ListById(Guid id)
        {

            try
            {
                return StatusCode(201, _productRepositorie.BuscarPorId(id));
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        
        }



        [HttpPost]
        public IActionResult Cadastrar(Product produto)
        {

            try
            {
                _productRepositorie.Cadastrar(produto);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }


        [HttpPut]
        public IActionResult Atualizar(Guid id,Product newProduct)
        {

            try
            {
                _productRepositorie.Atualizar(id, newProduct);

                return StatusCode(201);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }


        [HttpDelete]
        public IActionResult Deletar(Guid id)
        {

            try
            {
                _productRepositorie.Deletar(id);

                return StatusCode(201);
            }
            catch (Exception)
            {

                return NotFound();
            }

        }



    }
}
