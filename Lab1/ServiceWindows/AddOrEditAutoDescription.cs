using Lab1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.ServiceWindows {
    public partial class AddOrEditAutoDescription : Form {

        private MainForm main;

        private AutoDescription description;

        private void Init() {

            foreach (var item in this.main.listOwner.OrderBy(x => x.LAST_NAME)) {
                comboBoxOwners.Items.Add(item);
            }
            comboBoxOwners.DisplayMember = "LAST_NAME";

        }

        public AddOrEditAutoDescription(MainForm main) {
            InitializeComponent();
            this.main = main;
            Init();
        }

        public AddOrEditAutoDescription(MainForm main, AutoDescription desc) {
            InitializeComponent();
            this.main = main;
            Init();
            description = desc;

            txtMark.Text = description.MARK;
            txtNumber.Text = description.NUMBER;
            if (!string.IsNullOrEmpty(description.CREATE_DATE)) {
                dateTimeCreate.Value = DateTime.Parse(description.CREATE_DATE).Date;
            }

            comboBoxOwners.SelectedItem = this.main.listOwner.First(x => x.LAST_NAME == description.LAST_NAME);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(txtMark.Text)) {
                MessageBox.Show("Вы не заполнили марку!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtNumber.Text)) {
                MessageBox.Show("Вы не заполнили номер!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Lab1.Models.Owner owner = (Lab1.Models.Owner)comboBoxOwners.SelectedItem;

            if (owner == null) {
                MessageBox.Show("Вы не выбрали владельца!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AutoDescription description = new AutoDescription();

            if (this.description != null) {
                description = this.description;
            } else {
                description.ID_DESCRIPTION = main.listDescription.Count == 0 ? 1 : main.listDescription.Max(x => x.ID_DESCRIPTION) + 1;
            }

            description.MARK = txtMark.Text;
            description.NUMBER = txtNumber.Text;
            if (checkBoxIsSetDate.Checked) {
                description.CREATE_DATE = dateTimeCreate.Value.ToShortDateString();
            } else {
                description.CREATE_DATE = string.Empty;
            }
            description.LAST_NAME = owner.LAST_NAME;

            if (this.description == null) {
                main.listDescription.Add(description);
            }

            DialogResult = DialogResult.OK;
        }

        private void checkBoxIsSetDate_CheckedChanged(object sender, EventArgs e) {
            groupBoxDate.Enabled = checkBoxIsSetDate.Checked;
        }
    }
}
