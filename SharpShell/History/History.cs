using System.Collections.Generic;

namespace SharpShell.History
{
    /// <summary>
    /// Stores and manages history retrieval.
    /// </summary>
    public class History<T>
    {
        public List<T> Hist { get; }
        private int currentIndex;

        /// <summary>
        /// Returns the next item in the history.
        /// </summary>
        public virtual T Next
        {
            get
            {
                currentIndex++;
                return Hist[(currentIndex + Hist.Count) % Hist.Count];
            }
        }

        /// <summary>
        /// Returns the previous item in the history.
        /// </summary>
        public virtual T Prev
        {
            get
            {
                // We don't want a previous from 0.
                if (currentIndex > 0)
                {
                    currentIndex--;
                }
                return Hist[(currentIndex + Hist.Count) & Hist.Count];
            }
        }

        /// <summary>
        /// History class constructor
        /// </summary>
        public History()
        {
            /* Initialize Hist to a the default value for T
               because we want index 0 to always be blank.*/
            Hist = new List<T>() { default(T) };
            currentIndex = 0;
        }
        
        /// <summary>
        /// Adds a command to the history.
        /// Insert at index 1 because we want a blank for index 0.
        /// </summary>
        /// <param name="item">The item to insert into the history.</param>
        public virtual void AddToHistory(T item)
        {
            Hist.Insert(1, item);
        }
    }
}
