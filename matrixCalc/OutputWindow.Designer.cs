
namespace matrixCalc
{
    public partial class OutputWindow
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
            this.otpDGV = new System.Windows.Forms.DataGridView();
            this.copyToDGV1 = new System.Windows.Forms.Button();
            this.copyToDGV2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.otpDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // otpDGV
            // 
            this.otpDGV.AllowUserToAddRows = false;
            this.otpDGV.AllowUserToDeleteRows = false;
            this.otpDGV.AllowUserToResizeRows = false;
            this.otpDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.otpDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.otpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.otpDGV.Location = new System.Drawing.Point(13, 13);
            this.otpDGV.Name = "otpDGV";
            this.otpDGV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.otpDGV.Size = new System.Drawing.Size(425, 425);
            this.otpDGV.TabIndex = 0;
            // 
            // copyToDGV1
            // 
            this.copyToDGV1.Location = new System.Drawing.Point(13, 444);
            this.copyToDGV1.Name = "copyToDGV1";
            this.copyToDGV1.Size = new System.Drawing.Size(210, 45);
            this.copyToDGV1.TabIndex = 1;
            this.copyToDGV1.Text = "Copy to the left matrix";
            this.copyToDGV1.UseVisualStyleBackColor = true;
            // 
            // copyToDGV2
            // 
            this.copyToDGV2.Location = new System.Drawing.Point(228, 444);
            this.copyToDGV2.Name = "copyToDGV2";
            this.copyToDGV2.Size = new System.Drawing.Size(210, 45);
            this.copyToDGV2.TabIndex = 2;
            this.copyToDGV2.Text = "Copy to the right matrix";
            this.copyToDGV2.UseVisualStyleBackColor = true;
            // 
            // OutputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 502);
            this.Controls.Add(this.copyToDGV2);
            this.Controls.Add(this.copyToDGV1);
            this.Controls.Add(this.otpDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OutputWindow";
            this.Text = "OutputWindow";
            ((System.ComponentModel.ISupportInitialize)(this.otpDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView otpDGV;
        public System.Windows.Forms.Button copyToDGV1;
        public System.Windows.Forms.Button copyToDGV2;
    }
}