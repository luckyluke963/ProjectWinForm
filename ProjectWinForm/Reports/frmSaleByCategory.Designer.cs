namespace ProjectWinForm.Reports
{
    partial class frmSaleByCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleByCategory));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(45, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 30);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(269, 78);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(131, 30);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Date";
            // 
            // btnReport
            // 
            this.btnReport.AllowAnimations = true;
            this.btnReport.AllowMouseEffects = true;
            this.btnReport.AllowToggling = false;
            this.btnReport.AnimationSpeed = 200;
            this.btnReport.AutoGenerateColors = false;
            this.btnReport.AutoRoundBorders = true;
            this.btnReport.AutoSizeLeftIcon = true;
            this.btnReport.AutoSizeRightIcon = true;
            this.btnReport.BackColor = System.Drawing.Color.Transparent;
            this.btnReport.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReport.BackgroundImage")));
            this.btnReport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.ButtonText = "Report";
            this.btnReport.ButtonTextMarginLeft = 0;
            this.btnReport.ColorContrastOnClick = 45;
            this.btnReport.ColorContrastOnHover = 45;
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = false;
            this.btnReport.CustomizableEdges = borderEdges1;
            this.btnReport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReport.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnReport.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnReport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.IconLeft = null;
            this.btnReport.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnReport.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnReport.IconMarginLeft = 11;
            this.btnReport.IconPadding = 10;
            this.btnReport.IconRight = null;
            this.btnReport.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnReport.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnReport.IconSize = 25;
            this.btnReport.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnReport.IdleBorderRadius = 0;
            this.btnReport.IdleBorderThickness = 0;
            this.btnReport.IdleFillColor = System.Drawing.Color.Empty;
            this.btnReport.IdleIconLeftImage = null;
            this.btnReport.IdleIconRightImage = null;
            this.btnReport.IndicateFocus = false;
            this.btnReport.Location = new System.Drawing.Point(46, 146);
            this.btnReport.Name = "btnReport";
            this.btnReport.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnReport.OnDisabledState.BorderRadius = 39;
            this.btnReport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.OnDisabledState.BorderThickness = 1;
            this.btnReport.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnReport.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnReport.OnDisabledState.IconLeftImage = null;
            this.btnReport.OnDisabledState.IconRightImage = null;
            this.btnReport.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnReport.onHoverState.BorderRadius = 39;
            this.btnReport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.onHoverState.BorderThickness = 1;
            this.btnReport.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnReport.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnReport.onHoverState.IconLeftImage = null;
            this.btnReport.onHoverState.IconRightImage = null;
            this.btnReport.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.OnIdleState.BorderRadius = 39;
            this.btnReport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.OnIdleState.BorderThickness = 1;
            this.btnReport.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnReport.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnReport.OnIdleState.IconLeftImage = null;
            this.btnReport.OnIdleState.IconRightImage = null;
            this.btnReport.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReport.OnPressedState.BorderRadius = 39;
            this.btnReport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnReport.OnPressedState.BorderThickness = 1;
            this.btnReport.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnReport.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnReport.OnPressedState.IconLeftImage = null;
            this.btnReport.OnPressedState.IconRightImage = null;
            this.btnReport.Size = new System.Drawing.Size(88, 39);
            this.btnReport.TabIndex = 4;
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnReport.TextMarginLeft = 0;
            this.btnReport.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnReport.UseDefaultRadiusAndThickness = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // frmSaleByCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 326);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "frmSaleByCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Sale By Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnReport;
    }
}