using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paper.Storage.Entities
{
    internal class User
    {
        public string UserId { get; set; }

        public string AppleSubId { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public Settings Settings { get; set; }

        public List<Workbook> Workbooks { get; set; }
    }
}
