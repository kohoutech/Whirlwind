namespace Whirlwind
{
    partial class WhirlwindDialog
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
            this.lblChordHold = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnHoldOn = new Transonic.Widget.PushButton();
            this.sldMode = new Transonic.Widget.Slider();
            this.sldRange = new Transonic.Widget.Slider();
            this.sldRate = new Transonic.Widget.Slider();
            this.SuspendLayout();
            // 
            // lblChordHold
            // 
            this.lblChordHold.AutoSize = true;
            this.lblChordHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChordHold.ForeColor = System.Drawing.Color.Black;
            this.lblChordHold.Location = new System.Drawing.Point(13, 17);
            this.lblChordHold.Name = "lblChordHold";
            this.lblChordHold.Size = new System.Drawing.Size(47, 15);
            this.lblChordHold.TabIndex = 5;
            this.lblChordHold.Text = "On / Off";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.Black;
            this.lblRate.Location = new System.Drawing.Point(179, 2);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(33, 15);
            this.lblRate.TabIndex = 6;
            this.lblRate.Text = "Rate";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRange.ForeColor = System.Drawing.Color.Black;
            this.lblRange.Location = new System.Drawing.Point(123, 2);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(44, 15);
            this.lblRange.TabIndex = 7;
            this.lblRange.Text = "Range";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.Black;
            this.lblMode.Location = new System.Drawing.Point(72, 2);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(39, 15);
            this.lblMode.TabIndex = 8;
            this.lblMode.Text = "Mode";
            // 
            // btnHoldOn
            // 
            this.btnHoldOn.BackColor = System.Drawing.Color.LightCoral;
            this.btnHoldOn.Location = new System.Drawing.Point(21, 41);
            this.btnHoldOn.Name = "btnHoldOn";
            this.btnHoldOn.Size = new System.Drawing.Size(30, 50);
            this.btnHoldOn.TabIndex = 9;
            // 
            // sldMode
            // 
            this.sldMode.BackColor = System.Drawing.Color.Tomato;
            this.sldMode.Location = new System.Drawing.Point(83, 26);
            this.sldMode.Name = "sldMode";
            this.sldMode.Size = new System.Drawing.Size(17, 80);
            this.sldMode.TabIndex = 10;
            // 
            // sldRange
            // 
            this.sldRange.BackColor = System.Drawing.Color.Tomato;
            this.sldRange.Location = new System.Drawing.Point(137, 26);
            this.sldRange.Name = "sldRange";
            this.sldRange.Size = new System.Drawing.Size(17, 80);
            this.sldRange.TabIndex = 11;
            // 
            // sldRate
            // 
            this.sldRate.BackColor = System.Drawing.Color.Tomato;
            this.sldRate.Location = new System.Drawing.Point(187, 26);
            this.sldRate.Name = "sldRate";
            this.sldRate.Size = new System.Drawing.Size(17, 80);
            this.sldRate.TabIndex = 12;
            // 
            // WhirlwindDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(224, 111);
            this.Controls.Add(this.sldRate);
            this.Controls.Add(this.sldRange);
            this.Controls.Add(this.sldMode);
            this.Controls.Add(this.btnHoldOn);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblChordHold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "WhirlwindDialog";
            this.Text = "Whirlwind-001";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChordHold;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblMode;
        private Transonic.Widget.PushButton btnHoldOn;
        private Transonic.Widget.Slider sldMode;
        private Transonic.Widget.Slider sldRange;
        private Transonic.Widget.Slider sldRate;
    }
}

