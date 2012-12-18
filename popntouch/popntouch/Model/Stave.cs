using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace popntouch.Model
{
    class Stave
    {
        #region Properties

        public InstrumentType _currentInstrument { get; set; }
        public int _maxNote { get; set; }
        public int _nbNoteChord { get; set; }
        public List<Note> _notes { get; set; }
        public List<Instrument> _instruments { get; set; }

        #endregion // Properties
        
        #region Constructors
        #endregion // Constructors

        #region Methods
        #endregion //Methods
    }
}
