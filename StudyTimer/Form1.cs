using Newtonsoft.Json;

namespace StudyTimer
{
    public partial class Form1 : Form
    {
        private List<Work> works;
        private static Form1 _instance;
        
        public static Form1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Form1();
                }
                return _instance;
            }
        }
        public Form1()
        {
            InitializeComponent();
            this.LoadWorksFromFile();
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
        }


        private void settingsButton_Click(object sender, EventArgs e)
        {
            using (SettingsForm settingsForm = new SettingsForm(this.works))
            {
                var result = settingsForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.SaveWorksToFile();
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            using(StudyForm studyTimerForm = new StudyForm(this.works))
            {
                studyTimerForm.ShowDialog();
            }
        }
        // ��leri JSON'dan y�kleme
        private void LoadWorksFromFile()
        {
            if (File.Exists(GetJsonFilePath()))
            {
                string json = File.ReadAllText(GetJsonFilePath());
                this.works = JsonConvert.DeserializeObject<List<Work>>(json);
            }
            else
            {
                this.works = new List<Work>();
            }
        }

        // ��leri JSON'a kaydetme
        private void SaveWorksToFile()
        {
            string json = JsonConvert.SerializeObject(this.works, Formatting.Indented,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
            File.WriteAllText(GetJsonFilePath(), json);
        }

        private string GetJsonFilePath()
        {
            // Uygulaman�n bulundu�u dizin + JSON dosyas� ismi
            return Path.Combine(Application.StartupPath, "works.json");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var work in this.works)
            {
                work.sessionTime = 0;
            }
            this.SaveWorksToFile();
        }

        public void GetWorks(List<Work> works)
        {
            this.works = works;
        }
    }
}
