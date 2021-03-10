using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RssReader.Models
{
    public class ImgItem
    {
            public DateTimeOffset Created_At { get; set; }
            public string Description { get; set; }
            public Urls Urls { get; set; }
    }
}