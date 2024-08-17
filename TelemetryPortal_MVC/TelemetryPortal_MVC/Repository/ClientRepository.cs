using Microsoft.EntityFrameworkCore;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repository
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        
        public ClientRepository(TechtrendsContext context) : base(context)
        { 
            
        }

        //Implement client-specific methods here

    }
}
