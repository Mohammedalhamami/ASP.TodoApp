﻿using ASP.TodoApp.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.TodoApp.MVC.Controllers
{
	public class TodosController : Controller
	{
		public IActionResult Index()
		{
			var todos = new List<Todo>()
			{
				new Todo
				{
					Id = 1,
					Description = "My birth day party",
					CreatedAt = new DateTime(2024, 5, 13, 5, 30, 22),
					Completed = false

				},

				new Todo
				{
					Id = 2,
					Description = "Go to Minstry of Health",
					CreatedAt = new DateTime(2024, 5, 02, 10, 30, 22),
					Completed = true

				},
				new Todo
				{
					Id = 3,
					Description = "First time as night sheft nurse",
					CreatedAt = new DateTime(2024, 5, 04, 14, 30, 22),
					Completed = false

				},
				new Todo
				{
					Id = 4,
					Description = "Finsh Udemy Course Api",
					CreatedAt = new DateTime(2024, 5, 30, 5, 30, 22),
					Completed = false

				},
			};
			return View(todos);
		}
	}
}
