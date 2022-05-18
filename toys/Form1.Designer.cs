namespace toys
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.addBttn = new System.Windows.Forms.Button();
            this.delBttn = new System.Windows.Forms.Button();
            this.decSpeed = new System.Windows.Forms.Button();
            this.incSpeed = new System.Windows.Forms.Button();
            this.valSpeed = new System.Windows.Forms.TextBox();
            this.speedBox = new System.Windows.Forms.GroupBox();
            this.diveBox = new System.Windows.Forms.GroupBox();
            this.incDive = new System.Windows.Forms.Button();
            this.valDive = new System.Windows.Forms.TextBox();
            this.decDive = new System.Windows.Forms.Button();
            this.riseBox = new System.Windows.Forms.GroupBox();
            this.incRise = new System.Windows.Forms.Button();
            this.valRise = new System.Windows.Forms.TextBox();
            this.decRise = new System.Windows.Forms.Button();
            this.speedBox.SuspendLayout();
            this.diveBox.SuspendLayout();
            this.riseBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "car",
            "plane",
            "submarine",
            "computer"});
            this.listBox1.Location = new System.Drawing.Point(127, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.DisplayMember = "name";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(395, 41);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // addBttn
            // 
            this.addBttn.Location = new System.Drawing.Point(280, 70);
            this.addBttn.Name = "addBttn";
            this.addBttn.Size = new System.Drawing.Size(75, 23);
            this.addBttn.TabIndex = 2;
            this.addBttn.Text = "add";
            this.addBttn.UseVisualStyleBackColor = true;
            this.addBttn.Click += new System.EventHandler(this.addBttn_Click);
            // 
            // delBttn
            // 
            this.delBttn.Location = new System.Drawing.Point(541, 70);
            this.delBttn.Name = "delBttn";
            this.delBttn.Size = new System.Drawing.Size(75, 23);
            this.delBttn.TabIndex = 2;
            this.delBttn.Text = "delete";
            this.delBttn.UseVisualStyleBackColor = true;
            this.delBttn.Click += new System.EventHandler(this.delBttn_Click);
            // 
            // decSpeed
            // 
            this.decSpeed.Location = new System.Drawing.Point(12, 19);
            this.decSpeed.Name = "decSpeed";
            this.decSpeed.Size = new System.Drawing.Size(75, 23);
            this.decSpeed.TabIndex = 3;
            this.decSpeed.Text = "-";
            this.decSpeed.UseVisualStyleBackColor = true;
            this.decSpeed.Click += new System.EventHandler(this.decSpeed_Click);
            // 
            // incSpeed
            // 
            this.incSpeed.Location = new System.Drawing.Point(150, 19);
            this.incSpeed.Name = "incSpeed";
            this.incSpeed.Size = new System.Drawing.Size(75, 23);
            this.incSpeed.TabIndex = 4;
            this.incSpeed.Text = "+";
            this.incSpeed.UseVisualStyleBackColor = true;
            this.incSpeed.Click += new System.EventHandler(this.incSpeed_Click);
            // 
            // valSpeed
            // 
            this.valSpeed.Enabled = false;
            this.valSpeed.Location = new System.Drawing.Point(93, 20);
            this.valSpeed.Name = "valSpeed";
            this.valSpeed.Size = new System.Drawing.Size(51, 20);
            this.valSpeed.TabIndex = 5;
            // 
            // speedBox
            // 
            this.speedBox.Controls.Add(this.incSpeed);
            this.speedBox.Controls.Add(this.valSpeed);
            this.speedBox.Controls.Add(this.decSpeed);
            this.speedBox.Location = new System.Drawing.Point(412, 174);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(231, 52);
            this.speedBox.TabIndex = 6;
            this.speedBox.TabStop = false;
            this.speedBox.Text = "Speed";
            this.speedBox.Visible = false;
            // 
            // diveBox
            // 
            this.diveBox.Controls.Add(this.incDive);
            this.diveBox.Controls.Add(this.valDive);
            this.diveBox.Controls.Add(this.decDive);
            this.diveBox.Location = new System.Drawing.Point(412, 244);
            this.diveBox.Name = "diveBox";
            this.diveBox.Size = new System.Drawing.Size(231, 52);
            this.diveBox.TabIndex = 6;
            this.diveBox.TabStop = false;
            this.diveBox.Text = "Dive";
            this.diveBox.Visible = false;
            // 
            // incDive
            // 
            this.incDive.Location = new System.Drawing.Point(150, 19);
            this.incDive.Name = "incDive";
            this.incDive.Size = new System.Drawing.Size(75, 23);
            this.incDive.TabIndex = 4;
            this.incDive.Text = "+";
            this.incDive.UseVisualStyleBackColor = true;
            this.incDive.Click += new System.EventHandler(this.incDive_Click);
            // 
            // valDive
            // 
            this.valDive.Enabled = false;
            this.valDive.Location = new System.Drawing.Point(93, 20);
            this.valDive.Name = "valDive";
            this.valDive.Size = new System.Drawing.Size(51, 20);
            this.valDive.TabIndex = 5;
            // 
            // decDive
            // 
            this.decDive.Location = new System.Drawing.Point(12, 19);
            this.decDive.Name = "decDive";
            this.decDive.Size = new System.Drawing.Size(75, 23);
            this.decDive.TabIndex = 3;
            this.decDive.Text = "-";
            this.decDive.UseVisualStyleBackColor = true;
            this.decDive.Click += new System.EventHandler(this.decDive_Click);
            // 
            // riseBox
            // 
            this.riseBox.Controls.Add(this.incRise);
            this.riseBox.Controls.Add(this.valRise);
            this.riseBox.Controls.Add(this.decRise);
            this.riseBox.Location = new System.Drawing.Point(412, 313);
            this.riseBox.Name = "riseBox";
            this.riseBox.Size = new System.Drawing.Size(231, 52);
            this.riseBox.TabIndex = 6;
            this.riseBox.TabStop = false;
            this.riseBox.Text = "Rise";
            this.riseBox.Visible = false;
            // 
            // incRise
            // 
            this.incRise.Location = new System.Drawing.Point(150, 19);
            this.incRise.Name = "incRise";
            this.incRise.Size = new System.Drawing.Size(75, 23);
            this.incRise.TabIndex = 4;
            this.incRise.Text = "+";
            this.incRise.UseVisualStyleBackColor = true;
            this.incRise.Click += new System.EventHandler(this.incRise_Click);
            // 
            // valRise
            // 
            this.valRise.Enabled = false;
            this.valRise.Location = new System.Drawing.Point(93, 20);
            this.valRise.Name = "valRise";
            this.valRise.Size = new System.Drawing.Size(51, 20);
            this.valRise.TabIndex = 5;
            // 
            // decRise
            // 
            this.decRise.Location = new System.Drawing.Point(12, 19);
            this.decRise.Name = "decRise";
            this.decRise.Size = new System.Drawing.Size(75, 23);
            this.decRise.TabIndex = 3;
            this.decRise.Text = "-";
            this.decRise.UseVisualStyleBackColor = true;
            this.decRise.Click += new System.EventHandler(this.decRise_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.riseBox);
            this.Controls.Add(this.diveBox);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.delBttn);
            this.Controls.Add(this.addBttn);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.speedBox.ResumeLayout(false);
            this.speedBox.PerformLayout();
            this.diveBox.ResumeLayout(false);
            this.diveBox.PerformLayout();
            this.riseBox.ResumeLayout(false);
            this.riseBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button addBttn;
        private System.Windows.Forms.Button delBttn;
        private System.Windows.Forms.Button decSpeed;
        private System.Windows.Forms.Button incSpeed;
        private System.Windows.Forms.TextBox valSpeed;
        private System.Windows.Forms.GroupBox speedBox;
        private System.Windows.Forms.GroupBox diveBox;
        private System.Windows.Forms.Button incDive;
        private System.Windows.Forms.TextBox valDive;
        private System.Windows.Forms.Button decDive;
        private System.Windows.Forms.GroupBox riseBox;
        private System.Windows.Forms.Button incRise;
        private System.Windows.Forms.TextBox valRise;
        private System.Windows.Forms.Button decRise;
    }
}

