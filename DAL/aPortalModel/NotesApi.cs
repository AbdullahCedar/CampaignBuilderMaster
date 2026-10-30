using System;
using System.Collections.Generic;

namespace DAL.aPortalModel
{
    public partial class NotesApi
    {
        public int Id { get; set; }
        public int? FormId { get; set; }
        public byte[]? NotesPortal { get; set; }
    }
}
