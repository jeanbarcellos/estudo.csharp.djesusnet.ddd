using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApi.Application.DTO;
using WebApi.Application.Interfaces;

namespace WebApi.Service.Api.Controllers
{
    [Route("/clients")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientApplicationService _applicationService;

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
        public ActionResult Post([FromBody] ClientDTO clientDTO)
        {
            try
            {
                if (clientDTO == null)
                {
                    return NotFound();
                }

                _applicationService.Add(clientDTO);

                return Ok("Cliente Cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ClientDTO clientDTO)
        {
            try
            {
                if (clientDTO == null || id != clientDTO.Id)
                {
                    return NotFound();
                }

                _applicationService.Update(clientDTO);

                return Ok("Cliente Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete([FromBody] ClientDTO clientDTO)
        {
            try
            {
                if (clientDTO == null)
                {
                    return NotFound();
                }

                _applicationService.Remove(clientDTO);

                return Ok("Cliente Removido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
