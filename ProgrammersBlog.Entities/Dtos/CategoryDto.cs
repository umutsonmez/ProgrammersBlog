﻿using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CategoryDto:DtoGetBase
    {
        public Category Category { get; set; }
    }
}
