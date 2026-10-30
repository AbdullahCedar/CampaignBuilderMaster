using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class AgentsAndManager
    {
        public int Id { get; set; }
        public string? AgentName { get; set; }
        public string? DepartmentName { get; set; }
        public string? ManagerId { get; set; }
        public string? ManagerEmail { get; set; }
        public string? Vpid { get; set; }
        public string? Vpemail { get; set; }
    }
}
