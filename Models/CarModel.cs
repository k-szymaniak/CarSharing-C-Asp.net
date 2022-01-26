using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace CarRent.Models
{
    [Table("Cars")]
    public class CarModel
    {
        [Key]
        public int CarId { get; set; }
        [Required (ErrorMessage = "Required field")]
        public string CarMark { get; set; }
        [Required(ErrorMessage = "Required field")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Required field")]

        public double Power { get; set; }
        [Required(ErrorMessage = "Required field")]

        public string FuelType { get; set; }
        [Required(ErrorMessage = "Required field")]
        public double Price { get; set; }
        [Required(ErrorMessage = "Required field")]
        public double CategoryId { get; set; }
        [Required(ErrorMessage = "Required field")]
        public double Mileage { get; set; }
        [Required(ErrorMessage = "Required field")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Required field")]
        public bool Availability { get; set; }

    }



}
