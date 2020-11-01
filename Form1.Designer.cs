namespace L2_5_Process_Scheduler
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
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.lbxInput = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.pnlVariation = new System.Windows.Forms.Panel();
            this.rbtnMy = new System.Windows.Forms.RadioButton();
            this.rbtnRR = new System.Windows.Forms.RadioButton();
            this.rdbtnSJF = new System.Windows.Forms.RadioButton();
            this.rbtnFIFS = new System.Windows.Forms.RadioButton();
            this.lblVariation = new System.Windows.Forms.Label();
            this.lblForRR = new System.Windows.Forms.Label();
            this.numUD = new System.Windows.Forms.NumericUpDown();
            this.cbxSysProc = new System.Windows.Forms.CheckBox();
            this.pnlVariation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.ItemHeight = 20;
            this.lbxOutput.Location = new System.Drawing.Point(406, 73);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(502, 204);
            this.lbxOutput.TabIndex = 0;
            // 
            // lbxInput
            // 
            this.lbxInput.FormattingEnabled = true;
            this.lbxInput.ItemHeight = 20;
            this.lbxInput.Location = new System.Drawing.Point(216, 73);
            this.lbxInput.Name = "lbxInput";
            this.lbxInput.Size = new System.Drawing.Size(171, 204);
            this.lbxInput.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerate.Location = new System.Drawing.Point(216, 297);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(171, 40);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(409, 297);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(122, 40);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "TIME: ";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutput.Location = new System.Drawing.Point(401, 45);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(71, 25);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "Output";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInput.Location = new System.Drawing.Point(211, 45);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(55, 25);
            this.lblInput.TabIndex = 5;
            this.lblInput.Text = "Input";
            // 
            // pnlVariation
            // 
            this.pnlVariation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVariation.Controls.Add(this.rbtnMy);
            this.pnlVariation.Controls.Add(this.rbtnRR);
            this.pnlVariation.Controls.Add(this.rdbtnSJF);
            this.pnlVariation.Controls.Add(this.rbtnFIFS);
            this.pnlVariation.Location = new System.Drawing.Point(21, 50);
            this.pnlVariation.Name = "pnlVariation";
            this.pnlVariation.Size = new System.Drawing.Size(178, 196);
            this.pnlVariation.TabIndex = 7;
            // 
            // rbtnMy
            // 
            this.rbtnMy.AutoSize = true;
            this.rbtnMy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnMy.Location = new System.Drawing.Point(16, 148);
            this.rbtnMy.Name = "rbtnMy";
            this.rbtnMy.Size = new System.Drawing.Size(64, 29);
            this.rbtnMy.TabIndex = 3;
            this.rbtnMy.TabStop = true;
            this.rbtnMy.Text = "My";
            this.rbtnMy.UseVisualStyleBackColor = true;
            // 
            // rbtnRR
            // 
            this.rbtnRR.AutoSize = true;
            this.rbtnRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnRR.Location = new System.Drawing.Point(16, 106);
            this.rbtnRR.Name = "rbtnRR";
            this.rbtnRR.Size = new System.Drawing.Size(63, 29);
            this.rbtnRR.TabIndex = 2;
            this.rbtnRR.TabStop = true;
            this.rbtnRR.Text = "RR";
            this.rbtnRR.UseVisualStyleBackColor = true;
            // 
            // rdbtnSJF
            // 
            this.rdbtnSJF.AutoSize = true;
            this.rdbtnSJF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbtnSJF.Location = new System.Drawing.Point(16, 64);
            this.rdbtnSJF.Name = "rdbtnSJF";
            this.rdbtnSJF.Size = new System.Drawing.Size(74, 29);
            this.rdbtnSJF.TabIndex = 1;
            this.rdbtnSJF.TabStop = true;
            this.rdbtnSJF.Text = "SJF";
            this.rdbtnSJF.UseVisualStyleBackColor = true;
            // 
            // rbtnFIFS
            // 
            this.rbtnFIFS.AutoSize = true;
            this.rbtnFIFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnFIFS.Location = new System.Drawing.Point(16, 22);
            this.rbtnFIFS.Name = "rbtnFIFS";
            this.rbtnFIFS.Size = new System.Drawing.Size(80, 29);
            this.rbtnFIFS.TabIndex = 0;
            this.rbtnFIFS.TabStop = true;
            this.rbtnFIFS.Text = "FIFS";
            this.rbtnFIFS.UseVisualStyleBackColor = true;
            // 
            // lblVariation
            // 
            this.lblVariation.AutoSize = true;
            this.lblVariation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVariation.Location = new System.Drawing.Point(34, 37);
            this.lblVariation.Name = "lblVariation";
            this.lblVariation.Size = new System.Drawing.Size(89, 25);
            this.lblVariation.TabIndex = 8;
            this.lblVariation.Text = "Variation";
            // 
            // lblForRR
            // 
            this.lblForRR.AutoSize = true;
            this.lblForRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblForRR.Location = new System.Drawing.Point(14, 259);
            this.lblForRR.Name = "lblForRR";
            this.lblForRR.Size = new System.Drawing.Size(112, 32);
            this.lblForRR.TabIndex = 9;
            this.lblForRR.Text = "For RR:";
            // 
            // numUD
            // 
            this.numUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numUD.Location = new System.Drawing.Point(145, 259);
            this.numUD.Name = "numUD";
            this.numUD.Size = new System.Drawing.Size(54, 30);
            this.numUD.TabIndex = 10;
            // 
            // cbxSysProc
            // 
            this.cbxSysProc.AutoSize = true;
            this.cbxSysProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbxSysProc.Location = new System.Drawing.Point(20, 308);
            this.cbxSysProc.Name = "cbxSysProc";
            this.cbxSysProc.Size = new System.Drawing.Size(179, 26);
            this.cbxSysProc.TabIndex = 11;
            this.cbxSysProc.Text = "system processes";
            this.cbxSysProc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(934, 360);
            this.Controls.Add(this.cbxSysProc);
            this.Controls.Add(this.numUD);
            this.Controls.Add(this.lblForRR);
            this.Controls.Add(this.lblVariation);
            this.Controls.Add(this.pnlVariation);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lbxInput);
            this.Controls.Add(this.lbxOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "L2-5 Process Scheduler";
            this.pnlVariation.ResumeLayout(false);
            this.pnlVariation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.ListBox lbxInput;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Panel pnlVariation;
        private System.Windows.Forms.Label lblVariation;
        private System.Windows.Forms.RadioButton rbtnMy;
        private System.Windows.Forms.RadioButton rbtnRR;
        private System.Windows.Forms.RadioButton rdbtnSJF;
        private System.Windows.Forms.RadioButton rbtnFIFS;
        private System.Windows.Forms.Label lblForRR;
        private System.Windows.Forms.NumericUpDown numUD;
        private System.Windows.Forms.CheckBox cbxSysProc;
    }
}

