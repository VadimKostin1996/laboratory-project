using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using payday;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;

namespace View
{
    public partial class PayrollForm : Form
    {
        public PayrollForm()
        {
            InitializeComponent();
        }

        public List<IPayday> payList = new List<IPayday>();

        public int selectedRow = -1; // выбранная строка, идентификатор того, в каком режиме откоется addOrModifyForm (добавить или изменить)

        private void addButton_Click(object sender, EventArgs e)
        {
            var addEmployee = new AddEmployeeForm();
            addEmployee.Owner = this;
            addEmployee.ShowDialog();
        }

        private void PayrollForm_Activated(object sender, EventArgs e)
        {
            if (payList.Count != 0)
            {
            payDataGridView.Rows.Clear();
            for (int i = 0; i != payList.Count; i++)
            {
                payDataGridView.Rows.Add(payList[i].name, payList[i].surname, payList[i].patronymic, payList[i].CalculationOfWages());
            }
                }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (payDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the row");
            }
            else
            {
                DialogResult result = MessageBox.Show("Remowe this row?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    payList.RemoveAt(payDataGridView.SelectedRows[0].Index);
                    payDataGridView.Rows.RemoveAt(payDataGridView.SelectedRows[0].Index);
                    MessageBox.Show("Row is removed");
                }
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (payDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the row");
            }
            else
            {
                var addEmployee = new AddEmployeeForm();
                addEmployee.Owner = this;
                selectedRow = payDataGridView.SelectedRows[0].Index;
                addEmployee.ShowDialog();
            }
        }

        private void createRandomDataButton_Click(object sender, EventArgs e)
        {
            String[] nameArr = new String[] { "Андрей", "Григорий", "Иван", "Пётр", };
            String[] surnameArr = new String[] { "Иванов", "Сидоров", "Петров", "Андреев" };
            String[] patronymicArr = new String[] { "Иванович", "Сидорович", "Петрович", "Андреевич" };
            var rand = new Random();
            for (int i = 0; i < 9; i++)
            {
                if (rand.Next(0, 2) == 0)
                {
                    var newCasing = new Casing(nameArr[rand.Next(0, 4)], surnameArr[rand.Next(0, 4)], patronymicArr[rand.Next(0, 4)], rand.Next(100,10000), 1/rand.Next(1,3));
                    payList.Add(newCasing);
                }
                if (rand.Next(0, 2) == 1)
                {
                    var newHourlyPay = new HourlyPay( nameArr[rand.Next(0, 4)], surnameArr[rand.Next(0, 4)], patronymicArr[rand.Next(0, 4)], rand.Next(1, 185), rand.Next(100, 1000));
                    payList.Add(newHourlyPay);
                }
            }
            MessageBox.Show("Data was created");
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Current data will be lost. Сontinue?", "New", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // выводим сообщение с вопросом
            if (result == DialogResult.Yes) // если пользователь отвечает да 
            {
                payList.Clear();             // очистить список объектов
                payDataGridView.Rows.Clear();     // очистить таблицу    
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serializer = new Newtonsoft.Json.JsonSerializer()
            {
                NullValueHandling = NullValueHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented,
                DefaultValueHandling = DefaultValueHandling.Ignore
            };
            var saveFileDialog = new SaveFileDialog();
            var fileName = saveFileDialog.FileName;
            saveFileDialog.Filter = "Pay | *.pay";
            saveFileDialog.OverwritePrompt = true;
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string outputString = Newtonsoft.Json.JsonConvert.SerializeObject(payList);
            using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
            {
                using (Newtonsoft.Json.JsonWriter jWriter = new Newtonsoft.Json.JsonTextWriter(streamWriter))
                {
                    serializer.Serialize(jWriter, payList);
                }
            }
            MessageBox.Show("File is saved");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                var serializer = new Newtonsoft.Json.JsonSerializer()
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    TypeNameHandling = TypeNameHandling.Auto,
                    Formatting = Formatting.Indented,
                    DefaultValueHandling = DefaultValueHandling.Ignore
                };
                var openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Payment|*.pay";
                if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
                {
                    using (Newtonsoft.Json.JsonReader jReader = new Newtonsoft.Json.JsonTextReader(streamReader))
                    {
                        payList = serializer.Deserialize<List<IPayday>>(jReader);
                    }
                }
                MessageBox.Show("File is loading");
            }
        }

        private void _payrollForm_Load(object sender, EventArgs e)
        {

        }

        private void payDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
