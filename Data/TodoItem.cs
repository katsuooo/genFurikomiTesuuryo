using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace genFurikomiTesuuryo.Data
{
    public class TodoItem
    {
        public string Titel { get; set; }
        public bool IsDone { get; set; }
        public bool IsNew { get; set; }
        public bool IsCopied { get; set; }
    }
}
