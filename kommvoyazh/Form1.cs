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
        int[] f= new int[0];
        string[] puti = new string[0];
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
                if (sch == 0)
                    MessageBox.Show("Путь из точки в саму себя\nможет быть равен только нулю!\nЗаменили их на 0!", "Внимание!");
                for (int i1 = 0; i1 < uzli; i1++)
                {
                    for (int i2 = 0; i2 < uzli; i2++)
                    {
                        mas.Rows[i1].Cells[i2].Value = time[i1, i2];
                    }
                }
                MessageBox.Show("Если Вас всё устраивает - нажмите на кнопку \"Далее\"\nВ противном случае измените данные и сохраните снова!");
                next.Visible = !next.Visible;
            }
            catch
            {
                MessageBox.Show("ОШИБКА! Введите целые числа больше нуля во все ячейки", "Ошибка");
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            mas.Visible = !mas.Visible;
            Vvodmas.Visible = !Vvodmas.Visible;
            next.Visible = !next.Visible;
            otvet.Visible = !otvet.Visible;
            restart.Visible = !restart.Visible;
            for (int i = 0; i <= mas.Rows.Count; i++)
            {
                mas.Rows.RemoveAt(0);
            }
            for (int i = 0; i <= mas.Columns.Count; i++)
            {
                mas.Columns.RemoveAt(0); ;
            }

            for (int i = 0; i < uzli; i++) //точка отправления - передаем в метод для поиска путей
            {
                Array.Resize(ref puti, puti.Length + 1);
                Array.Resize(ref f, f.Length + 1);
                puti[puti.Length - 1] = $"{i + 1}";
                puti = schet(puti.Length - 1, i, 0);
            }
            otvet.Text += "Все пути:\r\n";
            for (int i = 0; i < puti.Length; i++)
            {
                otvet.Text += $"Путь: {puti[i]}, F = {f[i]} у.д.е.\r\n";
            }
            int min = f[0];
            for (int i = 1; i < puti.Length; i++)
            {
                if (min > f[i])
                    min = f[i];
            }
            otvet.Text += "\r\nОТВЕТ:\r\nПути с наименьшими затратами: \r\n";
            for (int i = 0; i < puti.Length; i++)
            {
                if (f[i] == min)
                    otvet.Text += (puti[i] + ", F = " + f[i]+ "\r\n");
            }

        }

        private void restart_Click(object sender, EventArgs e)
        {
            vvodkolputei.Visible = !vvodkolputei.Visible;
            vvodkolputei.Text = "";
            sohrrazm.Visible = !sohrrazm.Visible;
            restart.Visible = !restart.Visible;
            otvet.Text = "";
            otvet.Visible = !otvet.Visible;
            f = new int[0];
            puti = new string[0];
        }
        public string[] schet(int pi, int i1, int i2)
        {
            int min = time[i1, i2], mi2 = i2;
            if (puti[pi].Length != time.GetLength(0) * 2 - 1)
            {
                for (int j = 0; j < time.GetLength(0); j++)
                {
                    if (time[i1, j] != 0)
                    {
                        if (poisksovpad(pi, j + 1))
                        {
                            min = time[i1, j];
                            mi2 = j;
                            break;
                        }
                    }
                }
                for (int j = 0; j < time.GetLength(0); j++)
                {
                    if (time[i1, j] != 0)
                    {
                        if (poisksovpad(pi, j + 1))
                        {
                            if (min > time[i1, j] || (min == time[i1, j] && j == mi2))
                            {
                                min = time[i1, j];
                                mi2 = j;

                            }
                        }
                    }
                }
                for (int j = i2; j < time.GetLength(0); j++) //0
                {
                    if (poisksovpad(pi, j + 1))
                        if (min == time[i1, j] && j != mi2)
                        {
                            string s = puti[pi];
                            int ff = f[pi];
                            puti[pi] += $"-{mi2 + 1}";
                            f[pi] += min;
                            puti = schet(pi, mi2, 0);
                            mi2 = j;
                            Array.Resize(ref puti, puti.Length + 1);
                            Array.Resize(ref f, f.Length + 1);
                            pi = f.Length - 1;
                            puti[pi] = s;
                            f[pi] = ff;
                        }
                }
            }
            else
            {
                foreach (string s in puti[pi].Split('-'))
                {
                    mi2 = Convert.ToInt32(s);

                    min = time[i1, mi2 - 1];
                    break;
                }
                puti[pi] += $"-{mi2}";
                f[pi] += min;
                return puti;
            }
            puti[pi] += $"-{mi2 + 1}";
            f[pi] += min;
            puti = schet(pi, mi2, 0);
            return puti;
        }

        public bool poisksovpad(int pi, int j)
        {
            bool sch = true; //совпадений нет
            foreach (string s in puti[pi].Split('-'))
            {
                if (Convert.ToInt32(s) == j)
                {
                    sch = false; //есть
                    break;
                }
            }
            return sch;
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
