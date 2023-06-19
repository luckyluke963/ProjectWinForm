namespace ProjectWinForm.Model
{
    partial class frmPOSuser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOSuser));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.CategoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvproID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2MessageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnExit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblWaiter = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.btnDin = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnTake = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnDelivery = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnHold = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnNew = new Guna.UI2.WinForms.Guna2TileButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.btnClear = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnOrder = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnHome = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoryPanel
            // 
            this.CategoryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CategoryPanel.Location = new System.Drawing.Point(12, 182);
            this.CategoryPanel.Name = "CategoryPanel";
            this.CategoryPanel.Size = new System.Drawing.Size(200, 344);
            this.CategoryPanel.TabIndex = 2;
            // 
            // ProductPanel
            // 
            this.ProductPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductPanel.AutoScroll = true;
            this.ProductPanel.Location = new System.Drawing.Point(218, 182);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(610, 344);
            this.ProductPanel.TabIndex = 3;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 40;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvid,
            this.dgvproID,
            this.dgvName,
            this.dgvQty,
            this.dgvPrice,
            this.dgvAmount,
            this.dgvDel});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(834, 182);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 35;
            this.guna2DataGridView1.Size = new System.Drawing.Size(422, 344);
            this.guna2DataGridView1.TabIndex = 9;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 35;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellClick);
            this.guna2DataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.guna2DataGridView1_CellFormatting);
            // 
            // dgvSno
            // 
            this.dgvSno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSno.FillWeight = 70F;
            this.dgvSno.HeaderText = "Sr#";
            this.dgvSno.MinimumWidth = 70;
            this.dgvSno.Name = "dgvSno";
            this.dgvSno.ReadOnly = true;
            this.dgvSno.Width = 70;
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "id";
            this.dgvid.MinimumWidth = 6;
            this.dgvid.Name = "dgvid";
            this.dgvid.ReadOnly = true;
            this.dgvid.Visible = false;
            // 
            // dgvproID
            // 
            this.dgvproID.HeaderText = "ProductID";
            this.dgvproID.MinimumWidth = 6;
            this.dgvproID.Name = "dgvproID";
            this.dgvproID.ReadOnly = true;
            this.dgvproID.Visible = false;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvName.HeaderText = "Name";
            this.dgvName.MinimumWidth = 6;
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            // 
            // dgvQty
            // 
            this.dgvQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvQty.FillWeight = 40F;
            this.dgvQty.HeaderText = "Qty";
            this.dgvQty.MinimumWidth = 40;
            this.dgvQty.Name = "dgvQty";
            this.dgvQty.ReadOnly = true;
            this.dgvQty.Width = 40;
            // 
            // dgvPrice
            // 
            this.dgvPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvPrice.FillWeight = 50F;
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.MinimumWidth = 50;
            this.dgvPrice.Name = "dgvPrice";
            this.dgvPrice.ReadOnly = true;
            this.dgvPrice.Width = 50;
            // 
            // dgvAmount
            // 
            this.dgvAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvAmount.FillWeight = 75F;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.MinimumWidth = 75;
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.ReadOnly = true;
            this.dgvAmount.Width = 75;
            // 
            // dgvDel
            // 
            this.dgvDel.HeaderText = "";
            this.dgvDel.Image = global::ProjectWinForm.Properties.Resources.icons8_delete_64;
            this.dgvDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgvDel.MinimumWidth = 6;
            this.dgvDel.Name = "dgvDel";
            this.dgvDel.ReadOnly = true;
            // 
            // guna2MessageDialog1
            // 
            this.guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.guna2MessageDialog1.Caption = "RMS";
            this.guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.guna2MessageDialog1.Parent = null;
            this.guna2MessageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.guna2MessageDialog1.Text = null;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.AutoSizeHeight = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 1;
            this.txtSearch.BorderThickness = 1;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = global::ProjectWinForm.Properties.Resources.icons8_search_64;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(229, 122);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtSearch.PlaceholderText = "Search Here";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(343, 43);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 10;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 3;
            this.txtSearch.TextMarginTop = 1;
            this.txtSearch.TextPlaceholder = "Search Here";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.btnHome);
            this.bunifuPanel2.Controls.Add(this.btnOrder);
            this.bunifuPanel2.Controls.Add(this.btnClear);
            this.bunifuPanel2.Controls.Add(this.lblTotal);
            this.bunifuPanel2.Controls.Add(this.label2);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 532);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1268, 100);
            this.bunifuPanel2.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(1084, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(68, 37);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "0.00";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(990, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btnExit);
            this.bunifuPanel1.Controls.Add(this.guna2CirclePictureBox1);
            this.bunifuPanel1.Controls.Add(this.lblWaiter);
            this.bunifuPanel1.Controls.Add(this.lblTable);
            this.bunifuPanel1.Controls.Add(this.btnDin);
            this.bunifuPanel1.Controls.Add(this.btnTake);
            this.bunifuPanel1.Controls.Add(this.btnDelivery);
            this.bunifuPanel1.Controls.Add(this.btnHold);
            this.bunifuPanel1.Controls.Add(this.btnNew);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1268, 100);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::ProjectWinForm.Properties.Resources.icons8_shutdown_64;
            this.btnExit.ImageRotate = 0F;
            this.btnExit.Location = new System.Drawing.Point(1192, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnExit.Size = new System.Drawing.Size(64, 64);
            this.btnExit.TabIndex = 12;
            this.btnExit.TabStop = false;
            this.btnExit.UseTransparentBackground = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::ProjectWinForm.Properties.Resources.icons8_restaurant_64;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(12, 16);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(64, 64);
            this.guna2CirclePictureBox1.TabIndex = 11;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.UseTransparentBackground = true;
            // 
            // lblWaiter
            // 
            this.lblWaiter.AutoSize = true;
            this.lblWaiter.BackColor = System.Drawing.Color.Transparent;
            this.lblWaiter.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiter.ForeColor = System.Drawing.Color.White;
            this.lblWaiter.Location = new System.Drawing.Point(674, 53);
            this.lblWaiter.Name = "lblWaiter";
            this.lblWaiter.Size = new System.Drawing.Size(94, 37);
            this.lblWaiter.TabIndex = 9;
            this.lblWaiter.Text = "Waiter";
            this.lblWaiter.Visible = false;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.BackColor = System.Drawing.Color.Transparent;
            this.lblTable.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.White;
            this.lblTable.Location = new System.Drawing.Point(674, 16);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(79, 37);
            this.lblTable.TabIndex = 9;
            this.lblTable.Text = "Table";
            this.lblTable.Visible = false;
            // 
            // btnDin
            // 
            this.btnDin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnDin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnDin.BorderRadius = 10;
            this.btnDin.BorderThickness = 2;
            this.btnDin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnDin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnDin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDin.ForeColor = System.Drawing.Color.White;
            this.btnDin.Image = global::ProjectWinForm.Properties.Resources.icons8_restaurant_table_64;
            this.btnDin.Location = new System.Drawing.Point(590, 12);
            this.btnDin.Name = "btnDin";
            this.btnDin.Size = new System.Drawing.Size(78, 78);
            this.btnDin.TabIndex = 8;
            this.btnDin.Text = "Din In";
            this.btnDin.Click += new System.EventHandler(this.btnDin_Click);
            // 
            // btnTake
            // 
            this.btnTake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnTake.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnTake.BorderRadius = 10;
            this.btnTake.BorderThickness = 2;
            this.btnTake.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnTake.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTake.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTake.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTake.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTake.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnTake.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTake.ForeColor = System.Drawing.Color.White;
            this.btnTake.Image = global::ProjectWinForm.Properties.Resources.icons8_take_away_food_64;
            this.btnTake.Location = new System.Drawing.Point(506, 12);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(78, 78);
            this.btnTake.TabIndex = 7;
            this.btnTake.Text = "Take away";
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnDelivery.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnDelivery.BorderRadius = 10;
            this.btnDelivery.BorderThickness = 2;
            this.btnDelivery.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelivery.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelivery.ForeColor = System.Drawing.Color.White;
            this.btnDelivery.Image = global::ProjectWinForm.Properties.Resources.icons8_delivery_64;
            this.btnDelivery.Location = new System.Drawing.Point(410, 12);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(90, 78);
            this.btnDelivery.TabIndex = 5;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnHold
            // 
            this.btnHold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnHold.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnHold.BorderRadius = 10;
            this.btnHold.BorderThickness = 2;
            this.btnHold.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnHold.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHold.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHold.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHold.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHold.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnHold.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHold.ForeColor = System.Drawing.Color.White;
            this.btnHold.Image = global::ProjectWinForm.Properties.Resources.icons8_hold_64;
            this.btnHold.Location = new System.Drawing.Point(326, 12);
            this.btnHold.Name = "btnHold";
            this.btnHold.Size = new System.Drawing.Size(78, 78);
            this.btnHold.TabIndex = 3;
            this.btnHold.Text = "Hold";
            this.btnHold.Click += new System.EventHandler(this.btnHold_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnNew.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnNew.BorderRadius = 10;
            this.btnNew.BorderThickness = 2;
            this.btnNew.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(55)))), ((int)(((byte)(89)))));
            this.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = global::ProjectWinForm.Properties.Resources.icons8_new_ticket_64;
            this.btnNew.Location = new System.Drawing.Point(242, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(78, 78);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "POS";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ProjectWinForm.Properties.Resources.icons8_edit_64;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 50;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::ProjectWinForm.Properties.Resources.icons8_delete_64;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 50;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // lblDriverName
            // 
            this.lblDriverName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.BackColor = System.Drawing.Color.Transparent;
            this.lblDriverName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDriverName.Location = new System.Drawing.Point(667, 122);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(79, 37);
            this.lblDriverName.TabIndex = 13;
            this.lblDriverName.Text = "Table";
            this.lblDriverName.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.AllowAnimations = true;
            this.btnClear.AllowMouseEffects = true;
            this.btnClear.AllowToggling = false;
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.AnimationSpeed = 200;
            this.btnClear.AutoGenerateColors = false;
            this.btnClear.AutoRoundBorders = true;
            this.btnClear.AutoSizeLeftIcon = true;
            this.btnClear.AutoSizeRightIcon = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.ButtonText = "Clear";
            this.btnClear.ButtonTextMarginLeft = 0;
            this.btnClear.ColorContrastOnClick = 45;
            this.btnClear.ColorContrastOnHover = 45;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = false;
            this.btnClear.CustomizableEdges = borderEdges3;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClear.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnClear.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnClear.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.IconLeft = null;
            this.btnClear.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClear.IconMarginLeft = 11;
            this.btnClear.IconPadding = 10;
            this.btnClear.IconRight = null;
            this.btnClear.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClear.IconSize = 25;
            this.btnClear.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnClear.IdleBorderRadius = 0;
            this.btnClear.IdleBorderThickness = 0;
            this.btnClear.IdleFillColor = System.Drawing.Color.Empty;
            this.btnClear.IdleIconLeftImage = null;
            this.btnClear.IdleIconRightImage = null;
            this.btnClear.IndicateFocus = false;
            this.btnClear.Location = new System.Drawing.Point(758, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClear.OnDisabledState.BorderRadius = 39;
            this.btnClear.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.OnDisabledState.BorderThickness = 1;
            this.btnClear.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnClear.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClear.OnDisabledState.IconLeftImage = null;
            this.btnClear.OnDisabledState.IconRightImage = null;
            this.btnClear.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClear.onHoverState.BorderRadius = 39;
            this.btnClear.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.onHoverState.BorderThickness = 1;
            this.btnClear.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnClear.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClear.onHoverState.IconLeftImage = null;
            this.btnClear.onHoverState.IconRightImage = null;
            this.btnClear.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnClear.OnIdleState.BorderRadius = 39;
            this.btnClear.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.OnIdleState.BorderThickness = 1;
            this.btnClear.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnClear.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClear.OnIdleState.IconLeftImage = null;
            this.btnClear.OnIdleState.IconRightImage = null;
            this.btnClear.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClear.OnPressedState.BorderRadius = 39;
            this.btnClear.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClear.OnPressedState.BorderThickness = 1;
            this.btnClear.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClear.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClear.OnPressedState.IconLeftImage = null;
            this.btnClear.OnPressedState.IconRightImage = null;
            this.btnClear.Size = new System.Drawing.Size(88, 39);
            this.btnClear.TabIndex = 16;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.TextMarginLeft = 0;
            this.btnClear.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClear.UseDefaultRadiusAndThickness = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.AllowAnimations = true;
            this.btnOrder.AllowMouseEffects = true;
            this.btnOrder.AllowToggling = false;
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.AnimationSpeed = 200;
            this.btnOrder.AutoGenerateColors = false;
            this.btnOrder.AutoRoundBorders = true;
            this.btnOrder.AutoSizeLeftIcon = true;
            this.btnOrder.AutoSizeRightIcon = true;
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrder.BackgroundImage")));
            this.btnOrder.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.ButtonText = "Order";
            this.btnOrder.ButtonTextMarginLeft = 0;
            this.btnOrder.ColorContrastOnClick = 45;
            this.btnOrder.ColorContrastOnHover = 45;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = false;
            this.btnOrder.CustomizableEdges = borderEdges2;
            this.btnOrder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOrder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOrder.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnOrder.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnOrder.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.IconLeft = null;
            this.btnOrder.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnOrder.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnOrder.IconMarginLeft = 11;
            this.btnOrder.IconPadding = 10;
            this.btnOrder.IconRight = null;
            this.btnOrder.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrder.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnOrder.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnOrder.IconSize = 25;
            this.btnOrder.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnOrder.IdleBorderRadius = 0;
            this.btnOrder.IdleBorderThickness = 0;
            this.btnOrder.IdleFillColor = System.Drawing.Color.Empty;
            this.btnOrder.IdleIconLeftImage = null;
            this.btnOrder.IdleIconRightImage = null;
            this.btnOrder.IndicateFocus = false;
            this.btnOrder.Location = new System.Drawing.Point(866, 27);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOrder.OnDisabledState.BorderRadius = 39;
            this.btnOrder.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.OnDisabledState.BorderThickness = 1;
            this.btnOrder.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnOrder.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOrder.OnDisabledState.IconLeftImage = null;
            this.btnOrder.OnDisabledState.IconRightImage = null;
            this.btnOrder.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnOrder.onHoverState.BorderRadius = 39;
            this.btnOrder.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.onHoverState.BorderThickness = 1;
            this.btnOrder.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnOrder.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnOrder.onHoverState.IconLeftImage = null;
            this.btnOrder.onHoverState.IconRightImage = null;
            this.btnOrder.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnOrder.OnIdleState.BorderRadius = 39;
            this.btnOrder.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.OnIdleState.BorderThickness = 1;
            this.btnOrder.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnOrder.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnOrder.OnIdleState.IconLeftImage = null;
            this.btnOrder.OnIdleState.IconRightImage = null;
            this.btnOrder.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnOrder.OnPressedState.BorderRadius = 39;
            this.btnOrder.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOrder.OnPressedState.BorderThickness = 1;
            this.btnOrder.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnOrder.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnOrder.OnPressedState.IconLeftImage = null;
            this.btnOrder.OnPressedState.IconRightImage = null;
            this.btnOrder.Size = new System.Drawing.Size(88, 39);
            this.btnOrder.TabIndex = 17;
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOrder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOrder.TextMarginLeft = 0;
            this.btnOrder.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnOrder.UseDefaultRadiusAndThickness = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnHome
            // 
            this.btnHome.AllowAnimations = true;
            this.btnHome.AllowMouseEffects = true;
            this.btnHome.AllowToggling = false;
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHome.AnimationSpeed = 200;
            this.btnHome.AutoGenerateColors = false;
            this.btnHome.AutoRoundBorders = true;
            this.btnHome.AutoSizeLeftIcon = true;
            this.btnHome.AutoSizeRightIcon = true;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHome.ButtonText = "GO Home";
            this.btnHome.ButtonTextMarginLeft = 0;
            this.btnHome.ColorContrastOnClick = 45;
            this.btnHome.ColorContrastOnHover = 45;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = false;
            this.btnHome.CustomizableEdges = borderEdges1;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHome.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHome.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnHome.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnHome.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconLeft = null;
            this.btnHome.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnHome.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnHome.IconMarginLeft = 11;
            this.btnHome.IconPadding = 10;
            this.btnHome.IconRight = null;
            this.btnHome.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnHome.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnHome.IconSize = 25;
            this.btnHome.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnHome.IdleBorderRadius = 0;
            this.btnHome.IdleBorderThickness = 0;
            this.btnHome.IdleFillColor = System.Drawing.Color.Empty;
            this.btnHome.IdleIconLeftImage = null;
            this.btnHome.IdleIconRightImage = null;
            this.btnHome.IndicateFocus = false;
            this.btnHome.Location = new System.Drawing.Point(12, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnHome.OnDisabledState.BorderRadius = 39;
            this.btnHome.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHome.OnDisabledState.BorderThickness = 1;
            this.btnHome.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnHome.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnHome.OnDisabledState.IconLeftImage = null;
            this.btnHome.OnDisabledState.IconRightImage = null;
            this.btnHome.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnHome.onHoverState.BorderRadius = 39;
            this.btnHome.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHome.onHoverState.BorderThickness = 1;
            this.btnHome.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnHome.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnHome.onHoverState.IconLeftImage = null;
            this.btnHome.onHoverState.IconRightImage = null;
            this.btnHome.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnHome.OnIdleState.BorderRadius = 39;
            this.btnHome.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHome.OnIdleState.BorderThickness = 1;
            this.btnHome.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.btnHome.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnHome.OnIdleState.IconLeftImage = null;
            this.btnHome.OnIdleState.IconRightImage = null;
            this.btnHome.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHome.OnPressedState.BorderRadius = 39;
            this.btnHome.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnHome.OnPressedState.BorderThickness = 1;
            this.btnHome.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnHome.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnHome.OnPressedState.IconLeftImage = null;
            this.btnHome.OnPressedState.IconRightImage = null;
            this.btnHome.Size = new System.Drawing.Size(88, 39);
            this.btnHome.TabIndex = 18;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHome.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHome.TextMarginLeft = 0;
            this.btnHome.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnHome.UseDefaultRadiusAndThickness = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // frmPOSuser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1268, 632);
            this.Controls.Add(this.lblDriverName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.CategoryPanel);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPOSuser";
            this.Text = "frmPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPOS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Guna.UI2.WinForms.Guna2TileButton btnDin;
        private Guna.UI2.WinForms.Guna2TileButton btnTake;
        private Guna.UI2.WinForms.Guna2TileButton btnDelivery;
        private Guna.UI2.WinForms.Guna2TileButton btnHold;
        private Guna.UI2.WinForms.Guna2TileButton btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWaiter;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.FlowLayoutPanel CategoryPanel;
        private System.Windows.Forms.FlowLayoutPanel ProductPanel;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        public Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnExit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2MessageDialog guna2MessageDialog1;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvproID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private System.Windows.Forms.DataGridViewImageColumn dgvDel;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOrder;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClear;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnHome;
    }
}