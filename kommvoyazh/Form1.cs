using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kommvoyazh
{
    public partial class Form1 : Form
    {
        int uzli, otv;
        int[,] time;
        int[] f;
        string[] puti;
        public Form1()
        {
            InitializeComponent();
        }

        private void sohrrazm_Click(object sender, EventArgs e)
        {
            uzli = vvodint(true, false, 0);
            if (uzli > 0)
            {
                time = new int[uzli, uzli];
                sohrrazm.Visible = false;
                vvodkolputei.Visible = false;
                mas.Visible = true;
                Vvodmas.Visible = true;
                for (int i = 0; i < uzli; i++)
                    mas.Columns.Add("col" + i, "" + (i + 1));
                mas.Rows.Add(uzli);
            }

        }

        private void vvodkolputei_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Vvodmas_Click(object sender, EventArgs e)
        {
            vvodint();
        }
        public void vvodint()
        {

            try
            {
                int sch = 0;
                for (int i1 = 0; i1 < uzli; i1++)
                {
                    for (int i2 = 0; i2 < uzli; i2++)
                    {
                        if (i1 == i2)
                        {

                            time[i1, i2] = 0;
                            if (sch == 0)
                                MessageBox.Show("Путь из точки в саму себя\nможет быть равен только нулю!\nЗаменили их на 0!", "Внимание!");
                            sch++;
                        }
                        else
                        {
                            time[i1, i2] = Convert.ToInt32(mas.Rows[i1].Cells[i2].Value);
                            if (time[i1, i2] <= 0)
                                throw new Exception("Меньше или равно нулю");
                        }
                    }
                }
                for (int i1 = 0; i1 < uzli; i1++)
                {
                    for (int i2 = 0; i2 < uzli; i2++)
                    {
                        mas.Rows[i1].Cells[i2].Value = time[i1, i2];
                    }
                }
                MessageBox.Show("Если Вас всё устраивает - нажмите на кнопку \"Далее\"\nВ противном случае измените данные и сохраните снова!");
            }
            catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "Меньше или равно нулю":
                        MessageBox.Show("ОШИБКА! Число должно быть больше нуля!", "Ошибка");
                        break;
                    default:
                        MessageBox.Show("ОШИБКА! Введите целые числа во все ячейка","Ошибка");
                        break;
                }
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            mas.Visible = !mas.Visible;
            Vvodmas.Visible = !Vvodmas.Visible;
            next.Visible = !next.Visible;
        }

        public int vvodint(bool bolshenulya, bool vopros, int kolvarotv)
        {
            int vvod;
            try
            {
                vvod = Convert.ToInt32(vvodkolputei.Text);
                if (bolshenulya)
                {
                    if (vvod <= 0)
                        throw new Exception("Меньше или равно нулю");
                }
                if (vopros)
                {
                    if (vvod < 0 || vvod >= kolvarotv)
                        throw new Exception("Ответ не совпадает с вариантом");
                }
            }
            catch (Exception ex)
            {
                switch (ex.Message)
                {
                    case "Меньше или равно нулю":
                        MessageBox.Show("ОШИБКА! Число должно быть больше нуля!","Ошибка");
                        break;
                    case "Ответ не совпадает с вариантом":
                        MessageBox.Show("ОШИБКА! Такого варианта не существует!","Ошибка");
                        break;
                    default:
                        MessageBox.Show("ОШИБКА! Введите целое число!", "Ошибка");
                        break;
                }
                return 0;
            }
            return vvod;
        }
    }
}
