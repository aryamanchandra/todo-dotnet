using System.ComponentModel.DataAnnotations;

public class UpdateTodoRequest {
    [StringLength(100)]
    public string Title {get; set;}

    [StringLength(500)]
    public string Description {get; set;}
    public bool? isComplete {get; set;}
    public DateTime? DueDate {get; set;}

    [Range(1,5)]
    public int? Priority {get; set;}

    public UpdateTodoRequest(){
        isComplete = false;
    }
}