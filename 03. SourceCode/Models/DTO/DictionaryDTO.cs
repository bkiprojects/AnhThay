using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models.DTO
{
    public class DictionaryDTO
    {
        public int DictionaryId { get; set; }
        public int DictionaryTypeId { get; set; }
        public string DictionaryTypeName { get; set; }

        public string DictionaryCode { get; set; }
        public string ShortName { get; set; }
            
        public string LongName { get; set; }
        public string Notes { get; set; }

    }
}
