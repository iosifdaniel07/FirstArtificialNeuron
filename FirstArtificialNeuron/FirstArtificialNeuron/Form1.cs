using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstArtificialNeuron {
    public partial class Form1 : Form {

        private List<NumericUpDown> _inputXlist;
        private List<NumericUpDown> _weightlist;
        private List<Label> _labellistX;
        private List<Label> _labellistW;
        private int counter = 0;
        private FirstArtificialNeuron.Classes.ArtificialNeuron _neuron;
        public Form1() {
            InitializeComponent();

            _neuron = new FirstArtificialNeuron.Classes.ArtificialNeuron(1);
            _inputXlist = new List<NumericUpDown>();
            _weightlist = new List<NumericUpDown>();
            _labellistW = new List<Label>();
            _labellistX = new List<Label>();
            flowLayoutPanelInput.FlowDirection = FlowDirection.LeftToRight;

            checkBoxBinar.Checked = false;

            numericUpDownGA.Value = 1;
            numericUpDownGA.Increment = 0.1m;
            numericUpDownGA.DecimalPlaces = 2;
            numericUpDownGA.Minimum = -300;
            numericUpDownGA.Maximum = 300;
            numericUpDownTeta.Value = 0;
            numericUpDownTeta.Increment = 0.1m;
            numericUpDownTeta.DecimalPlaces = 2;
            numericUpDownTeta.Minimum = -300;
            numericUpDownTeta.Maximum = 300;

            AddInput();

        }

        private void numericUpDownInput_ValueChanged(object sender, EventArgs e) {
            if (numericUpDownInput.Value > counter && counter >= 1) {
                AddInput();
            }
            else if (numericUpDownInput.Value < counter && counter >= 1) {
                DeleteInput();
            }
        }

        private void DeleteInput() {
            flowLayoutPanelInput.Controls.Remove(_inputXlist[counter - 1]);
            flowLayoutPanelInput.Controls.Remove(_weightlist[counter - 1]);
            flowLayoutPanelInput.Controls.Remove(_labellistW[counter - 1]);
            flowLayoutPanelInput.Controls.Remove(_labellistX[counter - 1]);
            _inputXlist.RemoveAt(counter - 1);
            _weightlist.RemoveAt(counter - 1);
            _labellistX.RemoveAt(counter - 1);
            _labellistW.RemoveAt(counter - 1);

            _neuron._inputX.RemoveAt(counter - 1);
            _neuron._weight.RemoveAt(counter - 1);
            _neuron._numberInput = counter - 1;

            counter--;
        }

        private void AddInput() {
            counter++;

            //X1
            NumericUpDown Xinput = new NumericUpDown();
            Xinput.Size = new System.Drawing.Size(50, 20);
            Xinput.ValueChanged += new EventHandler(inputXValueChanged);
            Xinput.DecimalPlaces = 2;
            Xinput.Increment = 0.01M;
            Xinput.Minimum = -300;
            Xinput.Maximum = 300;
            Xinput.Name = Convert.ToString(counter);
            _inputXlist.Add(Xinput);
            _neuron._inputX.Add(0);
            _neuron._numberInput = counter;

            Label label1 = new Label();
            label1.Size = new System.Drawing.Size(30, 30);
            label1.Text = "X" + counter;
            label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            _labellistX.Add(label1);

            //W1
            NumericUpDown Winput = new NumericUpDown();
            Winput.Size = new System.Drawing.Size(50, 20);
            Winput.ValueChanged += new EventHandler(inputWeightValueChanged);
            Winput.DecimalPlaces = 2;
            Winput.Increment = 0.01M;
            Winput.Minimum = -300;
            Winput.Maximum = 300;
            Winput.Name = Convert.ToString(counter);
            _weightlist.Add(Winput);
            _neuron._weight.Add(0);

            Label label2 = new Label();
            label2.Size = new System.Drawing.Size(30, 30);
            label2.Text = "W" + counter;
            label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            _labellistW.Add(label2);

            flowLayoutPanelInput.Controls.Add(label1);
            flowLayoutPanelInput.Controls.Add(Xinput);
            flowLayoutPanelInput.Controls.Add(label2);
            flowLayoutPanelInput.Controls.Add(Winput);
        }


        private void inputXValueChanged(object sender, EventArgs e) {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            int position = Convert.ToInt32(numericUpDown.Name) - 1;
            _neuron._inputX[position] = (double)numericUpDown.Value;
            updateData();
        }

        private void inputWeightValueChanged(object sender, EventArgs e) {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            int position = Convert.ToInt32(numericUpDown.Name) - 1;
            _neuron._weight[position] = (double)numericUpDown.Value;
            updateData();
        }

        private void updateData() {

            if (radioBtnSuma.Checked) {
                _neuron.sumFunction();
                textBoxGlobalInput.Text = _neuron._globalInput.ToString();
            }
            else if (radioBtnProdus.Checked) {
                _neuron.produs();
                textBoxGlobalInput.Text = _neuron._globalInput.ToString();
            }
            else if (radioBtnMaxim.Checked) {
                _neuron.maxim();
                textBoxGlobalInput.Text = _neuron._globalInput.ToString();

            }
            else if (radioBtnMinim.Checked) {
                _neuron.minim();
                textBoxGlobalInput.Text = _neuron._globalInput.ToString();
            }

            if (radioBtnLiniara.Checked) {
                _neuron.functiaLiniara((double)numericUpDownTeta.Value, (double)numericUpDownGA.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
                updateData();

            }
            else if (radioBtnSemn.Checked) {
                _neuron.functiaSemn((double)numericUpDownTeta.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
                updateOutput();
            }
            else if (radioBtnTreapta.Checked) {
                _neuron.functiaTreapta((double)numericUpDownTeta.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
                updateOutput();
            }
            else if (radioBtnSigmodiala.Checked) {
                _neuron.functiaSigmoidala((double)numericUpDownTeta.Value, (double)numericUpDownGA.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
                updateOutput();
            }
            else if (Tangenta.Checked) {
                _neuron.functiaTangentaHiperbolica((double)numericUpDownTeta.Value, (double)numericUpDownGA.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
                updateOutput();
            }
        }

        private void radioBtn_CheckedChanged(object sender, EventArgs e) {

            if (radioBtnSuma.Checked) {
                _neuron.sumFunction();
                textBoxGlobalInput.Text = _neuron._globalInput.ToString();
            }
            else if (radioBtnProdus.Checked) {
                _neuron.produs();
                textBoxGlobalInput.Text = _neuron._globalInput.ToString();
            }
            else if (radioBtnMaxim.Checked) {
                _neuron.maxim();
                textBoxGlobalInput.Text = _neuron._globalInput.ToString();

            }
            else if (radioBtnMinim.Checked) {
                _neuron.minim();
                textBoxGlobalInput.Text = _neuron._globalInput.ToString();
            }
        }

        private void radioBtnActivation_CheckedChanged(object sender, EventArgs e) {
            if (radioBtnLiniara.Checked) {
                _neuron.functiaLiniara((double)numericUpDownTeta.Value, (double)numericUpDownGA.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
                updateOutput();
            }
            else if (radioBtnSemn.Checked) {
                _neuron.functiaSemn((double)numericUpDownTeta.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
                updateOutput();
            }
            else if (radioBtnTreapta.Checked) {
                _neuron.functiaTreapta((double)numericUpDownTeta.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
                updateOutput();
            }
            else if (radioBtnSigmodiala.Checked) {
                _neuron.functiaSigmoidala((double)numericUpDownTeta.Value, (double)numericUpDownGA.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
                updateOutput();
            }
            else if (Tangenta.Checked) {
                _neuron.functiaTangentaHiperbolica((double)numericUpDownTeta.Value, (double)numericUpDownGA.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
                updateOutput();
            }
        }

        private void numericUpDownTeta_ValueChanged(object sender, EventArgs e) {
            if (radioBtnLiniara.Checked) {
                _neuron.functiaLiniara((double)numericUpDownTeta.Value, (double)numericUpDownGA.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
            }
            else if (radioBtnSemn.Checked) {
                _neuron.functiaSemn((double)numericUpDownTeta.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
            }
            else if (radioBtnTreapta.Checked) {
                _neuron.functiaTreapta((double)numericUpDownTeta.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
            }
            else if (radioBtnSigmodiala.Checked) {
                _neuron.functiaSigmoidala((double)numericUpDownTeta.Value, (double)numericUpDownGA.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
            }
            else if (Tangenta.Checked) {
                _neuron.functiaTangentaHiperbolica((double)numericUpDownTeta.Value, (double)numericUpDownGA.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
            }
        }

        private void numericUpDownGA_ValueChanged(object sender, EventArgs e) {
            if (radioBtnLiniara.Checked) {
                _neuron.functiaLiniara((double)numericUpDownTeta.Value, (double)numericUpDownGA.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
            }
            else if (radioBtnSemn.Checked) {
                _neuron.functiaSemn((double)numericUpDownTeta.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
            }
            else if (radioBtnTreapta.Checked) {
                _neuron.functiaTreapta((double)numericUpDownTeta.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
            }
            else if (radioBtnSigmodiala.Checked) {
                _neuron.functiaSigmoidala((double)numericUpDownTeta.Value, (double)numericUpDownGA.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
            }
            else if (Tangenta.Checked) {
                _neuron.functiaTangentaHiperbolica((double)numericUpDownTeta.Value, (double)numericUpDownGA.Value);
                textBoxActivation.Text = _neuron._activation.ToString();
            }
        }

        private void checkBoxBinar_CheckedChanged(object sender, EventArgs e) {
            updateOutput();
        }

        private void updateOutput() {
            if (checkBoxBinar.Checked) {
                if (radioBtnLiniara.Checked) {
                    _neuron.activareTangentaLiniara();
                    textBoxOutput.Text = _neuron._globalOutput.ToString();
                }
                else if (radioBtnSemn.Checked) {
                    _neuron.activareSemn();
                    textBoxOutput.Text = _neuron._globalOutput.ToString();
                }
                else if (radioBtnTreapta.Checked) {
                    _neuron.activareTreapta();
                    textBoxOutput.Text = _neuron._globalOutput.ToString();
                }
                else if (radioBtnSigmodiala.Checked) {
                    _neuron.activareSigmoidala();
                    textBoxOutput.Text = _neuron._globalOutput.ToString();
                }
                else if (Tangenta.Checked) {
                    _neuron.activareTangentaLiniara();
                    textBoxOutput.Text = _neuron._globalOutput.ToString();
                }
            }
            else {
                textBoxOutput.Text = _neuron._activation.ToString();
            }
        }
    }

}

