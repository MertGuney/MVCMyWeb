using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MJG.Models.Entity;

namespace MJG.Models.IEClass
{
    public class Class1
    {

        public IEnumerable<tblHakkimda> Deger1 { get; set; }
        public IEnumerable<tblHizmetler> Deger2 { get; set; }
        public IEnumerable<tblDeneyim> Deger3 { get; set; }
    }
}