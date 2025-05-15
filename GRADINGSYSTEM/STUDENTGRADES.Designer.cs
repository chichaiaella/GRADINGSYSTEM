namespace GRADINGSYSTEM
{
    partial class STUDENTGRADES
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSub = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblMidterm = new System.Windows.Forms.Label();
            this.lblPrelim = new System.Windows.Forms.Label();
            this.lblProg = new System.Windows.Forms.Label();
            this.lblMname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtMidterm = new System.Windows.Forms.TextBox();
            this.txtPrelim = new System.Windows.Forms.TextBox();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lvwInfo = new System.Windows.Forms.ListView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.BackColor = System.Drawing.Color.Transparent;
            this.lblSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSub.ForeColor = System.Drawing.Color.White;
            this.lblSub.Location = new System.Drawing.Point(32, 201);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(71, 20);
            this.lblSub.TabIndex = 39;
            this.lblSub.Text = "Subject :";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.BackColor = System.Drawing.Color.Transparent;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinal.ForeColor = System.Drawing.Color.White;
            this.lblFinal.Location = new System.Drawing.Point(460, 174);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(68, 16);
            this.lblFinal.TabIndex = 38;
            this.lblFinal.Text = "Final  50%";
            // 
            // lblMidterm
            // 
            this.lblMidterm.AutoSize = true;
            this.lblMidterm.BackColor = System.Drawing.Color.Transparent;
            this.lblMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMidterm.ForeColor = System.Drawing.Color.White;
            this.lblMidterm.Location = new System.Drawing.Point(355, 174);
            this.lblMidterm.Name = "lblMidterm";
            this.lblMidterm.Size = new System.Drawing.Size(87, 16);
            this.lblMidterm.TabIndex = 37;
            this.lblMidterm.Text = "Midterm  30%";
            this.lblMidterm.Click += new System.EventHandler(this.lblMidterm_Click);
            // 
            // lblPrelim
            // 
            this.lblPrelim.AutoSize = true;
            this.lblPrelim.BackColor = System.Drawing.Color.Transparent;
            this.lblPrelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrelim.ForeColor = System.Drawing.Color.White;
            this.lblPrelim.Location = new System.Drawing.Point(254, 174);
            this.lblPrelim.Name = "lblPrelim";
            this.lblPrelim.Size = new System.Drawing.Size(77, 16);
            this.lblPrelim.TabIndex = 36;
            this.lblPrelim.Text = "Prelim  20%";
            // 
            // lblProg
            // 
            this.lblProg.AutoSize = true;
            this.lblProg.BackColor = System.Drawing.Color.Transparent;
            this.lblProg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProg.ForeColor = System.Drawing.Color.White;
            this.lblProg.Location = new System.Drawing.Point(298, 117);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(77, 20);
            this.lblProg.TabIndex = 35;
            this.lblProg.Text = "Program :";
            // 
            // lblMname
            // 
            this.lblMname.AutoSize = true;
            this.lblMname.BackColor = System.Drawing.Color.Transparent;
            this.lblMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMname.ForeColor = System.Drawing.Color.White;
            this.lblMname.Location = new System.Drawing.Point(298, 88);
            this.lblMname.Name = "lblMname";
            this.lblMname.Size = new System.Drawing.Size(103, 20);
            this.lblMname.TabIndex = 34;
            this.lblMname.Text = "Middlename :";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.BackColor = System.Drawing.Color.Transparent;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.ForeColor = System.Drawing.Color.White;
            this.lblLname.Location = new System.Drawing.Point(15, 117);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(88, 20);
            this.lblLname.TabIndex = 33;
            this.lblLname.Text = "Lastname :";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.BackColor = System.Drawing.Color.Transparent;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.White;
            this.lblFname.Location = new System.Drawing.Point(15, 88);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(88, 20);
            this.lblFname.TabIndex = 32;
            this.lblFname.Text = "Firstname :";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.Black;
            this.btnClearAll.Location = new System.Drawing.Point(345, 260);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(108, 64);
            this.btnClearAll.TabIndex = 31;
            this.btnClearAll.Text = "CLEAR ALL";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(233, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 64);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(121, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 64);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtFinal
            // 
            this.txtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinal.Location = new System.Drawing.Point(464, 201);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(64, 26);
            this.txtFinal.TabIndex = 27;
            // 
            // txtMidterm
            // 
            this.txtMidterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMidterm.Location = new System.Drawing.Point(358, 201);
            this.txtMidterm.Name = "txtMidterm";
            this.txtMidterm.Size = new System.Drawing.Size(64, 26);
            this.txtMidterm.TabIndex = 26;
            // 
            // txtPrelim
            // 
            this.txtPrelim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrelim.Location = new System.Drawing.Point(257, 201);
            this.txtPrelim.Name = "txtPrelim";
            this.txtPrelim.Size = new System.Drawing.Size(64, 26);
            this.txtPrelim.TabIndex = 25;
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Items.AddRange(new object[] {
            "Computer Programming 2",
            "Animation & Multimedia",
            "Discrete Structure",
            "Mathematics in the Modern World",
            "Purposive Communication",
            "Art Appreciation",
            "NSTP2",
            "PAFIT2"});
            this.cmbSubjects.Location = new System.Drawing.Point(109, 196);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(121, 28);
            this.cmbSubjects.TabIndex = 24;
            // 
            // txtProgram
            // 
            this.txtProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgram.Location = new System.Drawing.Point(403, 119);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(157, 26);
            this.txtProgram.TabIndex = 23;
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddlename.Location = new System.Drawing.Point(403, 87);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(157, 26);
            this.txtMiddlename.TabIndex = 22;
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(109, 120);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(164, 26);
            this.txtLastname.TabIndex = 21;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(109, 88);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(164, 26);
            this.txtFirstname.TabIndex = 20;
            // 
            // lvwInfo
            // 
            this.lvwInfo.HideSelection = false;
            this.lvwInfo.Location = new System.Drawing.Point(52, 348);
            this.lvwInfo.Name = "lvwInfo";
            this.lvwInfo.Size = new System.Drawing.Size(490, 149);
            this.lvwInfo.TabIndex = 40;
            this.lvwInfo.UseCompatibleStateImageBehavior = false;
            this.lvwInfo.View = System.Windows.Forms.View.Details;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Broadway", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(98, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(381, 42);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "GRADING SYSTEM";
            // 
            // STUDENTGRADES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lvwInfo);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblMidterm);
            this.Controls.Add(this.lblPrelim);
            this.Controls.Add(this.lblProg);
            this.Controls.Add(this.lblMname);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtMidterm);
            this.Controls.Add(this.txtPrelim);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.txtProgram);
            this.Controls.Add(this.txtMiddlename);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Name = "STUDENTGRADES";
            this.Size = new System.Drawing.Size(584, 626);
            this.Load += new System.EventHandler(this.STUDENTGRADES_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblMidterm;
        private System.Windows.Forms.Label lblPrelim;
        private System.Windows.Forms.Label lblProg;
        private System.Windows.Forms.Label lblMname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtMidterm;
        private System.Windows.Forms.TextBox txtPrelim;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.ListView lvwInfo;
        private System.Windows.Forms.Label lblTitle;
    }
}
