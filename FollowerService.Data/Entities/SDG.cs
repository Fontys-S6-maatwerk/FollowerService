using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowerService.Data.Entities
{
    public class SDG : BaseEntity
    {
        public Guid userId { get; set; }

        public Guid sdgId { get; set; }
    }
}
