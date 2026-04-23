namespace OlegChaes2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblRad = new System.Windows.Forms.Label();
            this.lblWater = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtWater = new System.Windows.Forms.TextBox();
            this.btnWater = new System.Windows.Forms.Button();
            this.btnCool = new System.Windows.Forms.Button();
            this.txtCool = new System.Windows.Forms.TextBox();
            this.lblWarns = new System.Windows.Forms.Label();
            this.lblChanges = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblWater, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTemp, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRad, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(244, 231);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 72);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblRad
            // 
            this.lblRad.AutoSize = true;
            this.lblRad.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRad.Location = new System.Drawing.Point(247, 36);
            this.lblRad.Name = "lblRad";
            this.lblRad.Size = new System.Drawing.Size(58, 19);
            this.lblRad.TabIndex = 5;
            this.lblRad.Text = "label7";
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWater.Location = new System.Drawing.Point(127, 36);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(58, 19);
            this.lblWater.TabIndex = 4;
            this.lblWater.Text = "label6";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemp.Location = new System.Drawing.Point(3, 36);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(58, 19);
            this.lblTemp.TabIndex = 3;
            this.lblTemp.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(247, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Радиация";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(127, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Объем воды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Температура";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(495, 38);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 51);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Сбросить реактор";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(336, 38);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(149, 51);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Аварийная остановка";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtWater
            // 
            this.txtWater.Location = new System.Drawing.Point(180, 95);
            this.txtWater.Name = "txtWater";
            this.txtWater.Size = new System.Drawing.Size(150, 20);
            this.txtWater.TabIndex = 3;
            // 
            // btnWater
            // 
            this.btnWater.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWater.Location = new System.Drawing.Point(180, 38);
            this.btnWater.Name = "btnWater";
            this.btnWater.Size = new System.Drawing.Size(149, 51);
            this.btnWater.TabIndex = 4;
            this.btnWater.Text = "Долить воды";
            this.btnWater.UseVisualStyleBackColor = true;
            this.btnWater.Click += new System.EventHandler(this.btnWater_Click);
            // 
            // btnCool
            // 
            this.btnCool.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCool.Location = new System.Drawing.Point(650, 38);
            this.btnCool.Name = "btnCool";
            this.btnCool.Size = new System.Drawing.Size(149, 51);
            this.btnCool.TabIndex = 6;
            this.btnCool.Text = "Охладить реактор";
            this.btnCool.UseVisualStyleBackColor = true;
            this.btnCool.Click += new System.EventHandler(this.btnCool_Click);
            // 
            // txtCool
            // 
            this.txtCool.Location = new System.Drawing.Point(650, 95);
            this.txtCool.Name = "txtCool";
            this.txtCool.Size = new System.Drawing.Size(150, 20);
            this.txtCool.TabIndex = 5;
            // 
            // lblWarns
            // 
            this.lblWarns.AutoSize = true;
            this.lblWarns.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWarns.Location = new System.Drawing.Point(240, 407);
            this.lblWarns.Name = "lblWarns";
            this.lblWarns.Size = new System.Drawing.Size(0, 19);
            this.lblWarns.TabIndex = 7;
            // 
            // lblChanges
            // 
            this.lblChanges.AutoSize = true;
            this.lblChanges.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChanges.Location = new System.Drawing.Point(239, 547);
            this.lblChanges.Name = "lblChanges";
            this.lblChanges.Size = new System.Drawing.Size(0, 25);
            this.lblChanges.TabIndex = 8;
            // 
            // frmMain
            // 
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(890, 664);
            this.Controls.Add(this.lblChanges);
            this.Controls.Add(this.lblWarns);
            this.Controls.Add(this.btnCool);
            this.Controls.Add(this.txtCool);
            this.Controls.Add(this.btnWater);
            this.Controls.Add(this.txtWater);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Управление реактором";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblRad;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtWater;
        private System.Windows.Forms.Button btnWater;
        private System.Windows.Forms.Button btnCool;
        private System.Windows.Forms.TextBox txtCool;
        private System.Windows.Forms.Label lblWarns;
        private System.Windows.Forms.Label lblChanges;
    }
}
