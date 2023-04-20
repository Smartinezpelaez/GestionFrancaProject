using AutoMapper;
using GestionFranca.BLL.DTOs;
using GestionFranca.BLL.Repository;
using GestionFranca.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GestionFranca.Web.Controllers
{
    public class ElementoController : Controller
    {
        readonly IElementoRepository elementoRepository;
        readonly IMapper mapper;

        public ElementoController(IElementoRepository elementoRepository, IMapper mapper)
        {
            this.elementoRepository = elementoRepository;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var elemento = elementoRepository.GetAllAsync().Result;
            var elementoDTO = elemento.Select(x => mapper.Map<ElementoDTO>(x));
            return View(elementoDTO);
        }
    }
}
