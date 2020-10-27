﻿namespace Eraware.Modules.LanaguageTroubleshooter.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Eraware.Modules.LanaguageTroubleshooter.Common;

    /// <summary>
    /// Represents an item entity.
    /// </summary>
    [Table(Globals.ModulePrefix + "Items")]
    public class Item : IEntity
    {
        /// <summary>
        /// Gets or sets the item id.
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the item name.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the item description.
        /// </summary>
        [StringLength(250)]
        public string Description { get; set; }
    }
}