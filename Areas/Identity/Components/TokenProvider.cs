﻿namespace BrapShop.Areas.Identity.Components
{
    public class TokenProvider
    {
        public string? XsrfToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
