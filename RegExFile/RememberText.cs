using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegExFile
{
    public class RememberText
    {
        public int PageNum { get; set; }

        public string Text { get; set; }

        public override bool Equals(object obj)
        {
            var rememberText = obj as RememberText;

            return rememberText.PageNum == this.PageNum;
        }
        public override int GetHashCode()
        {
            return this.PageNum;
        }
    }
}
