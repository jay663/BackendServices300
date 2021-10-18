using HikeSharingUI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HikeSharingUI.Services
{
    public interface IParkService
    {
        Task<List<ParkListItemModel>> GetAllParksAsync();
    }
}