using ITM_VENTA_DE_CARROS.Clases;
using ITM_VENTA_DE_CARROS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ITM_VENTA_DE_CARROS.Controllers
{
    [RoutePrefix("api/Clientes")]
    public class ClientesController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Cliente> ConsultarTodos() 
        {
            clsCliente Cliente = new clsCliente();
            return Cliente.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarPorDocumento")]
        public Cliente ConsultarPorDocumento([FromUri] string Documento)
        {
            clsCliente Cliente = new clsCliente();
            return Cliente.Consultar(Documento);
        }


        [HttpPost]
        [Route("Insertar")] 
        // POST api/<controller>
        public string Insertar([FromBody] Cliente cliente)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = cliente;
            return Cliente.Insertar();
        }

        [HttpPut]
        [Route ("Actualizar")]
        // PUT api/<controller>/5
        public string Actualizar([FromBody] Cliente cliente)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = cliente;
            return Cliente.Actualizar();
        }
        [HttpDelete]
        [Route("Eliminar")]
        // DELETE api/<controller>/5
        public string Eliminar([FromBody] Cliente cliente)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.cliente = cliente;
            return Cliente.Eliminar();
        }
    }
}