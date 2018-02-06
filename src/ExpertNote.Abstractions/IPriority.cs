using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertNote.Abstractions
{
    /// <summary>
    /// The combination of these elements result in an overall priority
    /// </summary>
    public interface IPriority
    {
        /// <summary>
        /// How important this is, in the long term.  
        /// </summary>
        int Importance { get; }

        /// <summary>
        /// How urgent this is, in the short term
        /// </summary>
        int Urgency { get; }

        /// <summary>
        /// How far we've progressed into our task
        /// </summary>
        int Stage { get; }

        DateTime? Due { get; }
    }
}
