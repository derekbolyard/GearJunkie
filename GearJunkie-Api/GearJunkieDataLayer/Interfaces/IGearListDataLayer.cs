using BusinessObjects;
using Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GearJunkie.DataLayer.Interfaces
{
    public interface IGearListDataLayer
    {
        Task<OperationResultOfT<List<GearList>>> GetGearListsByUserId(long userId);
    }
}
