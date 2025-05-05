using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using MiAppHexagonal.Application.Services;
using MiAppHexagonal.Domain.Factory;

namespace MiAppHexagonal.Application.UI.Productos
{
    public class UIProducto
    {     
        private readonly IDbFactory _factory;
        //var servicio = new ClienteService(factory.CrearClienteRepository());

        public UIProducto(IDbFactory factory)
        {
            _factory = factory;


        }
    }


}