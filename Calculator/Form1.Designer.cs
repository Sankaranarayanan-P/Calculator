namespace Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Screen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Zerobtn = new System.Windows.Forms.Button();
            this.Dotbtn = new System.Windows.Forms.Button();
            this.Onebtn = new System.Windows.Forms.Button();
            this.Twobtn = new System.Windows.Forms.Button();
            this.Threebtn = new System.Windows.Forms.Button();
            this.Fourbtn = new System.Windows.Forms.Button();
            this.Fivebtn = new System.Windows.Forms.Button();
            this.Sevenbtn = new System.Windows.Forms.Button();
            this.Sixbtn = new System.Windows.Forms.Button();
            this.Eightbtn = new System.Windows.Forms.Button();
            this.Ninebtn = new System.Windows.Forms.Button();
            this.ACbtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Modulusbtn = new System.Windows.Forms.Button();
            this.Equaltobtn = new System.Windows.Forms.Button();
            this.Additionbtn = new System.Windows.Forms.Button();
            this.Minusbtn = new System.Windows.Forms.Button();
            this.Multiplicationbtn = new System.Windows.Forms.Button();
            this.Divisionbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Screen
            // 
            this.Screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.Screen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Screen.Font = new System.Drawing.Font("Verdana", 30F);
            this.Screen.ForeColor = System.Drawing.Color.White;
            this.Screen.Location = new System.Drawing.Point(32, 68);
            this.Screen.Name = "Screen";
            this.Screen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Screen.Size = new System.Drawing.Size(334, 49);
            this.Screen.TabIndex = 0;
            this.Screen.Text = "0";
            this.Screen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(47)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Zerobtn);
            this.groupBox1.Controls.Add(this.Dotbtn);
            this.groupBox1.Controls.Add(this.Onebtn);
            this.groupBox1.Controls.Add(this.Twobtn);
            this.groupBox1.Controls.Add(this.Threebtn);
            this.groupBox1.Controls.Add(this.Fourbtn);
            this.groupBox1.Controls.Add(this.Fivebtn);
            this.groupBox1.Controls.Add(this.Sevenbtn);
            this.groupBox1.Controls.Add(this.Sixbtn);
            this.groupBox1.Controls.Add(this.Eightbtn);
            this.groupBox1.Controls.Add(this.Ninebtn);
            this.groupBox1.Controls.Add(this.ACbtn);
            this.groupBox1.Controls.Add(this.Clearbtn);
            this.groupBox1.Controls.Add(this.Modulusbtn);
            this.groupBox1.Controls.Add(this.Equaltobtn);
            this.groupBox1.Controls.Add(this.Additionbtn);
            this.groupBox1.Controls.Add(this.Minusbtn);
            this.groupBox1.Controls.Add(this.Multiplicationbtn);
            this.groupBox1.Controls.Add(this.Divisionbtn);
            this.groupBox1.Controls.Add(this.Screen);
            this.groupBox1.Location = new System.Drawing.Point(-20, -32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 638);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 21;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Zerobtn
            // 
            this.Zerobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.Zerobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Zerobtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zerobtn.ForeColor = System.Drawing.Color.White;
            this.Zerobtn.Location = new System.Drawing.Point(17, 411);
            this.Zerobtn.Name = "Zerobtn";
            this.Zerobtn.Size = new System.Drawing.Size(184, 65);
            this.Zerobtn.TabIndex = 20;
            this.Zerobtn.Text = "0";
            this.Zerobtn.UseVisualStyleBackColor = false;
            this.Zerobtn.Click += new System.EventHandler(this.Zerobtn_Click);
            // 
            // Dotbtn
            // 
            this.Dotbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.Dotbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dotbtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dotbtn.ForeColor = System.Drawing.Color.White;
            this.Dotbtn.Location = new System.Drawing.Point(201, 411);
            this.Dotbtn.Name = "Dotbtn";
            this.Dotbtn.Size = new System.Drawing.Size(92, 65);
            this.Dotbtn.TabIndex = 18;
            this.Dotbtn.Text = ".";
            this.Dotbtn.UseVisualStyleBackColor = false;
            this.Dotbtn.Click += new System.EventHandler(this.Dotbtn_Click);
            // 
            // Onebtn
            // 
            this.Onebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.Onebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Onebtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Onebtn.ForeColor = System.Drawing.Color.White;
            this.Onebtn.Location = new System.Drawing.Point(17, 346);
            this.Onebtn.Name = "Onebtn";
            this.Onebtn.Size = new System.Drawing.Size(92, 65);
            this.Onebtn.TabIndex = 17;
            this.Onebtn.Text = "1";
            this.Onebtn.UseVisualStyleBackColor = false;
            this.Onebtn.Click += new System.EventHandler(this.Onebtn_Click);
            // 
            // Twobtn
            // 
            this.Twobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.Twobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Twobtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Twobtn.ForeColor = System.Drawing.Color.White;
            this.Twobtn.Location = new System.Drawing.Point(109, 346);
            this.Twobtn.Name = "Twobtn";
            this.Twobtn.Size = new System.Drawing.Size(92, 65);
            this.Twobtn.TabIndex = 16;
            this.Twobtn.Text = "2";
            this.Twobtn.UseVisualStyleBackColor = false;
            this.Twobtn.Click += new System.EventHandler(this.Twobtn_Click);
            // 
            // Threebtn
            // 
            this.Threebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.Threebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Threebtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Threebtn.ForeColor = System.Drawing.Color.White;
            this.Threebtn.Location = new System.Drawing.Point(201, 346);
            this.Threebtn.Name = "Threebtn";
            this.Threebtn.Size = new System.Drawing.Size(92, 65);
            this.Threebtn.TabIndex = 15;
            this.Threebtn.Text = "3";
            this.Threebtn.UseVisualStyleBackColor = false;
            this.Threebtn.Click += new System.EventHandler(this.Threebtn_Click);
            // 
            // Fourbtn
            // 
            this.Fourbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.Fourbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fourbtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fourbtn.ForeColor = System.Drawing.Color.White;
            this.Fourbtn.Location = new System.Drawing.Point(17, 281);
            this.Fourbtn.Name = "Fourbtn";
            this.Fourbtn.Size = new System.Drawing.Size(92, 65);
            this.Fourbtn.TabIndex = 14;
            this.Fourbtn.Text = "4";
            this.Fourbtn.UseVisualStyleBackColor = false;
            this.Fourbtn.Click += new System.EventHandler(this.Fourbtn_Click);
            // 
            // Fivebtn
            // 
            this.Fivebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.Fivebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fivebtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fivebtn.ForeColor = System.Drawing.Color.White;
            this.Fivebtn.Location = new System.Drawing.Point(109, 281);
            this.Fivebtn.Name = "Fivebtn";
            this.Fivebtn.Size = new System.Drawing.Size(92, 65);
            this.Fivebtn.TabIndex = 13;
            this.Fivebtn.Text = "5";
            this.Fivebtn.UseVisualStyleBackColor = false;
            this.Fivebtn.Click += new System.EventHandler(this.Fivebtn_Click);
            // 
            // Sevenbtn
            // 
            this.Sevenbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.Sevenbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sevenbtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sevenbtn.ForeColor = System.Drawing.Color.White;
            this.Sevenbtn.Location = new System.Drawing.Point(17, 216);
            this.Sevenbtn.Name = "Sevenbtn";
            this.Sevenbtn.Size = new System.Drawing.Size(92, 65);
            this.Sevenbtn.TabIndex = 11;
            this.Sevenbtn.Text = "7";
            this.Sevenbtn.UseVisualStyleBackColor = false;
            this.Sevenbtn.Click += new System.EventHandler(this.Sevenbtn_Click);
            // 
            // Sixbtn
            // 
            this.Sixbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.Sixbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sixbtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sixbtn.ForeColor = System.Drawing.Color.White;
            this.Sixbtn.Location = new System.Drawing.Point(201, 281);
            this.Sixbtn.Name = "Sixbtn";
            this.Sixbtn.Size = new System.Drawing.Size(92, 65);
            this.Sixbtn.TabIndex = 12;
            this.Sixbtn.Text = "6";
            this.Sixbtn.UseVisualStyleBackColor = false;
            this.Sixbtn.Click += new System.EventHandler(this.Sixbtn_Click);
            // 
            // Eightbtn
            // 
            this.Eightbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.Eightbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eightbtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eightbtn.ForeColor = System.Drawing.Color.White;
            this.Eightbtn.Location = new System.Drawing.Point(109, 216);
            this.Eightbtn.Name = "Eightbtn";
            this.Eightbtn.Size = new System.Drawing.Size(92, 65);
            this.Eightbtn.TabIndex = 10;
            this.Eightbtn.Text = "8";
            this.Eightbtn.UseVisualStyleBackColor = false;
            this.Eightbtn.Click += new System.EventHandler(this.Eightbtn_Click);
            // 
            // Ninebtn
            // 
            this.Ninebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(98)))));
            this.Ninebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ninebtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ninebtn.ForeColor = System.Drawing.Color.White;
            this.Ninebtn.Location = new System.Drawing.Point(201, 216);
            this.Ninebtn.Name = "Ninebtn";
            this.Ninebtn.Size = new System.Drawing.Size(92, 65);
            this.Ninebtn.TabIndex = 9;
            this.Ninebtn.Text = "9";
            this.Ninebtn.UseVisualStyleBackColor = false;
            this.Ninebtn.Click += new System.EventHandler(this.Ninebtn_Click);
            // 
            // ACbtn
            // 
            this.ACbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(65)))), ((int)(((byte)(67)))));
            this.ACbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACbtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACbtn.ForeColor = System.Drawing.Color.White;
            this.ACbtn.Location = new System.Drawing.Point(17, 151);
            this.ACbtn.Name = "ACbtn";
            this.ACbtn.Size = new System.Drawing.Size(92, 65);
            this.ACbtn.TabIndex = 8;
            this.ACbtn.Text = "AC";
            this.ACbtn.UseVisualStyleBackColor = false;
            this.ACbtn.Click += new System.EventHandler(this.ACbtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(65)))), ((int)(((byte)(67)))));
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.Color.White;
            this.Clearbtn.Location = new System.Drawing.Point(109, 151);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(92, 65);
            this.Clearbtn.TabIndex = 7;
            this.Clearbtn.Text = "C";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Plusorminusbtn_Click);
            // 
            // Modulusbtn
            // 
            this.Modulusbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(65)))), ((int)(((byte)(67)))));
            this.Modulusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modulusbtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modulusbtn.ForeColor = System.Drawing.Color.White;
            this.Modulusbtn.Location = new System.Drawing.Point(201, 151);
            this.Modulusbtn.Name = "Modulusbtn";
            this.Modulusbtn.Size = new System.Drawing.Size(92, 65);
            this.Modulusbtn.TabIndex = 6;
            this.Modulusbtn.Text = "%";
            this.Modulusbtn.UseVisualStyleBackColor = false;
            this.Modulusbtn.Click += new System.EventHandler(this.Modulusbtn_Click);
            // 
            // Equaltobtn
            // 
            this.Equaltobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(12)))));
            this.Equaltobtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Equaltobtn.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equaltobtn.ForeColor = System.Drawing.Color.White;
            this.Equaltobtn.Location = new System.Drawing.Point(293, 411);
            this.Equaltobtn.Name = "Equaltobtn";
            this.Equaltobtn.Size = new System.Drawing.Size(92, 65);
            this.Equaltobtn.TabIndex = 5;
            this.Equaltobtn.Text = "=";
            this.Equaltobtn.UseVisualStyleBackColor = false;
            this.Equaltobtn.Click += new System.EventHandler(this.Equaltobtn_Click);
            // 
            // Additionbtn
            // 
            this.Additionbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(12)))));
            this.Additionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Additionbtn.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Additionbtn.ForeColor = System.Drawing.Color.White;
            this.Additionbtn.Location = new System.Drawing.Point(293, 346);
            this.Additionbtn.Name = "Additionbtn";
            this.Additionbtn.Size = new System.Drawing.Size(92, 65);
            this.Additionbtn.TabIndex = 4;
            this.Additionbtn.Text = "+";
            this.Additionbtn.UseVisualStyleBackColor = false;
            this.Additionbtn.Click += new System.EventHandler(this.Additionbtn_Click);
            // 
            // Minusbtn
            // 
            this.Minusbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(12)))));
            this.Minusbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minusbtn.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minusbtn.ForeColor = System.Drawing.Color.White;
            this.Minusbtn.Location = new System.Drawing.Point(293, 281);
            this.Minusbtn.Name = "Minusbtn";
            this.Minusbtn.Size = new System.Drawing.Size(92, 65);
            this.Minusbtn.TabIndex = 3;
            this.Minusbtn.Text = "-";
            this.Minusbtn.UseVisualStyleBackColor = false;
            this.Minusbtn.Click += new System.EventHandler(this.Minusbtn_Click);
            // 
            // Multiplicationbtn
            // 
            this.Multiplicationbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(12)))));
            this.Multiplicationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiplicationbtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicationbtn.ForeColor = System.Drawing.Color.White;
            this.Multiplicationbtn.Location = new System.Drawing.Point(293, 216);
            this.Multiplicationbtn.Name = "Multiplicationbtn";
            this.Multiplicationbtn.Size = new System.Drawing.Size(92, 65);
            this.Multiplicationbtn.TabIndex = 2;
            this.Multiplicationbtn.Text = "X";
            this.Multiplicationbtn.UseVisualStyleBackColor = false;
            this.Multiplicationbtn.Click += new System.EventHandler(this.Multiplicationbtn_Click);
            // 
            // Divisionbtn
            // 
            this.Divisionbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(12)))));
            this.Divisionbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divisionbtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divisionbtn.ForeColor = System.Drawing.Color.White;
            this.Divisionbtn.Location = new System.Drawing.Point(293, 151);
            this.Divisionbtn.Name = "Divisionbtn";
            this.Divisionbtn.Size = new System.Drawing.Size(92, 65);
            this.Divisionbtn.TabIndex = 1;
            this.Divisionbtn.Text = "/";
            this.Divisionbtn.UseVisualStyleBackColor = false;
            this.Divisionbtn.Click += new System.EventHandler(this.Divisionbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 441);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Screen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Sevenbtn;
        private System.Windows.Forms.Button Eightbtn;
        private System.Windows.Forms.Button Ninebtn;
        private System.Windows.Forms.Button ACbtn;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Button Modulusbtn;
        private System.Windows.Forms.Button Equaltobtn;
        private System.Windows.Forms.Button Additionbtn;
        private System.Windows.Forms.Button Minusbtn;
        private System.Windows.Forms.Button Multiplicationbtn;
        private System.Windows.Forms.Button Divisionbtn;
        private System.Windows.Forms.Button Zerobtn;
        private System.Windows.Forms.Button Dotbtn;
        private System.Windows.Forms.Button Onebtn;
        private System.Windows.Forms.Button Twobtn;
        private System.Windows.Forms.Button Threebtn;
        private System.Windows.Forms.Button Fourbtn;
        private System.Windows.Forms.Button Fivebtn;
        private System.Windows.Forms.Button Sixbtn;
        private System.Windows.Forms.Label label1;
    }
}

