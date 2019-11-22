using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace K9TB
{
    public class Dog : Object
    {
		public string RegName { get; set; }
        public string CallName { get; set; }
		[DisplayName("Owner(s)")]
        public List<Person> OwnerList { get; set; }
		public Breeder Breeder { get; set; }
        public string Breed { get; set; }
		public string Coat { get; set; }
		public string Color { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
		public string Pedigree { get; set; }
        public int? SireId { get; set; }
		public Dog Sire { get; set; }
        public int? DamId { get; set; }
		public Dog Dam { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
		public bool Altered { get; set; }
		[DisplayName("AKC Registration")]
        public string AKCReg { get; set; }
        [DisplayName("CKC Registration")]
        public string CKCReg { get; set; }
        [DisplayName("UKC Registration")]
        public string UKCReg { get; set; }
        [DisplayName("Rally Jump Height")]
        public float RallyJumpHeight { get; set; }
        [DisplayName("Obedience Jump Height")]
        public float ObedienceJumpHeight { get; set; }
        [DisplayName("Agility Jump Height")]
        public float AgilityJumpHeight { get; set; }
        [DisplayName("Titles")]
        public List<Title> TitleList { get; set; }
		[DisplayName("Media")]
        public List<MediaItem> MediaList { get; set; }

        public Dog()
        {
            OwnerList = new List<Person>();
            TitleList = new List<Title>();
            MediaList = new List<MediaItem>();
        }

        public TimeSpan Age()
        {
            return DateTime.Now - DateOfBirth;
        }

        /// <summary>
        /// Check if the dog has the requested title already
        /// </summary>
        /// <param name="titleName"></param>
        /// <returns></returns>
        public bool HasTitle(string titleName)
        {
            return QualifiesForTitle(titleName);
        }

        /// <summary>
        /// Check if the dog qualifies for the requested title
        /// </summary>
        /// <param name="titleName"></param>
        /// <returns></returns>
        public bool QualifiesForTitle(string titleName)
        {
            // REVIEW: Should we affirm all the dog's qualifying legs have been assessed and the title list is current?
            return null == TitleList.FirstOrDefault(t => t.Name == titleName);
        }

        /// <summary>
        /// Adds a leg to the dog's record and updates its titles
        /// </summary>
        /// <returns>The ID of the new leg</returns>
        public List<Title> AddLeg(Run qualifyingRun)
        {
            // TODO: Add the run provided as a new leg for the dog

            List<Title> newTitles = new List<Title>();
            
            // REVIEW: Create an Azure Function which accepts the dog and the run and updates the database as well as the dog's title list
            //   and returns the updated title list
            
            // Compare the new list to the existing list and return the delta as new titles this leg qualifies the dog for

            // TODO: Update the dog's title list locally

            return newTitles;
        }
    }
}
