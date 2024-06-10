using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Books_Inbox.Models
{
    public class Writer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        public string ImageName { get; set; }
        public DateTime BrithDataTime { get; set; }    
        public DateTime DeathDataTime { get; set; }    
        }

}