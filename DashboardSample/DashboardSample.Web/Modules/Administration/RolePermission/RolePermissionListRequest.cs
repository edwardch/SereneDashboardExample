﻿using Serenity.Services;

namespace DashboardSample.Administration
{
    public class RolePermissionListRequest : ServiceRequest
    {
        public int? RoleID { get; set; }
        public string Module { get; set; }
        public string Submodule { get; set; }
    }
}