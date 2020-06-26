using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test2_Retake.DTOs.Requests;
using Test2_Retake.Models;

namespace Test2_Retake.Services
{
    public interface IListService
    {
        public List<Firefighter> GetList(int id);
        public void AssignFireTruckAction(AssignFireTruckActionRequest request);
    }
}
