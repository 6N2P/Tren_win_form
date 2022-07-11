
using System.Windows.Forms;
using System;

namespace Tren_win_form.Views
{
    partial class FoodProductListView
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
            this.label5 = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.caloriNormLabel = new System.Windows.Forms.Label();
            this.coaficComboBox = new System.Windows.Forms.ComboBox();
            this.growTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.massTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculatedCaloriesLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 52);
            this.label5.TabIndex = 17;
            this.label5.Text = "Кол-во порций";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ageTextBox.Location = new System.Drawing.Point(549, 95);
            this.ageTextBox.Multiline = true;
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(44, 40);
            this.ageTextBox.TabIndex = 13;
            this.ageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // caloriNormLabel
            // 
            this.caloriNormLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caloriNormLabel.AutoSize = true;
            this.caloriNormLabel.Location = new System.Drawing.Point(685, 0);
            this.caloriNormLabel.Name = "caloriNormLabel";
            this.caloriNormLabel.Size = new System.Drawing.Size(46, 46);
            this.caloriNormLabel.TabIndex = 16;
            this.caloriNormLabel.Text = "caloriNormLabel";
            this.caloriNormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.caloriNormLabel.Click += new System.EventHandler(this.caloriNormLabel_Click);
            // 
            // coaficComboBox
            // 
            this.coaficComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.coaficComboBox, 4);
            this.coaficComboBox.FormattingEnabled = true;
            this.coaficComboBox.Items.AddRange(new object[] {
            "Минимальная нагрузка (офис) 1,2",
            "2 раза в неделю тренеровка 1,375",
            "3 раза в неделю тренеровка 1,55",
            "Активный стиль жизни 1,725",
            "Спортик 1,9"});
            this.coaficComboBox.Location = new System.Drawing.Point(463, 141);
            this.coaficComboBox.Name = "coaficComboBox";
            this.coaficComboBox.Size = new System.Drawing.Size(268, 21);
            this.coaficComboBox.TabIndex = 15;
            this.coaficComboBox.Text = "Какой активности образ жизни";
            // 
            // growTextBox
            // 
            this.growTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.growTextBox.Location = new System.Drawing.Point(685, 95);
            this.growTextBox.Multiline = true;
            this.growTextBox.Name = "growTextBox";
            this.growTextBox.Size = new System.Drawing.Size(46, 40);
            this.growTextBox.TabIndex = 14;
            this.growTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(599, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 46);
            this.label10.TabIndex = 12;
            this.label10.Text = "Рост";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 46);
            this.label9.TabIndex = 11;
            this.label9.Text = "Возраст";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(3, 375);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(159, 23);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "Добавить продукт в БД";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Питание на сутки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Продукты";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Каллории из таблицы";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(463, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Настоящий вес";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 46);
            this.label6.TabIndex = 8;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // massTextBox
            // 
            this.massTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.massTextBox.Location = new System.Drawing.Point(549, 3);
            this.massTextBox.Multiline = true;
            this.massTextBox.Name = "massTextBox";
            this.massTextBox.Size = new System.Drawing.Size(44, 40);
            this.massTextBox.TabIndex = 3;
            this.massTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Каллории для поддержания";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Нужное кол-во калорий";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculatedCaloriesLabel
            // 
            this.calculatedCaloriesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculatedCaloriesLabel.AutoSize = true;
            this.calculatedCaloriesLabel.Location = new System.Drawing.Point(685, 46);
            this.calculatedCaloriesLabel.Name = "calculatedCaloriesLabel";
            this.calculatedCaloriesLabel.Size = new System.Drawing.Size(46, 46);
            this.calculatedCaloriesLabel.TabIndex = 7;
            this.calculatedCaloriesLabel.Text = "Calories";
            this.calculatedCaloriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.calculatedCaloriesLabel.Click += new System.EventHandler(this.CalculatedCaloriesLabel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.81815F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.15162F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.454207F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.454207F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.72267F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.838228F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.72267F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.838228F));
            this.tableLayoutPanel1.Controls.Add(this.calculatedCaloriesLabel, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.massTextBox, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddProductButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label10, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.growTextBox, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.coaficComboBox, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.caloriNormLabel, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.ageTextBox, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.41868F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.41868F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.41868F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.09343F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.650519F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(383, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 39);
            this.label11.TabIndex = 18;
            this.label11.Text = "Порция в грм.";
            // 
            // FoodProductListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 411);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FoodProductListView";
            this.Text = "FoodProductListView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label5;
        public TextBox ageTextBox;
        public Label caloriNormLabel;
        public ComboBox coaficComboBox;
        private TableLayoutPanel tableLayoutPanel1;
        public Label calculatedCaloriesLabel;
        private Label label4;
        private Label label2;
        public TextBox massTextBox;
        private Label label6;
        private Label label1;
        private Label label3;
        private Label label7;
        private Button AddProductButton;
        private Label label9;
        private Label label10;
        public TextBox growTextBox;
        private Label label8;
        private Label label11;

        public int Mass
        {
            get => Convert.ToInt32(massTextBox.Text);            
            set => massTextBox.Text = value.ToString();
        }


    }
}