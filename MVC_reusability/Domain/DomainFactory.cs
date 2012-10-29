using System;

namespace MVC_reusability.Domain
{
    public static class DomainFactory
    {
        public static DomainAccountModel GetAccount()
        {
            return new DomainAccountModel
                       {
                           Name = "Thor Kristian",
                           Address = "Eiriks gate 18",
                           DueDate = new DateTime(2012,10,09),
                           InsurenceAmount = 1560
                       };
        }

        public static MotorvognDomainModel GetMotorvognAccountModel()
        {
            return new MotorvognDomainModel
                       {
                           RegNr = "AB 15600",
                           Model = "Ford",
                           YearModel = 1999
                       };
        }
    }

    public class MotorvognDomainModel
    {
        public string RegNr {get; set; }
        public string Model { get; set; }
        public int YearModel { get; set; }
    }

    public class DomainAccountModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime DueDate { get; set; }
        public double InsurenceAmount { get; set; }
    }
}