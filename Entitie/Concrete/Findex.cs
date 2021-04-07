using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Findex : IEntity
    {
        public int FindexId { get; set; }
        public int Id { get; set; }
        public int FindexStore { get; set; }
    }
}
