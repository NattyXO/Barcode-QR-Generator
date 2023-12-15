
namespace Barcode_and_QRcode_Generator
{
    partial class TaostNotification
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
            this.pnlBorder = new System.Windows.Forms.Panel();
            this.lblType = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.toastTimer = new System.Windows.Forms.Timer(this.components);
            this.toastHide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBorder
            // 
            this.pnlBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pnlBorder.Location = new System.Drawing.Point(0, -5);
            this.pnlBorder.Name = "pnlBorder";
            this.pnlBorder.Size = new System.Drawing.Size(12, 68);
            this.pnlBorder.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(53, 5);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 18);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "Type";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(53, 25);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(80, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Taost Message";
            // 
            // picIcon
            // 
            this.picIcon.Image = global::Barcode_and_QRcode_Generator.Properties.Resources.icons8_ok_240;
            this.picIcon.Location = new System.Drawing.Point(18, 17);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(20, 20);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // toastTimer
            // 
            this.toastTimer.Interval = 10;
            this.toastTimer.Tick += new System.EventHandler(this.toastTimer_Tick);
            // 
            // toastHide
            // 
            this.toastHide.Interval = 10;
            this.toastHide.Tick += new System.EventHandler(this.toastHide_Tick);
            // 
            // TaostNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 59);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.pnlBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaostNotification";
            this.Text = "TaostNotification";
            this.Load += new System.EventHandler(this.TaostNotification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorder;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer toastHide;
    }
}