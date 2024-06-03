using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capstone_23_Proteine.Models.Domain
{
    public class FoodIntake
    {
        public Guid ID { get; set; }
        public int Protein { get; set; }
        public int Calories { get; set; }
        public int Fat { get; set; }
        public string MealType { get; set; }
        public string MealName { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; } // Foreign key to IdentityUser

        // Navigation property to the associated IdentityUser
        public IdentityUser User { get; set; }
    }

    public class FoodDisplay
    {
        public Guid Id { get; set; }
        [Column("Protien")]
        public int proteinDisplay { get; set; }
        [Column("Calories")]
        public int caloriesDisplay { get; set; }
        [Column("Fat")]
        public int fatDisplay { get; set; }
        [Column("MealName")]
        public string foodDisplay { get; set; }
    }

}