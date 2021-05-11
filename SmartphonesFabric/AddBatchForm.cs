using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Smartphones;

namespace SmartphonesFabric
{
    public partial class AddBatchForm : Form
    {
        public Phone Phone = null;
        public AddBatchForm()
        {
            InitializeComponent();
            UnEnableAll();
        }
        private void UnEnableAll()
        {
            AddPhoneButton.Enabled = false;
            AOHcheckBox.Enabled = false;
            DisplayCheckBox.Enabled = false;
            FreeHandsCheckBox.Enabled = false;
            AnsweringMachineCheckBox.Enabled = false;
            SimCardCountComboBox.Enabled = false;
            MemoryBox.Enabled = false;
            MemoryCardCheckBox.Enabled = false;
            ScreenDiagonalScrollBar.Enabled = false;
            CameraBar.Enabled = false;
            BattaryBox.Enabled = false;
            OSPanel.Enabled = false;
            CPUcomboBox.Enabled = false;
            ModelTextBox.Enabled = false;
            CostBox.Enabled = false;
        }

        private void ScreenDiagonalScrollBar_Scroll(object sender, EventArgs e)
        {
            DiagonalLabel.Text = ((ScreenDiagonalScrollBar.Value) / 10.0).ToString();
        }

        private void CameraBar_Scroll(object sender, EventArgs e)
        {
            CameraMPLabel.Text = CameraBar.Value.ToString();
        }

        private void AddPhoneButton_Click(object sender, EventArgs e)
        {
            if(ModelTextBox.Text == ""||CostBox.Text == "")
            {
                MessageBox.Show("Введтие модель и стоимость телефона!");
                return;
            }
            if (RadioLLP.Checked)
                Phone = new LandLinePhone(ModelTextBox.Text, double.Parse(CostBox.Text), AOHcheckBox.Checked, DisplayCheckBox.Checked, FreeHandsCheckBox.Checked, AnsweringMachineCheckBox.Checked);
            else if (RadioPBP.Checked)
            {
                if (CheckDataPBP())
                    Phone = new PushButtonPhone(ModelTextBox.Text, double.Parse(CostBox.Text), sbyte.Parse(SimCardCountComboBox.SelectedItem.ToString()), double.Parse(DiagonalLabel.Text), double.Parse(MemoryBox.Text), MemoryCardCheckBox.Checked, CameraBar.Value, double.Parse(BattaryBox.Text));
            }
            else if(RadioSP.Checked)
            {
                if(CheckDataSP())
                {
                    if (RadioWindows.Checked)
                        Phone = new WindowsPhone(ModelTextBox.Text, double.Parse(CostBox.Text), sbyte.Parse(SimCardCountComboBox.SelectedItem.ToString()), float.Parse(DiagonalLabel.Text), double.Parse(MemoryBox.Text), MemoryCardCheckBox.Checked, CameraBar.Value, double.Parse(BattaryBox.Text), sbyte.Parse(CPUcomboBox.Text));
                    if (RadioAndroid.Checked)
                        Phone = new Android(ModelTextBox.Text, double.Parse(CostBox.Text), sbyte.Parse(SimCardCountComboBox.SelectedItem.ToString()), float.Parse(DiagonalLabel.Text), double.Parse(MemoryBox.Text), MemoryCardCheckBox.Checked, CameraBar.Value, double.Parse(BattaryBox.Text), sbyte.Parse(CPUcomboBox.Text));
                    if (RadioIOS.Checked)
                        Phone = new IPhone(ModelTextBox.Text, double.Parse(CostBox.Text), sbyte.Parse(SimCardCountComboBox.SelectedItem.ToString()), float.Parse(DiagonalLabel.Text), double.Parse(MemoryBox.Text), MemoryCardCheckBox.Checked, CameraBar.Value, double.Parse(BattaryBox.Text), sbyte.Parse(CPUcomboBox.Text));
                }
            }
            if (Phone != null)
                Close();
        }
        private bool CheckDataSP()
        {
            if (!CheckDataPBP())
                return false;
            if(CPUcomboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите количество ядер процессора!");
                return false;
            }
            if (RadioAndroid.Checked || RadioIOS.Checked || RadioWindows.Checked)
                return true;
            MessageBox.Show("Выберите операционную систему!");
            return false;
        }
        private bool CheckDataPBP()
        {
            if (SimCardCountComboBox.SelectedItem == null)
            {
                MessageBox.Show("Выберите количество сим-карт!");
                return false;
            }
            if (MemoryBox.Text == "")
            {
                MessageBox.Show("Введите память!");
                return false;
            }
            if (BattaryBox.Text == "")
            {
                MessageBox.Show("Введите ёмкость батареи!");
                return false;
            }
            return true;
        }
        private void EnableLLP()
        {
            UnEnableAll();
            AddPhoneButton.Enabled = true;
            AOHcheckBox.Enabled = true;
            AnsweringMachineCheckBox.Enabled = true;
            DisplayCheckBox.Enabled = true;
            FreeHandsCheckBox.Enabled = true;
            ModelTextBox.Enabled = true;
            CostBox.Enabled = true;
        }
        private void EnablePBP()
        {
            UnEnableAll();
            ModelTextBox.Enabled = true;
            CostBox.Enabled = true;
            AddPhoneButton.Enabled = true;
            CameraBar.Enabled = true;
            SimCardCountComboBox.Enabled = true;
            MemoryBox.Enabled = true;
            MemoryCardCheckBox.Enabled = true;
            ScreenDiagonalScrollBar.Enabled = true;
            BattaryBox.Enabled = true;
        }
        private void EnableSP()
        {
            UnEnableAll();
            EnablePBP();
            OSPanel.Enabled = true;
            CPUcomboBox.Enabled = true;
        }
        private void RadioLLP_CheckedChanged(object sender, EventArgs e)
        {
            EnableLLP();
        }

        private void RadioPBP_CheckedChanged(object sender, EventArgs e)
        {
            EnablePBP();
        }

        private void RadioSP_CheckedChanged(object sender, EventArgs e)
        {
            EnableSP();
        }
    }
}
