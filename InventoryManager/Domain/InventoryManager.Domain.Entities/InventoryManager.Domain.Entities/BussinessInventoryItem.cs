﻿
namespace InventoryManager.Domain.Entities
{
    /// <summary>
    /// The BussinessInventoryItem class
    /// </summary>
    public class BussinessInventoryItem : InventoryItem
    {
        /// <summary>
        /// The Identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The Expiration Date.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// The Type.
        /// </summary>
        public int Type { get; set; }
    }
}