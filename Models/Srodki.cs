using System.ComponentModel.DataAnnotations;
using System;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Srodki
    {
        public int Id { get; set; }
        public string Rodzaj_srodka { get; set; }
        public string Producent { get; set; }
        public int Cena { get; set; }
        [DataType(DataType.Date)]
        public DateTime Data_waznosci { get; set; }
        public int Pojemnosc { get; set; }
    }
}
