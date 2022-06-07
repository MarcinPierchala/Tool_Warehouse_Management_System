using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tool_Warehouse_Management_System.DataAccess;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace Tool_Warehouse_Management_System.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToolCategoryController : ControllerBase
    {
        private readonly IRepository<ToolCategory> toolCategoryRepository;
        public ToolCategoryController(IRepository<ToolCategory> toolCategoryRepository)
        {
            this.toolCategoryRepository = toolCategoryRepository;
        }

        [HttpGet]
        [Route("")]
        public async Task<IEnumerable<ToolCategory>> GetAllToolsAsync() => await this.toolCategoryRepository.GetAll();

        [HttpGet]
        [Route("{toolCategoryId}")]
        public async Task<ToolCategory> GetToolCategoryByIdAsync(int toolCategoryId) => await this.toolCategoryRepository.GetById(toolCategoryId);
    }
}
