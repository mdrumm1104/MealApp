using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealApp
{
    class MealCreationHandler
    {
        Meal meal;
        public MealCreationHandler(Meal meal)
        {
            this.meal = meal;
        }

        public Boolean PrepareMealForInsertion()
        {
            Boolean isValid = true;
            if (CheckMealName())
            {
                MessageBox.Show("Meal name already exists!");
                isValid = false;
                return isValid;
            }

            InsertMissingItems();

            return isValid;
        }

        private Boolean CheckMealName()
        {
            Boolean mealNameAlreadyExists = false;
            string mealNameQuery;

            mealNameQuery = "select count(*) from meal m where upper(m.meal_name) = " + 
                "upper('"+meal.MealName+"')";
            DatabaseConnector sqlQuery = new DatabaseConnector();
            int mealCount = sqlQuery.ExecuteQueryCount(mealNameQuery);

            if (mealCount > 0)
                mealNameAlreadyExists = true;

            return mealNameAlreadyExists;
        }

        private string BuildInClause(List<string> inList)
        {
            string inClauseString = "";

            for(int i=0; i < inList.Count; i++)
            {
                if (i == 0)
                {
                    inClauseString = inClauseString + "('" + inList[i] + "')";
                }
                else
                {
                    inClauseString = inClauseString + ",('" + inList[i] + "')";
                }
            }

            return inClauseString;
        }

        private void InsertMissingItems()
        {
            DatabaseConnector sqlConnection = new DatabaseConnector();

            //Insert missing protein items if any
            if(meal.ProteinList.Count > 0)
            {
                string proteinInClause = BuildInClause(meal.ProteinList);
                string proteinQuery = "select protein_name" + Environment.NewLine +
                        "from (values " + proteinInClause + " ) as t(protein_name)" + Environment.NewLine +
                        "EXCEPT" + Environment.NewLine +
                        "select protein_name" + Environment.NewLine +
                        "from Protein";

                List<string> missingProteinsList = sqlConnection.ExecuteQuery(proteinQuery);

                if (missingProteinsList.Count > 0)
                {
                    string missingProteinValues = BuildInClause(missingProteinsList);
                    string proteinInsertStatement = "Insert INTO Protein" + Environment.NewLine +
                                             "(protein_name)" + Environment.NewLine +
                                             "values(" + missingProteinValues + ")";

                    sqlConnection.ExecuteInsertStatement(proteinInsertStatement);
                }
            }

            //Insert missing meal types if any
            if (meal.MealTypeList.Count > 0)
            {
                string mealTypeInClause = BuildInClause(meal.MealTypeList);
                string mealTypeQuery = "select meal_type_name" + Environment.NewLine +
                        "from (values " + mealTypeInClause + " ) as t(meal_type_name)" + Environment.NewLine +
                        "EXCEPT" + Environment.NewLine +
                        "select meal_type_name" + Environment.NewLine +
                        "from Meal_type";

               List<string> missingMealTypesList = sqlConnection.ExecuteQuery(mealTypeQuery);

                if (missingMealTypesList.Count > 0)
                {
                    string missingMealTypeValues = BuildInClause(missingMealTypesList);
                    string mealTypeInsertStatement = "Insert INTO Meal_Type" + Environment.NewLine +
                                             "(meal_type_name)" + Environment.NewLine +
                                             "values(" + missingMealTypeValues + ")";

                    sqlConnection.ExecuteInsertStatement(mealTypeInsertStatement);
                }
            }
        }

        public void InsertNewMeal()
        {
            string newMealName = meal.MealName;
            Boolean newMealKidApproved = meal.KidApproved;
            Boolean newMealFamilyFavorie = meal.FamilyFavorite;
            DateTime newMealLastMade = meal.LastMadeDateTime;
            int newMealHealthyRating = meal.HealthyRating;
            List<string> newMealProteinList = meal.ProteinList;
            List<string> newMealMealTypeList = meal.MealTypeList;

            string mealInsertStatement = "Insert INTO meal " + Environment.NewLine
                                        + "(meal_name,last_made_dt_tm,kid_approved_ind,favorite_ind,healthy_rating)" + Environment.NewLine
                                        + "values(@mealName,@lastMadeDtTm,@kidApproved,@favorite,@healthyRating)";

            DatabaseConnector conn = new DatabaseConnector();
            conn.ExecuteParameterizedMealInset(mealInsertStatement, meal);

            foreach(string protein in newMealProteinList)
            {
                string newMealProteinInsert = "Insert INTO meal_protein_reltn " + Environment.NewLine
                                              + "(meal_id, protein_id)" + Environment.NewLine
                                              + "select m.meal_id, p.protein_id" + Environment.NewLine
                                              + "from meal m, protein p" + Environment.NewLine
                                              + "where m.meal_name = '" + meal.MealName + "'" + Environment.NewLine
                                              + "and p.protein_name = '" + protein + "'";

                conn.ExecuteInsertStatement(newMealProteinInsert);
            }

            foreach(string mealType in newMealMealTypeList)
            {
                string newMealMealTypeInsert = "Insert INTO meal_type_reltn" + Environment.NewLine
                                               + "(meal_id, meal_type_id)" + Environment.NewLine
                                               + "select m.meal_id, mt.meal_type_id" + Environment.NewLine
                                               + "from meal m, meal_type mt" + Environment.NewLine
                                               + "where m.meal_name = '" + meal.MealName + "'" + Environment.NewLine
                                               + "and mt.meal_type_name = '" + mealType + "'";

                conn.ExecuteInsertStatement(newMealMealTypeInsert);
            }
        }
    }
}
