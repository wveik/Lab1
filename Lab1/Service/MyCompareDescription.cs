using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Service {
    public class MyCompareDescription : IComparer<AutoDescription> {
        public int Compare(AutoDescription x, AutoDescription y) {
            DateTime ix = InnerCompate(x);
            DateTime iy = InnerCompate(y);
            return ix.CompareTo(iy);
        }

        private DateTime InnerCompate(AutoDescription x) {
            DateTime result = DateTime.MinValue;
            if (!string.IsNullOrEmpty(x.CREATE_DATE)) {
                result = DateTime.Parse(x.CREATE_DATE).Date;
            }
            return result;
        }
    }
}
