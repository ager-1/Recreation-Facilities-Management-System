namespace Recreational_Facilities_Management_System
{
    partial class StudentHomePage
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
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnViewFacility = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panelNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelNav.Controls.Add(this.btnUpdate);
            this.panelNav.Controls.Add(this.btnBooking);
            this.panelNav.Controls.Add(this.btnViewFacility);
            this.panelNav.Controls.Add(this.btnReview);
            this.panelNav.Controls.Add(this.btnSearch);
            this.panelNav.Location = new System.Drawing.Point(-1, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(220, 527);
            this.panelNav.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(22, 84);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(168, 44);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search Facilities";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReview
            // 
            this.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReview.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReview.Location = new System.Drawing.Point(22, 346);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(168, 41);
            this.btnReview.TabIndex = 1;
            this.btnReview.Text = "Send Review";
            this.btnReview.UseVisualStyleBackColor = true;
            // 
            // btnViewFacility
            // 
            this.btnViewFacility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewFacility.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFacility.ForeColor = System.Drawing.SystemColors.Control;
            this.btnViewFacility.Location = new System.Drawing.Point(22, 170);
            this.btnViewFacility.Name = "btnViewFacility";
            this.btnViewFacility.Size = new System.Drawing.Size(168, 42);
            this.btnViewFacility.TabIndex = 2;
            this.btnViewFacility.Text = "View Facility";
            this.btnViewFacility.UseVisualStyleBackColor = true;
            // 
            // btnBooking
            // 
            this.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooking.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooking.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBooking.Location = new System.Drawing.Point(22, 258);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(168, 41);
            this.btnBooking.TabIndex = 3;
            this.btnBooking.Text = "Perform Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(22, 423);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 41);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = " Update Profile";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome!!";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(399, 266);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(155, 33);
            this.lblName.TabIndex = 2;
            // 
            // StudentHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelNav);
            this.Name = "StudentHomePage";
            this.Text = "StudentHomePage";
            this.Load += new System.EventHandler(this.Student_Load);
            this.panelNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnViewFacility;
        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
    }
}