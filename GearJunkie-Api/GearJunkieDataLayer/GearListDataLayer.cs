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
                return  new OperationResultOfT<List<GearList>> {
                    Messages = new List<string> { "Your user id is 1"},
                    Entity = new List<GearList>
                    {
                        new GearList
                        {
                            GearListId = 1,
                            Name = "Gear List 1",
                            Description = "testing"
                        },
                        new GearList
                        {
                            GearListId = 2,
                            Name = "Gear List 2",
                            Description = "testing"
                        },
                        new GearList
                        {
                            GearListId = 3,
                            Name = "Gear List 3",
                            Description = "testing"
                        }
                    }
                };
            }

            return null;
        }
    }
}
