using System.ComponentModel.DataAnnotations; 

namespace Books_Inbox.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string WriterName { get; set; }

        public int PageCount { get; set; }

        public string ImageName { get; set; }

        public DateTime DataTime { get; set; }    
        }

}