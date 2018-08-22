using BusinessObjects;
using Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GearJunkie.BusinessLayer.Interfaces
{
    public interface IGearListBusinessLayer
    {
        Task<OperationResultOfT<List<GearList>>> GetGearListsByUserId(long userId);
    }
}
