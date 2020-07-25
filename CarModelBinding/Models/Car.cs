using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarModelBinding.Models
{
    public class Car
    {
        public int CarId { get; set; }
        /// <summary>
        /// Make of the vehicle
        /// </summary>
        [Required]
        public string Make { get; set; }
        /// <summary>
        /// Model of the Vehicle
        /// </summary>
        [Required]
        public string Model { get; set; }
        /// <summary>
        /// When production starts
        /// </summary>
        [DataType(DataType.Date)]
        [Required]
        public DateTime Year { get; set; }
        /// <summary>
        /// Engine of the Vehicle 
        /// </summary>
        [Required]
        public string Engine { get; set; }
        /// <summary>
        /// Interior and Exterior Trim for the Vehicle
        /// </summary>
        [Required]
        public string Trim { get; set; }
    }
}
