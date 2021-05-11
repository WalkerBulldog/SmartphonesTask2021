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
    public partial class FactoryViewForm : Form
    {
        private List<PhonesBatch> List = new List<PhonesBatch>();
        public FactoryViewForm()
        {
            InitializeComponent();
        }
        private void UpdateView()
        {
            BatchesView.Items.Clear();
            for (int i = 0; i < List.Count; i++)
                BatchesView.Items.Add(new ListViewItem(new string[] { i.ToString(), List[i].Type, List[i].Model, List[i].Count.ToString(), List[i].Cost.ToString(), List[i].Date.ToString() }));
        }

        private void AddBatchButton_Click(object sender, EventArgs e)
        {
            if(CountBox.Text == "")
            {
                MessageBox.Show("Введите количество телефонов в партии!");
                return;
            }
            AddBatchForm form = new AddBatchForm();
            form.ShowDialog();
            if(form.Phone != null)
                List.Add(new PhonesBatch(form.Phone, int.Parse(CountBox.Text), DateBatchPicker.Value));
            UpdateView();
        }

        private void DeleteBatchButton_Click(object sender, EventArgs e)
        {
            List.RemoveAt(BatchesView.SelectedItems[0].Index);
            BatchInfoLabel.Text = "Удалено!";
            UpdateView();
        }

        private void BatchInfoButton_Click(object sender, EventArgs e)
        {
            if(BatchesView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите партию!");
                return;
            }
            else BatchInfoLabel.Text = List[BatchesView.SelectedItems[0].Index].ToString();
        }
    }
}
