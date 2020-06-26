using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Test2_Retake.DTOs.Requests;
using Test2_Retake.DTOs.Responses;
using Test2_Retake.Exceptions;
using Test2_Retake.Models;

namespace Test2_Retake.Services
{
    public class ListService : IListService
    {
        private readonly s19183DbContext _context;

        public ListService(s19183DbContext context)
        {
            _context = context;
        }
        
        public  AssignFireTruckAction(AssignFireTruckActionRequest request)
        {
            var Firetruck = _context.FireTrucks.FirstOrDefault(p => p.IdFireTruck);
            var Action = _context.Actions.FirstOrDefault(p => p.IdAction == request.IdAction);

            if (FireTruck == null) throw new FireFighterNotFoundException();
            if (Action == null) throw new ActionNotFoundException();

            var fireTruckAssign = new FireTruck_Action() { IdAction = request.IdAction };

            _context.Actions.Add(fireTruckAssign);
            _context.SaveChanges();

            return new AssignFireTruckActionResponse { IdAction = request.IdAction };
        }

        public List<Firefighter> GetList(int id)
        {
            var FireFighterCheck = _context.Firefighters.FirstOrDefault(p => p.IdFirefighter == id);
            if (FireFighterCheck == null) throw new FireFighterNotFoundException();

            var res = _context.Firefighters.Where(f => f.IdFirefighter == f.IdFirefighter).Join(_context.Action, st => st.IdFirefighter, sa=> sa.IdAction), (st,sa) => new GetListResponse
            {
                IdAction = sa.IdAction,
                StartTime = sa.StartTime,
                EndTime = sa.EndTime
            }).ToList().OrderByDescending(sa => sa.EndTime);

            return new GetListResponse() { Actions = res };
        }
    }
}
