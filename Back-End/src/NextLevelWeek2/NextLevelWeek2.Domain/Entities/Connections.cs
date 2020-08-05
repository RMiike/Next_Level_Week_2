using NextLevelWeek2.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proffy.Core.Entities
{
    public class Connections
    {
        public int Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int UserId { get; private set; }
        public User User{ get; private set; }
    }
}
