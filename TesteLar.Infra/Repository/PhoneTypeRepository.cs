using TesteLar.Domain.Entities;
using TesteLar.Domain.Interfaces;
using TesteLar.Infra.Context;
using TesteLar.Infra.Repository.Base;

namespace TesteLar.Infra.Repository
{
    public class PhoneTypeRepository : Repository<PhoneType>, IPhoneTypeRepository
    {
        public PhoneTypeRepository(LarContext larContext) : base(larContext) { }
    }
}
