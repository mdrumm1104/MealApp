
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealForm));
            this.getMealsButton = new System.Windows.Forms.Button();
            this.proteinCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.proteinListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteProteinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mealTypeLabel = new System.Windows.Forms.Label();
            this.mealTypeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.mealTypeListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleterMealTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMealTypeLabel = new System.Windows.Forms.Label();
            this.mealTypeTextBox = new System.Windows.Forms.TextBox();
            this.addMealTypeButton = new System.Windows.Forms.Button();
            this.proteinListContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthyRatingUpDown)).BeginInit();
            this.mealTypeListContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // getMealsButton
            // 
            this.getMealsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.getMealsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getMealsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.getMealsButton.Location = new System.Drawing.Point(178, 269);
            this.getMealsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.getMealsButton.Name = "getMealsButton";
            this.getMealsButton.Size = new System.Drawing.Size(148, 42);
            this.getMealsButton.TabIndex = 11;
            this.getMealsButton.Text = "Add Meal";
            this.getMealsButton.UseVisualStyleBackColor = true;
            this.getMealsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button1_Paint);
            this.getMealsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addMealButton_Click);
            // 
            // proteinCheckedListBox
            // 
            this.proteinCheckedListBox.CheckOnClick = true;
            this.proteinCheckedListBox.ContextMenuStrip = this.proteinListContextMenuStrip;
            this.proteinCheckedListBox.FormattingEnabled = true;
            this.proteinCheckedListBox.Location = new System.Drawing.Point(177, 30);
            this.proteinCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proteinCheckedListBox.Name = "proteinCheckedListBox";
            this.proteinCheckedListBox.Size = new System.Drawing.Size(135, 174);
            this.proteinCheckedListBox.TabIndex = 0;
            this.proteinCheckedListBox.TabStop = false;
            // 
            // proteinListContextMenuStrip
            // 
            this.proteinListContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.proteinListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteProteinToolStripMenuItem});
            this.proteinListContextMenuStrip.Name = "proteinListContextMenuStrip";
            this.proteinListContextMenuStrip.Size = new System.Drawing.Size(123, 28);
            // 
            // deleteProteinToolStripMenuItem
            // 
            this.deleteProteinToolStripMenuItem.Name = "deleteProteinToolStripMenuItem";
            this.deleteProteinToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteProteinToolStripMenuItem.Text = "Delete";
            this.deleteProteinToolStripMenuItem.Click += new System.EventHandler(this.deleteProteinFromList_Click);
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
            this.mealNameLabel.Location = new System.Drawing.Point(12, 11);
            this.mealNameLabel.Name = "mealNameLabel";
            this.mealNameLabel.Size = new System.Drawing.Size(79, 17);
            this.mealNameLabel.TabIndex = 0;
            this.mealNameLabel.Text = "Meal Name";
            // 
            // healthyRatingUpDown
            // 
            this.healthyRatingUpDown.Location = new System.Drawing.Point(12, 133);
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
            this.healthyRatingUpDown.TabIndex = 3;
            this.healthyRatingUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // healthyRatingLabel
            // 
            this.healthyRatingLabel.AutoSize = true;
            this.healthyRatingLabel.Location = new System.Drawing.Point(12, 114);
            this.healthyRatingLabel.Name = "healthyRatingLabel";
            this.healthyRatingLabel.Size = new System.Drawing.Size(101, 17);
            this.healthyRatingLabel.TabIndex = 0;
            this.healthyRatingLabel.Text = "Healthy Rating";
            // 
            // kidApprovedCheckBox
            // 
            this.kidApprovedCheckBox.AutoSize = true;
            this.kidApprovedCheckBox.Location = new System.Drawing.Point(11, 171);
            this.kidApprovedCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kidApprovedCheckBox.Name = "kidApprovedCheckBox";
            this.kidApprovedCheckBox.Size = new System.Drawing.Size(115, 21);
            this.kidApprovedCheckBox.TabIndex = 4;
            this.kidApprovedCheckBox.Text = "Kid Approved";
            this.kidApprovedCheckBox.UseVisualStyleBackColor = true;
            // 
            // familyFavoriteCheckBox
            // 
            this.familyFavoriteCheckBox.AutoSize = true;
            this.familyFavoriteCheckBox.Location = new System.Drawing.Point(11, 196);
            this.familyFavoriteCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.familyFavoriteCheckBox.Name = "familyFavoriteCheckBox";
            this.familyFavoriteCheckBox.Size = new System.Drawing.Size(125, 21);
            this.familyFavoriteCheckBox.TabIndex = 5;
            this.familyFavoriteCheckBox.Text = "Family Favorite";
            this.familyFavoriteCheckBox.UseVisualStyleBackColor = true;
            // 
            // lastMadeDateTimePicker
            // 
            this.lastMadeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lastMadeDateTimePicker.Location = new System.Drawing.Point(12, 80);
            this.lastMadeDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastMadeDateTimePicker.Name = "lastMadeDateTimePicker";
            this.lastMadeDateTimePicker.Size = new System.Drawing.Size(120, 22);
            this.lastMadeDateTimePicker.TabIndex = 2;
            this.lastMadeDateTimePicker.Value = new System.DateTime(2021, 8, 3, 0, 0, 0, 0);
            // 
            // lastMadeDateLabel
            // 
            this.lastMadeDateLabel.AutoSize = true;
            this.lastMadeDateLabel.Location = new System.Drawing.Point(12, 61);
            this.lastMadeDateLabel.Name = "lastMadeDateLabel";
            this.lastMadeDateLabel.Size = new System.Drawing.Size(74, 17);
            this.lastMadeDateLabel.TabIndex = 0;
            this.lastMadeDateLabel.Text = "Last Made";
            // 
            // proteinListLabel
            // 
            this.proteinListLabel.AutoSize = true;
            this.proteinListLabel.Location = new System.Drawing.Point(175, 9);
            this.proteinListLabel.Name = "proteinListLabel";
            this.proteinListLabel.Size = new System.Drawing.Size(113, 17);
            this.proteinListLabel.TabIndex = 0;
            this.proteinListLabel.Text = "Select Protein(s)";
            // 
            // addProteinTextBox
            // 
            this.addProteinTextBox.Location = new System.Drawing.Point(319, 53);
            this.addProteinTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addProteinTextBox.Name = "addProteinTextBox";
            this.addProteinTextBox.Size = new System.Drawing.Size(132, 22);
            this.addProteinTextBox.TabIndex = 6;
            this.addProteinTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddToList_EnterPressed);
            // 
            // addProteinLabel
            // 
            this.addProteinLabel.AutoSize = true;
            this.addProteinLabel.Location = new System.Drawing.Point(319, 30);
            this.addProteinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProteinLabel.Name = "addProteinLabel";
            this.addProteinLabel.Size = new System.Drawing.Size(124, 17);
            this.addProteinLabel.TabIndex = 0;
            this.addProteinLabel.Text = "Add Protein to List";
            // 
            // addProteinButton
            // 
            this.addProteinButton.Location = new System.Drawing.Point(319, 81);
            this.addProteinButton.Margin = new System.Windows.Forms.Padding(4);
            this.addProteinButton.Name = "addProteinButton";
            this.addProteinButton.Size = new System.Drawing.Size(99, 25);
            this.addProteinButton.TabIndex = 7;
            this.addProteinButton.Text = "Add Protein";
            this.addProteinButton.UseVisualStyleBackColor = true;
            this.addProteinButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button1_Paint);
            this.addProteinButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AddToList_EnterPressed);
            this.addProteinButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddToListMouseClick);
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearFieldsButton.Location = new System.Drawing.Point(11, 269);
            this.clearFieldsButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(136, 41);
            this.clearFieldsButton.TabIndex = 10;
            this.clearFieldsButton.Text = "Clear Fields";
            this.clearFieldsButton.UseVisualStyleBackColor = true;
            this.clearFieldsButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button1_Paint);
            this.clearFieldsButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ClearFields_EnterPressed);
            this.clearFieldsButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearFieldsButton_MouseClick);
            // 
            // mealTypeLabel
            // 
            this.mealTypeLabel.AutoSize = true;
            this.mealTypeLabel.Location = new System.Drawing.Point(473, 9);
            this.mealTypeLabel.Name = "mealTypeLabel";
            this.mealTypeLabel.Size = new System.Drawing.Size(134, 17);
            this.mealTypeLabel.TabIndex = 0;
            this.mealTypeLabel.Text = "Select Meal Type(s)";
            // 
            // mealTypeCheckedListBox
            // 
            this.mealTypeCheckedListBox.CheckOnClick = true;
            this.mealTypeCheckedListBox.ContextMenuStrip = this.mealTypeListContextMenuStrip;
            this.mealTypeCheckedListBox.FormattingEnabled = true;
            this.mealTypeCheckedListBox.Location = new System.Drawing.Point(476, 30);
            this.mealTypeCheckedListBox.Name = "mealTypeCheckedListBox";
            this.mealTypeCheckedListBox.Size = new System.Drawing.Size(131, 174);
            this.mealTypeCheckedListBox.TabIndex = 0;
            this.mealTypeCheckedListBox.TabStop = false;
            // 
            // mealTypeListContextMenuStrip
            // 
            this.mealTypeListContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mealTypeListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleterMealTypeToolStripMenuItem});
            this.mealTypeListContextMenuStrip.Name = "mealTypeListContextMenuStrip";
            this.mealTypeListContextMenuStrip.Size = new System.Drawing.Size(123, 28);
            // 
            // deleterMealTypeToolStripMenuItem
            // 
            this.deleterMealTypeToolStripMenuItem.Name = "deleterMealTypeToolStripMenuItem";
            this.deleterMealTypeToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleterMealTypeToolStripMenuItem.Text = "Delete";
            this.deleterMealTypeToolStripMenuItem.Click += new System.EventHandler(this.deleteMealTypeFromList_Click);
            // 
            // addMealTypeLabel
            // 
            this.addMealTypeLabel.AutoSize = true;
            this.addMealTypeLabel.Location = new System.Drawing.Point(613, 30);
            this.addMealTypeLabel.Name = "addMealTypeLabel";
            this.addMealTypeLabel.Size = new System.Drawing.Size(145, 17);
            this.addMealTypeLabel.TabIndex = 0;
            this.addMealTypeLabel.Text = "Add Meal Type to List";
            // 
            // mealTypeTextBox
            // 
            this.mealTypeTextBox.Location = new System.Drawing.Point(613, 53);
            this.mealTypeTextBox.Name = "mealTypeTextBox";
            this.mealTypeTextBox.Size = new System.Drawing.Size(153, 22);
            this.mealTypeTextBox.TabIndex = 8;
            this.mealTypeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddToList_EnterPressed);
            // 
            // addMealTypeButton
            // 
            this.addMealTypeButton.Location = new System.Drawing.Point(613, 83);
            this.addMealTypeButton.Name = "addMealTypeButton";
            this.addMealTypeButton.Size = new System.Drawing.Size(124, 23);
            this.addMealTypeButton.TabIndex = 9;
            this.addMealTypeButton.Text = "Add Meal Type";
            this.addMealTypeButton.UseVisualStyleBackColor = true;
            this.addMealTypeButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button1_Paint);
            this.addMealTypeButton.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AddToList_EnterPressed);
            this.addMealTypeButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddToListMouseClick);
            // 
            // MealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(832, 361);
            this.Controls.Add(this.addMealTypeButton);
            this.Controls.Add(this.mealTypeTextBox);
            this.Controls.Add(this.addMealTypeLabel);
            this.Controls.Add(this.mealTypeCheckedListBox);
            this.Controls.Add(this.mealTypeLabel);
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
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MealForm";
            this.Text = "Drummond Meal Creator";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.MealForm_Load);
            this.proteinListContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.healthyRatingUpDown)).EndInit();
            this.mealTypeListContextMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.Label mealTypeLabel;
        private System.Windows.Forms.CheckedListBox mealTypeCheckedListBox;
        private System.Windows.Forms.Label addMealTypeLabel;
        private System.Windows.Forms.TextBox mealTypeTextBox;
        private System.Windows.Forms.Button addMealTypeButton;
        private System.Windows.Forms.ContextMenuStrip proteinListContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteProteinToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip mealTypeListContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleterMealTypeToolStripMenuItem;
    }
}

