using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace K9TB
{
    /// <summary>
    /// Base class for all FMX objects exposing and managing common features such as a unique ID, edition support and tag management
    /// </summary>
    public abstract class Object
    {
        /// <summary>
        /// A string containing the unique ID
        /// </summary>
        public int ID { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// The edition as an int
        /// </summary>
        public Int64 Edition { get; set; }

        /// <summary>
        /// Time the object was created in universal time
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Created { get; set; }

        /// <summary>
        /// A list of tags as strings
        /// </summary>
        public ICollection<string> Tags;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Object()
        {
            this.ID = 0;
            this.Edition = 1;
            this.Created = DateTime.UtcNow;
            this.Tags = new List<string>();
            return;
        }

        /// <summary>
        /// Adds the given tag to the object's tag list
        /// </summary>
        /// <param name="newTag">A string containing the new tag</param>
        public void addTag(string newTag)
        {
            this.Tags.Add(newTag);
            return;
        }

        /// <summary>
        /// Checks if the object has the tag in question
        /// </summary>
        /// <param name="searchTag">A string containing the tag to check for</param>
        /// <returns>true if the tag is in the object's tag list</returns>
        public bool hasTag(string searchTag)
        {
            // Check if this object has the requested tag
            return this.Tags.Contains(searchTag);
        }

        /// <summary>
        /// Increments the object's edition by one
        /// </summary>
        /// <returns>The new edition as an int</returns>
        public Int64 incrementEdition()
        {
            if (this.Edition >= Int64.MaxValue)
            {
                throw new Exception(string.Format("Edition incremented out of range ({0:d}).", Int64.MaxValue));
            }

            return ++this.Edition;
        }
    }
}
