
namespace KuzProject
{
    partial class HumburgerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HumburgerMenu));
            this.cheeseBox = new System.Windows.Forms.CheckBox();
            this.saladBox = new System.Windows.Forms.CheckBox();
            this.baconBox = new System.Windows.Forms.CheckBox();
            this.tomatoBox = new System.Windows.Forms.CheckBox();
            this.cucumberBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HumAddButton = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.cheeseprice = new System.Windows.Forms.Label();
            this.saladprice = new System.Windows.Forms.Label();
            this.cucumberprice = new System.Windows.Forms.Label();
            this.baconprice = new System.Windows.Forms.Label();
            this.tomatoprice = new System.Windows.Forms.Label();
            this.resultbutton = new System.Windows.Forms.Button();
            this.resultsum = new System.Windows.Forms.Label();
            this.burgerprice = new System.Windows.Forms.Label();
            this.numerichum = new System.Windows.Forms.NumericUpDown();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerichum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // cheeseBox
            // 
            this.cheeseBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cheeseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cheeseBox.Location = new System.Drawing.Point(21, 174);
            this.cheeseBox.Name = "cheeseBox";
            this.cheeseBox.Size = new System.Drawing.Size(192, 41);
            this.cheeseBox.TabIndex = 0;
            this.cheeseBox.Text = "Сыр";
            this.cheeseBox.UseVisualStyleBackColor = true;
            this.cheeseBox.CheckedChanged += new System.EventHandler(this.cheeseBox_CheckedChanged);
            // 
            // saladBox
            // 
            this.saladBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saladBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saladBox.Location = new System.Drawing.Point(21, 221);
            this.saladBox.Name = "saladBox";
            this.saladBox.Size = new System.Drawing.Size(192, 41);
            this.saladBox.TabIndex = 1;
            this.saladBox.Text = "Салат";
            this.saladBox.UseVisualStyleBackColor = true;
            this.saladBox.CheckedChanged += new System.EventHandler(this.saladBox_CheckedChanged);
            // 
            // baconBox
            // 
            this.baconBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.baconBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baconBox.Location = new System.Drawing.Point(21, 268);
            this.baconBox.Name = "baconBox";
            this.baconBox.Size = new System.Drawing.Size(192, 41);
            this.baconBox.TabIndex = 2;
            this.baconBox.Text = "Бекон";
            this.baconBox.UseVisualStyleBackColor = true;
            this.baconBox.CheckedChanged += new System.EventHandler(this.baconBox_CheckedChanged);
            // 
            // tomatoBox
            // 
            this.tomatoBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tomatoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tomatoBox.Location = new System.Drawing.Point(21, 362);
            this.tomatoBox.Name = "tomatoBox";
            this.tomatoBox.Size = new System.Drawing.Size(192, 41);
            this.tomatoBox.TabIndex = 4;
            this.tomatoBox.Text = "Помидор";
            this.tomatoBox.UseVisualStyleBackColor = true;
            this.tomatoBox.CheckedChanged += new System.EventHandler(this.tomatoBox_CheckedChanged);
            // 
            // cucumberBox
            // 
            this.cucumberBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cucumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cucumberBox.Location = new System.Drawing.Point(21, 315);
            this.cucumberBox.Name = "cucumberBox";
            this.cucumberBox.Size = new System.Drawing.Size(192, 41);
            this.cucumberBox.TabIndex = 5;
            this.cucumberBox.Text = "Огурец";
            this.cucumberBox.UseVisualStyleBackColor = true;
            this.cucumberBox.CheckedChanged += new System.EventHandler(this.cucumberBox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HumAddButton
            // 
            this.HumAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HumAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HumAddButton.Location = new System.Drawing.Point(461, 244);
            this.HumAddButton.Name = "HumAddButton";
            this.HumAddButton.Size = new System.Drawing.Size(191, 57);
            this.HumAddButton.TabIndex = 7;
            this.HumAddButton.Text = "Добавить";
            this.HumAddButton.UseVisualStyleBackColor = true;
            this.HumAddButton.Click += new System.EventHandler(this.HumAddButton_Click);
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Back.Location = new System.Drawing.Point(21, 454);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(305, 48);
            this.Back.TabIndex = 8;
            this.Back.Text = "<--- Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // cheeseprice
            // 
            this.cheeseprice.AutoSize = true;
            this.cheeseprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cheeseprice.Location = new System.Drawing.Point(219, 182);
            this.cheeseprice.Name = "cheeseprice";
            this.cheeseprice.Size = new System.Drawing.Size(67, 25);
            this.cheeseprice.TabIndex = 9;
            this.cheeseprice.Text = "+15 р.";
            this.cheeseprice.Visible = false;
            // 
            // saladprice
            // 
            this.saladprice.AutoSize = true;
            this.saladprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saladprice.Location = new System.Drawing.Point(219, 229);
            this.saladprice.Name = "saladprice";
            this.saladprice.Size = new System.Drawing.Size(67, 25);
            this.saladprice.TabIndex = 10;
            this.saladprice.Text = "+15 р.";
            this.saladprice.Visible = false;
            // 
            // cucumberprice
            // 
            this.cucumberprice.AutoSize = true;
            this.cucumberprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cucumberprice.Location = new System.Drawing.Point(219, 323);
            this.cucumberprice.Name = "cucumberprice";
            this.cucumberprice.Size = new System.Drawing.Size(67, 25);
            this.cucumberprice.TabIndex = 12;
            this.cucumberprice.Text = "+15 р.";
            this.cucumberprice.Visible = false;
            // 
            // baconprice
            // 
            this.baconprice.AutoSize = true;
            this.baconprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.baconprice.Location = new System.Drawing.Point(219, 276);
            this.baconprice.Name = "baconprice";
            this.baconprice.Size = new System.Drawing.Size(67, 25);
            this.baconprice.TabIndex = 11;
            this.baconprice.Text = "+15 р.";
            this.baconprice.Visible = false;
            // 
            // tomatoprice
            // 
            this.tomatoprice.AutoSize = true;
            this.tomatoprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tomatoprice.Location = new System.Drawing.Point(219, 370);
            this.tomatoprice.Name = "tomatoprice";
            this.tomatoprice.Size = new System.Drawing.Size(67, 25);
            this.tomatoprice.TabIndex = 13;
            this.tomatoprice.Text = "+15 р.";
            this.tomatoprice.Visible = false;
            // 
            // resultbutton
            // 
            this.resultbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultbutton.Location = new System.Drawing.Point(461, 103);
            this.resultbutton.Name = "resultbutton";
            this.resultbutton.Size = new System.Drawing.Size(175, 48);
            this.resultbutton.TabIndex = 15;
            this.resultbutton.Text = "Расчитать";
            this.resultbutton.UseVisualStyleBackColor = true;
            this.resultbutton.Click += new System.EventHandler(this.resultbutton_Click);
            // 
            // resultsum
            // 
            this.resultsum.AutoSize = true;
            this.resultsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultsum.Location = new System.Drawing.Point(456, 174);
            this.resultsum.Name = "resultsum";
            this.resultsum.Size = new System.Drawing.Size(209, 25);
            this.resultsum.TabIndex = 16;
            this.resultsum.Text = "Цена Бургера: 70 руб.";
            // 
            // burgerprice
            // 
            this.burgerprice.AutoSize = true;
            this.burgerprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.burgerprice.Location = new System.Drawing.Point(219, 66);
            this.burgerprice.Name = "burgerprice";
            this.burgerprice.Size = new System.Drawing.Size(72, 25);
            this.burgerprice.TabIndex = 17;
            this.burgerprice.Text = "= 70 р.";
            // 
            // numerichum
            // 
            this.numerichum.Location = new System.Drawing.Point(461, 71);
            this.numerichum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numerichum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numerichum.Name = "numerichum";
            this.numerichum.Size = new System.Drawing.Size(72, 20);
            this.numerichum.TabIndex = 18;
            this.numerichum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numerichum.ValueChanged += new System.EventHandler(this.numerichum_ValueChanged);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(486, 346);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(150, 139);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 20;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(466, 326);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(192, 176);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            // 
            // HumburgerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 550);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.numerichum);
            this.Controls.Add(this.burgerprice);
            this.Controls.Add(this.resultsum);
            this.Controls.Add(this.resultbutton);
            this.Controls.Add(this.tomatoprice);
            this.Controls.Add(this.cucumberprice);
            this.Controls.Add(this.baconprice);
            this.Controls.Add(this.saladprice);
            this.Controls.Add(this.cheeseprice);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.HumAddButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cucumberBox);
            this.Controls.Add(this.tomatoBox);
            this.Controls.Add(this.baconBox);
            this.Controls.Add(this.saladBox);
            this.Controls.Add(this.cheeseBox);
            this.Name = "HumburgerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Humburger";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerichum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox cheeseBox;
        public System.Windows.Forms.CheckBox saladBox;
        public System.Windows.Forms.CheckBox baconBox;
        public System.Windows.Forms.CheckBox tomatoBox;
        public System.Windows.Forms.CheckBox cucumberBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button HumAddButton;
        private System.Windows.Forms.Button Back;
        public System.Windows.Forms.Label cheeseprice;
        public System.Windows.Forms.Label saladprice;
        public System.Windows.Forms.Label cucumberprice;
        public System.Windows.Forms.Label baconprice;
        public System.Windows.Forms.Label tomatoprice;
        private System.Windows.Forms.Button resultbutton;
        public System.Windows.Forms.Label resultsum;
        public System.Windows.Forms.Label burgerprice;
        public System.Windows.Forms.NumericUpDown numerichum;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}