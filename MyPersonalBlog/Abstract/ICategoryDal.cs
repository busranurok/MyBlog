﻿using MyPersonalBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalBlog.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
