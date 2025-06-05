namespace PvZU_Level_Maker.PvZU_Level_Maker
{
    partial class ZombieManager
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
            label1 = new Label();
            numericRow = new NumericUpDown();
            label2 = new Label();
            comboZombie = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericRow).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Row (1–5)";
            // 
            // numericRow
            // 
            numericRow.Location = new Point(13, 33);
            numericRow.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericRow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericRow.Name = "numericRow";
            numericRow.Size = new Size(59, 23);
            numericRow.TabIndex = 1;
            numericRow.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 15);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Zombie Type";
            // 
            // comboZombie
            // 
            comboZombie.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboZombie.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboZombie.FormattingEnabled = true;
            comboZombie.Location = new Point(78, 33);
            comboZombie.Name = "comboZombie";
            comboZombie.Size = new Size(163, 23);
            comboZombie.TabIndex = 3;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(12, 66);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(128, 66);
            button2.Name = "button2";
            button2.Size = new Size(113, 23);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // ZombieManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 105);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboZombie);
            Controls.Add(label2);
            Controls.Add(numericRow);
            Controls.Add(label1);
            Name = "ZombieManager";
            Text = "ZombieManager";
            ((System.ComponentModel.ISupportInitialize)numericRow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private void InitializeMore()
        {
            comboZombie.Items.AddRange(Program.zombies.ToArray());
        }

        private Label label1;
        private NumericUpDown numericRow;
        private Label label2;
        private ComboBox comboZombie;
        private Button button1;
        private Button button2;
    }
}