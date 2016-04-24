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

namespace View
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private PayrollForm ownerForm
        {
            get
            {
                return this.Owner as PayrollForm;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void casingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            salaryTextBox.Visible = true;
            salaryLabel.Visible = true;
            rateTextBox.Visible = true;
            rateLabel.Visible = true;
            hourTextBox.Visible = false;
            hourLabel.Visible = false;
            paymentTextBox.Visible = false;
            paymentLabel.Visible = false;

        }

        private void hourlyPayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            salaryTextBox.Visible = false;
            salaryLabel.Visible = false;
            rateTextBox.Visible = false;
            rateLabel.Visible = false;
            hourTextBox.Visible = true;
            hourLabel.Visible = true;
            paymentTextBox.Visible = true;
            paymentLabel.Visible = true;
        }

        private void addOrModifyButton_Click(object sender, EventArgs e)
        {
            if (ownerForm.selectedRow == -1) // если форма открыта в режиме добавления строки
            {
                if (casingRadioButton.Checked == true)
                {
                    if (nameTextBox.Text == "" || surnameTextBox.Text == "" || patronymicTextBox.Text == "" || salaryTextBox.Text == "" || rateTextBox.Text == "")
                    {
                        MessageBox.Show("Incomplete data");
                        return;
                    }

                    if (casingRadioButton.Checked == true)
                    {
                        if ((Convert.ToDouble(rateTextBox.Text) > 1) || (Convert.ToDouble(rateTextBox.Text) < 0))
                        {
                            rateTextBox.Clear();
                            MessageBox.Show("Invalid number of rate");
                        }
                        else
                        {
                            var newCasing = new payday.Casing(nameTextBox.Text, surnameTextBox.Text, patronymicTextBox.Text,
                                Convert.ToDouble(salaryTextBox.Text), Convert.ToDouble(rateTextBox.Text));
                            ownerForm.payList.Add(newCasing);
                            this.Close();
                            MessageBox.Show("Record id add");
                            return;
                        }
                    }
                }
                ////////////////
                if (hourlyPayRadioButton.Checked == true)
                {
                    if (nameTextBox.Text == "" || surnameTextBox.Text == "" || patronymicTextBox.Text == "" || hourTextBox.Text == "" || paymentTextBox.Text == "")
                    {
                        MessageBox.Show("Incomplete data");
                        return;
                    }
                    if (Convert.ToInt32(hourTextBox.Text) > 184 || Convert.ToInt32(hourTextBox.Text) < 0)
                    {
                        MessageBox.Show("Invalid number of hours");
                        hourTextBox.Clear();
                        return;
                    }

                    var newHourlyPay = new HourlyPay(nameTextBox.Text, surnameTextBox.Text, patronymicTextBox.Text,
                    Convert.ToInt32(hourTextBox.Text), Convert.ToDouble(paymentTextBox.Text));
                    ownerForm.payList.Add(newHourlyPay);
                    this.Close();
                    MessageBox.Show("Record id add");
                    return;
                }
                MessageBox.Show("Select caltulation metod");
            }
            if (ownerForm.selectedRow != -1)
            {
                if (casingRadioButton.Checked == true)
                {
                    var casing = new Casing(nameTextBox.Text, surnameTextBox.Text, patronymicTextBox.Text,
                                    Convert.ToDouble(salaryTextBox.Text), Convert.ToDouble(rateTextBox.Text));
                    ownerForm.payList[ownerForm.selectedRow] = casing;
                    this.Close();
                    MessageBox.Show("Record id changed");
                    ownerForm.selectedRow = -1;
                    return;
                }
                if (hourlyPayRadioButton.Checked == true)
                {
                    var hourlyPay = new HourlyPay(nameTextBox.Text, surnameTextBox.Text, patronymicTextBox.Text,
                        Convert.ToInt32(hourTextBox.Text), Convert.ToDouble(paymentTextBox.Text));
                    ownerForm.payList[ownerForm.selectedRow] = hourlyPay;
                    this.Close();
                    MessageBox.Show("Record id changed");
                    ownerForm.selectedRow = -1;
                    return;
                }
            }
        }


        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
                e.Handled = true;  
            if (nameTextBox.Text == "")
            {
                // клавиша символ и длина строки 0 т.е. первый символ в строке
                e.KeyChar = Char.ToUpper(e.KeyChar);    // Делаем символ заглавным 
                //      ( при условии что символ будет именно первым)
                return;
            }
            
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
                e.Handled = true; 
            if (surnameTextBox.Text == "")
            {
                // клавиша символ и длина строки 0 т.е. первый символ в строке
                e.KeyChar = Char.ToUpper(e.KeyChar);    // Делаем символ заглавным 
                //      ( при условии что символ будет именно первым)
                return;
            }
            
        }

        private void patronymicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) && e.KeyChar != 8)
                e.Handled = true;
            if (patronymicTextBox.Text == "")
            {
                // клавиша символ и длина строки 0 т.е. первый символ в строке
                e.KeyChar = Char.ToUpper(e.KeyChar);    // Делаем символ заглавным 
                //      ( при условии что символ будет именно первым)
                return;
            }
            
        }

        private void salaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar)) && (e.KeyChar != ',')&& e.KeyChar != 8)
                e.Handled = true;
        }

        private void rateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar)) && (e.KeyChar != ',') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void hourTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void paymentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar)) && (e.KeyChar != ',') && e.KeyChar != 8)
                e.Handled = true;
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            if (ownerForm.selectedRow != -1 && ownerForm.payList.Count > 0) 
            {
                addButton.Text = "Modify";
                this.Text = "Modify employee";
                if (ownerForm.payList[ownerForm.selectedRow] is Casing)
                {
                    casingRadioButton.Checked = true;
                    nameTextBox.Text = ownerForm.payList[ownerForm.selectedRow].name;
                    surnameTextBox.Text = ownerForm.payList[ownerForm.selectedRow].surname;
                    patronymicTextBox.Text = ownerForm.payList[ownerForm.selectedRow].patronymic;
                    rateTextBox.Text = Convert.ToString((ownerForm.payList[ownerForm.selectedRow] as Casing).rate);
                    salaryTextBox.Text = Convert.ToString((ownerForm.payList[ownerForm.selectedRow] as Casing).salary);
                }
                if (ownerForm.payList[ownerForm.selectedRow] is payday.HourlyPay)
                {
                    hourlyPayRadioButton.Checked = true;
                    nameTextBox.Text = (ownerForm.payList[ownerForm.selectedRow].name);
                    surnameTextBox.Text = (ownerForm.payList[ownerForm.selectedRow].surname);
                    patronymicTextBox.Text = (ownerForm.payList[ownerForm.selectedRow].patronymic);
                    hourTextBox.Text = Convert.ToString((ownerForm.payList[ownerForm.selectedRow] as HourlyPay).hour);
                    paymentTextBox.Text = Convert.ToString((ownerForm.payList[ownerForm.selectedRow] as HourlyPay).payment);
                }
            }
        }
    }
}