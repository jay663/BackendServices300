using HikeSharingUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HikeSharingUI.Services
{
    public class InMemoryParkService : IParkService
    {
        public async Task<List<ParkListItemModel>> GetAllParksAsync()
        {
            var result = new List<ParkListItemModel>
            {
                new ParkListItemModel{ Id=1, Description="Lakewood Park", Address="Lakewood", OpenInformation="All Year"},
                new ParkListItemModel {Id = 2, Description="Bob's Road Park", Address="Cleveland Heights", OpenInformation ="Just in June"}
            };

            return result;
        }
    }
}
