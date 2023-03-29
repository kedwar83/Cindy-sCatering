namespace Cindy_s_Catering
{
    partial class Catering
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catering));
            label1 = new Label();
            label2 = new Label();
            GuestName = new TextBox();
            PhoneNumber = new TextBox();
            NumberOfGuests = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 86);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 187);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Phone Number";
            label2.Click += label2_Click;
            // 
            // GuestName
            // 
            GuestName.Location = new Point(164, 85);
            GuestName.Name = "GuestName";
            GuestName.Size = new Size(100, 23);
            GuestName.TabIndex = 2;
            GuestName.TextChanged += GuestName_TextChanged;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Location = new Point(164, 187);
            PhoneNumber.Name = "PhoneNumber";
            PhoneNumber.Size = new Size(100, 23);
            PhoneNumber.TabIndex = 3;
            PhoneNumber.TextChanged += PhoneNumber_TextChanged;
            // 
            // NumberOfGuests
            // 
            NumberOfGuests.Location = new Point(164, 268);
            NumberOfGuests.Name = "NumberOfGuests";
            NumberOfGuests.Size = new Size(100, 23);
            NumberOfGuests.TabIndex = 5;
            NumberOfGuests.TextChanged += NumberOfGuests_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 268);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 4;
            label3.Text = "Number Of Guests";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(164, 549);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            button1.Click += To_Next_Screen;
            // 
            // Catering
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1000, 665);
            Controls.Add(button1);
            Controls.Add(NumberOfGuests);
            Controls.Add(label3);
            Controls.Add(PhoneNumber);
            Controls.Add(GuestName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Catering";
            Text = "Registery";
            Load += Catering_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox GuestName;
        private TextBox PhoneNumber;
        private TextBox NumberOfGuests;
        private Label label3;
        private Button button1;
    }
}