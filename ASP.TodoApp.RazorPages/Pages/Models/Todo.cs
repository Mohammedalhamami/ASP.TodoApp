﻿namespace ASP.TodoApp.RazorPages.Pages.Models
{
    public class Todo
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool Completed { get; set; }

    }
}
