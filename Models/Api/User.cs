using System.ComponentModel.DataAnnotations;

namespace TodoList.Api.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string EmailAddress { get; set; }
    }
}