using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbResult.Controls[0].Visible = false;
            tbResult.Visible = false;
            textBox1.Visible = false;
            pereplata.Controls[0].Visible = false;
        }
             
        double sum;
        double dPercent;
        int time;
        double payment;
        double sum2;
        double per;   //размер переплаты
        double dPer;  //срок для анн. расчета переплаты
        double per1;

        double sum0;
        double time0;
        double dPercent0;
        double sum20;
      




        private void btnCount_Click(object sender, EventArgs e)
        {
            lvPayments.Items.Clear();

            if (comboprocess.SelectedIndex == 0)
            {
                try
                {
                    textBox1.Visible = false;
                    tbResult.Visible = true;
                 

                    sum = double.Parse(tbSum.Text);
                    time = Int32.Parse(tbTime.Text);
                    dPercent = double.Parse(tbPercent.Text);

                    dPer = double.Parse(tbPercent.Text);


                    dPercent /= 1200;

                    payment = (sum * dPercent) / (1 - Math.Pow(1 + dPercent, -time));

                    // per = payment * dPer - sum;
                    //per = -sum;
                   // per
                }
                catch (FormatException)
                {
                    MessageBox.Show("Неправильный формат ввода данных");
                }

                tbResult.Text = Math.Round(payment, 2).ToString();
                per = payment* time - sum;

                CalcPayments();
            }

            

           else if (comboprocess.SelectedIndex == 1)
            {
                
                try
                {
                    tbResult.Visible = false;
                    textBox1.Visible = true;

                    sum = double.Parse(tbSum.Text);
                    time = Int32.Parse(tbTime.Text);
                    dPercent = double.Parse(tbPercent.Text);

                    dPercent /= 1200;
                    sum2 = sum;

                    per1 = -sum;
                    sum0 = sum;
                    time0 = time;
                    dPercent0 = dPercent;
                    sum20 = sum2;
                    

                    for (int j = 0; j < time; j++)
                    {

                        double sumMonth0 = sum0 / time0;
                        double perMonth0 = dPercent0 * sum20;


                        sum20 -= sumMonth0;
                        double total0 = sumMonth0 + perMonth0;
                        per1 = per1 + total0;

                    }
                    
                 //    payment = (sum * dPercent) / (1 - Math.Pow(1 + dPercent, -time));


                }
                catch (FormatException)
                {
                    MessageBox.Show("Неправильный формат ввода данных");
                }

                //  tbResult.Text="0,00";
                //  MessageBox.Show("Ежемесячный платеж см. в табл.погашения Платеж");
                // tbResult.Show.Text("см. в табл.погашения Платеж");
               // tbResult.ResetText();
               // textBox1 = "см. в табл.погашения Платеж";

                 CalcPayments2();
            } 

            else
            {
                comboprocess.Text = "Тип не выбран";
            }

            } 

private void CalcPayments()
        {
            DateTime payDay = dateTimePicker1.Value;
            payDay = payDay.AddMonths(1);
            for (int i = 0; i < time; i++)
            {
                double perMonth = sum * dPercent;             
                double sumMonth = payment - perMonth;
                sum -= sumMonth;
                double total = sumMonth + perMonth;
                //double pereplat=per;


                ListViewItem item = new ListViewItem((i + 1).ToString());


                //  item.SubItems.Add("1");
                //item.SubItems.Add(dateTimePicker1.)

                //dateTimePicker1.Value = new DateTime(DateTime.Today.Date);
                
                item.SubItems.Add(payDay.ToShortDateString());

                //start.AddMonths(1);
                payDay = payDay.AddMonths(1);
                item.SubItems.Add(string.Format("{0:#,##0.00}", Convert.ToDecimal(Math.Round(sumMonth, 2).ToString())));             
                item.SubItems.Add(string.Format("{0:#,##0.00}", Convert.ToDecimal(Math.Round(perMonth, 2).ToString())));
                item.SubItems.Add(string.Format("{0:#,##0.00}", Convert.ToDecimal(Math.Round(sum, 2).ToString())));
                item.SubItems.Add(string.Format("{0:#,##0.00}", Convert.ToDecimal(Math.Round(total, 2).ToString())));


                lvPayments.Items.Add(item);

                pereplata.Text = Convert.ToString(per);
            }

        }

        private void CalcPayments2()
        {
            DateTime payDay = dateTimePicker1.Value;
            payDay = payDay.AddMonths(1);

            for (int i = 0; i < time; i++)
            {
                
                double sumMonth = sum / time;
                double perMonth = dPercent * sum2;
                               

                sum2 -= sumMonth;
                double total = sumMonth + perMonth;

                



                ListViewItem item = new ListViewItem((i + 1).ToString());

                //item.SubItems.Add("1");

                item.SubItems.Add(payDay.ToShortDateString());

                //start.AddMonths(1);
                payDay = payDay.AddMonths(1);

                item.SubItems.Add(string.Format("{0:#,##0.00}", Convert.ToDecimal(Math.Round(sumMonth, 2).ToString())));
                item.SubItems.Add(string.Format("{0:#,##0.00}", Convert.ToDecimal(Math.Round(perMonth, 2).ToString())));
                item.SubItems.Add(string.Format("{0:#,##0.00}", Convert.ToDecimal(Math.Round(sum2, 2).ToString())));
               // item.SubItems.Add(Math.Round(total, 2).ToString());

                item.SubItems.Add(string.Format("{0:#,##0.00}", Convert.ToDecimal(Math.Round(total, 2).ToString())));
                

                lvPayments.Items.Add(item);

                pereplata.Text = Convert.ToString(per1);


            }
           
        }

        
    }
    
}
