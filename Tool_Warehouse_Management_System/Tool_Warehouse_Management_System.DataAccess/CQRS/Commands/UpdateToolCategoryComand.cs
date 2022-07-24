using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace Tool_Warehouse_Management_System.DataAccess.CQRS.Commands
{
    public class UpdateToolCategoryComand : CommandBase<Entities.ToolCategory, Entities.ToolCategory>
    {
        public override async Task<ToolCategory> Execute(ToolWarehouseStorageContext context)
        {
            context.ToolCategories.Update(this.Parameter);     //AddAsync(this.Parameter);  //dodaje nowy wpis - kategorię narzędzi
            await context.SaveChangesAsync();   //zapisuje zmiany
            return this.Parameter;  //zwrotka juz z bazy danych pełnego wpisu (z id itd)
        }
    }
}