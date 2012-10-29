using System;

namespace MVC_reusability.Models
{
    public class AccountModel: BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DueDate { get; set; }
        public double InsurenceAmount { get; set; }
    }
}