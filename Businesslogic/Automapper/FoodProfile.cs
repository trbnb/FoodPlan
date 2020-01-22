﻿using AutoMapper;
using Businesslogic.DTO;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businesslogic.Automapper
{
    public class FoodProfile : Profile
    {
        public FoodProfile()
        {
            CreateMap<Meal, MealDTO>();
        }
    }
}