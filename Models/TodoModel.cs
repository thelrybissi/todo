using System;

namespace Todo.Model{
    
    public class TodoModel {

        public int Id { get; set; }

        public string Title { get; set; }

        public bool Done { get; set; }

        public DateTime CreatAt { get; set; }
    } 
}
