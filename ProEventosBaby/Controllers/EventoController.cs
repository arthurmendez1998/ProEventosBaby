using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventosBaby.Data;
using ProEventosBaby.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventosBaby.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<EventoModel> _evento = new EventoModel[] { // EventoModel do tipo colleção genérica cria um novo evento

          
        };
        private readonly Context _bancocontexto;  // _bancocontexto recebe tudo do bancodedados ou seja, nesse momento, o EventoModel
        public EventoController(Context bancocontexto) 
        {
              _bancocontexto = bancocontexto;
        }
        [HttpGet]
        public IEnumerable<EventoModel> Get()
        {
            return this._bancocontexto.Eventos;

        }

        [HttpGet("{id}")]
        public IEnumerable<EventoModel> Get(int id)
        {
            return this._bancocontexto.Eventos.Where(e => e.EventoId == id);

        }












    };
      
    };

