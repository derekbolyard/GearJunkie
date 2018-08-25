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
        public async Task<OperationResultOfT<List<GearList>>> GetGearListsByUserId(long userId)
        {
            if(userId == 1)
            {
                return  new OperationResultOfT<List<GearList>> { Messages = new List<string> { "Your user id is 1"}};
            }

            return null;
        }
    }
}
