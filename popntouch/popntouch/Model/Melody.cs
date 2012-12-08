using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace popntouch.Model
{
    class Melody
    {
        #region Constructors

        public Melody(List<Note> list)
        {
            notes = list;
        }

        #endregion // Constructors

        #region Properties

        public List<Note> notes
        {
            get;
            set;
        }

        public Gesture symbol
        {
            get;
            set;
        }

        #endregion // Properties

        #region Methods
        #endregion //Methods
    }
}
