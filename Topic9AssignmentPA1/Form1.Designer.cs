namespace Topic9AssignmentPA1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGood = new System.Windows.Forms.Button();
            this.btnBad = new System.Windows.Forms.Button();
            this.picDoor = new System.Windows.Forms.PictureBox();
            this.picBaddoor = new System.Windows.Forms.PictureBox();
            this.picGooddoor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBaddoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGooddoor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGood
            // 
            this.btnGood.BackColor = System.Drawing.Color.YellowGreen;
            this.btnGood.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGood.Location = new System.Drawing.Point(173, 161);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(75, 74);
            this.btnGood.TabIndex = 0;
            this.btnGood.Text = "Good";
            this.btnGood.UseVisualStyleBackColor = false;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // btnBad
            // 
            this.btnBad.BackColor = System.Drawing.Color.Crimson;
            this.btnBad.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBad.Location = new System.Drawing.Point(552, 161);
            this.btnBad.Name = "btnBad";
            this.btnBad.Size = new System.Drawing.Size(75, 74);
            this.btnBad.TabIndex = 1;
            this.btnBad.Text = "Bad";
            this.btnBad.UseVisualStyleBackColor = false;
            this.btnBad.Click += new System.EventHandler(this.btnBad_Click);
            // 
            // picDoor
            // 
            this.picDoor.Image = ((System.Drawing.Image)(resources.GetObject("picDoor.Image")));
            this.picDoor.Location = new System.Drawing.Point(351, 88);
            this.picDoor.Name = "picDoor";
            this.picDoor.Size = new System.Drawing.Size(100, 206);
            this.picDoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoor.TabIndex = 2;
            this.picDoor.TabStop = false;
            // 
            // picBaddoor
            // 
            this.picBaddoor.Image = ((System.Drawing.Image)(resources.GetObject("picBaddoor.Image")));
            this.picBaddoor.Location = new System.Drawing.Point(274, 51);
            this.picBaddoor.Name = "picBaddoor";
            this.picBaddoor.Size = new System.Drawing.Size(255, 243);
            this.picBaddoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBaddoor.TabIndex = 3;
            this.picBaddoor.TabStop = false;
            this.picBaddoor.Visible = false;
            // 
            // picGooddoor
            // 
            this.picGooddoor.Image = ((System.Drawing.Image)(resources.GetObject("picGooddoor.Image")));
            this.picGooddoor.Location = new System.Drawing.Point(309, 40);
            this.picGooddoor.Name = "picGooddoor";
            this.picGooddoor.Size = new System.Drawing.Size(190, 294);
            this.picGooddoor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGooddoor.TabIndex = 4;
            this.picGooddoor.TabStop = false;
            this.picGooddoor.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picGooddoor);
            this.Controls.Add(this.picBaddoor);
            this.Controls.Add(this.picDoor);
            this.Controls.Add(this.btnBad);
            this.Controls.Add(this.btnGood);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBaddoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGooddoor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.Button btnBad;
        private System.Windows.Forms.PictureBox picDoor;
        private System.Windows.Forms.PictureBox picBaddoor;
        private System.Windows.Forms.PictureBox picGooddoor;
    }
}

