using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        List<Cliente> listacliente = new List<Cliente>();


        public ClienteController()
        {
            Cliente c = new Cliente { IDCliente = 1, Nombre = "Lucia", Mail = "lucia@gmail.com" };

            this.listacliente.Add(c);
        }

        //GET api/Cliente
        [HttpGet]
        public List<Cliente> GetClientes()
        {
            return this.listacliente;
        }


        //GET api/Cliente/9
        [HttpGet("{id}")]
        public Cliente GetCliente(int id)
        {
            Cliente c = this.listacliente.Find(z => z.IDCliente == id);

            return c;
        }
    }
}
