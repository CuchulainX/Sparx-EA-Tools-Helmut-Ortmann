﻿
namespace hoTools.Query
{
    partial class QueryGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryGUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.btnRunScriptForSql = new System.Windows.Forms.Button();
            this.btnRunScriptForSqlWithAsk = new System.Windows.Forms.Button();
            this.dataGridViewScripts = new System.Windows.Forms.DataGridView();
            this.contextMenuStripDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runScriptAndAskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.loadScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.showScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowErrorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlSql = new System.Windows.Forms.TabControl();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnLoadScripts = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTabCTRLLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTabFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lastsqlErrorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastSqlStringSentToEAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.templatesAndMacrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.loadStandardScriptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScripts)).BeginInit();
            this.contextMenuStripDataGrid.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Location = new System.Drawing.Point(394, 3);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(223, 20);
            this.txtSearchTerm.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSearchTerm, resources.GetString("txtSearchTerm.ToolTip"));
            this.txtSearchTerm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchTerm_KeyDown);
            this.txtSearchTerm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchTerm_KeyDown);
            this.txtSearchTerm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSearchTerm_MouseDoubleClick);
            // 
            // btnRunScriptForSql
            // 
            this.btnRunScriptForSql.Location = new System.Drawing.Point(121, 3);
            this.btnRunScriptForSql.Name = "btnRunScriptForSql";
            this.btnRunScriptForSql.Size = new System.Drawing.Size(108, 23);
            this.btnRunScriptForSql.TabIndex = 4;
            this.btnRunScriptForSql.Text = "Run Script";
            this.toolTip1.SetToolTip(this.btnRunScriptForSql, "Run current Query and execute Script for all found Elements (rows)");
            this.btnRunScriptForSql.UseVisualStyleBackColor = true;
            this.btnRunScriptForSql.Click += new System.EventHandler(this.btnRunScriptForSql_Click);
            // 
            // btnRunScriptForSqlWithAsk
            // 
            this.btnRunScriptForSqlWithAsk.Location = new System.Drawing.Point(235, 3);
            this.btnRunScriptForSqlWithAsk.Name = "btnRunScriptForSqlWithAsk";
            this.btnRunScriptForSqlWithAsk.Size = new System.Drawing.Size(123, 23);
            this.btnRunScriptForSqlWithAsk.TabIndex = 8;
            this.btnRunScriptForSqlWithAsk.Text = "Run Script and ask";
            this.toolTip1.SetToolTip(this.btnRunScriptForSqlWithAsk, "Run current / active Query until next found element, execute Script for this elem" +
        "ent and ask to:\r\n- Break\r\n- Execute Script on current row\r\n- Skip current row");
            this.btnRunScriptForSqlWithAsk.UseVisualStyleBackColor = true;
            this.btnRunScriptForSqlWithAsk.Click += new System.EventHandler(this.btnRunScriptForSqlWithAsk_Click);
            // 
            // dataGridViewScripts
            // 
            this.dataGridViewScripts.AllowUserToOrderColumns = true;
            this.dataGridViewScripts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewScripts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewScripts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewScripts.ContextMenuStrip = this.contextMenuStripDataGrid;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewScripts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewScripts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewScripts.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewScripts.Name = "dataGridViewScripts";
            this.dataGridViewScripts.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewScripts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewScripts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewScripts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewScripts.Size = new System.Drawing.Size(767, 146);
            this.dataGridViewScripts.TabIndex = 3;
            this.toolTip1.SetToolTip(this.dataGridViewScripts, resources.GetString("dataGridViewScripts.ToolTip"));
            this.dataGridViewScripts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewScripts_MouseClick);
            // 
            // contextMenuStripDataGrid
            // 
            this.contextMenuStripDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runScriptToolStripMenuItem,
            this.runScriptAndAskToolStripMenuItem,
            this.toolStripSeparator5,
            this.loadScriptsToolStripMenuItem,
            this.toolStripSeparator6,
            this.showScriptToolStripMenuItem,
            this.ShowErrorToolStripMenuItem1});
            this.contextMenuStripDataGrid.Name = "contextMenuStripDataGrid";
            this.contextMenuStripDataGrid.Size = new System.Drawing.Size(331, 126);
            this.contextMenuStripDataGrid.Text = "C";
            this.contextMenuStripDataGrid.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripDataGrid_Opening);
            // 
            // runScriptToolStripMenuItem
            // 
            this.runScriptToolStripMenuItem.Name = "runScriptToolStripMenuItem";
            this.runScriptToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.runScriptToolStripMenuItem.Text = "&Run Script for Query";
            this.runScriptToolStripMenuItem.ToolTipText = "Run current Query and execute Script for all found Elements (rows)";
            this.runScriptToolStripMenuItem.Click += new System.EventHandler(this.btnRunScriptForSql_Click);
            // 
            // runScriptAndAskToolStripMenuItem
            // 
            this.runScriptAndAskToolStripMenuItem.Name = "runScriptAndAskToolStripMenuItem";
            this.runScriptAndAskToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.runScriptAndAskToolStripMenuItem.Text = "Run Script for Query results and ask for each row";
            this.runScriptAndAskToolStripMenuItem.ToolTipText = "Run current / active Query until next found element, execute Script for this elem" +
    "ent and ask to:\r\n- Break\r\n- Execute Script on current row\r\n- Skip current row";
            this.runScriptAndAskToolStripMenuItem.Click += new System.EventHandler(this.btnRunScriptForSqlWithAsk_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(327, 6);
            // 
            // loadScriptsToolStripMenuItem
            // 
            this.loadScriptsToolStripMenuItem.Name = "loadScriptsToolStripMenuItem";
            this.loadScriptsToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.loadScriptsToolStripMenuItem.Text = "Load  Scripts";
            this.loadScriptsToolStripMenuItem.ToolTipText = "Load, compile and show Scripts with:\r\n- Contains string \'EA-Matic\'\r\n- Have 2 or 3" +
    " parameters\r\n- JScript\r\n- vbScript\r\n- JavaScript";
            this.loadScriptsToolStripMenuItem.Click += new System.EventHandler(this.btnLoadScripts_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(327, 6);
            // 
            // showScriptToolStripMenuItem
            // 
            this.showScriptToolStripMenuItem.Name = "showScriptToolStripMenuItem";
            this.showScriptToolStripMenuItem.Size = new System.Drawing.Size(330, 22);
            this.showScriptToolStripMenuItem.Text = "&ShowScript";
            this.showScriptToolStripMenuItem.Click += new System.EventHandler(this.showScriptToolStripMenuItem_Click);
            // 
            // ShowErrorToolStripMenuItem1
            // 
            this.ShowErrorToolStripMenuItem1.Name = "ShowErrorToolStripMenuItem1";
            this.ShowErrorToolStripMenuItem1.Size = new System.Drawing.Size(330, 22);
            this.ShowErrorToolStripMenuItem1.Text = "Show&Script Error";
            this.ShowErrorToolStripMenuItem1.ToolTipText = "Show errors of Script.\r\n\r\nNote:\r\n1. Some errors results in not showing in this li" +
    "st\r\n2. Just run Script in EA to check for errors";
            this.ShowErrorToolStripMenuItem1.Click += new System.EventHandler(this.ShowScriptErrorToolStripMenuItem_Click);
            // 
            // tabControlSql
            // 
            this.tabControlSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSql.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlSql.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSql.HotTrack = true;
            this.tabControlSql.ItemSize = new System.Drawing.Size(0, 18);
            this.tabControlSql.Location = new System.Drawing.Point(0, 0);
            this.tabControlSql.Multiline = true;
            this.tabControlSql.Name = "tabControlSql";
            this.tabControlSql.SelectedIndex = 0;
            this.tabControlSql.ShowToolTips = true;
            this.tabControlSql.Size = new System.Drawing.Size(767, 332);
            this.tabControlSql.TabIndex = 5;
            this.toolTip1.SetToolTip(this.tabControlSql, "Enter SQL code. EA macros like:\r\n- #Branch#\r\n- #ObjectID#\r\n- #ObjectGUID#\r\n- #Pac" +
        "kage#\r\n- \'Search Term\'\r\n\r\nare allowed.");
            this.tabControlSql.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControlSql_DrawItem);
            this.tabControlSql.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabControlSql_DragDrop);
            this.tabControlSql.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabControlSql_DragEnter);
            this.tabControlSql.DragOver += new System.Windows.Forms.DragEventHandler(this.splitContainer_DragOver);
            this.tabControlSql.DragLeave += new System.EventHandler(this.tabControlSql_DragLeave);
            this.tabControlSql.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControlSql_MouseDown);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::hoTools.Query.Properties.Resources.icon_undo_h;
            this.btnUndo.Location = new System.Drawing.Point(290, 3);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(32, 23);
            this.btnUndo.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnUndo, "Undo Text change (CTRL+Z)");
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.Image = global::hoTools.Query.Properties.Resources.icon_redo_h;
            this.btnRedo.Location = new System.Drawing.Point(328, 3);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(31, 23);
            this.btnRedo.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnRedo, "Redo Text change (CTRL+Y)");
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSave.Location = new System.Drawing.Point(176, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 32);
            this.btnSave.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnSave, "Save active SQL Tabs at its current location (CTRL+S). If unsaved you are asked t" +
        "o choose a location.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAll.Image")));
            this.btnSaveAll.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveAll.Location = new System.Drawing.Point(214, 3);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(32, 32);
            this.btnSaveAll.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnSaveAll, "Save all SQL Tabs at their current location (CTRL+SHFT+S). If unsaved Tabs you ar" +
        "e asked to choose a location.\r\n");
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.Image")));
            this.btnSaveAs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveAs.Location = new System.Drawing.Point(252, 3);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(32, 32);
            this.btnSaveAs.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnSaveAs, "Save SQL Tabs AS ...\r\n\r\nSave it to a choosable *.sql file location.");
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnRun
            // 
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.Location = new System.Drawing.Point(365, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(23, 23);
            this.btnRun.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnRun, "Run SQL of the current Tab (CTRL+R).\r\n\r\nIn case of Errors: Help, Last sql Error!\r" +
        "\nYou want to see the SQL after replacing macros: Help, Last sql string sent to E" +
        "A");
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnLoadScripts
            // 
            this.btnLoadScripts.Location = new System.Drawing.Point(3, 3);
            this.btnLoadScripts.Name = "btnLoadScripts";
            this.btnLoadScripts.Size = new System.Drawing.Size(112, 23);
            this.btnLoadScripts.TabIndex = 2;
            this.btnLoadScripts.Text = "Load Scripts";
            this.toolTip1.SetToolTip(this.btnLoadScripts, "Load, compile and show Scripts with:\r\n- Contains string \'EA-Matic\'\r\n- Have 2 or 3" +
        " parameters\r\n- No errors in Script (just run Script in EA to see errors)\r\n- JScr" +
        "ipt\r\n- vbScript\r\n- JavaScript");
            this.btnLoadScripts.UseVisualStyleBackColor = true;
            this.btnLoadScripts.Click += new System.EventHandler(this.btnLoadScripts_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 38);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Scripts && Queries";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(173, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTabCTRLLToolStripMenuItem,
            this.loadTabFromToolStripMenuItem,
            this.toolStripSeparator2,
            this.newTabToolStripMenuItem,
            this.newTabFromToolStripMenuItem,
            this.toolStripSeparator1,
            this.runToolStripMenuItem,
            this.toolStripSeparator3,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.toolStripSeparator4,
            this.settingsToolStripMenuItem,
            this.loadStandardScriptsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(33, 20);
            this.fileToolStripMenuItem.Text = "&File";
            this.fileToolStripMenuItem.ToolTipText = "Create a new Tab from recent *.sql files";
            // 
            // loadTabCTRLLToolStripMenuItem
            // 
            this.loadTabCTRLLToolStripMenuItem.Name = "loadTabCTRLLToolStripMenuItem";
            this.loadTabCTRLLToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.loadTabCTRLLToolStripMenuItem.Text = "&Load Tab (CTRL+L)";
            this.loadTabCTRLLToolStripMenuItem.Click += new System.EventHandler(this.loadTabCTRLLToolStripMenuItem_Click);
            // 
            // loadTabFromToolStripMenuItem
            // 
            this.loadTabFromToolStripMenuItem.Name = "loadTabFromToolStripMenuItem";
            this.loadTabFromToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.loadTabFromToolStripMenuItem.Text = "Load Tab from...  ";
            this.loadTabFromToolStripMenuItem.ToolTipText = "Load current Tab from recent file.";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.newTabToolStripMenuItem.Text = "&NewTab ";
            this.newTabToolStripMenuItem.ToolTipText = "New empty tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.FileNewTabToolStripMenuItem_Click);
            // 
            // newTabFromToolStripMenuItem
            // 
            this.newTabFromToolStripMenuItem.Name = "newTabFromToolStripMenuItem";
            this.newTabFromToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.newTabFromToolStripMenuItem.Text = "New Tab from...";
            this.newTabFromToolStripMenuItem.ToolTipText = "New Tab from recent file.";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.runToolStripMenuItem.Text = "Run (CTRL+R)";
            this.runToolStripMenuItem.ToolTipText = "Run SQL of the current Tab (CTRL+R).\r\n\r\nIn case of Errors: Help, Last sql Error!\r" +
    "\nYou want to see the SQL after replacing macros: Help, Last sql string sent to E" +
    "A";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runSqlTabToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(201, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveToolStripMenuItem.Text = "&Save (CTRL+S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveSqlTabToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveAsToolStripMenuItem.Text = "Save As..";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveSqlTabAsToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveAllToolStripMenuItem.Text = "Save All (CTRL+SHFT+S)";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(201, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.ToolTipText = "View and change settings of Scripts and Queries";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem1,
            this.lastsqlErrorToolStripMenuItem,
            this.lastSqlStringSentToEAToolStripMenuItem,
            this.templatesAndMacrosToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(202, 22);
            this.helpToolStripMenuItem1.Text = "&Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // lastsqlErrorToolStripMenuItem
            // 
            this.lastsqlErrorToolStripMenuItem.Name = "lastsqlErrorToolStripMenuItem";
            this.lastsqlErrorToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.lastsqlErrorToolStripMenuItem.Text = "Last &sql error";
            this.lastsqlErrorToolStripMenuItem.ToolTipText = "Get the last EA sql error from %APPDATA%Sparx Systems\\EA\\DBError.txt";
            this.lastsqlErrorToolStripMenuItem.Click += new System.EventHandler(this.showSqlErrorToolStripMenuItem_Click);
            // 
            // lastSqlStringSentToEAToolStripMenuItem
            // 
            this.lastSqlStringSentToEAToolStripMenuItem.Name = "lastSqlStringSentToEAToolStripMenuItem";
            this.lastSqlStringSentToEAToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.lastSqlStringSentToEAToolStripMenuItem.Text = "Last sql string sent to EA";
            this.lastSqlStringSentToEAToolStripMenuItem.ToolTipText = "Get the last sql string sent by hoTools Query\r\nto EA.\r\n%APPDATA%Sparx Systems\\EA\\" +
    "hoTools_LastSql.sql";
            this.lastSqlStringSentToEAToolStripMenuItem.Click += new System.EventHandler(this.lastSqlStringSentToEAToolStripMenuItem_Click);
            // 
            // templatesAndMacrosToolStripMenuItem
            // 
            this.templatesAndMacrosToolStripMenuItem.Name = "templatesAndMacrosToolStripMenuItem";
            this.templatesAndMacrosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.templatesAndMacrosToolStripMenuItem.Text = "Templates and macros";
            this.templatesAndMacrosToolStripMenuItem.ToolTipText = "View Templates and Macors in Editor";
            this.templatesAndMacrosToolStripMenuItem.Click += new System.EventHandler(this.templatesAndMacrosToolStripMenuItem_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 25);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tabControlSql);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dataGridViewScripts);
            this.splitContainer.Panel2.Controls.Add(this.flowLayoutPanel4);
            this.splitContainer.Size = new System.Drawing.Size(769, 513);
            this.splitContainer.SplitterDistance = 334;
            this.splitContainer.SplitterWidth = 6;
            this.splitContainer.TabIndex = 9;
            this.splitContainer.DragDrop += new System.Windows.Forms.DragEventHandler(this.splitContainer_DragDrop);
            this.splitContainer.DragOver += new System.Windows.Forms.DragEventHandler(this.splitContainer_DragOver);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.btnLoadScripts);
            this.flowLayoutPanel4.Controls.Add(this.btnRunScriptForSql);
            this.flowLayoutPanel4.Controls.Add(this.btnRunScriptForSqlWithAsk);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 146);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(767, 25);
            this.flowLayoutPanel4.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.menuStrip1);
            this.flowLayoutPanel2.Controls.Add(this.btnSave);
            this.flowLayoutPanel2.Controls.Add(this.btnSaveAll);
            this.flowLayoutPanel2.Controls.Add(this.btnSaveAs);
            this.flowLayoutPanel2.Controls.Add(this.btnUndo);
            this.flowLayoutPanel2.Controls.Add(this.btnRedo);
            this.flowLayoutPanel2.Controls.Add(this.btnRun);
            this.flowLayoutPanel2.Controls.Add(this.txtSearchTerm);
            this.flowLayoutPanel2.Controls.Add(this.lblTitle);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(769, 25);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // loadStandardScriptsToolStripMenuItem
            // 
            this.loadStandardScriptsToolStripMenuItem.Name = "loadStandardScriptsToolStripMenuItem";
            this.loadStandardScriptsToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.loadStandardScriptsToolStripMenuItem.Text = "LoadStandardScripts";
            this.loadStandardScriptsToolStripMenuItem.Click += new System.EventHandler(this.loadStandardScriptsToolStripMenuItem_Click);
            // 
            // QueryGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "QueryGUI";
            this.Size = new System.Drawing.Size(769, 538);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewScripts)).EndInit();
            this.contextMenuStripDataGrid.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLoadScripts;
        private System.Windows.Forms.DataGridView dataGridViewScripts;
        private System.Windows.Forms.Button btnRunScriptForSql;
        private System.Windows.Forms.TabControl tabControlSql;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataGrid;
        private System.Windows.Forms.ToolStripMenuItem ShowErrorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem runScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showScriptToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Button btnRunScriptForSqlWithAsk;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastsqlErrorToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ToolStripMenuItem loadTabFromToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTabFromToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.ToolStripMenuItem lastSqlStringSentToEAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTabCTRLLToolStripMenuItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAll;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ToolStripMenuItem templatesAndMacrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runScriptAndAskToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem loadScriptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem loadStandardScriptsToolStripMenuItem;
    }
}
