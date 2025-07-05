using TesteLar.Domain.Entities.Base;

namespace TesteLar.Domain.Entities;
public class Person : Entity
{
    public string Name { get; set; }

    public string Cpf { get; set; }
    public DateTime BirthDate { get; set; }
    public List<Phone> Phone { get; set; }
}
