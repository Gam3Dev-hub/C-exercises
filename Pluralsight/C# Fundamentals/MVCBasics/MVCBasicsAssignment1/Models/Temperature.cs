using System.ComponentModel.DataAnnotations;

namespace MVCBasicsAssignment1.Models
{
    public class Temperature
    {
        [Required(ErrorMessage = "Please enter a temperature in Celsius.")]
        public double Celsius { get; set; }

        [Display(Name = "Fahrenheit")]
        public double fahrenheit => (Celsius * 9 / 5) + 32;
        public double Kelvin => Celsius + 273.15;
        public static string CheckFever(double celsius)
        {
            string message = celsius switch
            {
                37.0 => "Normal body temperature.",
                >= 38.0 => "Fever detected.",
                < 36.0 and > 35.0 => "Temperature is below normal.",
                <= 35.0 => "Hypothermia detected.",
                _ => "Invalid input."
            };
            return message;
        }
    }
}

            
