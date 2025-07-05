using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteLar.Domain.Entities.Base;

namespace TesteLar.Domain.Entities;

public class PhoneType: Entity
{
    public string Name { get; set; }
    public string Description { get; set; }
}
