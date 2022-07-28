using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;
using DevExpress.Xpf.Bars;

namespace RichEditSpellChecker_Example
{
    public class MainWindowViewModel
    {
        public List<BarItem> ItemLinks { get; } = new()
        {
            new BarButtonItem() {Content = "Hello, World!"}
        };
    }
}
