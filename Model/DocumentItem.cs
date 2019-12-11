using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_app.Model
{
    class DocumentItem
    {
        private String link;
        private String tieuDe;

        public DocumentItem(string link, string tieuDe)
        {
            this.link = link;
            this.tieuDe = tieuDe;
        }

        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public string Link { get => link; set => link = value; }
    }
}
