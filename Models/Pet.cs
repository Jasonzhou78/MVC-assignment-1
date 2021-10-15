using System;
using System.ComponentModel.DataAnnotations;

namespace FindPet.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Type { get; set; }

        [DataType(DataType.Date)]
        public DateTime ArrivedDate { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public Boolean Vacine { get; set; }
    }
}
