using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace RegExFile.GetId
{
    public class GetBgWordId
    {
        public static RegExFileContext context = new RegExFileContext();

        public int? GetWordBgID(string wordBg)
        {
            var checkBgWord = context.BgWords?.Select(w => new { w.BgWord, w.Id }).SingleOrDefault(w => w.BgWord == wordBg);
            int? bgWordId = checkBgWord?.Id;

            return bgWordId;
        }
    }
}
