using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laan.SQL.Parser
{
    public class DeleteStatement : CustomStatement
    {
        public int? Top { get; set; }
        public string TableName { get; set; }
    }
}