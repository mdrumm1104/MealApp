
namespace MealApp
{
    partial class MealForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.getMealsButton = new System.Windows.Forms.Button();
            this.proteinCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.mealNameTextBox = new System.Windows.Forms.TextBox();
            this.mealNameLabel = new System.Windows.Forms.Label();
            this.healthyRatingUpDown = new System.Windows.Forms.NumericUpDown();
            this.healthyRatingLabel = new System.Windows.Forms.Label();
            this.kidApprovedCheckBox = new System.Windows.Forms.CheckBox();
            this.familyFavoriteCheckBox = new System.Windows.Forms.CheckBox();
            this.lastMadeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastMadeDateLabel = new System.Windows.Forms.Label();
            this.proteinListLabel = new System.Windows.Forms.Label();
            this.addProteinTextBox = new System.Windows.Forms.TextBox();
            this.addProteinLabel = new System.Windows.Forms.Label();
            this.addProteinButton = new System.Windows.Forms.Button();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.healthyRatingUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // getMealsButton
            // 
            this.getMealsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.getMealsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getMealsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.getMealsButton.Location = new System.Drawing.Point(640, 396);
            this.getMealsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getMealsButton.Name = "getMealsButton";
            this.getMealsButton.Size = new System.Drawing.Size(148, 42);
            this.getMealsButton.TabIndex = 8;
            this.getMealsButton.Text = "Add Meal";
            this.getMealsButton.UseVisualStyleBackColor = true;
            this.getMealsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button1_Paint);
            // 
            // proteinCheckedListBox
            // 
            this.proteinCheckedListBox.CheckOnClick = true;
            this.proteinCheckedListBox.FormattingEnabled = true;
            this.proteinCheckedListBox.Location = new System.Drawing.Point(12, 132);
            this.proteinCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proteinCheckedListBox.Name = "proteinCheckedListBox";
            this.proteinCheckedListBox.Size = new System.Drawing.Size(135, 174);
            this.proteinCheckedListBox.TabIndex = 0;
            this.proteinCheckedListBox.TabStop = false;
            // 
            // mealNameTextBox
            // 
            this.mealNameTextBox.Location = new System.Drawing.Point(12, 30);
            this.mealNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mealNameTextBox.Name = "mealNameTextBox";
            this.mealNameTextBox.Size = new System.Drawing.Size(147, 22);
            this.mealNameTextBox.TabIndex = 1;
            // 
            // mealNameLabel
            // 
            this.mealNameLabel.AutoSize = true;
            this.mealNameLabel.Location = new System.Drawing.Point(12, 9);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(79, 17);
            this.mealNameLabel.TabIndex = 3;
            this.mealNameLabel.Text = "Meal Name";
            // 
            // healthyRatingUpDown
            // 
            this.healthyRatingUpDown.Location = new System.Drawing.Point(197, 30);
            this.healthyRatingUpDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.healthyRatingUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.healthyRatingUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.healthyRatingUpDown.Name = "healthyRatingUpDown";
            this.healthyRatingUpDown.ReadOnly = true;
            this.healthyRatingUpDown.Size = new System.Drawing.Size(120, 22);
            this.healthyRatingUpDown.TabIndex = 2;
            this.healthyRatingUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // healthyRatingLabel
            // 
            this.healthyRatingLabel.AutoSize = true;
            this.healthyRatingLabel.Location = new System.Drawing.Point(197, 9);
            this.healthyRatingLabel.Name = "healthyRatingLabel";
            this.healthyRatingLabel.Size = new System.Drawing.Size(101, 17);
            this.healthyRatingLabel.TabIndex = 5;
            this.healthyRatingLabel.Text = "Healthy Rating";
            // 
            // kidApprovedCheckBox
            // 
            this.kidApprovedCheckBox.AutoSize = true;
            this.kidApprovedCheckBox.Location = new System.Drawing.Point(348, 30);
            this.kidApprovedCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kidApprovedCheckBox.Name = "kidApprovedCheckBox";
            this.kidApprovedCheckBox.Size = new System.Drawing.Size(115, 21);
            this.kidApprovedCheckBox.TabIndex = 3;
            this.kidApprovedCheckBox.Text = "Kid Approved";
            this.kidApprovedCheckBox.UseVisualStyleBackColor = true;
            // 
            // familyFavoriteCheckBox
            // 
            this.familyFavoriteCheckBox.AutoSize = true;
            this.familyFavoriteCheckBox.Location = new System.Drawing.Point(503, 30);
            this.familyFavoriteCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.familyFavoriteCheckBox.Name = "familyFavoriteCheckBox";
            this.familyFavoriteCheckBox.Size = new System.Drawing.Size(125, 21);
            this.familyFavoriteCheckBox.TabIndex = 4;
            this.familyFavoriteCheckBox.Text = "Family Favorite";
            this.familyFavoriteCheckBox.UseVisualStyleBackColor = true;
            // 
            // lastMadeDateTimePicker
            // 
            this.lastMadeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lastMadeDateTimePicker.Location = new System.Drawing.Point(197, 132);
            this.lastMadeDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastMadeDateTimePicker.Name = "lastMadeDateTimePicker";
            this.lastMadeDateTimePicker.Size = new System.Drawing.Size(120, 22);
            this.lastMadeDateTimePicker.TabIndex = 5;
            this.lastMadeDateTimePicker.Value = new System.DateTime(2021, 8, 3, 0, 0, 0, 0);
            // 
            // lastMadeDateLabel
            // 
            this.lastMadeDateLabel.AutoSize = true;
            this.lastMadeDateLabel.Location = new System.Drawing.Point(197, 106);
            this.lastMadeDateLabel.Name = "lastMadeDateLabel";
            this.lastMadeDateLabel.Size = new System.Drawing.Size(74, 17);
            this.lastMadeDateLabel.TabIndex = 9;
            this.lastMadeDateLabel.Text = "Last Made";
            // 
            // proteinListLabel
            // 
            this.proteinListLabel.AutoSize = true;
            this.proteinListLabel.Location = new System.Drawing.Point(9, 106);
            this.proteinListLabel.Name = "proteinListLabel";
            this.proteinListLabel.Size = new System.Drawing.Size(79, 17);
            this.proteinListLabel.TabIndex = 10;
            this.proteinListLabel.Text = "Protein List";
            // 
            // addProteinTextBox
            // 
            this.addProteinTextBox.Location = new System.Drawing.Point(197, 219);
            this.addProteinTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addProteinTextBox.Name = "addProteinTextBox";
            this.addProteinTextBox.Size = new System.Drawing.Size(132, 22);
            this.addProteinTextBox.TabIndex = 6;
            // 
            // addProteinLabel
            // 
            this.addProteinLabel.AutoSize = true;
            this.addProteinLabel.Location = new System.Drawing.Point(197, 199);
            this.addProteinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProteinLabel.Name = "addProteinLabel";
            this.addProteinLabel.Size = new System.Drawing.Size(124, 17);
            this.addProteinLabel.TabIndex = 12;
            this.addProteinLabel.Text = "Add Protein to List";
            // 
            // addProteinButton
            // 
            this.addProteinButton.Location = new System.Drawing.Point(339, 219);
            this.addProteinButton.Margin = new System.Windows.Forms.Padding(4);
            this.addProteinButton.Name = "addProteinButton";
            this.addProteinButton.Size = new System.Drawing.Size(99, 25);
            this.addProteinButton.TabIndex = 7;
            this.addProteinButton.Text = "Add Protein";
            this.addProteinButton.UseVisualStyleBackColor = true;
            this.addProteinButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button1_Paint);
            this.addProteinButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddProteinButton_MouseClick);
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearFieldsButton.Location = new System.Drawing.Point(12, 396);
            this.clearFieldsButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(136, 41);
            this.clearFieldsButton.TabIndex = 13;
            this.clearFieldsButton.Text = "Clear Fields";
            this.clearFieldsButton.UseVisualStyleBackColor = true;
            this.clearFieldsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button1_Paint);
            this.clearFieldsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearFieldsButton_MouseClick);
            // 
            // MealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearFieldsButton);
            this.Controls.Add(this.addProteinButton);
            this.Controls.Add(this.addProteinLabel);
            this.Controls.Add(this.addProteinTextBox);
            this.Controls.Add(this.proteinListLabel);
            this.Controls.Add(this.lastMadeDateLabel);
            this.Controls.Add(this.lastMadeDateTimePicker);
            this.Controls.Add(this.familyFavoriteCheckBox);
            this.Controls.Add(this.kidApprovedCheckBox);
            this.Controls.Add(this.healthyRatingLabel);
            this.Controls.Add(this.healthyRatingUpDown);
            this.Controls.Add(this.mealNameLabel);
            this.Controls.Add(this.mealNameTextBox);
            this.Controls.Add(this.proteinCheckedListBox);
            this.Controls.Add(this.getMealsButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MealForm";
            this.Text = "Drummond Meals";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.MealForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.healthyRatingUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getMealsButton;
        private System.Windows.Forms.CheckedListBox proteinCheckedListBox;
        private System.Windows.Forms.TextBox mealNameTextBox;
        private System.Windows.Forms.Label mealNameLabel;
        private System.Windows.Forms.NumericUpDown healthyRatingUpDown;
        private System.Windows.Forms.Label healthyRatingLabel;
        private System.Windows.Forms.CheckBox kidApprovedCheckBox;
        private System.Windows.Forms.CheckBox familyFavoriteCheckBox;
        private System.Windows.Forms.DateTimePicker lastMadeDateTimePicker;
        private System.Windows.Forms.Label lastMadeDateLabel;
        private System.Windows.Forms.Label proteinListLabel;
        private System.Windows.Forms.TextBox addProteinTextBox;
        private System.Windows.Forms.Label addProteinLabel;
        private System.Windows.Forms.Button addProteinButton;
        private System.Windows.Forms.Button clearFieldsButton;
    }
}

