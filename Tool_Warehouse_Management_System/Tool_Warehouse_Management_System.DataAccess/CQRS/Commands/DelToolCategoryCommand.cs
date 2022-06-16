﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool_Warehouse_Management_System.DataAccess.CQRS.Queries;
using Tool_Warehouse_Management_System.DataAccess.Entities;

namespace Tool_Warehouse_Management_System.DataAccess.CQRS.Commands
{
    public class DelToolCategoryCommand : CommandBase<Entities.ToolCategory, ToolCategory>
    {
        public override async Task<ToolCategory> Execute(ToolWarehouseStorageContext context)
        {
            //context.ChangeTracker.Clear();
            context.ToolCategories.Remove(this.Parameter);  
            await context.SaveChangesAsync();   //zapisuje zmiany
            return this.Parameter; //zwrotka juz z bazy danych pełnego wpisu (z id itd)
        }
    }
}
