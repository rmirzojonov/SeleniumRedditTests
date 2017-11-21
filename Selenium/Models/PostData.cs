using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{
    public class PostData
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Area { get; set; }
        public PostData(string title, string text, string area)
        {
            Title = title;
            Text = text;
            Area = area;
        }
    }
}
