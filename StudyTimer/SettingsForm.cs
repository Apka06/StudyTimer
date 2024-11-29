using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyTimer
{
    public partial class SettingsForm : Form
    {
        public List<Work> works;
        public SettingsForm(List<Work> works)
        {
            this.works = works;
            InitializeComponent();
            InitializeDataGridView();
        }

        // DataGridView başlatma
        private void InitializeDataGridView()
        {
            foreach (var work in works)
            {
                dataGridView1.Rows.Add(work.Name, GetTime(work.totalTimeWorked)); // Oturum süresi sıfırdan başlar
            }
            // Event ekle: silme butonuna basıldığında
            this.dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) // Sil butonu
            {
                if (MessageBox.Show("Are you sure you want to delete this work??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    works.RemoveAt(e.RowIndex); // İş listeden silinir
                    dataGridView1.Rows.RemoveAt(e.RowIndex); // Satır grid'den silinir
                }
            }
        }

        // Yeni iş eklemek için butonun tıklanması
        private void btnAddWork_Click(object sender, EventArgs e)
        {
            using (AddWorkForm addWorkForm = new AddWorkForm())
            {
                if (addWorkForm.ShowDialog() == DialogResult.OK)
                {
                    string workName = addWorkForm.WorkName;
                    Work newWork = new Work(workName, 0);
                    works.Add(newWork);

                    // Yeni iş grid'e eklenir
                    dataGridView1.Rows.Add(newWork.Name, newWork.totalTimeWorked);
                }
            }
        }

        // Tüm işleri temizleme butonu
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete all works?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                works.Clear();
                dataGridView1.Rows.Clear();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Form1.Instance.GetWorks(this.works);
            this.Close();
        }
        private string GetTime(double seconds)
        {
            int hours = (int)seconds / 3600;
            int minutes = ((int)seconds / 60) - (hours * 60);
            int sec = (int)seconds % 60;
            return hours.ToString() + ":" + minutes.ToString() + ":" + sec.ToString();
        }
    }
}
