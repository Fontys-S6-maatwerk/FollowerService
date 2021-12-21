using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FollowerService.Data.Entities
{
    public class User
    {
        public Guid userId { get; set; }

        public Guid followerId { get; set; }
    }
}
