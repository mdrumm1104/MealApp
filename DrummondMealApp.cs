using System;
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

        private void AddProteinButton_MouseClick(object sender, MouseEventArgs e)
        {
            if(addProteinTextBox.TextLength == 0)
            {
                MessageBox.Show("You must enter a protein!");
                addProteinTextBox.Focus();
            }
            else
            {
                if (ValidateNewProtein())
                {
                    proteinCheckedListBox.Items.Insert(0, addProteinTextBox.Text);
                }

                addProteinTextBox.Clear();
                addProteinTextBox.Focus();
            }

        }

        private Boolean ValidateNewProtein()
        {
            Boolean isValid = true;

            for(int i=0; i < proteinCheckedListBox.Items.Count; i++)
            {
                if (addProteinTextBox.Text.Equals((string)proteinCheckedListBox.Items[i], StringComparison.OrdinalIgnoreCase))
                {
                    isValid = false;
                    MessageBox.Show("You Entered a Protein Already in the List!");
                    break;
                }
            }

            return isValid;
        }

        private void ClearFieldsButton_MouseClick(object sender, MouseEventArgs e)
        {
            List<Control> allControls = GetAllControls(this, new List<Control>());
            ClearControls(allControls);
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
                    }
                }

                if(c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
            }
        }
    }
}
