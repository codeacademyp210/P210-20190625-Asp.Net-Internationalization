using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultiLang.Models
{
    public class Translate
    {
        public int Id { get; set; }
        public string Keyword { get; set; }
        public string En { get; set; }
        public string Az { get; set; }
    }
}