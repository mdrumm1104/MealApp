using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealApp
{
    public partial class MealForm : Form
    {
        public MealForm()
        {
            InitializeComponent();
            lastMadeDateTimePicker.Value = DateTime.Now;
        }

        private void Button1_Paint(object sender, PaintEventArgs e)
        {
            Button myButton = (Button)sender;
            Rectangle borderRectangle = myButton.ClientRectangle;
            ControlPaint.DrawBorder3D(e.Graphics, borderRectangle,
                    Border3DStyle.Raised);
        }

        private void MealForm_Load(object sender, EventArgs e)
        {
            InitializeProteinList();
            InitializeMealTypeList();
        }

        private void InitializeProteinList()
        {
            DatabaseConnector sqlConnection = new DatabaseConnector();
            List<string> proteinList;
            string proteinQuery = "Select p.protein_name from protein p "+
                                  "where p.protein_name != 'No Protein' "+
                                  "order by p.protein_name";
            proteinList = sqlConnection.ExecuteQuery(proteinQuery);


            foreach (string p in proteinList)
            {
                proteinCheckedListBox.Items.Add(p);
            }


        }

        private void InitializeMealTypeList()
        {
            DatabaseConnector sqlConnection = new DatabaseConnector();
            List<string> mealTypeList;
            string mealTypeQuery = "Select mt.meal_type_name from meal_type mt " +
                                   "order by mt.meal_type_name";
            mealTypeList = sqlConnection.ExecuteQuery(mealTypeQuery);

            foreach(string m in mealTypeList)
            {
                mealTypeCheckedListBox.Items.Add(m);
            }
        }

        private void ValidateNewProtein()
        {
            Boolean isValid = true;

            if (addProteinTextBox.TextLength == 0)
            {
                MessageBox.Show("You must enter a protein!");
                addProteinTextBox.Focus();
                return;
            }

            for (int i=0; i < proteinCheckedListBox.Items.Count; i++)
            {
                if (addProteinTextBox.Text.Equals((string)proteinCheckedListBox.Items[i], StringComparison.OrdinalIgnoreCase))
                {
                    isValid = false;
                    MessageBox.Show("You Entered a Protein Already in the List!");
                    break;
                }
            }

            if (isValid)
            {
                proteinCheckedListBox.Items.Insert(0, addProteinTextBox.Text);
                proteinCheckedListBox.SetItemChecked(0, true);
            }
                
            addProteinTextBox.Clear();
            addProteinTextBox.Focus();

        }

        private void ValidateNewMealType()
        {
            Boolean isValid = true;

            if (mealTypeTextBox.TextLength == 0)
            {
                MessageBox.Show("You must enter a meal type!");
                mealTypeTextBox.Focus();
                return;
            }

            for (int i = 0; i < mealTypeCheckedListBox.Items.Count; i++)
            {
                if (mealTypeTextBox.Text.Equals((string)mealTypeCheckedListBox.Items[i], StringComparison.OrdinalIgnoreCase))
                {
                    isValid = false;
                    MessageBox.Show("You Entered a Meal Type Already in the List!");
                    break;
                }
            }
            if (isValid)
            {
                mealTypeCheckedListBox.Items.Insert(0, mealTypeTextBox.Text);
                mealTypeCheckedListBox.SetItemChecked(0, true);
            }
                

            mealTypeTextBox.Clear();
            mealTypeTextBox.Focus();


        }

        
        private void ClearFields()
        {
            List<Control> allControls = GetAllControls(this, new List<Control>());
            ClearControls(allControls);
        }
        private void ClearFieldsButton_MouseClick(object sender, MouseEventArgs e)
        {
            ClearFields();
            mealNameTextBox.Focus();
        }

        private List<Control> GetAllControls(Control control, List<Control> list)
        {
            foreach(Control c in control.Controls)
            {
                list.Add(c);
                if(!(c is NumericUpDown) && c.Controls.Count > 0)
                {
                    list = GetAllControls(c, list);
                }
            }
            return list;
        }

        private void ClearControls(List<Control> list)
        {
            foreach(Control c in list)
            {
                
                if(c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                
                if(c is CheckedListBox)
                {
                    for(int i = 0; i < ((CheckedListBox)c).Items.Count; i++)
                    {
                        ((CheckedListBox)c).SetItemCheckState(i, CheckState.Unchecked);
                        ((CheckedListBox)c).SetSelected(i, false);
                    }
                }

                if(c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }

                if(c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now;
                }

                if(c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = ((NumericUpDown)c).Minimum;
                }
            }
        }


        private void AddToListMouseClick(object sender, MouseEventArgs e)
        {
            if (sender.Equals(addMealTypeButton))
                ValidateNewMealType();
            else
                ValidateNewProtein();
        }

        private void AddToList_EnterPressed(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(sender == addMealTypeButton || sender == mealTypeTextBox)
                {
                    ValidateNewMealType();
                }
                else if(sender == addProteinButton || sender == addProteinTextBox)
                {
                    ValidateNewProtein();
                }
              
            }
        }

        private void ClearFields_EnterPressed(object sender, KeyEventArgs e)
        
        {
            if(e.KeyCode == Keys.Enter)
            {
                List<Control> allControls = GetAllControls(this, new List<Control>());
                ClearControls(allControls);
                mealNameTextBox.Focus();
            }
        }

        private void deleteProteinFromList_Click(object sender, EventArgs e)
        {
            int selectedProteinIndex = proteinCheckedListBox.SelectedIndex;
            if(selectedProteinIndex > -1)
                proteinCheckedListBox.Items.RemoveAt(selectedProteinIndex);
        }

        private void deleteMealTypeFromList_Click(object sender, EventArgs e)
        {
            int selectedMealTypeIndex = mealTypeCheckedListBox.SelectedIndex;
            if (selectedMealTypeIndex > -1)
                mealTypeCheckedListBox.Items.RemoveAt(selectedMealTypeIndex);
        }

        private void addMealButton_Click(object sender, MouseEventArgs e)
        {
            createNewMeal();            
        }

        private void createNewMeal()
        {
            
            if(mealNameTextBox.TextLength == 0)
            {
                MessageBox.Show("You Must Enter a Meal Name!");
                mealNameTextBox.Focus();
                return;
            }
            List<string> proteinList = new List<string>();
            List<string> mealTypeList = new List<string>();

            foreach(object item in proteinCheckedListBox.CheckedItems)
            {
                proteinList.Add((string)item);
            }

            foreach(object item in mealTypeCheckedListBox.CheckedItems)
            {
                mealTypeList.Add((string)item);
            }
            Meal newMeal = new Meal(mealNameTextBox.Text, kidApprovedCheckBox.Checked, familyFavoriteCheckBox.Checked, (int)healthyRatingUpDown.Value, proteinList, mealTypeList, lastMadeDateTimePicker.Value);
            MealCreationHandler createMeal = new MealCreationHandler(newMeal);

            if (!createMeal.PrepareMealForInsertion())
            {
                mealNameTextBox.Clear();
                mealNameTextBox.Focus();
            }
            else
            {
                createMeal.InsertNewMeal();
                ClearFields();
                mealNameTextBox.Focus();
            }
                

        }
    }
}
