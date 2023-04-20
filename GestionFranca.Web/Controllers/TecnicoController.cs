using AutoMapper;
using GestionFranca.BLL.DTOs;
using GestionFranca.BLL.Repository;
using GestionFranca.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net;

namespace GestionFranca.Web.Controllers
{
    public class TecnicoController : Controller
    {
        readonly ITecnicoRepository tecnicoRepository;
        readonly ISucursalRepository sucursalRepository;
        readonly IMapper mapper;

        public TecnicoController(ITecnicoRepository tecnicoRepository, IMapper mapper, ISucursalRepository sucursalRepository)
        {
            this.tecnicoRepository = tecnicoRepository;
            this.mapper = mapper;
            this.sucursalRepository = sucursalRepository;
        }
        public async Task<IActionResult> Index()
        {
            var tecnico = tecnicoRepository.GetAllAsync().Result;
            var tecnicoDTO = tecnico.Select(x => mapper.Map<TecnicoDTO>(x));
            return View(tecnicoDTO);
        }
        public IActionResult Create()
        {
            BLL.Services.SucursalService tecnicos = new();
            ViewBag.SucursalSelectList = tecnicos.GetSucursalSelectList();
            ViewBag.SucursalSelectList = tecnicos.GetSucursalSelectList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TecnicoDTO tecnicoDTO)
        {
            try
            {
                BLL.Services.SucursalService tecnicos = new();
                ViewBag.SucursalSelectList = tecnicos.GetSucursalSelectList();

                var tecnico = mapper.Map<Tecnico>(tecnicoDTO);
                if (tecnico != null)
                {
                    tecnico = tecnicoRepository.InsertAsync(tecnico).Result;
                    tecnicoDTO.TecnicoId = tecnico.TecnicoId;
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return Ok(new ResponseDTO { Code = (int)HttpStatusCode.InternalServerError, Message = ex.Message });
            }

        }

        public async Task<IActionResult> Edit(int? id)
        {
            BLL.Services.SucursalService tecnicos = new();
            ViewBag.SucursalSelectList = tecnicos.GetSucursalSelectList();
            return View();
        }       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int Id, TecnicoDTO tecnicoDTO)
        {
            try
            {
                var tecnico = tecnicoRepository.GetByIdAsync(Id).Result;
                if (tecnico == null)
                {
                    return Ok(new ResponseDTO { Code = (int)HttpStatusCode.NotFound, Message = "Not Found" });
                }

                if (tecnico != null)
                {
                    tecnico = mapper.Map<Tecnico>(tecnicoDTO);//objeto
                    tecnico = tecnicoRepository.UpdateAsync(tecnico).Result;
                }
                return RedirectToAction("Index");                
            }
            catch (Exception ex)
            {
                return Ok(new ResponseDTO { Code = (int)HttpStatusCode.InternalServerError, Message = ex.Message });
            }
        }

        public async Task<IActionResult> Delete(int? id)
        {
            BLL.Services.SucursalService tecnicos = new();
            ViewBag.SucursalSelectList = tecnicos.GetSucursalSelectList();
            return View();
        }
      
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var tecnico = tecnicoRepository.GetByIdAsync(id).Result;
                if (tecnico == null)
                {
                    return Ok(new ResponseDTO { Code = (int)HttpStatusCode.NotFound, Message = "Not Found" });
                }

                if (tecnico != null)
                {

                    await tecnicoRepository.DeleteAsync(id);
                }
                ViewBag.Id = id; // Establecer el ID en ViewBag
                return RedirectToAction("Index");                
            }
            catch (Exception ex)
            {
                return Ok(new ResponseDTO { Code = (int)HttpStatusCode.InternalServerError, Message = ex.Message });
            }
        }

    }
}
