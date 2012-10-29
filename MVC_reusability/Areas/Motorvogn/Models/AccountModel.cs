namespace MVC_reusability.Areas.Motorvogn.Models
{
    public class AccountModel : MVC_reusability.Models.AccountModel
    {
        public string RegNr { get; set; }
        public string Model { get; set; }
        public int YearModel { get; set; }
    }
}