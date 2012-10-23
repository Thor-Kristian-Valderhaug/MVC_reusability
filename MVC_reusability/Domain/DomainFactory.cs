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

        public static MotorvognDomainModel GetMotorvognAccountModel()
        {
            return new MotorvognDomainModel
                       {
                           RegNr = "Ikke registrert"
                       };
        }
    }

    public class MotorvognDomainModel
    {
        public string RegNr {get; set; }
    }

    public class DomainAccountModel
    {
        public string Name { get; set; }
        public int Alder { get; set; }
    }
}