using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApi.Application.DTO;
using WebApi.Application.Interfaces;

namespace WebApi.Service.Api.Controllers
{
    [Route("/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductApplicationService _applicationService;

        public ProductController(IProductApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_applicationService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_applicationService.GetById(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProductDTO productDTO)
        {
            try
            {
                if (productDTO == null)
                {
                    return NotFound();
                }

                _applicationService.Add(productDTO);

                return Ok("Produto Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ProductDTO productDTO)
        {
            try
            {
                if (productDTO == null || id != productDTO.Id)
                {
                    return NotFound();
                }

                _applicationService.Update(productDTO);

                return Ok("Produto Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromBody] ProductDTO productDTO)
        {
            try
            {
                if (productDTO == null)
                {
                    return NotFound();
                }

                _applicationService.Remove(productDTO);

                return Ok("Produto Removido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
