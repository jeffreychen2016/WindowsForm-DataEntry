namespace DataEntryProject
{
    partial class frmDataEntry
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
            this.grbDataEntry = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTimer = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTimer = new System.Windows.Forms.TextBox();
            this.timTimer = new System.Windows.Forms.Timer(this.components);
            this.grbDataEntry.SuspendLayout();
            this.grbTimer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDataEntry
            // 
            this.grbDataEntry.Controls.Add(this.btnClear);
            this.grbDataEntry.Controls.Add(this.btnAccept);
            this.grbDataEntry.Controls.Add(this.txtZip);
            this.grbDataEntry.Controls.Add(this.txtState);
            this.grbDataEntry.Controls.Add(this.txtCity);
            this.grbDataEntry.Controls.Add(this.txtAddress);
            this.grbDataEntry.Controls.Add(this.txtName);
            this.grbDataEntry.Controls.Add(this.label5);
            this.grbDataEntry.Controls.Add(this.label4);
            this.grbDataEntry.Controls.Add(this.label3);
            this.grbDataEntry.Controls.Add(this.label2);
            this.grbDataEntry.Controls.Add(this.label1);
            this.grbDataEntry.Location = new System.Drawing.Point(63, 32);
            this.grbDataEntry.Name = "grbDataEntry";
            this.grbDataEntry.Size = new System.Drawing.Size(309, 341);
            this.grbDataEntry.TabIndex = 0;
            this.grbDataEntry.TabStop = false;
            this.grbDataEntry.Text = "Data Entry";
            this.grbDataEntry.Enter += new System.EventHandler(this.grbDataEntry_Enter);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(192, 278);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnButtons_Leave);
            this.btnClear.MouseHover += new System.EventHandler(this.btnButtons_Hover);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(25, 278);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 36);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            this.btnAccept.MouseLeave += new System.EventHandler(this.btnButtons_Leave);
            this.btnAccept.MouseHover += new System.EventHandler(this.btnButtons_Hover);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(101, 213);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(166, 22);
            this.txtZip.TabIndex = 5;
            this.txtZip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(101, 163);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(166, 22);
            this.txtState.TabIndex = 4;
            this.txtState.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(101, 115);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(166, 22);
            this.txtCity.TabIndex = 3;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(101, 74);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(166, 22);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Zip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // grbTimer
            // 
            this.grbTimer.Controls.Add(this.btnStart);
            this.grbTimer.Controls.Add(this.btnPause);
            this.grbTimer.Controls.Add(this.btnExit);
            this.grbTimer.Controls.Add(this.txtTimer);
            this.grbTimer.Location = new System.Drawing.Point(453, 32);
            this.grbTimer.Name = "grbTimer";
            this.grbTimer.Size = new System.Drawing.Size(273, 341);
            this.grbTimer.TabIndex = 1;
            this.grbTimer.TabStop = false;
            this.grbTimer.Text = "Timer";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(103, 85);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 37);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(103, 128);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 38);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "&Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(103, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTimer
            // 
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimer.Location = new System.Drawing.Point(89, 34);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.ReadOnly = true;
            this.txtTimer.Size = new System.Drawing.Size(100, 27);
            this.txtTimer.TabIndex = 0;
            this.txtTimer.Text = "00:00:00";
            this.txtTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timTimer
            // 
            this.timTimer.Interval = 1000;
            this.timTimer.Tick += new System.EventHandler(this.timTimer_Tick);
            // 
            // frmDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 406);
            this.Controls.Add(this.grbTimer);
            this.Controls.Add(this.grbDataEntry);
            this.Name = "frmDataEntry";
            this.Text = "Data Entry Form";
            this.grbDataEntry.ResumeLayout(false);
            this.grbDataEntry.PerformLayout();
            this.grbTimer.ResumeLayout(false);
            this.grbTimer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDataEntry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTimer;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTimer;
        private System.Windows.Forms.Timer timTimer;
    }
}

