using System;
using System.Collections.Generic;
using System.Text;

namespace WebModels
{
    public class MuncipalityViewModel
    {
        public string Name { get; set; }
        public IEnumerable<SchoolsViewModel> Schools { get; set; }
    }
}
