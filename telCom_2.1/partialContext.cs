
namespace telCom_2._1
{
    using System;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    public partial class telComEntities : DbContext
    {
        public telComEntities(string connStr) : base(connStr)
        { }

        public telComEntities(DbConnection existingConnection, bool contextOwnsConnection) :
            base(existingConnection, contextOwnsConnection)
        { }
    }
}