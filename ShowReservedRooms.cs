using DatabaseClient.DbModels;
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

namespace DatabaseClient
{
    public partial class ShowReservedRooms : ProjectForm
    {
        struct ReservedRoomsStruct
        {
            public int Id { get; set; }
            public int RoomId { get; set; }
            public int ClientId { get; set; }
            public string ClientName { get; set; }
            public string RoomNumber { get; set; }
            public byte RoomCapacity { get; set; }
            public DateTime ExpiresAt { get; set; }
        }

        /// <summary>
        /// Конструктор формы
        /// </summary>
        /// <param name="parent"></param>
        public ShowReservedRooms(ProjectForm parent)
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

            using (MaiDbLbContext db = new MaiDbLbContext())
            {
                List<ReservedRoomsStruct> roomList = db.Reservation.Select(p => new ReservedRoomsStruct()
                {
                    Id = p.Id,
                    ClientName = p.Client.Fio,
                    RoomCapacity = p.Room.Capacity,
                    ClientId = p.ClientId,
                    RoomId = p.RoomId,
                    RoomNumber = p.Room.RoomNumber,
                    ExpiresAt = p.ExpiresAt
                    // Сортируем по имени клиента
                }).OrderBy(u => u.ClientName).ToList();
                string temp = roomList[0].ClientName;
                ListViewGroup group;
                group = new ListViewGroup(roomList[0].ClientName, HorizontalAlignment.Left);
                ReserveRooms_List.Groups.Add(group);
                foreach (var room in roomList)
                {
                    if (!temp.Equals(room.ClientName))
                    {
                        group = new ListViewGroup(room.ClientName, HorizontalAlignment.Left);
                        ReserveRooms_List.Groups.Add(group);
                        temp = room.ClientName;
                    }
                    // Создание элемента списка на экране
                    ListViewItem lvi = new ListViewItem(new[] {
                        room.RoomNumber.ToString(),
                        room.RoomCapacity.ToString(),
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
                using (MaiDbLbContext db = new MaiDbLbContext())
                {
                    List<int> ids = new List<int>();
                    foreach (ListViewItem item in ReserveRooms_List.SelectedItems)
                    {
                        ids.Add(((ReservedRoomsStruct)(item.Tag)).Id);

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
            using (MaiDbLbContext db = new MaiDbLbContext())
            {
                List<int> ids = new List<int>();
                foreach (ListViewItem item in ReserveRooms_List.SelectedItems)
                {
                    ids.Add(((ReservedRoomsStruct)(item.Tag)).Id);

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