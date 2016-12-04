using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoList.Api.Models
{
    [Table("Todos")]
    public class Todo
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public bool Completed { get; set; }

        //// Foreign Key
        //public int UserId { get; set; }
        //// Navigation property
        //public User User { get; set; }
    }
}