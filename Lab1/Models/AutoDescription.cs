using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Models {
    public class AutoDescription {

        public AutoDescription() { }

        public AutoDescription(string row) {
            string[] columns = row.Split('\t');

            this.ID_DESCRIPTION = int.Parse(columns[0]);
            this.MARK = columns[1];
            this.NUMBER = columns[2];
            this.LAST_NAME = columns[3];
            this.CREATE_DATE = columns[4];
        }

        public int ID_DESCRIPTION { get; set; }
        public string MARK { get; set; }
        public string NUMBER { get; set; }
        public string LAST_NAME { get; set; }
        public string CREATE_DATE { get; set; }
    }
}
