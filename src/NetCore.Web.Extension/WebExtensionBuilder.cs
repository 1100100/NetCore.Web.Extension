﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;

namespace NetCore.Web.Extension
{
    public class GlobalExceptionOptions
    {
        public Action<ExceptionContext, ILogger> Action { get; set; }
    }

    public class GlobalModelStateOptions
    {
        public Action<ActionExecutingContext> Action { get; set; }
    }

    public class JwtOptions
    {
        public string SecurityKey { get; set; }

        public string ValidIssuer { get; set; }

        public IEnumerable<string> ValidIssuers { get; set; }

        public string ValidAudience { get; set; }

        public IEnumerable<string> ValidAudiences { get; set; }

        public string SecurityAlgorithm { get; set; } = SecurityAlgorithms.HmacSha512Signature;

        public JwtBearerEvents Events { get; set; }
    }

    public class JwtCookieOptions : JwtOptions
    {
        public CookieBuilder Cookie { get; set; } = new CookieBuilder();

        public string AccessDeniedPath { get; set; }

        public string LoginPath { get; set; }

        public bool SlidingExpiration { get; set; }

        public TimeSpan ExpireTimeSpan { get; set; }

        public new CookieAuthenticationEvents Events { get; set; }
    }
}
