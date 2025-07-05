using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLar.Application.DTO;
using TesteLar.Domain.Interfaces;

namespace TesteLar.Application.Interfaces
{
    public class PhoneTypeApplicationService: IPhoneTypeApplicationService
    {

        protected readonly IPhoneTypeRepository _phoneTypeRepository;
        protected readonly IMapper _mapper;

        public PhoneTypeApplicationService(IPhoneTypeRepository phoneTypeRepository, IMapper mapper)
        {
            _phoneTypeRepository = phoneTypeRepository;
            _mapper = mapper;
        }
        public async Task<IList<PhoneTypeDTO>> GetAllPhoneTypesAsync()
        {
            var phoneTypes = await _phoneTypeRepository.GetAllAsync();
            return _mapper.Map<IList<PhoneTypeDTO>>(phoneTypes);
        }

        public void Dispose()
        {
            _phoneTypeRepository.Dispose();
        }
    }
}
