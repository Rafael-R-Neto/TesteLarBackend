
namespace TesteLar.Application.DTO
{
    public class PersonDTO: EntityDTO
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public List<PhoneDTO> Phone { get; set; }
    }
}
