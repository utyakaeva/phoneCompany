using System;

namespace telCom_2._1
{
    public interface IUser
    {       bool IsClient { get; }
            bool IsWorker { get; }
            int Id { get; }
            string Position { get; }
            string Login { get; }
        }
                public partial class Worker1 : IUser
        {
            public bool IsClient { get { return false; } }
            public bool IsWorker { get { return true; } }
        }
 
}
