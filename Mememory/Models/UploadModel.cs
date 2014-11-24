using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mememory.Models
{
    public class UploadModel
    {
        public UploadModel(string t, string u, string d, string g)
        {
            title = t;
            url = u;
            description = d;
            genre = g;
        }
        public string title { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public string genre { get; set; }
    }
}