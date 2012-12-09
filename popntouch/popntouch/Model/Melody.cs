using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace popntouch.Model
{
    class Melody
    {
        #region Properties
            public List<Note> notes { get; set; }
            public Gesture symbol { get; set; }
        #endregion 

        #region Constructors

        public Melody( Gesture g, List<Note> list)
        {
            notes = list;
            symbol = g;
        }

        #endregion // Constructors


        #region Methods
        #endregion //Methods
    }
}