using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todo.Model{
    
    [Table("Todo")]
    public class TodoModel {

        public int Id { get; set; }

        public string? Title { get; set; }

        public bool Done { get; set; }

        public DateTime CreatAt { get; set; } 
    } 
}

