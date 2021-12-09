using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SkysCodeFirstMultipleAdds.Data
{
    public class Team
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public List<Player> Players { get; set; } = new List<Player>();
    }
}