using AutoMapper;
using TesteLar.Application.DTO;
using TesteLar.Application.Interfaces;
using TesteLar.Domain.Entities;
using TesteLar.Domain.Interfaces;

namespace TesteLar.Application.ApplicationServices
{
    public class PersonApplicationService : IPersonApplicationService
    {
        protected readonly IPersonRepository _personRepository;
        protected readonly IMapper _mapper;
        public PersonApplicationService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<bool> AddPersonAsync(PersonDTO person)
        {
            await _personRepository.AddAsync(_mapper.Map<Person>(person));

            return true;
        }

        public async Task<bool> DeletePersonAsync(int id)
        {
            await _personRepository.DeleteAsync(id);

            return true;
        }

        public async Task<IList<PersonDTO>> GetAllPeopleAsync()
        {
            return _mapper.Map<IList<PersonDTO>>(await _personRepository.GetAllAsync()).ToList();
        }

        public async Task<PersonDTO> GetPersonByIdAsync(int id)
        {
            return _mapper.Map<PersonDTO>(await _personRepository.GetByIdAsync(id, p => p.Phone));
        }

        public async Task<bool> UpdatePersonAsync(PersonDTO person)
        {
            await _personRepository.UpdateAsync(_mapper.Map<Person>(person));

            return true;
        }

        public void Dispose()
        {
            _personRepository.Dispose();
        }
    }
}
