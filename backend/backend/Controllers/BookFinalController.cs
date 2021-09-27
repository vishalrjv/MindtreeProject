using backend.Interfaces;
using backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Controllers
{
    
    public class BookFinalController : BaseController
    {
        private readonly IUnitOfWork uow;
        public BookFinalController(IUnitOfWork uow)
        {
           
            this.uow = uow;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> GetBooks()
        {
            var bookdetails =await uow.BookFinalRepository.GetBookDetails();
            return Ok(bookdetails);
        }
        [HttpPost]
        public async Task<ActionResult> AddBookDetail(BookFinal bookfinal)
        {
            uow.BookFinalRepository.AddBookDetail(bookfinal);
            await uow.SaveAsync();
            return StatusCode(201);
        }
    }
}
