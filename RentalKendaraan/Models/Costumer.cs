using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace RentalKendaraan.Models
{
    public partial class Costumer
    {
        public int IdCostumer { get; set; }

        [Required(ErrorMessage ="Nama Costumer Tidak Boleh Kosong")]
        public string NamaCostumer { get; set; }

        [RegularExpression("^[0-9]*$", ErrorMessage ="Hanya Boleh Diisi Angka")]
        public string Nik { get; set; }

        public string Alamat { get; set; }

        [MinLength(10, ErrorMessage ="NO HP Minimal 10 Angka")]
        [MaxLength(13, ErrorMessage = "NO HP Maksimal 13 Angka")]
        public string NoHp { get; set; }

        public int? IdGender { get; set; }
    }
}
