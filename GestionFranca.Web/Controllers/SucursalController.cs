using AutoMapper;
using GestionFranca.BLL.DTOs;
using GestionFranca.BLL.Repository;
using GestionFranca.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace GestionFranca.Web.Controllers
{
    public class SucursalController : Controller
    {
        readonly ISucursalRepository sucursalRepository;
        readonly IMapper mapper;

        public SucursalController(ISucursalRepository sucursalRepository, IMapper mapper)
        {
            this.sucursalRepository = sucursalRepository;
            this.mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var sucursal = sucursalRepository.GetAllAsync().Result;
            var sucursalDTO = sucursal.Select(x => mapper.Map<SucursalDTO>(x));
            return View(sucursalDTO);
        }
    }
}
