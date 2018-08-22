using GearJunkie.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessObjects;
using Common;
using System.Threading.Tasks;

namespace GearJunkie.DataLayer
{
    public class GearListDataLayer : IGearListDataLayer
    {
        public Task<OperationResultOfT<List<GearList>>> GetGearListsByUserId(long userId)
        {
            throw new NotImplementedException();
        }
    }
}
