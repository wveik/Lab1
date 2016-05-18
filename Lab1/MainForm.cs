using Lab1.Models;
using Lab1.Service;
using Lab1.ServiceWindows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1 {
    public partial class MainForm : Form {

        //Список всех Владельцев
        public List<Owner> listOwner = new List<Owner>();

        //Список ТО
        public List<AutoDescription> listDescription = new List<AutoDescription>();

        public MainForm() {
            InitializeComponent();

            string path = string.Empty;
            string arrayData = string.Empty;

            //Получаем текущую директорию
            path = Directory.GetCurrentDirectory();

            path += "\\" + Properties.Settings.Default.name_file_owner;

            //Открываем файл со список владельцев
            string[] rows = File.ReadAllLines(path, Encoding.UTF8);

            foreach (var row in rows) {
                listOwner.Add(new Owner(row));
            }

            foreach (var item in this.listOwner.OrderBy(x => x.LAST_NAME)) {
                comboBoxOwners.Items.Add(item);
            }
            comboBoxOwners.DisplayMember = "LAST_NAME";
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddOrEditAutoDescription add = new AddOrEditAutoDescription(this);
            if (add.ShowDialog() == DialogResult.OK) {
                ShowListDescription(listDescription);
            }
        }

        private void ShowListDescription(List<AutoDescription> listDescription) {
            dataGridViewMain.DataSource = null;
            var orderedList = listDescription.OrderBy(x => x, new MyCompareDescription()).ToList();
            dataGridViewMain.DataSource = orderedList;
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            Lab1.Models.Owner owner = (Lab1.Models.Owner)comboBoxOwners.SelectedItem;

            List<AutoDescription> result = new List<AutoDescription>();

            foreach (var item in listDescription) {
                if (!string.IsNullOrEmpty(txtMark.Text)) {
                    if (!item.MARK.ToLower().Contains(txtMark.Text.Trim().ToLower()))
                        continue;
                }
                if (!string.IsNullOrEmpty(txtNumber.Text)) {
                    if (!item.NUMBER.ToLower().Contains(txtNumber.Text.Trim().ToLower()))
                        continue;
                }
                if (owner != null) {
                    if(item.LAST_NAME != owner.LAST_NAME)
                        continue;
                }
                if (checkDate.Checked) {
                    if (item.CREATE_DATE != dateTimeCreate.Value.Date.ToShortDateString())
                        continue;
                }

                result.Add(item);
            }

            ShowListDescription(result);
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            if (dataGridViewMain.Rows.Count == 0) {
                MessageBox.Show("Нет записей!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = 0;
            try {
                index = dataGridViewMain.SelectedCells[0].RowIndex;
            } catch {
                index = 0;
            }
            int id = int.Parse(dataGridViewMain.Rows[index].Cells["ID_DESCRIPTION"].Value.ToString());

            List<AutoDescription> result = new List<AutoDescription>();

            foreach (var item in listDescription) {
                if (item.ID_DESCRIPTION == id) continue;

                result.Add(item);
            }

            listDescription = result;

            ShowListDescription(listDescription);
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if (dataGridViewMain.Rows.Count == 0) {
                MessageBox.Show("Нет записей!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = 0;
            try {
                index = dataGridViewMain.SelectedCells[0].RowIndex;
            } catch {
                index = 0;
            }
            int id = -1;
            try {
                id = int.Parse(dataGridViewMain.Rows[index].Cells["ID_DESCRIPTION"].Value.ToString());
            } catch {
                id = int.Parse(dataGridViewMain.Rows[index].Cells[0].Value.ToString());
            }

            AutoDescription description = listDescription.First(x => x.ID_DESCRIPTION == id);

            AddOrEditAutoDescription edit = new AddOrEditAutoDescription(this, description);
            if (edit.ShowDialog() == DialogResult.OK) {
                ShowListDescription(listDescription);
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e) {
            string path = string.Empty;
            string arrayData = string.Empty;

            //Получаем текущую директорию
            path = Directory.GetCurrentDirectory();

            path += "\\" + Properties.Settings.Default.main_file;

            if (!File.Exists(path)) {
                File.Delete(path);
            }
            using (StreamWriter sw = File.CreateText(path)) {

                foreach (var item in listDescription) {
                    sw.WriteLine(
                        item.ID_DESCRIPTION.ToString() + "\t"
                        + item.MARK + "\t"
                        + item.NUMBER + "\t"
                        + item.LAST_NAME + "\t"
                        + item.CREATE_DATE
                    );
                }
            }

            StringBuilder builder = new StringBuilder();

            foreach (var item in listDescription) {
                builder.Append(
                    item.ID_DESCRIPTION.ToString() + "\t"
                    + item.MARK + "\t"
                    + item.NUMBER + "\t"
                    + item.LAST_NAME + "\t"
                    + item.CREATE_DATE
                    );
                builder.Append(Environment.NewLine);
            }

            MessageBox.Show("Сохранено Успешно!");
        }

        private void openMenuItem_Click(object sender, EventArgs e) {
            string path = string.Empty;
            string arrayData = string.Empty;

            //Получаем текущую директорию
            path = Directory.GetCurrentDirectory();

            path += "\\" + Properties.Settings.Default.main_file;

            if (!File.Exists(path)) {
                MessageBox.Show("Нет данных!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Открываем файл со список владельцев
            string[] rows = File.ReadAllLines(path, Encoding.UTF8);

            foreach (var row in rows) {
                listDescription.Add(new AutoDescription(row));
            }
            ShowListDescription(listDescription);
        }
    }
}
