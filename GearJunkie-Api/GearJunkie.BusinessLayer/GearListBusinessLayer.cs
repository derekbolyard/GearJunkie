using GearJunkie.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using BusinessObjects;
using Common;
using System.Threading.Tasks;
using GearJunkie.DataLayer.Interfaces;

namespace GearJunkie.BusinessLayer
{
    public class GearListBusinessLayer : IGearListBusinessLayer
    {
        private IGearListDataLayer gearListDataLayer;

        public GearListBusinessLayer(IGearListDataLayer gearListDataLayer)
        {
            this.gearListDataLayer = gearListDataLayer;
        }
        public Task<OperationResultOfT<List<GearList>>> GetGearListsByUserId(long userId)
        {
            throw new NotImplementedException();
        }
    }
}
