using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_Library.Models.Entity;

namespace MVC_Library.Models.Classes
{
    public class Class1
    {
        public IEnumerable<TblBook> Books { get; set; }
        public IEnumerable<TblAbout> Abouts { get; set; }
    }
}