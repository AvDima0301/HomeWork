namespace hw_02_02
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_NameEv = new System.Windows.Forms.TextBox();
            this.lb_name_ev = new System.Windows.Forms.Label();
            this.lb_name_pl = new System.Windows.Forms.Label();
            this.tb_Name_Pl = new System.Windows.Forms.TextBox();
            this.lb_date = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lb_event = new System.Windows.Forms.Label();
            this.lb_High = new System.Windows.Forms.Label();
            this.lb_Medium = new System.Windows.Forms.Label();
            this.lb_low = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_Events = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_NameEv
            // 
            this.tb_NameEv.Location = new System.Drawing.Point(15, 25);
            this.tb_NameEv.Name = "tb_NameEv";
            this.tb_NameEv.Size = new System.Drawing.Size(205, 20);
            this.tb_NameEv.TabIndex = 0;
            this.tb_NameEv.TextChanged += new System.EventHandler(this.tb_NameEv_TextChanged);
            // 
            // lb_name_ev
            // 
            this.lb_name_ev.AutoSize = true;
            this.lb_name_ev.Location = new System.Drawing.Point(12, 9);
            this.lb_name_ev.Name = "lb_name_ev";
            this.lb_name_ev.Size = new System.Drawing.Size(78, 13);
            this.lb_name_ev.TabIndex = 1;
            this.lb_name_ev.Text = "Name of Event";
            // 
            // lb_name_pl
            // 
            this.lb_name_pl.AutoSize = true;
            this.lb_name_pl.Location = new System.Drawing.Point(14, 48);
            this.lb_name_pl.Name = "lb_name_pl";
            this.lb_name_pl.Size = new System.Drawing.Size(76, 13);
            this.lb_name_pl.TabIndex = 2;
            this.lb_name_pl.Text = "Name of place";
            // 
            // tb_Name_Pl
            // 
            this.tb_Name_Pl.Location = new System.Drawing.Point(17, 64);
            this.tb_Name_Pl.Name = "tb_Name_Pl";
            this.tb_Name_Pl.Size = new System.Drawing.Size(205, 20);
            this.tb_Name_Pl.TabIndex = 3;
            this.tb_Name_Pl.TextChanged += new System.EventHandler(this.tb_Name_Pl_TextChanged);
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(14, 87);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(30, 13);
            this.lb_date.TabIndex = 4;
            this.lb_date.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(205, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lb_event
            // 
            this.lb_event.AutoSize = true;
            this.lb_event.Location = new System.Drawing.Point(241, 9);
            this.lb_event.Name = "lb_event";
            this.lb_event.Size = new System.Drawing.Size(40, 13);
            this.lb_event.TabIndex = 7;
            this.lb_event.Text = "Events";
            // 
            // lb_High
            // 
            this.lb_High.AutoSize = true;
            this.lb_High.BackColor = System.Drawing.Color.Silver;
            this.lb_High.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_High.Location = new System.Drawing.Point(14, 139);
            this.lb_High.MinimumSize = new System.Drawing.Size(50, 15);
            this.lb_High.Name = "lb_High";
            this.lb_High.Size = new System.Drawing.Size(50, 15);
            this.lb_High.TabIndex = 8;
            this.lb_High.Text = "High";
            this.lb_High.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_High.Click += new System.EventHandler(this.lb_High_Click);
            // 
            // lb_Medium
            // 
            this.lb_Medium.AutoSize = true;
            this.lb_Medium.BackColor = System.Drawing.Color.Silver;
            this.lb_Medium.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_Medium.Location = new System.Drawing.Point(12, 167);
            this.lb_Medium.MinimumSize = new System.Drawing.Size(50, 15);
            this.lb_Medium.Name = "lb_Medium";
            this.lb_Medium.Size = new System.Drawing.Size(50, 15);
            this.lb_Medium.TabIndex = 9;
            this.lb_Medium.Text = "Medium";
            this.lb_Medium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Medium.Click += new System.EventHandler(this.lb_Medium_Click);
            // 
            // lb_low
            // 
            this.lb_low.AutoSize = true;
            this.lb_low.BackColor = System.Drawing.Color.Silver;
            this.lb_low.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_low.Location = new System.Drawing.Point(12, 195);
            this.lb_low.MinimumSize = new System.Drawing.Size(50, 15);
            this.lb_low.Name = "lb_low";
            this.lb_low.Size = new System.Drawing.Size(50, 15);
            this.lb_low.TabIndex = 10;
            this.lb_low.Text = "Low";
            this.lb_low.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_low.Click += new System.EventHandler(this.lb_low_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(147, 139);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "Add Event";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_Events
            // 
            this.tb_Events.Location = new System.Drawing.Point(244, 25);
            this.tb_Events.Multiline = true;
            this.tb_Events.Name = "tb_Events";
            this.tb_Events.ReadOnly = true;
            this.tb_Events.Size = new System.Drawing.Size(328, 413);
            this.tb_Events.TabIndex = 12;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(147, 223);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 13;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(147, 252);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 14;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(147, 168);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 15;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Events);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lb_low);
            this.Controls.Add(this.lb_Medium);
            this.Controls.Add(this.lb_High);
            this.Controls.Add(this.lb_event);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.tb_Name_Pl);
            this.Controls.Add(this.lb_name_pl);
            this.Controls.Add(this.lb_name_ev);
            this.Controls.Add(this.tb_NameEv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_NameEv;
        private System.Windows.Forms.Label lb_name_ev;
        private System.Windows.Forms.Label lb_name_pl;
        private System.Windows.Forms.TextBox tb_Name_Pl;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lb_event;
        private System.Windows.Forms.Label lb_High;
        private System.Windows.Forms.Label lb_Medium;
        private System.Windows.Forms.Label lb_low;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_Events;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Clear;
    }
}

