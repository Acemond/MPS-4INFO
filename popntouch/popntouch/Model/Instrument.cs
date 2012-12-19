using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace popntouch.Model
{
    class Instrument
    {
        #region Properties

        public InstrumentType _name { get; set; }
        public Dictionary<PitchClass, String> _sounds { get; set; }

        #endregion // Properties

        #region Constructors

        //Empty constructor (needed for data template in XAML)
        public Instrument() { }

        #endregion // Constructors

        #region Methods
        #endregion //Methods
    }
}
