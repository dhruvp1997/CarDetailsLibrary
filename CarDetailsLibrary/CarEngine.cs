using System;
using System.Collections.Generic;
using System.Text;

namespace CarDetailsLibrary
{
    class CarEngine : CarDetailsLibraryBaseClass
    {
        public string Engine { get; set; }
        public int TopSpeed { get; set; }
        

        public override void Count()
        {
            _Counts++;
        }

        public override int Counts => _Counts;
    }
}
