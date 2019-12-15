using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_app.Models
{
    public class DocumentItem
    {
        private String link;
        private String title;

        public DocumentItem(string title, string link)
        {
            this.link = link;
            this.title = title;
        }

        public string Title { get => title; set => title = value; }
        public string Link { get => link; set => link = value; }
    }
}
