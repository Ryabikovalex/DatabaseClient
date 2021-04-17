using Hotel_SA.DbModels;
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

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="parent"></param>
        public Show_Reserved_Rooms(ProjectForm parent)
        {
            InitializeComponent();

            ParentF = parent;

            getReservationList();
        }
        /// <summary>
        /// Выборка списка всех бронирований и группировка по клиентам
        /// </summary>
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
                    // Сортируем по имени клиента
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
            Clear_btn.Select();
        }

        public override void disableElements()
        {
            ReserveDelete_btn.Enabled = false;
            ReserveUpdate_btn.Enabled = false;
            CheckIn_btn.Enabled = false;
        }
        public override void enableElements()
        {
            ReserveDelete_btn.Enabled = true;
            ReserveUpdate_btn.Enabled = true;
            CheckIn_btn.Enabled = true;
        }

        /// <summary>
        /// Обработка события клик по кнопке выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Обработка события клик по кнопке Заселение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckIn_btn_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Обработка события клик по кнопке Удаление брони
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReserveDelete_btn_Click(object sender, EventArgs e)
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
                    db.Reservation.RemoveRange(db.Reservation.Where(r => ids.Contains(r.Id)));
                    db.SaveChanges();
                }
                getReservationList();

            }
        }
        /// <summary>
        /// Обработка события клик по кнопке Продление брони
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReserveUpdate_btn_Click(object sender, EventArgs e)
        {
            using (u0996168_MAI_DB_LBContext db = new u0996168_MAI_DB_LBContext())
            {
                List<int> ids = new List<int>();
                foreach (ListViewItem item in ReserveRooms_List.SelectedItems)
                {
                    ids.Add(((ReservedRooms_struct)(item.Tag)).Id);

                }
                db.Reservation.Where(r => ids.Contains(r.Id)).ToList().ForEach(p => p.ExpiresAt = p.ExpiresAt.AddDays(1));
                db.SaveChanges();
            }
            getReservationList();
        }
        /// <summary>
        /// Обработка события клик по кнопке Очистить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_btn_Click(object sender, EventArgs e)
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