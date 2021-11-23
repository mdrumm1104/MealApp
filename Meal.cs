using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealApp
{
    public class Meal
    {
        private String mealName;
        private Boolean kidApproved, familyFavorite;
        private int healthyRating;
        private List<String> proteinList = new List<String>();
        private List<String> mealTypeList = new List<String>();
        private DateTime lastMadeDateTime;

        public Meal(String mealName, Boolean kidApproved, Boolean familyFavorite, int healthyRating, List<String> proteinList, List<String> mealTypeList, DateTime lastMadeDateTime)
        {
            this.mealName = mealName;
            this.kidApproved = kidApproved;
            this.familyFavorite = familyFavorite;
            this.healthyRating = healthyRating;
            this.proteinList = proteinList;
            this.lastMadeDateTime = lastMadeDateTime;
            this.mealTypeList = mealTypeList;
        }

        public String MealName => mealName;
        public Boolean KidApproved => kidApproved;
        public Boolean FamilyFavorite => familyFavorite;
        public int HealthyRating => healthyRating;
        public List<String> ProteinList => proteinList;
        public List<String> MealTypeList => mealTypeList;
        public DateTime LastMadeDateTime => lastMadeDateTime;


    }
}
