namespace GuardingBoard
{
    partial class frmBoard
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
            this.dtgBoard = new System.Windows.Forms.DataGridView();
            this.lblCrew = new System.Windows.Forms.Label();
            this.cmbCrew = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblSlash = new System.Windows.Forms.Label();
            this.txtSat = new System.Windows.Forms.TextBox();
            this.lblSat = new System.Windows.Forms.Label();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.lblNights = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnGenerateBoard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgBoard
            // 
            this.dtgBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBoard.Location = new System.Drawing.Point(12, 12);
            this.dtgBoard.Name = "dtgBoard";
            this.dtgBoard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtgBoard.RowTemplate.Height = 28;
            this.dtgBoard.Size = new System.Drawing.Size(1242, 556);
            this.dtgBoard.TabIndex = 1;
            // 
            // lblCrew
            // 
            this.lblCrew.AutoSize = true;
            this.lblCrew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrew.Location = new System.Drawing.Point(1474, 82);
            this.lblCrew.Name = "lblCrew";
            this.lblCrew.Size = new System.Drawing.Size(51, 25);
            this.lblCrew.TabIndex = 2;
            this.lblCrew.Text = "צוות";
            // 
            // cmbCrew
            // 
            this.cmbCrew.FormattingEnabled = true;
            this.cmbCrew.Location = new System.Drawing.Point(1279, 79);
            this.cmbCrew.Name = "cmbCrew";
            this.cmbCrew.Size = new System.Drawing.Size(131, 28);
            this.cmbCrew.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(1356, 131);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(169, 25);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "כמות אנשים בצוות";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(1279, 129);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(71, 26);
            this.txtAmount.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1429, 12);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(96, 25);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "שנה/חודש";
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(1279, 13);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(52, 26);
            this.txtMonth.TabIndex = 7;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(1358, 13);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(65, 26);
            this.txtYear.TabIndex = 8;
            // 
            // lblSlash
            // 
            this.lblSlash.AutoSize = true;
            this.lblSlash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlash.Location = new System.Drawing.Point(1337, 14);
            this.lblSlash.Name = "lblSlash";
            this.lblSlash.Size = new System.Drawing.Size(19, 25);
            this.lblSlash.TabIndex = 9;
            this.lblSlash.Text = "/";
            // 
            // txtSat
            // 
            this.txtSat.Enabled = false;
            this.txtSat.Location = new System.Drawing.Point(1278, 174);
            this.txtSat.Name = "txtSat";
            this.txtSat.Size = new System.Drawing.Size(71, 26);
            this.txtSat.TabIndex = 11;
            // 
            // lblSat
            // 
            this.lblSat.AutoSize = true;
            this.lblSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSat.Location = new System.Drawing.Point(1409, 173);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(116, 25);
            this.lblSat.TabIndex = 10;
            this.lblSat.Text = "כמות שבתות";
            // 
            // txtNights
            // 
            this.txtNights.Enabled = false;
            this.txtNights.Location = new System.Drawing.Point(1278, 216);
            this.txtNights.Name = "txtNights";
            this.txtNights.Size = new System.Drawing.Size(71, 26);
            this.txtNights.TabIndex = 13;
            // 
            // lblNights
            // 
            this.lblNights.AutoSize = true;
            this.lblNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNights.Location = new System.Drawing.Point(1409, 215);
            this.lblNights.Name = "lblNights";
            this.lblNights.Size = new System.Drawing.Size(108, 25);
            this.lblNights.TabIndex = 12;
            this.lblNights.Text = "כמות לילות";
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(1280, 56);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(236, 2);
            this.lblLine.TabIndex = 14;
            // 
            // btnGenerateBoard
            // 
            this.btnGenerateBoard.Location = new System.Drawing.Point(1434, 272);
            this.btnGenerateBoard.Name = "btnGenerateBoard";
            this.btnGenerateBoard.Size = new System.Drawing.Size(75, 49);
            this.btnGenerateBoard.TabIndex = 15;
            this.btnGenerateBoard.Text = "הפק לוח";
            this.btnGenerateBoard.UseVisualStyleBackColor = true;
            this.btnGenerateBoard.Click += new System.EventHandler(this.btnGenerateBoard_Click);
            // 
            // frmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1531, 580);
            this.Controls.Add(this.btnGenerateBoard);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.lblNights);
            this.Controls.Add(this.txtSat);
            this.Controls.Add(this.lblSat);
            this.Controls.Add(this.lblSlash);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmbCrew);
            this.Controls.Add(this.lblCrew);
            this.Controls.Add(this.dtgBoard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBoard";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgBoard;
        private System.Windows.Forms.Label lblCrew;
        private System.Windows.Forms.ComboBox cmbCrew;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblSlash;
        private System.Windows.Forms.TextBox txtSat;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.Label lblNights;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Button btnGenerateBoard;
    }
}

