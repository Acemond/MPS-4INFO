using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace popntouch.Model
{
    class NoteBubbleGenerator
    {
        #region Properties

        public List<NoteBubble> _noteBubbles { get; set; }

        #endregion // Properties
        
        #region Constructors

        public NoteBubbleGenerator()
        {
            _noteBubbles = new List<NoteBubble>();
        }

        #endregion // Constructors

        #region Methods

        public void createNoteBubble()
        {
            Random r = new Random();
            // Number of gestures defined
            int total = Enum.GetValues(typeof(NoteValue)).Length;
            _noteBubbles.Add(new NoteBubble());
        }

        /* Code à fusioner avec createNoteBubble()
         * 
         * 
         * private int nextBulle()
        {
            int[] type = { 0, 0, 0 };

            if (bubbles != null)
            {
                foreach (Bubble bubble in bubbles)
                {
                    type[bubble.id]++;
                }
            }
            List<int> mins = minimum_array(type);

            Random r = new Random();
            return mins[r.Next(mins.Count)];
        }

        private List<int> minimum_array(int[] types)
        {
            List<int> res = new List<int>(3);
            int min = types.Min();
            int i = 0;

            foreach (int a in types)
            {
                if (a == min)
                    res.Add(i);
                i++;
            }

            return res;
        }
         * /


        public void removeFromGenerator(NoteBubble b)
        {
            NoteBubble bubble = _noteBubbles.Find(e => e == b);
            _noteBubbles.Remove(bubble);
        }

        #endregion //Methods
    }
}
