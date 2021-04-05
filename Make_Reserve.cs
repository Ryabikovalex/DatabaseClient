﻿using Hotel_SA.DbModels;
using Hotel_SA.Properties;
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

namespace Hotel_SA
{
    public partial class Make_Reserve : Form
    {
        private Hotel_SA.Show_Available_Rooms ParentF;
        private List<DbModels.AvialableRooms> Rooms;
         
        /// <summary>
        /// Конструктор формы Создания брони
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="list"></param>
        public Make_Reserve(Hotel_SA.Show_Available_Rooms parent, List<DbModels.AvialableRooms> list)
        {
            InitializeComponent();

            ParentF = parent;
            ParentF.Hide();
            this.Show();
            Rooms = list;

            // Заполнение списков
            foreach (DbModels.AvialableRooms room in Rooms)
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

            Reserve_Btn.Enabled = false;
        }

        private void Reservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentF.enableElements();
            ParentF.Show();
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
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
                    Reserve_Btn.Enabled = true;
                else
                    Reserve_Btn.Enabled = false;
            }
            else
            {
                Name_textbox.ForeColor = Color.Black;
                Reserve_Btn.Enabled = false;
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
                        Reserve_Btn.Enabled = true;
                }
                else
                {
                    Number_textbox.ForeColor = Color.Red;
                    Reserve_Btn.Enabled = false;
                }
            }
            else
            {
                Number_textbox.ForeColor = Color.Black;
                Reserve_Btn.Enabled = false;
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Number_textbox.Text = "";
            Name_textbox.Text = "";
            clientType_checkbox.Checked = false;
        }

        private void Reserve_Btn_Click(object sender, EventArgs e)
        {
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
            using (u0996168_MAI_DB_LBContext db = new u0996168_MAI_DB_LBContext())
            {
                DbModels.Client client = db.Client.Where(p => p.Telephone == number).FirstOrDefault();
                if (client != null)
                {
                    if ((client.Fio != name && MessageBox.Show("Найден клиент " + "\"" + client.Fio + "\" с таким же номером телефона\n"
                            +"Yes - для замены клиента на " + "\"" + client.Fio + "\""
                            ,
                            "Ошибка ввода данных",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button2,
                            MessageBoxOptions.DefaultDesktopOnly
                        ) == DialogResult.Yes) || client.Fio == name)
                    {
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
        }

        private void proceedReserve(Client client)
        {
            using (u0996168_MAI_DB_LBContext db = new u0996168_MAI_DB_LBContext())
            {
                foreach (ListViewItem item in ReserveRooms_List.Items)
                {
                    AvialableRooms obj = (AvialableRooms)item.Tag;
                    db.Reservation.Add(new Reservation { RoomId = obj.Id, ClientId = client.Id });
                }
                db.SaveChanges();
                DialogResult result = MessageBox.Show("Бронирование произошло успешно", "Успех", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
