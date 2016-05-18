using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Models {
    public class Owner {
        public int ID_OWNER { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }

        public Owner() { }
        public Owner(string row) {
            bool flag = true;
            string[] columns = row.Split('\t');

            if (columns.Length > 3) {
                throw new ArgumentException("Неверное количество столбцов");
            }
            int temp = -1;
            int.TryParse(columns[0].Trim(), out temp);

            if (!flag) {
                throw new ArgumentException("Первый столбец не число");
            }

            this.ID_OWNER = temp;

            this.FIRST_NAME = columns[1];
            this.LAST_NAME = columns[2];
        }
    }
}
