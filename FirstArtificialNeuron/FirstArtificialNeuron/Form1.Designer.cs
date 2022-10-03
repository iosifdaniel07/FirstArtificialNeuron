namespace FirstArtificialNeuron {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.numericUpDownInput = new System.Windows.Forms.NumericUpDown();
            this.label_Input_Numbers = new System.Windows.Forms.Label();
            this.flowLayoutPanelInput = new System.Windows.Forms.FlowLayoutPanel();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.radioBtnMaxim = new System.Windows.Forms.RadioButton();
            this.radioBtnMinim = new System.Windows.Forms.RadioButton();
            this.radioBtnProdus = new System.Windows.Forms.RadioButton();
            this.radioBtnSuma = new System.Windows.Forms.RadioButton();
            this.groupBoxActivare = new System.Windows.Forms.GroupBox();
            this.radioBtnLiniara = new System.Windows.Forms.RadioButton();
            this.Tangenta = new System.Windows.Forms.RadioButton();
            this.radioBtnSigmodiala = new System.Windows.Forms.RadioButton();
            this.radioBtnSemn = new System.Windows.Forms.RadioButton();
            this.radioBtnTreapta = new System.Windows.Forms.RadioButton();
            this.labelteta = new System.Windows.Forms.Label();
            this.labelGA = new System.Windows.Forms.Label();
            this.numericUpDownTeta = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGA = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGlobalInput = new System.Windows.Forms.TextBox();
            this.textBoxActivation = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.checkBoxBinar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxActivare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGA)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownInput
            // 
            this.numericUpDownInput.Location = new System.Drawing.Point(113, 21);
            this.numericUpDownInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInput.Name = "numericUpDownInput";
            this.numericUpDownInput.ReadOnly = true;
            this.numericUpDownInput.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownInput.TabIndex = 0;
            this.numericUpDownInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInput.ValueChanged += new System.EventHandler(this.numericUpDownInput_ValueChanged);
            // 
            // label_Input_Numbers
            // 
            this.label_Input_Numbers.AutoSize = true;
            this.label_Input_Numbers.Location = new System.Drawing.Point(12, 23);
            this.label_Input_Numbers.Name = "label_Input_Numbers";
            this.label_Input_Numbers.Size = new System.Drawing.Size(86, 16);
            this.label_Input_Numbers.TabIndex = 1;
            this.label_Input_Numbers.Text = "Input Number";
            // 
            // flowLayoutPanelInput
            // 
            this.flowLayoutPanelInput.AutoScroll = true;
            this.flowLayoutPanelInput.Location = new System.Drawing.Point(15, 97);
            this.flowLayoutPanelInput.Name = "flowLayoutPanelInput";
            this.flowLayoutPanelInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanelInput.Size = new System.Drawing.Size(276, 341);
            this.flowLayoutPanelInput.TabIndex = 2;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(15, 64);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(35, 16);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(145, 64);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(49, 16);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Weight";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.radioBtnMaxim);
            this.groupBoxInput.Controls.Add(this.radioBtnMinim);
            this.groupBoxInput.Controls.Add(this.radioBtnProdus);
            this.groupBoxInput.Controls.Add(this.radioBtnSuma);
            this.groupBoxInput.Location = new System.Drawing.Point(317, 97);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(127, 154);
            this.groupBoxInput.TabIndex = 3;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Functii input";
            // 
            // radioBtnMaxim
            // 
            this.radioBtnMaxim.AutoSize = true;
            this.radioBtnMaxim.Location = new System.Drawing.Point(7, 112);
            this.radioBtnMaxim.Name = "radioBtnMaxim";
            this.radioBtnMaxim.Size = new System.Drawing.Size(67, 20);
            this.radioBtnMaxim.TabIndex = 3;
            this.radioBtnMaxim.TabStop = true;
            this.radioBtnMaxim.Text = "Maxim";
            this.radioBtnMaxim.UseVisualStyleBackColor = true;
            this.radioBtnMaxim.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChanged);
            // 
            // radioBtnMinim
            // 
            this.radioBtnMinim.AutoSize = true;
            this.radioBtnMinim.Location = new System.Drawing.Point(7, 85);
            this.radioBtnMinim.Name = "radioBtnMinim";
            this.radioBtnMinim.Size = new System.Drawing.Size(63, 20);
            this.radioBtnMinim.TabIndex = 2;
            this.radioBtnMinim.TabStop = true;
            this.radioBtnMinim.Text = "Minim";
            this.radioBtnMinim.UseVisualStyleBackColor = true;
            this.radioBtnMinim.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChanged);
            // 
            // radioBtnProdus
            // 
            this.radioBtnProdus.AutoSize = true;
            this.radioBtnProdus.Location = new System.Drawing.Point(7, 58);
            this.radioBtnProdus.Name = "radioBtnProdus";
            this.radioBtnProdus.Size = new System.Drawing.Size(71, 20);
            this.radioBtnProdus.TabIndex = 1;
            this.radioBtnProdus.TabStop = true;
            this.radioBtnProdus.Text = "Produs";
            this.radioBtnProdus.UseVisualStyleBackColor = true;
            this.radioBtnProdus.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChanged);
            // 
            // radioBtnSuma
            // 
            this.radioBtnSuma.AutoSize = true;
            this.radioBtnSuma.Location = new System.Drawing.Point(7, 31);
            this.radioBtnSuma.Name = "radioBtnSuma";
            this.radioBtnSuma.Size = new System.Drawing.Size(63, 20);
            this.radioBtnSuma.TabIndex = 0;
            this.radioBtnSuma.TabStop = true;
            this.radioBtnSuma.Text = "Suma";
            this.radioBtnSuma.UseVisualStyleBackColor = true;
            this.radioBtnSuma.CheckedChanged += new System.EventHandler(this.radioBtn_CheckedChanged);
            // 
            // groupBoxActivare
            // 
            this.groupBoxActivare.Controls.Add(this.radioBtnLiniara);
            this.groupBoxActivare.Controls.Add(this.Tangenta);
            this.groupBoxActivare.Controls.Add(this.radioBtnSigmodiala);
            this.groupBoxActivare.Controls.Add(this.radioBtnSemn);
            this.groupBoxActivare.Controls.Add(this.radioBtnTreapta);
            this.groupBoxActivare.Location = new System.Drawing.Point(472, 97);
            this.groupBoxActivare.Name = "groupBoxActivare";
            this.groupBoxActivare.Size = new System.Drawing.Size(135, 176);
            this.groupBoxActivare.TabIndex = 4;
            this.groupBoxActivare.TabStop = false;
            this.groupBoxActivare.Text = "Functii activare";
            // 
            // radioBtnLiniara
            // 
            this.radioBtnLiniara.AutoSize = true;
            this.radioBtnLiniara.Location = new System.Drawing.Point(7, 139);
            this.radioBtnLiniara.Name = "radioBtnLiniara";
            this.radioBtnLiniara.Size = new System.Drawing.Size(68, 20);
            this.radioBtnLiniara.TabIndex = 4;
            this.radioBtnLiniara.TabStop = true;
            this.radioBtnLiniara.Text = "Liniara";
            this.radioBtnLiniara.UseVisualStyleBackColor = true;
            this.radioBtnLiniara.CheckedChanged += new System.EventHandler(this.radioBtnActivation_CheckedChanged);
            // 
            // Tangenta
            // 
            this.Tangenta.AutoSize = true;
            this.Tangenta.Location = new System.Drawing.Point(7, 112);
            this.Tangenta.Name = "Tangenta";
            this.Tangenta.Size = new System.Drawing.Size(86, 20);
            this.Tangenta.TabIndex = 3;
            this.Tangenta.TabStop = true;
            this.Tangenta.Text = "Tangenta";
            this.Tangenta.UseVisualStyleBackColor = true;
            this.Tangenta.CheckedChanged += new System.EventHandler(this.radioBtnActivation_CheckedChanged);
            // 
            // radioBtnSigmodiala
            // 
            this.radioBtnSigmodiala.AutoSize = true;
            this.radioBtnSigmodiala.Location = new System.Drawing.Point(7, 85);
            this.radioBtnSigmodiala.Name = "radioBtnSigmodiala";
            this.radioBtnSigmodiala.Size = new System.Drawing.Size(97, 20);
            this.radioBtnSigmodiala.TabIndex = 2;
            this.radioBtnSigmodiala.TabStop = true;
            this.radioBtnSigmodiala.Text = "Sigmodiala";
            this.radioBtnSigmodiala.UseVisualStyleBackColor = true;
            this.radioBtnSigmodiala.CheckedChanged += new System.EventHandler(this.radioBtnActivation_CheckedChanged);
            // 
            // radioBtnSemn
            // 
            this.radioBtnSemn.AutoSize = true;
            this.radioBtnSemn.Location = new System.Drawing.Point(7, 58);
            this.radioBtnSemn.Name = "radioBtnSemn";
            this.radioBtnSemn.Size = new System.Drawing.Size(63, 20);
            this.radioBtnSemn.TabIndex = 1;
            this.radioBtnSemn.TabStop = true;
            this.radioBtnSemn.Text = "Semn";
            this.radioBtnSemn.UseVisualStyleBackColor = true;
            this.radioBtnSemn.CheckedChanged += new System.EventHandler(this.radioBtnActivation_CheckedChanged);
            // 
            // radioBtnTreapta
            // 
            this.radioBtnTreapta.AutoSize = true;
            this.radioBtnTreapta.Location = new System.Drawing.Point(7, 31);
            this.radioBtnTreapta.Name = "radioBtnTreapta";
            this.radioBtnTreapta.Size = new System.Drawing.Size(76, 20);
            this.radioBtnTreapta.TabIndex = 0;
            this.radioBtnTreapta.TabStop = true;
            this.radioBtnTreapta.Text = "Treapta";
            this.radioBtnTreapta.UseVisualStyleBackColor = true;
            this.radioBtnTreapta.CheckedChanged += new System.EventHandler(this.radioBtnActivation_CheckedChanged);
            // 
            // labelteta
            // 
            this.labelteta.AutoSize = true;
            this.labelteta.Location = new System.Drawing.Point(473, 292);
            this.labelteta.Name = "labelteta";
            this.labelteta.Size = new System.Drawing.Size(35, 16);
            this.labelteta.TabIndex = 5;
            this.labelteta.Text = "Teta";
            // 
            // labelGA
            // 
            this.labelGA.AutoSize = true;
            this.labelGA.Location = new System.Drawing.Point(473, 321);
            this.labelGA.Name = "labelGA";
            this.labelGA.Size = new System.Drawing.Size(27, 16);
            this.labelGA.TabIndex = 6;
            this.labelGA.Text = "g/a";
            // 
            // numericUpDownTeta
            // 
            this.numericUpDownTeta.Location = new System.Drawing.Point(523, 290);
            this.numericUpDownTeta.Name = "numericUpDownTeta";
            this.numericUpDownTeta.Size = new System.Drawing.Size(71, 22);
            this.numericUpDownTeta.TabIndex = 7;
            this.numericUpDownTeta.ValueChanged += new System.EventHandler(this.numericUpDownTeta_ValueChanged);
            // 
            // numericUpDownGA
            // 
            this.numericUpDownGA.Location = new System.Drawing.Point(523, 319);
            this.numericUpDownGA.Name = "numericUpDownGA";
            this.numericUpDownGA.Size = new System.Drawing.Size(71, 22);
            this.numericUpDownGA.TabIndex = 8;
            this.numericUpDownGA.ValueChanged += new System.EventHandler(this.numericUpDownGA_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "GInput";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(473, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Activare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(661, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Output";
            // 
            // textBoxGlobalInput
            // 
            this.textBoxGlobalInput.Enabled = false;
            this.textBoxGlobalInput.Location = new System.Drawing.Point(372, 47);
            this.textBoxGlobalInput.Name = "textBoxGlobalInput";
            this.textBoxGlobalInput.ReadOnly = true;
            this.textBoxGlobalInput.Size = new System.Drawing.Size(72, 22);
            this.textBoxGlobalInput.TabIndex = 12;
            // 
            // textBoxActivation
            // 
            this.textBoxActivation.Enabled = false;
            this.textBoxActivation.Location = new System.Drawing.Point(535, 47);
            this.textBoxActivation.Name = "textBoxActivation";
            this.textBoxActivation.ReadOnly = true;
            this.textBoxActivation.Size = new System.Drawing.Size(72, 22);
            this.textBoxActivation.TabIndex = 13;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Location = new System.Drawing.Point(711, 44);
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(71, 22);
            this.textBoxOutput.TabIndex = 14;
            // 
            // checkBoxBinar
            // 
            this.checkBoxBinar.AutoSize = true;
            this.checkBoxBinar.Location = new System.Drawing.Point(711, 83);
            this.checkBoxBinar.Name = "checkBoxBinar";
            this.checkBoxBinar.Size = new System.Drawing.Size(60, 20);
            this.checkBoxBinar.TabIndex = 15;
            this.checkBoxBinar.Text = "Binar";
            this.checkBoxBinar.UseVisualStyleBackColor = true;
            this.checkBoxBinar.CheckedChanged += new System.EventHandler(this.checkBoxBinar_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.checkBoxBinar);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxActivation);
            this.Controls.Add(this.textBoxGlobalInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownGA);
            this.Controls.Add(this.numericUpDownTeta);
            this.Controls.Add(this.labelGA);
            this.Controls.Add(this.labelteta);
            this.Controls.Add(this.groupBoxActivare);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.flowLayoutPanelInput);
            this.Controls.Add(this.label_Input_Numbers);
            this.Controls.Add(this.numericUpDownInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxActivare.ResumeLayout(false);
            this.groupBoxActivare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownInput;
        private System.Windows.Forms.Label label_Input_Numbers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.RadioButton radioBtnProdus;
        private System.Windows.Forms.RadioButton radioBtnSuma;
        private System.Windows.Forms.RadioButton radioBtnMaxim;
        private System.Windows.Forms.RadioButton radioBtnMinim;
        private System.Windows.Forms.GroupBox groupBoxActivare;
        private System.Windows.Forms.RadioButton radioBtnLiniara;
        private System.Windows.Forms.RadioButton Tangenta;
        private System.Windows.Forms.RadioButton radioBtnSigmodiala;
        private System.Windows.Forms.RadioButton radioBtnSemn;
        private System.Windows.Forms.RadioButton radioBtnTreapta;
        private System.Windows.Forms.Label labelteta;
        private System.Windows.Forms.Label labelGA;
        private System.Windows.Forms.NumericUpDown numericUpDownTeta;
        private System.Windows.Forms.NumericUpDown numericUpDownGA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGlobalInput;
        private System.Windows.Forms.TextBox textBoxActivation;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.CheckBox checkBoxBinar;
    }
}

