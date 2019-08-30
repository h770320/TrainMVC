﻿using System.Collections.Generic;
using TrainMVC.FilterParameter;
using TrainMVC.Models;

namespace TrainMVC.DA.Interfaces
{
    public interface ICountyStationMappingRepository
    {
        List<TrainQueryModel> GetByFilter(StationFilterParameter filter);
    }
}