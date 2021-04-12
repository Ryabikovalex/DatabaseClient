﻿using Hotel_SA.DbModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_SA
{
    public partial class Show_Reserved_Rooms : ProjectForm
    {
        struct ReservedRooms_struct
        {
            public int Id { get; set; }
            public int roomId { get; set; }
            public int clientId { get; set; }
            public string clientName { get; set; }
            public string roomNumber { get; set; }
            public byte roomCapacity { get; set; }
            public DateTime ExpiresAt { get; set; }
        }

        public Show_Reserved_Rooms(ProjectForm parent)
        {
            InitializeComponent();

            ParentF = parent;

            getReservationList();
        }

        private void getReservationList()
        {
            disableElements();
            ReserveRooms_List.Items.Clear();

            using (u0996168_MAI_DB_LBContext db = new u0996168_MAI_DB_LBContext())
            {
                List<ReservedRooms_struct> roomList = db.Reservation.Select(p => new ReservedRooms_struct()
                {
                    Id = p.Id,
                    clientName = p.Client.Fio,
                    roomCapacity = p.Room.Capacity,
                    clientId = p.ClientId,
                    roomId = p.RoomId,
                    roomNumber = p.Room.RoomNumber,
                    ExpiresAt = p.ExpiresAt
                }).OrderBy(u => u.clientName).ToList();
                string temp = roomList[0].clientName;
                ListViewGroup group;
                group = new ListViewGroup(roomList[0].clientName, HorizontalAlignment.Left);
                ReserveRooms_List.Groups.Add(group);
                foreach (var room in roomList)
                {
                    if (!temp.Equals(room.clientName))
                    {
                        group = new ListViewGroup(room.clientName, HorizontalAlignment.Left);
                        ReserveRooms_List.Groups.Add(group);
                        temp = room.clientName;
                    }
                    // Создание элемента списка на экране
                    ListViewItem lvi = new ListViewItem(new[] {
                        room.roomNumber.ToString(),
                        room.roomCapacity.ToString(),
                        room.ExpiresAt.ToShortDateString()
                    });
                    lvi.Tag = room;
                    // Добавление элемента в список
                    group.Items.Add(lvi);
                    ReserveRooms_List.Items.Add(lvi);
                }
            }

            // Выравнивание столбцов по шапке
            ReserveRooms_List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Clear_Btn.Select();
        }

        public override void disableElements()
        {
            ReserveDelete_Btn.Enabled = false;
            ReserveUpdate_Btn.Enabled = false;
            CheckIn_Btn.Enabled = false;
        }
        public override void enableElements()
        {
            ReserveDelete_Btn.Enabled = true;
            ReserveUpdate_Btn.Enabled = true;
            CheckIn_Btn.Enabled = true;
        }

        /// <summary>
        /// Обработка события клик по кнопке выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckIn_Btn_Click(object sender, EventArgs e)
        {

        }

        private void ReserveDelete_Btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(@"Потвердите действие",
                            "Вы потверждаете удаление " + ReserveRooms_List.SelectedItems.Count + " записей?",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button2,
                            MessageBoxOptions.DefaultDesktopOnly
                        ) == DialogResult.Yes)
            {
                using (u0996168_MAI_DB_LBContext db = new u0996168_MAI_DB_LBContext())
                {
                    List<int> ids = new List<int>();
                    foreach (ListViewItem item in ReserveRooms_List.SelectedItems)
                    {
                        ids.Add(((ReservedRooms_struct)(item.Tag)).Id);

                    }
                    db.Reservation.RemoveRange
(db.Reservation.Where(r => ids.Contains(r.Id)));
                    db.SaveChanges();
                }
                getReservationList();

            }
        }

        private void ReserveUpdate_Btn_Click(object sender, EventArgs e)
        {
            getReservationList();
        }

        private void Clear_Btn_Click(object sender, EventArgs e)
        {
            ReserveRooms_List.SelectedItems.Clear();
            disableElements();
        }

        private void ReserveRooms_List_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (ReserveRooms_List.SelectedItems.Count > 0)
            {
                enableElements();
            }
        }
    }
}