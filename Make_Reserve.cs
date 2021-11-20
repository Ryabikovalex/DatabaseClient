using DatabaseClient.DbModels;
using DatabaseClient.Properties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseClient
{
    public partial class MakeReserve : ProjectForm
    {
        private List<DbModels.AvialableRooms> _rooms;

        /// <summary>
        /// Конструктор формы Создания брони
        /// </summary>
        /// <param name="parent">Форма Поиска свободных номеров</param>
        /// <param name="list">Список номеров выбранных для бронирования</param>
        public MakeReserve(ProjectForm parent, List<DbModels.AvialableRooms> list)
        {
            InitializeComponent();

            ParentF = parent;
            ParentF.Hide();
            this.Show();
            _rooms = list;

            // Заполнение списков
            foreach (DbModels.AvialableRooms room in _rooms)
            {
                ListViewItem lvi = new ListViewItem(new[] {
                        room.Number.ToString(),
                        room.Capacity.ToString(),
                        room.CheckIn,
                        room.Cost.ToString()
                    });
                lvi.Tag = room;

                ReserveRooms_List.Items.Add(lvi);
            }

            // Выравнивание столбцов по шапке
            ReserveRooms_List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            // Настройка RadioBox по умолчанию
            sexMale_radio.Checked = true;

            Reserve_btn.Enabled = false;
        }

        private void Reservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentF.enableElements();
            ParentF.Show();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            ParentF.enableElements();
            ParentF.Show();
        }

        private void clientType_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if(checkBox.Checked)
            {
                sexMale_radio.Checked = false;
                sexMale_radio.Enabled = false;
                sexFemale_radio.Checked = false;
                sexFemale_radio.Enabled = false;
            } else
            {
                sexMale_radio.Checked = true;
                sexMale_radio.Enabled = true;
                sexFemale_radio.Checked = false;
                sexFemale_radio.Enabled = true;

            }
        }

        private void Name_textbox_TextChanged(object sender, EventArgs e)
        {
            if (Name_textbox.TextLength > 0 && Name_textbox.Text.Contains(" "))
            {
                Name_textbox.ForeColor = Color.Green;
                if (Number_textbox.ForeColor == Color.Green)
                    Reserve_btn.Enabled = true;
                else
                    Reserve_btn.Enabled = false;
            }
            else
            {
                Name_textbox.ForeColor = Color.Black;
                Reserve_btn.Enabled = false;
            }
        }

        private void Number_textbox_TextChanged(object sender, EventArgs e)
        {
            if (Number_textbox.TextLength < 18 && Number_textbox.TextLength > 0)
            {
                // Проверка телефонного номера
                Match m = Regex.Match(Number_textbox.Text, Resources.RegExTelePhone);

                if (m.Success)
                {
                    Number_textbox.ForeColor = Color.Green;
                    if (Name_textbox.ForeColor == Color.Green)
                        Reserve_btn.Enabled = true;
                }
                else
                {
                    Number_textbox.ForeColor = Color.Red;
                    Reserve_btn.Enabled = false;
                }
            }
            else
            {
                Number_textbox.ForeColor = Color.Black;
                Reserve_btn.Enabled = false;
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Number_textbox.Text = "";
            Name_textbox.Text = "";
            clientType_checkbox.Checked = false;
        }

        private void Reserve_btn_Click(object sender, EventArgs e)
        {
            disableElements();
            Match m = Regex.Match(Number_textbox.Text, Resources.RegExTelePhone);
            string number = "", name = "";
            bool type = clientType_checkbox.Checked ? true : false;
            bool sex = (type || sexMale_radio.Checked) ? false : true;
            for (int i = 1; i < m.Groups.Count; i++)
                number += m.Groups[i].Value.ToString();
            name = Name_textbox.Text.ToString();

            // Доделать проверку на наличие клиента до этого
            // Если его нет то добавить
            // Если есть то сделать резервацию новую
            using (MaiDbLbContext db = new MaiDbLbContext())
            {
                Client client = db.Client.Where(p => p.Telephone == number || p.Fio == name).FirstOrDefault();
                if (client != null)
                {
                    if (client.Fio != name
                         && client.Telephone == number
                        && MessageBox.Show(@"Найден клиент " + "\"" + client.Fio + "\" с указанным телефоном\n"
                            +@"Yes - чтобы продолжить как " + "\"" + client.Fio + "\""
                            ,
                            @"Ошибка ввода данных",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2,
                            MessageBoxOptions.DefaultDesktopOnly
                        ) == DialogResult.Yes)
                    {
                        this.proceedReserve(client);
                    }else if (client.Fio == name && client.Telephone != number)
                    {
                        client.Telephone = number;
                        db.SaveChanges();
                        this.proceedReserve(client);
                    }
                }
                else
                {
                    client = new Client { Fio = name, Telephone = number, Type = type, Sex = sex };
                    db.Client.Add(client);
                    db.SaveChanges();

                    this.proceedReserve(client);
                }
            }
            enableElements();
        }

        private void proceedReserve(Client client)
        {
            using (MaiDbLbContext db = new MaiDbLbContext())
            {
                foreach (ListViewItem item in ReserveRooms_List.Items)
                {
                    AvialableRooms obj = (AvialableRooms)item.Tag;
                    db.Reservation.Add(new Reservation { RoomId = obj.Id, ClientId = client.Id });
                }
                db.SaveChanges();
                DialogResult result = MessageBox.Show(@"Бронирование произошло успешно", @"Успех", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        public override void enableElements()
        {
            Name_textbox.Enabled = true;
            Number_textbox.Enabled = true;
            clientType_checkbox.Enabled = true;
            if (!clientType_checkbox.Checked)
            {
                sexMale_radio.Enabled = true;
                sexFemale_radio.Enabled = true;
            }
            Reserve_btn.Enabled = false;
        }
        public override void disableElements()
        {
            Name_textbox.Enabled = false;
            Number_textbox.Enabled = false;
            sexMale_radio.Enabled = false;
            sexFemale_radio.Enabled = false;
            clientType_checkbox.Enabled = false;
            Reserve_btn.Enabled = false;
        }
    }
}
