﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCore.Web.AutoGenerateHtmlControl.GenerateForm
{
    public interface ISelectDataSource
    {
        Task<IEnumerable<SelectListItem>> GetAsync(IEnumerable<object> values);
    }
}