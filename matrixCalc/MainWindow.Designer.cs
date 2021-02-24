
namespace matrixCalc
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.actionsBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.copyBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.fromAToBBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.fromBToABtn = new System.Windows.Forms.ToolStripMenuItem();
            this.associateMtrxExtensionBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.ToolStripButton();
            this.grpBox_A = new System.Windows.Forms.GroupBox();
            this.grpBox_actions_A = new System.Windows.Forms.GroupBox();
            this.btnPowA = new System.Windows.Forms.Button();
            this.txtPowA = new System.Windows.Forms.TextBox();
            this.lblPowA = new System.Windows.Forms.Label();
            this.btnMultiplyA = new System.Windows.Forms.Button();
            this.txtMultiplyA = new System.Windows.Forms.TextBox();
            this.lblMultiplyA = new System.Windows.Forms.Label();
            this.transposedA = new System.Windows.Forms.Button();
            this.reverseA = new System.Windows.Forms.Button();
            this.triangularA = new System.Windows.Forms.Button();
            this.txtRankA = new System.Windows.Forms.TextBox();
            this.RankABtn = new System.Windows.Forms.Button();
            this.txtDetA = new System.Windows.Forms.TextBox();
            this.detABtn = new System.Windows.Forms.Button();
            this.createTableA = new System.Windows.Forms.Button();
            this.txtColumnCount1 = new System.Windows.Forms.TextBox();
            this.lblColumnCount1 = new System.Windows.Forms.Label();
            this.txtRowCount1 = new System.Windows.Forms.TextBox();
            this.lblRowCount1 = new System.Windows.Forms.Label();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.grpBox_B = new System.Windows.Forms.GroupBox();
            this.grpBox_actions_B = new System.Windows.Forms.GroupBox();
            this.btnPowB = new System.Windows.Forms.Button();
            this.txtPowB = new System.Windows.Forms.TextBox();
            this.lblPowB = new System.Windows.Forms.Label();
            this.btnMultiplyB = new System.Windows.Forms.Button();
            this.txtMultiplyB = new System.Windows.Forms.TextBox();
            this.lblMultiplyB = new System.Windows.Forms.Label();
            this.transposedB = new System.Windows.Forms.Button();
            this.reverseB = new System.Windows.Forms.Button();
            this.triangularB = new System.Windows.Forms.Button();
            this.txtRankB = new System.Windows.Forms.TextBox();
            this.RankBBtn = new System.Windows.Forms.Button();
            this.txtDetB = new System.Windows.Forms.TextBox();
            this.detBBtn = new System.Windows.Forms.Button();
            this.createTableB = new System.Windows.Forms.Button();
            this.txtColumnCount2 = new System.Windows.Forms.TextBox();
            this.lblColumnCount2 = new System.Windows.Forms.Label();
            this.txtRowCount2 = new System.Windows.Forms.TextBox();
            this.lblRowCount2 = new System.Windows.Forms.Label();
            this.DGV2 = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.swapBtn = new System.Windows.Forms.Button();
            this.additionBtn = new System.Windows.Forms.Button();
            this.substractBtn = new System.Windows.Forms.Button();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip.SuspendLayout();
            this.grpBox_A.SuspendLayout();
            this.grpBox_actions_A.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.grpBox_B.SuspendLayout();
            this.grpBox_actions_B.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.actionsBtn,
            this.exitBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(784, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBtn,
            this.saveBtn,
            this.saveAsBtn});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.ShowDropDownArrow = false;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // openBtn
            // 
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(123, 22);
            this.openBtn.Text = "Open";
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(123, 22);
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // saveAsBtn
            // 
            this.saveAsBtn.Enabled = false;
            this.saveAsBtn.Name = "saveAsBtn";
            this.saveAsBtn.Size = new System.Drawing.Size(123, 22);
            this.saveAsBtn.Text = "Save As...";
            this.saveAsBtn.Click += new System.EventHandler(this.saveAsBtn_Click);
            // 
            // actionsBtn
            // 
            this.actionsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.actionsBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyBtn,
            this.associateMtrxExtensionBtn});
            this.actionsBtn.Image = ((System.Drawing.Image)(resources.GetObject("actionsBtn.Image")));
            this.actionsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actionsBtn.Name = "actionsBtn";
            this.actionsBtn.ShowDropDownArrow = false;
            this.actionsBtn.Size = new System.Drawing.Size(46, 22);
            this.actionsBtn.Text = "Action";
            // 
            // copyBtn
            // 
            this.copyBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromAToBBtn,
            this.fromBToABtn});
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(215, 22);
            this.copyBtn.Text = "Copy";
            // 
            // fromAToBBtn
            // 
            this.fromAToBBtn.Name = "fromAToBBtn";
            this.fromAToBBtn.Size = new System.Drawing.Size(135, 22);
            this.fromAToBBtn.Text = "from A to B";
            // 
            // fromBToABtn
            // 
            this.fromBToABtn.Name = "fromBToABtn";
            this.fromBToABtn.Size = new System.Drawing.Size(135, 22);
            this.fromBToABtn.Text = "from B to A";
            // 
            // associateMtrxExtensionBtn
            // 
            this.associateMtrxExtensionBtn.Name = "associateMtrxExtensionBtn";
            this.associateMtrxExtensionBtn.Size = new System.Drawing.Size(215, 22);
            this.associateMtrxExtensionBtn.Text = "Associate \'.mtrx\' extension";
            this.associateMtrxExtensionBtn.Click += new System.EventHandler(this.associateMtrxExtensionBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(34, 22);
            this.exitBtn.Text = "Quit";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // grpBox_A
            // 
            this.grpBox_A.Controls.Add(this.grpBox_actions_A);
            this.grpBox_A.Controls.Add(this.DGV1);
            this.grpBox_A.Location = new System.Drawing.Point(12, 28);
            this.grpBox_A.Name = "grpBox_A";
            this.grpBox_A.Size = new System.Drawing.Size(330, 538);
            this.grpBox_A.TabIndex = 1;
            this.grpBox_A.TabStop = false;
            this.grpBox_A.Text = "Matrix A";
            // 
            // grpBox_actions_A
            // 
            this.grpBox_actions_A.Controls.Add(this.btnPowA);
            this.grpBox_actions_A.Controls.Add(this.txtPowA);
            this.grpBox_actions_A.Controls.Add(this.lblPowA);
            this.grpBox_actions_A.Controls.Add(this.btnMultiplyA);
            this.grpBox_actions_A.Controls.Add(this.txtMultiplyA);
            this.grpBox_actions_A.Controls.Add(this.lblMultiplyA);
            this.grpBox_actions_A.Controls.Add(this.transposedA);
            this.grpBox_actions_A.Controls.Add(this.reverseA);
            this.grpBox_actions_A.Controls.Add(this.triangularA);
            this.grpBox_actions_A.Controls.Add(this.txtRankA);
            this.grpBox_actions_A.Controls.Add(this.RankABtn);
            this.grpBox_actions_A.Controls.Add(this.txtDetA);
            this.grpBox_actions_A.Controls.Add(this.detABtn);
            this.grpBox_actions_A.Controls.Add(this.createTableA);
            this.grpBox_actions_A.Controls.Add(this.txtColumnCount1);
            this.grpBox_actions_A.Controls.Add(this.lblColumnCount1);
            this.grpBox_actions_A.Controls.Add(this.txtRowCount1);
            this.grpBox_actions_A.Controls.Add(this.lblRowCount1);
            this.grpBox_actions_A.Location = new System.Drawing.Point(6, 344);
            this.grpBox_actions_A.Name = "grpBox_actions_A";
            this.grpBox_actions_A.Size = new System.Drawing.Size(317, 188);
            this.grpBox_actions_A.TabIndex = 3;
            this.grpBox_actions_A.TabStop = false;
            this.grpBox_actions_A.Text = "Matrix A Actions";
            // 
            // btnPowA
            // 
            this.btnPowA.Location = new System.Drawing.Point(155, 159);
            this.btnPowA.Name = "btnPowA";
            this.btnPowA.Size = new System.Drawing.Size(156, 23);
            this.btnPowA.TabIndex = 17;
            this.btnPowA.Text = "Equals";
            this.btnPowA.UseVisualStyleBackColor = true;
            this.btnPowA.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // txtPowA
            // 
            this.txtPowA.Location = new System.Drawing.Point(87, 161);
            this.txtPowA.Name = "txtPowA";
            this.txtPowA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPowA.Size = new System.Drawing.Size(62, 20);
            this.txtPowA.TabIndex = 16;
            this.txtPowA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPowA
            // 
            this.lblPowA.AutoSize = true;
            this.lblPowA.Location = new System.Drawing.Point(6, 168);
            this.lblPowA.Name = "lblPowA";
            this.lblPowA.Size = new System.Drawing.Size(83, 13);
            this.lblPowA.TabIndex = 0;
            this.lblPowA.Text = "A ^ x, where x =";
            // 
            // btnMultiplyA
            // 
            this.btnMultiplyA.Location = new System.Drawing.Point(155, 133);
            this.btnMultiplyA.Name = "btnMultiplyA";
            this.btnMultiplyA.Size = new System.Drawing.Size(156, 23);
            this.btnMultiplyA.TabIndex = 15;
            this.btnMultiplyA.Text = "Equals";
            this.btnMultiplyA.UseVisualStyleBackColor = true;
            this.btnMultiplyA.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // txtMultiplyA
            // 
            this.txtMultiplyA.Location = new System.Drawing.Point(87, 135);
            this.txtMultiplyA.Name = "txtMultiplyA";
            this.txtMultiplyA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMultiplyA.Size = new System.Drawing.Size(62, 20);
            this.txtMultiplyA.TabIndex = 14;
            this.txtMultiplyA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMultiplyA
            // 
            this.lblMultiplyA.AutoSize = true;
            this.lblMultiplyA.Location = new System.Drawing.Point(6, 142);
            this.lblMultiplyA.Name = "lblMultiplyA";
            this.lblMultiplyA.Size = new System.Drawing.Size(81, 13);
            this.lblMultiplyA.TabIndex = 0;
            this.lblMultiplyA.Text = "A * x, where x =";
            // 
            // transposedA
            // 
            this.transposedA.Location = new System.Drawing.Point(212, 104);
            this.transposedA.Name = "transposedA";
            this.transposedA.Size = new System.Drawing.Size(99, 23);
            this.transposedA.TabIndex = 13;
            this.transposedA.Text = "Transposed";
            this.transposedA.UseVisualStyleBackColor = true;
            this.transposedA.Click += new System.EventHandler(this.transposed_Click);
            // 
            // reverseA
            // 
            this.reverseA.Location = new System.Drawing.Point(109, 104);
            this.reverseA.Name = "reverseA";
            this.reverseA.Size = new System.Drawing.Size(99, 23);
            this.reverseA.TabIndex = 12;
            this.reverseA.Text = "Reverse";
            this.reverseA.UseVisualStyleBackColor = true;
            this.reverseA.Click += new System.EventHandler(this.reverse_Click);
            // 
            // triangularA
            // 
            this.triangularA.Location = new System.Drawing.Point(6, 104);
            this.triangularA.Name = "triangularA";
            this.triangularA.Size = new System.Drawing.Size(99, 23);
            this.triangularA.TabIndex = 11;
            this.triangularA.Text = "Triangular";
            this.triangularA.UseVisualStyleBackColor = true;
            this.triangularA.Click += new System.EventHandler(this.triangular_Click);
            // 
            // txtRankA
            // 
            this.txtRankA.BackColor = System.Drawing.SystemColors.Window;
            this.txtRankA.Location = new System.Drawing.Point(236, 77);
            this.txtRankA.Name = "txtRankA";
            this.txtRankA.ReadOnly = true;
            this.txtRankA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRankA.Size = new System.Drawing.Size(75, 20);
            this.txtRankA.TabIndex = 10;
            this.txtRankA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RankABtn
            // 
            this.RankABtn.Location = new System.Drawing.Point(155, 63);
            this.RankABtn.Name = "RankABtn";
            this.RankABtn.Size = new System.Drawing.Size(75, 35);
            this.RankABtn.TabIndex = 9;
            this.RankABtn.Text = "Rank(A)";
            this.RankABtn.UseVisualStyleBackColor = true;
            this.RankABtn.Click += new System.EventHandler(this.RankBtn_Click);
            // 
            // txtDetA
            // 
            this.txtDetA.BackColor = System.Drawing.SystemColors.Window;
            this.txtDetA.Location = new System.Drawing.Point(87, 78);
            this.txtDetA.Name = "txtDetA";
            this.txtDetA.ReadOnly = true;
            this.txtDetA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDetA.Size = new System.Drawing.Size(62, 20);
            this.txtDetA.TabIndex = 8;
            this.txtDetA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // detABtn
            // 
            this.detABtn.Location = new System.Drawing.Point(6, 63);
            this.detABtn.Name = "detABtn";
            this.detABtn.Size = new System.Drawing.Size(75, 35);
            this.detABtn.TabIndex = 7;
            this.detABtn.Text = "det(A)";
            this.detABtn.UseVisualStyleBackColor = true;
            this.detABtn.Click += new System.EventHandler(this.detBtn_Click);
            // 
            // createTableA
            // 
            this.createTableA.Location = new System.Drawing.Point(218, 20);
            this.createTableA.Name = "createTableA";
            this.createTableA.Size = new System.Drawing.Size(93, 37);
            this.createTableA.TabIndex = 6;
            this.createTableA.Text = "Create Table";
            this.createTableA.UseVisualStyleBackColor = true;
            this.createTableA.Click += new System.EventHandler(this.createTable_Click);
            // 
            // txtColumnCount1
            // 
            this.txtColumnCount1.Location = new System.Drawing.Point(112, 36);
            this.txtColumnCount1.Name = "txtColumnCount1";
            this.txtColumnCount1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtColumnCount1.Size = new System.Drawing.Size(100, 20);
            this.txtColumnCount1.TabIndex = 5;
            this.txtColumnCount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblColumnCount1
            // 
            this.lblColumnCount1.AutoSize = true;
            this.lblColumnCount1.Location = new System.Drawing.Point(112, 20);
            this.lblColumnCount1.Name = "lblColumnCount1";
            this.lblColumnCount1.Size = new System.Drawing.Size(82, 13);
            this.lblColumnCount1.TabIndex = 0;
            this.lblColumnCount1.Text = "Column Number";
            // 
            // txtRowCount1
            // 
            this.txtRowCount1.Location = new System.Drawing.Point(6, 36);
            this.txtRowCount1.Name = "txtRowCount1";
            this.txtRowCount1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRowCount1.Size = new System.Drawing.Size(100, 20);
            this.txtRowCount1.TabIndex = 4;
            this.txtRowCount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRowCount1
            // 
            this.lblRowCount1.AutoSize = true;
            this.lblRowCount1.Location = new System.Drawing.Point(6, 20);
            this.lblRowCount1.Name = "lblRowCount1";
            this.lblRowCount1.Size = new System.Drawing.Size(69, 13);
            this.lblRowCount1.TabIndex = 0;
            this.lblRowCount1.Text = "Row Number";
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.AllowUserToResizeRows = false;
            this.DGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV1.BackgroundColor = System.Drawing.Color.White;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(6, 20);
            this.DGV1.Name = "DGV1";
            this.DGV1.Size = new System.Drawing.Size(317, 317);
            this.DGV1.TabIndex = 2;
            // 
            // grpBox_B
            // 
            this.grpBox_B.Controls.Add(this.grpBox_actions_B);
            this.grpBox_B.Controls.Add(this.DGV2);
            this.grpBox_B.Location = new System.Drawing.Point(442, 28);
            this.grpBox_B.Name = "grpBox_B";
            this.grpBox_B.Size = new System.Drawing.Size(330, 538);
            this.grpBox_B.TabIndex = 18;
            this.grpBox_B.TabStop = false;
            this.grpBox_B.Text = "Matrix B";
            // 
            // grpBox_actions_B
            // 
            this.grpBox_actions_B.Controls.Add(this.btnPowB);
            this.grpBox_actions_B.Controls.Add(this.txtPowB);
            this.grpBox_actions_B.Controls.Add(this.lblPowB);
            this.grpBox_actions_B.Controls.Add(this.btnMultiplyB);
            this.grpBox_actions_B.Controls.Add(this.txtMultiplyB);
            this.grpBox_actions_B.Controls.Add(this.lblMultiplyB);
            this.grpBox_actions_B.Controls.Add(this.transposedB);
            this.grpBox_actions_B.Controls.Add(this.reverseB);
            this.grpBox_actions_B.Controls.Add(this.triangularB);
            this.grpBox_actions_B.Controls.Add(this.txtRankB);
            this.grpBox_actions_B.Controls.Add(this.RankBBtn);
            this.grpBox_actions_B.Controls.Add(this.txtDetB);
            this.grpBox_actions_B.Controls.Add(this.detBBtn);
            this.grpBox_actions_B.Controls.Add(this.createTableB);
            this.grpBox_actions_B.Controls.Add(this.txtColumnCount2);
            this.grpBox_actions_B.Controls.Add(this.lblColumnCount2);
            this.grpBox_actions_B.Controls.Add(this.txtRowCount2);
            this.grpBox_actions_B.Controls.Add(this.lblRowCount2);
            this.grpBox_actions_B.Location = new System.Drawing.Point(6, 344);
            this.grpBox_actions_B.Name = "grpBox_actions_B";
            this.grpBox_actions_B.Size = new System.Drawing.Size(317, 188);
            this.grpBox_actions_B.TabIndex = 20;
            this.grpBox_actions_B.TabStop = false;
            this.grpBox_actions_B.Text = "Matrix B Actions";
            // 
            // btnPowB
            // 
            this.btnPowB.Location = new System.Drawing.Point(155, 159);
            this.btnPowB.Name = "btnPowB";
            this.btnPowB.Size = new System.Drawing.Size(156, 23);
            this.btnPowB.TabIndex = 33;
            this.btnPowB.Text = "Equals";
            this.btnPowB.UseVisualStyleBackColor = true;
            this.btnPowB.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // txtPowB
            // 
            this.txtPowB.Location = new System.Drawing.Point(87, 161);
            this.txtPowB.Name = "txtPowB";
            this.txtPowB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPowB.Size = new System.Drawing.Size(62, 20);
            this.txtPowB.TabIndex = 32;
            this.txtPowB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPowB
            // 
            this.lblPowB.AutoSize = true;
            this.lblPowB.Location = new System.Drawing.Point(6, 168);
            this.lblPowB.Name = "lblPowB";
            this.lblPowB.Size = new System.Drawing.Size(83, 13);
            this.lblPowB.TabIndex = 0;
            this.lblPowB.Text = "B ^ x, where x =";
            // 
            // btnMultiplyB
            // 
            this.btnMultiplyB.Location = new System.Drawing.Point(155, 133);
            this.btnMultiplyB.Name = "btnMultiplyB";
            this.btnMultiplyB.Size = new System.Drawing.Size(156, 23);
            this.btnMultiplyB.TabIndex = 31;
            this.btnMultiplyB.Text = "Equals";
            this.btnMultiplyB.UseVisualStyleBackColor = true;
            this.btnMultiplyB.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // txtMultiplyB
            // 
            this.txtMultiplyB.Location = new System.Drawing.Point(87, 135);
            this.txtMultiplyB.Name = "txtMultiplyB";
            this.txtMultiplyB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMultiplyB.Size = new System.Drawing.Size(62, 20);
            this.txtMultiplyB.TabIndex = 30;
            this.txtMultiplyB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMultiplyB
            // 
            this.lblMultiplyB.AutoSize = true;
            this.lblMultiplyB.Location = new System.Drawing.Point(6, 142);
            this.lblMultiplyB.Name = "lblMultiplyB";
            this.lblMultiplyB.Size = new System.Drawing.Size(81, 13);
            this.lblMultiplyB.TabIndex = 0;
            this.lblMultiplyB.Text = "B * x, where x =";
            // 
            // transposedB
            // 
            this.transposedB.Location = new System.Drawing.Point(212, 104);
            this.transposedB.Name = "transposedB";
            this.transposedB.Size = new System.Drawing.Size(99, 23);
            this.transposedB.TabIndex = 29;
            this.transposedB.Text = "Transposed";
            this.transposedB.UseVisualStyleBackColor = true;
            this.transposedB.Click += new System.EventHandler(this.transposed_Click);
            // 
            // reverseB
            // 
            this.reverseB.Location = new System.Drawing.Point(109, 104);
            this.reverseB.Name = "reverseB";
            this.reverseB.Size = new System.Drawing.Size(99, 23);
            this.reverseB.TabIndex = 28;
            this.reverseB.Text = "Reverse";
            this.reverseB.UseVisualStyleBackColor = true;
            this.reverseB.Click += new System.EventHandler(this.reverse_Click);
            // 
            // triangularB
            // 
            this.triangularB.Location = new System.Drawing.Point(6, 104);
            this.triangularB.Name = "triangularB";
            this.triangularB.Size = new System.Drawing.Size(99, 23);
            this.triangularB.TabIndex = 27;
            this.triangularB.Text = "Triangular";
            this.triangularB.UseVisualStyleBackColor = true;
            this.triangularB.Click += new System.EventHandler(this.triangular_Click);
            // 
            // txtRankB
            // 
            this.txtRankB.BackColor = System.Drawing.SystemColors.Window;
            this.txtRankB.Location = new System.Drawing.Point(236, 77);
            this.txtRankB.Name = "txtRankB";
            this.txtRankB.ReadOnly = true;
            this.txtRankB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRankB.Size = new System.Drawing.Size(75, 20);
            this.txtRankB.TabIndex = 26;
            this.txtRankB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RankBBtn
            // 
            this.RankBBtn.Location = new System.Drawing.Point(155, 63);
            this.RankBBtn.Name = "RankBBtn";
            this.RankBBtn.Size = new System.Drawing.Size(75, 35);
            this.RankBBtn.TabIndex = 25;
            this.RankBBtn.Text = "Rank(A)";
            this.RankBBtn.UseVisualStyleBackColor = true;
            this.RankBBtn.Click += new System.EventHandler(this.RankBtn_Click);
            // 
            // txtDetB
            // 
            this.txtDetB.BackColor = System.Drawing.SystemColors.Window;
            this.txtDetB.Location = new System.Drawing.Point(87, 78);
            this.txtDetB.Name = "txtDetB";
            this.txtDetB.ReadOnly = true;
            this.txtDetB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDetB.Size = new System.Drawing.Size(62, 20);
            this.txtDetB.TabIndex = 24;
            this.txtDetB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // detBBtn
            // 
            this.detBBtn.Location = new System.Drawing.Point(6, 63);
            this.detBBtn.Name = "detBBtn";
            this.detBBtn.Size = new System.Drawing.Size(75, 35);
            this.detBBtn.TabIndex = 23;
            this.detBBtn.Text = "det(A)";
            this.detBBtn.UseVisualStyleBackColor = true;
            this.detBBtn.Click += new System.EventHandler(this.detBtn_Click);
            // 
            // createTableB
            // 
            this.createTableB.Location = new System.Drawing.Point(218, 20);
            this.createTableB.Name = "createTableB";
            this.createTableB.Size = new System.Drawing.Size(93, 37);
            this.createTableB.TabIndex = 22;
            this.createTableB.Text = "Create Table";
            this.createTableB.UseVisualStyleBackColor = true;
            this.createTableB.Click += new System.EventHandler(this.createTable_Click);
            // 
            // txtColumnCount2
            // 
            this.txtColumnCount2.Location = new System.Drawing.Point(112, 36);
            this.txtColumnCount2.Name = "txtColumnCount2";
            this.txtColumnCount2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtColumnCount2.Size = new System.Drawing.Size(100, 20);
            this.txtColumnCount2.TabIndex = 21;
            this.txtColumnCount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblColumnCount2
            // 
            this.lblColumnCount2.AutoSize = true;
            this.lblColumnCount2.Location = new System.Drawing.Point(112, 20);
            this.lblColumnCount2.Name = "lblColumnCount2";
            this.lblColumnCount2.Size = new System.Drawing.Size(82, 13);
            this.lblColumnCount2.TabIndex = 0;
            this.lblColumnCount2.Text = "Column Number";
            // 
            // txtRowCount2
            // 
            this.txtRowCount2.Location = new System.Drawing.Point(6, 36);
            this.txtRowCount2.Name = "txtRowCount2";
            this.txtRowCount2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRowCount2.Size = new System.Drawing.Size(100, 20);
            this.txtRowCount2.TabIndex = 20;
            this.txtRowCount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRowCount2
            // 
            this.lblRowCount2.AutoSize = true;
            this.lblRowCount2.Location = new System.Drawing.Point(6, 20);
            this.lblRowCount2.Name = "lblRowCount2";
            this.lblRowCount2.Size = new System.Drawing.Size(69, 13);
            this.lblRowCount2.TabIndex = 0;
            this.lblRowCount2.Text = "Row Number";
            // 
            // DGV2
            // 
            this.DGV2.AllowUserToAddRows = false;
            this.DGV2.AllowUserToDeleteRows = false;
            this.DGV2.AllowUserToResizeRows = false;
            this.DGV2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV2.BackgroundColor = System.Drawing.Color.White;
            this.DGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV2.Location = new System.Drawing.Point(6, 20);
            this.DGV2.Name = "DGV2";
            this.DGV2.Size = new System.Drawing.Size(317, 317);
            this.DGV2.TabIndex = 19;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 574);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 39;
            this.statusStrip.Text = "stsStrip";
            // 
            // swapBtn
            // 
            this.swapBtn.Location = new System.Drawing.Point(348, 82);
            this.swapBtn.Name = "swapBtn";
            this.swapBtn.Size = new System.Drawing.Size(88, 35);
            this.swapBtn.TabIndex = 34;
            this.swapBtn.Text = "A <-> B";
            this.swapBtn.UseVisualStyleBackColor = true;
            this.swapBtn.Click += new System.EventHandler(this.swapBtn_Click);
            // 
            // additionBtn
            // 
            this.additionBtn.Location = new System.Drawing.Point(348, 123);
            this.additionBtn.Name = "additionBtn";
            this.additionBtn.Size = new System.Drawing.Size(88, 35);
            this.additionBtn.TabIndex = 35;
            this.additionBtn.Text = "A + B";
            this.additionBtn.UseVisualStyleBackColor = true;
            this.additionBtn.Click += new System.EventHandler(this.additionBtn_Click);
            // 
            // substractBtn
            // 
            this.substractBtn.Location = new System.Drawing.Point(348, 164);
            this.substractBtn.Name = "substractBtn";
            this.substractBtn.Size = new System.Drawing.Size(88, 35);
            this.substractBtn.TabIndex = 36;
            this.substractBtn.Text = "A - B";
            this.substractBtn.UseVisualStyleBackColor = true;
            this.substractBtn.Click += new System.EventHandler(this.substractBtn_Click);
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Location = new System.Drawing.Point(348, 205);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(88, 35);
            this.multiplyBtn.TabIndex = 37;
            this.multiplyBtn.Text = "A * B";
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(348, 246);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(88, 35);
            this.resetBtn.TabIndex = 38;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // SFD
            // 
            this.SFD.DefaultExt = "mtrx";
            this.SFD.FileName = "Matrix_A.mtrx";
            this.SFD.Filter = "Matrix Files (*.mtrx)|*.mtrx";
            // 
            // OFD
            // 
            this.OFD.Filter = "Matrix Files (*.mtrx)|*.mtrx";
            // 
            // MainWindow
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 596);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.multiplyBtn);
            this.Controls.Add(this.substractBtn);
            this.Controls.Add(this.additionBtn);
            this.Controls.Add(this.swapBtn);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.grpBox_B);
            this.Controls.Add(this.grpBox_A);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 635);
            this.MinimumSize = new System.Drawing.Size(800, 635);
            this.Name = "MainWindow";
            this.Text = "Matrix Calculator";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.grpBox_A.ResumeLayout(false);
            this.grpBox_actions_A.ResumeLayout(false);
            this.grpBox_actions_A.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.grpBox_B.ResumeLayout(false);
            this.grpBox_actions_B.ResumeLayout(false);
            this.grpBox_actions_B.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public System.Windows.Forms.ToolStrip toolStrip;
        public System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        public System.Windows.Forms.ToolStripMenuItem openBtn;
        public System.Windows.Forms.ToolStripMenuItem saveBtn;
        public System.Windows.Forms.ToolStripMenuItem saveAsBtn;
        public System.Windows.Forms.ToolStripDropDownButton actionsBtn;
        public System.Windows.Forms.ToolStripMenuItem copyBtn;
        public System.Windows.Forms.ToolStripMenuItem fromAToBBtn;
        public System.Windows.Forms.ToolStripMenuItem fromBToABtn;
        public System.Windows.Forms.GroupBox grpBox_A;
        public System.Windows.Forms.GroupBox grpBox_actions_A;
        public System.Windows.Forms.Button btnPowA;
        public System.Windows.Forms.TextBox txtPowA;
        public System.Windows.Forms.Label lblPowA;
        public System.Windows.Forms.Button btnMultiplyA;
        public System.Windows.Forms.TextBox txtMultiplyA;
        public System.Windows.Forms.Label lblMultiplyA;
        public System.Windows.Forms.Button transposedA;
        public System.Windows.Forms.Button reverseA;
        public System.Windows.Forms.Button triangularA;
        public System.Windows.Forms.TextBox txtRankA;
        public System.Windows.Forms.Button RankABtn;
        public System.Windows.Forms.TextBox txtDetA;
        public System.Windows.Forms.Button detABtn;
        public System.Windows.Forms.Button createTableA;
        public System.Windows.Forms.TextBox txtColumnCount1;
        public System.Windows.Forms.Label lblColumnCount1;
        public System.Windows.Forms.TextBox txtRowCount1;
        public System.Windows.Forms.Label lblRowCount1;
        public System.Windows.Forms.DataGridView DGV1;
        public System.Windows.Forms.GroupBox grpBox_B;
        public System.Windows.Forms.DataGridView DGV2;
        public System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.GroupBox grpBox_actions_B;
        public System.Windows.Forms.Button btnPowB;
        public System.Windows.Forms.TextBox txtPowB;
        public System.Windows.Forms.Label lblPowB;
        public System.Windows.Forms.Button btnMultiplyB;
        public System.Windows.Forms.TextBox txtMultiplyB;
        public System.Windows.Forms.Label lblMultiplyB;
        public System.Windows.Forms.Button transposedB;
        public System.Windows.Forms.Button reverseB;
        public System.Windows.Forms.Button triangularB;
        public System.Windows.Forms.TextBox txtRankB;
        public System.Windows.Forms.Button RankBBtn;
        public System.Windows.Forms.TextBox txtDetB;
        public System.Windows.Forms.Button detBBtn;
        public System.Windows.Forms.Button createTableB;
        public System.Windows.Forms.TextBox txtColumnCount2;
        public System.Windows.Forms.Label lblColumnCount2;
        public System.Windows.Forms.TextBox txtRowCount2;
        public System.Windows.Forms.Label lblRowCount2;
        public System.Windows.Forms.Button swapBtn;
        public System.Windows.Forms.Button additionBtn;
        public System.Windows.Forms.Button substractBtn;
        public System.Windows.Forms.Button multiplyBtn;
        public System.Windows.Forms.Button resetBtn;
        public System.Windows.Forms.ToolStripButton exitBtn;
        public System.Windows.Forms.SaveFileDialog SFD;
        public System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.ToolStripMenuItem associateMtrxExtensionBtn;
    }
}