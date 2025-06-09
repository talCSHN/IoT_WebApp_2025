using System.ComponentModel.DataAnnotations;

namespace WebApiApp03.Models
{
    public class iot_datas
    {
        [Key]
        public int id { get; set; }
        [Required]
        public DateTime sensing_Dt { get; set; }
        [Required]
        public string loc_Id { get; set; }
        public float temp { get; set; }
        public float humid { get; set; }
    }
}
