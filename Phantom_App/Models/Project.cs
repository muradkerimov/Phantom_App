using System;

namespace Phantom_App.Models
{
    public class Project : Base
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
    }
}
