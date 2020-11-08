using System;
using System.Text;
using Usizo_Beta.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Usizo_Beta.Services
{
    public interface IActiviteServices
    {
        Task<IEnumerable<Activite>> Activites();
        ObservableCollection<Activite> ListActivites();
        Task<Activite> ActiviteDetails(string UID);
    }
}
