using desktop_app.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop_app.ViewModels
{
    public class DocumentManagerViewModel : BindableBase
    {
        public DocumentManagerViewModel()
        {
            DocumentItems = new ObservableCollection<DocumentItem>()
            {
                new DocumentItem("Google", "https://google.com", DateTime.Today, DateTime.Today),
                new DocumentItem("Facebook", "https://facebook.com", DateTime.Today, DateTime.Today)
            };
        }
        
        public ObservableCollection<DocumentItem> DocumentItems { get; private set; }
    }
}
