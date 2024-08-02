using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento() {
                EventoId = 1,
                Tema = "Angular e .net 5",
                Local = "Piauí",
                Lote = "2º Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImgUrl = "foto.png"
            },
            new Evento() {
                EventoId = 2,
                Tema = "Angular e Php 8",
                Local = "São Paulo",
                Lote = "1º Lote",
                QtdPessoas = 500,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImgUrl = "foto2.png"
            }
        };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
    }
}


