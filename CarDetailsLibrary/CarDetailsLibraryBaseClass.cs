using System;
using System.Collections.Generic;
using System.Text;

namespace CarDetailsLibrary
{
    
        abstract class CarDetailsLibraryBaseClass
        { 
            public string CompanyName { get; set; }
            public string ModelName { get; set; }
            protected int _Counts = 0;
            public abstract void Count();
            public abstract int Counts { get; }
    }
    }

