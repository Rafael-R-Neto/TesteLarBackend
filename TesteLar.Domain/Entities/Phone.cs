using TesteLar.Domain.Entities.Base;

namespace TesteLar.Domain.Entities;

public class Phone : Entity
{
    public string Number { get; set; }
    public int PhoneTypeId { get; set; }
    public PhoneType PhoneType { get; set; }
}