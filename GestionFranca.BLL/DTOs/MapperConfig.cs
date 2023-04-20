using AutoMapper;
using GestionFranca.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFranca.BLL.DTOs
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Tecnico, TecnicoDTO>().ReverseMap();
            CreateMap<Elemento, ElementoDTO>().ReverseMap();
            CreateMap<Sucursal, SucursalDTO>().ReverseMap();
            CreateMap<TecnicoElemento, TecnicoElementoDTO>().ReverseMap();
        }
    }
}
