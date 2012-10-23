namespace MVC_reusability.Domain
{
    public static class DomainFactory
    {
        public static DomainAccountModel GetAccount()
        {
            return new DomainAccountModel
                       {
                           Name = "Thor Kristian",
                           Alder = 25
                       };
        }
    }

    public class DomainAccountModel
    {
        public string Name { get; set; }
        public int Alder { get; set; }
    }
}