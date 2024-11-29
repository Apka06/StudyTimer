using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace StudyTimer
{
    public partial class StudyForm : Form
    {
        private List<Work> works; // SettingsForm'dan gelen işler
        private Timer timer;
        private Work activeWork = null;
        private DateTime sessionStart;
        public StudyForm(List<Work> works)
        {
            InitializeComponent();
            this.works = works;
            InitializeDataGridView();

            // Timer başlatma
            timer = new Timer();
            timer.Interval = 1000; // Her saniye
            timer.Tick += Timer_Tick;
            this.FormClosing += new FormClosingEventHandler(this.btnClose_Click);
        }

        private void InitializeDataGridView()
        {
            // İşleri ekle
            foreach (var work in works)
            {
                dataGridView1.Rows.Add(work.Name, GetTime(work.sessionTime)); // Oturum süresi sıfırdan başlar
            }

            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2) // Başla/Dur butonu
            {
                var selectedWork = works[e.RowIndex];

                if (activeWork != null && activeWork != selectedWork)
                {
                    StopActiveWork();
                }

                if (activeWork == selectedWork)
                {
                    StopActiveWork();
                }
                else
                {
                    StartWork(selectedWork);
                }
            }
        }

        private void StartWork(Work work)
        {
            activeWork = work;
            Debug.WriteLine(activeWork.sessionTime);
            sessionStart = DateTime.Now;
            timer.Start();
        }

        private void StopActiveWork()
        {
            timer.Stop();
            if (activeWork != null)
            {
                var elapsed = (DateTime.Now - sessionStart).TotalSeconds;
                activeWork.totalTimeWorked += elapsed;
                activeWork.sessionTime += elapsed;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == activeWork.Name)
                    {
                        row.Cells[1].Value = this.GetTime(activeWork.sessionTime);
                        break;
                    }
                }

                activeWork = null;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (activeWork != null)
            {
                var elapsed = (DateTime.Now - sessionStart).TotalSeconds;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value.ToString() == activeWork.Name)
                    {
                        row.Cells[1].Value = this.GetTime(elapsed + activeWork.sessionTime);
                        break;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (activeWork != null)
            {
                var elapsed = (DateTime.Now - sessionStart).TotalSeconds;
                activeWork.totalTimeWorked += elapsed;
                activeWork.sessionTime += elapsed;
            }
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
