﻿using System;

namespace NetCore.Web.AutoGenerateHtmlControl.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class TextAreaAttribute : FormControlsAttribute
    {
        public TextAreaAttribute()
        {
            ControlType = HtmlControlType.TextArea;
        }

        private int _rows;

        public int Rows
        {
            get => _rows;

            set
            {
                _rows = value;
                AddAttribute(nameof(Rows), value);
            }
        }

        private string _placeholder;
        public string Placeholder
        {
            get => _placeholder; set
            {
                _placeholder = value;
                AddAttribute(nameof(Placeholder), value);
            }
        }
    }
}
