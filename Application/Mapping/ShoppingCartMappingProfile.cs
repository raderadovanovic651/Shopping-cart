using Application.Commands.Item;
using Application.Responses.Item;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapping
{
    public class ShoppingCartMappingProfile : Profile
    {
        public ShoppingCartMappingProfile()
        {
            CreateMap<ItemInsertCommand, Item>().ReverseMap();
            CreateMap<Item, ItemResponse>().ReverseMap();
        }
    }
}
