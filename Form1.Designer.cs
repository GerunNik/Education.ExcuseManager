namespace ExcuseManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Directory = new System.Windows.Forms.Button();
            this.txt_Excuse = new System.Windows.Forms.TextBox();
            this.datePicker_lastUsed = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Reaction = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.btn_quickExcuse = new System.Windows.Forms.Button();
            this.btn_Serialize = new System.Windows.Forms.Button();
            this.btn_LoadSerializable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entschuldigung";
            // 
            // btn_Directory
            // 
            this.btn_Directory.Location = new System.Drawing.Point(12, 116);
            this.btn_Directory.Name = "btn_Directory";
            this.btn_Directory.Size = new System.Drawing.Size(75, 23);
            this.btn_Directory.TabIndex = 1;
            this.btn_Directory.Text = "Ordner";
            this.btn_Directory.UseVisualStyleBackColor = true;
            this.btn_Directory.Click += new System.EventHandler(this.btn_Directory_Click);
            // 
            // txt_Excuse
            // 
            this.txt_Excuse.Location = new System.Drawing.Point(110, 5);
            this.txt_Excuse.Name = "txt_Excuse";
            this.txt_Excuse.Size = new System.Drawing.Size(254, 20);
            this.txt_Excuse.TabIndex = 2;
            // 
            // datePicker_lastUsed
            // 
            this.datePicker_lastUsed.Location = new System.Drawing.Point(110, 53);
            this.datePicker_lastUsed.Name = "datePicker_lastUsed";
            this.datePicker_lastUsed.Size = new System.Drawing.Size(200, 20);
            this.datePicker_lastUsed.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reaktion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zuletzt verwendet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datei-Datum";
            // 
            // txt_Reaction
            // 
            this.txt_Reaction.Location = new System.Drawing.Point(110, 27);
            this.txt_Reaction.Name = "txt_Reaction";
            this.txt_Reaction.Size = new System.Drawing.Size(254, 20);
            this.txt_Reaction.TabIndex = 7;
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(110, 76);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(254, 20);
            this.txt_Date.TabIndex = 9;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(93, 116);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Speichern";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(174, 116);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(75, 23);
            this.btn_Open.TabIndex = 11;
            this.btn_Open.Text = "Öffnen";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // btn_quickExcuse
            // 
            this.btn_quickExcuse.Location = new System.Drawing.Point(255, 116);
            this.btn_quickExcuse.Name = "btn_quickExcuse";
            this.btn_quickExcuse.Size = new System.Drawing.Size(109, 23);
            this.btn_quickExcuse.TabIndex = 12;
            this.btn_quickExcuse.Text = "Schnelle Ausrede";
            this.btn_quickExcuse.UseVisualStyleBackColor = true;
            this.btn_quickExcuse.Click += new System.EventHandler(this.btn_quickExcuse_Click);
            // 
            // btn_Serialize
            // 
            this.btn_Serialize.Location = new System.Drawing.Point(12, 145);
            this.btn_Serialize.Name = "btn_Serialize";
            this.btn_Serialize.Size = new System.Drawing.Size(156, 23);
            this.btn_Serialize.TabIndex = 13;
            this.btn_Serialize.Text = "Serialize Object";
            this.btn_Serialize.UseVisualStyleBackColor = true;
            this.btn_Serialize.Click += new System.EventHandler(this.btn_Serialize_Click);
            // 
            // btn_LoadSerializable
            // 
            this.btn_LoadSerializable.Location = new System.Drawing.Point(174, 145);
            this.btn_LoadSerializable.Name = "btn_LoadSerializable";
            this.btn_LoadSerializable.Size = new System.Drawing.Size(190, 23);
            this.btn_LoadSerializable.TabIndex = 14;
            this.btn_LoadSerializable.Text = "Load serialized Object";
            this.btn_LoadSerializable.UseVisualStyleBackColor = true;
            this.btn_LoadSerializable.Click += new System.EventHandler(this.btn_LoadSerializable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 184);
            this.Controls.Add(this.btn_LoadSerializable);
            this.Controls.Add(this.btn_Serialize);
            this.Controls.Add(this.btn_quickExcuse);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.txt_Reaction);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePicker_lastUsed);
            this.Controls.Add(this.txt_Excuse);
            this.Controls.Add(this.btn_Directory);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Entschuldigungsverwaltung";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Directory;
        private System.Windows.Forms.TextBox txt_Excuse;
        private System.Windows.Forms.DateTimePicker datePicker_lastUsed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Reaction;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_quickExcuse;
        private System.Windows.Forms.Button btn_Serialize;
        private System.Windows.Forms.Button btn_LoadSerializable;
    }
}

