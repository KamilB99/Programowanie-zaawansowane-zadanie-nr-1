using System.ComponentModel.DataAnnotations;
using System;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Meble
    {
        public int Id { get; set; }
        public string Material_wykonania { get; set; }
        public int Waga { get; set; }
        public string Kolor { get; set; }
        public string Rodzaj_mebla { get; set; }
        public int Cena { get; set; }
    }
}
