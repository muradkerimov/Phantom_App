﻿using Phantom_App.Models;
using System.Collections.Generic;

namespace Phantom_App.ViewModel
{
    public class HomeViewModel
    {
        public Header headers { get; set; }
        public List<Project> projects { get; set; }
        public List<Message> messages { get; set; }
    }
}
