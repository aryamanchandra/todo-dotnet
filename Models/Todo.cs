using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace TodoAPI.Models
{
    public class Todo
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Todo()
        {
            IsComplete = false;

        }
    }

    public class ErrorResponse {
        public string Title { get; set; }
        public int StatusCode { get; set; }
        public string Message { get; set; }
    }

    public class DbSettings {
        public string ConnectionString { get; set;}
    }

}