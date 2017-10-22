﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Data.Interfaces;
using LibraryManagement.Data.Model;
using LibraryManagement.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryManagement.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorRepository _repository;

        public AuthorController(IAuthorRepository repository)
        {
            _repository = repository;
        }
        [Route("Author")]
        public IActionResult List()
        {
            var authors = _repository.GetAllWithBooks();

            if (authors?.ToList().Count == 0)
            {
                return View("Empty");
            }

            var authorsVM = new List<AuthorViewModel>();

            foreach (var author in authors)
            {
                authorsVM.Add(new AuthorViewModel
                {
                    Author = author,
                    BookCount = author.Books?.Count
                });
            }

            return View(authorsVM);
        }

        public IActionResult Detail(int id)
        {
            var author = _repository.GetById(id);

            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        public IActionResult Update(int id)
        {
            var author = _repository.GetById(id);
            
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        [HttpPost]
        public IActionResult Update(Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }
            _repository.Update(author);

            return RedirectToAction("List");
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author customer)
        {
            if (!ModelState.IsValid)
            {
                return View(customer);
            }

            _repository.Create(customer);

            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            var customer = _repository.GetById(id);

            _repository.Delete(customer);

            return RedirectToAction("List");
        }
    }
}