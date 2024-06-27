namespace DietApp
{
    partial class TrainingMemoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.lblPhase = new System.Windows.Forms.Label();
            this.txtPhase = new System.Windows.Forms.TextBox();
            this.lblBloodPressure = new System.Windows.Forms.Label();
            this.txtBloodPressure = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.lblBodyFat = new System.Windows.Forms.Label();
            this.txtBodyFat = new System.Windows.Forms.TextBox();
            this.dgvExercises = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCardioType = new System.Windows.Forms.Label();
            this.txtCardioType = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblCalories = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.btnShowTrainingMemo = new System.Windows.Forms.Button();
            this.btnShowCardio = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExercises)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 400);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblDate);
            this.tabPage1.Controls.Add(this.dtpDate);
            this.tabPage1.Controls.Add(this.lblTime);
            this.tabPage1.Controls.Add(this.txtTime);
            this.tabPage1.Controls.Add(this.lblPlace);
            this.tabPage1.Controls.Add(this.txtPlace);
            this.tabPage1.Controls.Add(this.lblPhase);
            this.tabPage1.Controls.Add(this.txtPhase);
            this.tabPage1.Controls.Add(this.lblBloodPressure);
            this.tabPage1.Controls.Add(this.txtBloodPressure);
            this.tabPage1.Controls.Add(this.lblWeight);
            this.tabPage1.Controls.Add(this.txtWeight);
            this.tabPage1.Controls.Add(this.lblBodyFat);
            this.tabPage1.Controls.Add(this.txtBodyFat);
            this.tabPage1.Controls.Add(this.dgvExercises);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 374);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "トレーニングメモ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(29, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "日付:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(74, 12);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(6, 45);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(29, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "時間:";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(74, 42);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(200, 20);
            this.txtTime.TabIndex = 3;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Location = new System.Drawing.Point(6, 75);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(29, 13);
            this.lblPlace.TabIndex = 4;
            this.lblPlace.Text = "場所:";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(74, 72);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(200, 20);
            this.txtPlace.TabIndex = 5;
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Location = new System.Drawing.Point(6, 105);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(41, 13);
            this.lblPhase.TabIndex = 6;
            this.lblPhase.Text = "フェーズ:";
            // 
            // txtPhase
            // 
            this.txtPhase.Location = new System.Drawing.Point(74, 102);
            this.txtPhase.Name = "txtPhase";
            this.txtPhase.Size = new System.Drawing.Size(200, 20);
            this.txtPhase.TabIndex = 7;
            // 
            // lblBloodPressure
            // 
            this.lblBloodPressure.AutoSize = true;
            this.lblBloodPressure.Location = new System.Drawing.Point(6, 135);
            this.lblBloodPressure.Name = "lblBloodPressure";
            this.lblBloodPressure.Size = new System.Drawing.Size(29, 13);
            this.lblBloodPressure.TabIndex = 8;
            this.lblBloodPressure.Text = "血圧:";
            // 
            // txtBloodPressure
            // 
            this.txtBloodPressure.Location = new System.Drawing.Point(74, 132);
            this.txtBloodPressure.Name = "txtBloodPressure";
            this.txtBloodPressure.Size = new System.Drawing.Size(200, 20);
            this.txtBloodPressure.TabIndex = 9;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(6, 165);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(29, 13);
            this.lblWeight.TabIndex = 10;
            this.lblWeight.Text = "体重:";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(74, 162);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(200, 20);
            this.txtWeight.TabIndex = 11;
            // 
            // lblBodyFat
            // 
            this.lblBodyFat.AutoSize = true;
            this.lblBodyFat.Location = new System.Drawing.Point(6, 195);
            this.lblBodyFat.Name = "lblBodyFat";
            this.lblBodyFat.Size = new System.Drawing.Size(53, 13);
            this.lblBodyFat.TabIndex = 12;
            this.lblBodyFat.Text = "体脂肪率:";
            // 
            // txtBodyFat
            // 
            this.txtBodyFat.Location = new System.Drawing.Point(74, 192);
            this.txtBodyFat.Name = "txtBodyFat";
            this.txtBodyFat.Size = new System.Drawing.Size(200, 20);
            this.txtBodyFat.TabIndex = 13;
            // 
            // dgvExercises
            // 
            this.dgvExercises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExercises.Location = new System.Drawing.Point(6, 230);
            this.dgvExercises.Name = "dgvExercises";
            this.dgvExercises.Size = new System.Drawing.Size(500, 150);
            this.dgvExercises.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(431, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCardioType);
            this.tabPage2.Controls.Add(this.txtCardioType);
            this.tabPage2.Controls.Add(this.lblDuration);
            this.tabPage2.Controls.Add(this.txtDuration);
            this.tabPage2.Controls.Add(this.lblCalories);
            this.tabPage2.Controls.Add(this.txtCalories);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 374);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "有酸素";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCardioType
            // 
            this.lblCardioType.AutoSize = true;
            this.lblCardioType.Location = new System.Drawing.Point(6, 15);
            this.lblCardioType.Name = "lblCardioType";
            this.lblCardioType.Size = new System.Drawing.Size(65, 13);
            this.lblCardioType.TabIndex = 0;
            this.lblCardioType.Text = "有酸素の種類:";
            // 
            // txtCardioType
            // 
            this.txtCardioType.Location = new System.Drawing.Point(74, 12);
            this.txtCardioType.Name = "txtCardioType";
            this.txtCardioType.Size = new System.Drawing.Size(200, 20);
            this.txtCardioType.TabIndex = 1;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(6, 45);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(53, 13);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "時間（分）:";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(74, 42);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(200, 20);
            this.txtDuration.TabIndex = 3;
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Location = new System.Drawing.Point(6, 75);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(65, 13);
            this.lblCalories.TabIndex = 4;
            this.lblCalories.Text = "消費カロリー:";
            // 
            // txtCalories
            // 
            this.txtCalories.Location = new System.Drawing.Point(74, 72);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(200, 20);
            this.txtCalories.TabIndex = 5;
            // 
            // btnShowTrainingMemo
            // 
            this.btnShowTrainingMemo.Location = new System.Drawing.Point(12, 12);
            this.btnShowTrainingMemo.Name = "btnShowTrainingMemo";
            this.btnShowTrainingMemo.Size = new System.Drawing.Size(120, 23);
            this.btnShowTrainingMemo.TabIndex = 1;
            this.btnShowTrainingMemo.Text = "トレーニングメモ";
            this.btnShowTrainingMemo.UseVisualStyleBackColor = true;
            this.btnShowTrainingMemo.Click += new System.EventHandler(this.btnShowTrainingMemo_Click);
            // 
            // btnShowCardio
            // 
            this.btnShowCardio.Location = new System.Drawing.Point(152, 12);
            this.btnShowCardio.Name = "btnShowCardio";
            this.btnShowCardio.Size = new System.Drawing.Size(120, 23);
            this.btnShowCardio.TabIndex = 2;
            this.btnShowCardio.Text = "有酸素";
            this.btnShowCardio.UseVisualStyleBackColor = true;
            this.btnShowCardio.Click += new System.EventHandler(this.btnShowCardio_Click);
            // 
            // TrainingMemoForm
            // 
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btnShowCardio);
            this.Controls.Add(this.btnShowTrainingMemo);
            this.Controls.Add(this.tabControl1);
            this.Name = "TrainingMemoForm";
            this.Text = "トレーニングメモ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExercises)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.TextBox txtPhase;
        private System.Windows.Forms.Label lblBloodPressure;
        private System.Windows.Forms.TextBox txtBloodPressure;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblBodyFat;
        private System.Windows.Forms.TextBox txtBodyFat;
        private System.Windows.Forms.DataGridView dgvExercises;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCardioType;
        private System.Windows.Forms.TextBox txtCardioType;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblCalories;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.Button btnShowTrainingMemo;
        private System.Windows.Forms.Button btnShowCardio;
    }
}
