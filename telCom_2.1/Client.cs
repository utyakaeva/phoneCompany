namespace telCom_2._1
{
    using System;
    using System.Collections.Generic;

    public partial class Client1
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public double Balance { get; set; }
        public Nullable<int> LegalEntityId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public Nullable<int> TariffId { get; set; }

        public static implicit operator Client1(Client v)
        {
            throw new NotImplementedException();
        }
    }
}

    public class Client
{
}
    
