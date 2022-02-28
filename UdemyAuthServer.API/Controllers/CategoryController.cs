using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyAuthServer.API.Controllers;
using UdemyAuthServer.Core.Dtos;
using UdemyAuthServer.Core.Models;
using UdemyAuthServer.Core.Services;
using UnluCoAuthServer.Core.Dtos;
using UnluCoAuthServer.Core.Models;

namespace UnluCoAuthServer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class CategoryController : CustomBaseController
    {

        private readonly IGenericService<Category, CategoryDto> _categoryService;

        public CategoryController(IGenericService<Category, CategoryDto> categoryService)
        {
            _categoryService = categoryService;


        }
        [HttpGet]
        public async Task<IActionResult> GetCategory()
        {
            return ActionResultInstance(await _categoryService.GetAllAsync());

        }
        [HttpPost]
        public async Task<IActionResult> SaveCategory(CategoryDto categorytDto)
        {
            return ActionResultInstance(await _categoryService.AddAsync(categorytDto));

        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(CategoryDto categoryDto)
        {
            return ActionResultInstance(await _categoryService.Update(categoryDto, categoryDto.Id));

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            return ActionResultInstance(await _categoryService.Remove(id));

        }
    }
}
