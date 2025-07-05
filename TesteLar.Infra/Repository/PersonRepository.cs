using TesteLar.Domain.Entities;
using TesteLar.Domain.Interfaces;
using TesteLar.Infra.Context;
using TesteLar.Infra.Repository.Base;

namespace TesteLar.Infra.Repository
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(LarContext larContext) : base(larContext) { }
    }
}
