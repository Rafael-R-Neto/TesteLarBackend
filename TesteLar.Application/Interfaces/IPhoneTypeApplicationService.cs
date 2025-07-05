using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLar.Application.DTO;

namespace TesteLar.Application.Interfaces
{
    public interface IPhoneTypeApplicationService: IDisposable
    {
        Task<IList<PhoneTypeDTO>> GetAllPhoneTypesAsync();
    }
}
