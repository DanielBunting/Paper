using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paper.Models.DTOs
{
    public class WorkbookDto
    {
        public string Title { get; set; }

        public List<PageDto> Pages { get; set; }
    }
}
