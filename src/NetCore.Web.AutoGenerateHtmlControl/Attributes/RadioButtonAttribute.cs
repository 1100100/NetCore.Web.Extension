﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace NetCore.Web.AutoGenerateHtmlControl.Attributes
{
    public class RadioButtonAttribute : FormControlsAttribute
    {
        public RadioButtonAttribute()
        {
            ControlType = HtmlControlType.RadioButton;
        }

        public Type DataSource { get; set; }

        public IEnumerable<SelectListItem> GetDataSource()
        {
            return null;
        }
    }
}
