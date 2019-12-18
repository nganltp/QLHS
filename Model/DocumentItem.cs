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
        private DateTime uploadDate;
        private DateTime editDate;

        public DocumentItem(string title, string link, DateTime uploadDate, DateTime editDate)
        {
            this.link = link;
            this.UploadDate = uploadDate;
            this.EditDate = editDate;
            this.title = title;
        }

        public string Title { get => title; set => title = value; }
        public string Link { get => link; set => link = value; }

        public DateTime UploadDate
        {
            get => uploadDate;
            set => uploadDate = value;
        }

        public DateTime EditDate
        {
            get => editDate;
            set => editDate = value;
        }
    }
}
