using System.ComponentModel.DataAnnotations;

namespace SkysCodeFirstMultipleAdds.Data
{
    public class Player
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public int Age { get; set; }
    }
}