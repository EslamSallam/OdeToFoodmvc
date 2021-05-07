using OdeToFood.Data.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public interface IRestuarantData
    {
        IEnumerable<Restuarant> GetAll();
    }
}
