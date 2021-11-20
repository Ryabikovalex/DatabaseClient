using DatabaseClient.DbModels;
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
    public partial class ShowLiving : ProjectForm
    {
        public struct LivingInfoStruct
        {
            public int Id { get; set; }
            public int ClientId { get; set; }

            public string ClientName { get; set; }
            public bool ClientSex { get;  set; }

            public string GetClientSex {
                get{
                    if (this.ClientSex) return @"Ж";
                    else return @"М";
                }
            }
            public string ClientNumber { get; set; }
            public int RoomId { get; set; }
            public string RoomNumber { get; set; }
            public string GetRoomNumber
            {
                get
                {
                    return "Комната " + RoomNumber;
                }
            }
            public DateTime DateIn { get; set; }

        }
        public ShowLiving(ProjectForm f)
        {
            InitializeComponent();

            ParentF = f;

            getLivingList();
        }

        private void getLivingList()
        {
            disableElements();
            Cursor.Current = Cursors.WaitCursor;
            Living_List.Items.Clear();

            using (MaiDbLbContext db = new MaiDbLbContext())
            {
                List<LivingInfoStruct> roomList = db.Living.Select(p => new LivingInfoStruct
                {
                    Id = p.Id,
                    ClientId = p.ClientId,
                    ClientName = p.Client.Fio,
                    ClientSex = (bool)p.Client.Sex,
                    ClientNumber = p.Client.Telephone,
                    RoomId = p.RoomId,
                    RoomNumber = p.Room.RoomNumber,
                    DateIn = p.DateIn,
                    // Сортируем по имени клиента
                }).OrderBy(u => u.RoomNumber).ThenBy(v => v.ClientName).ToList();

                string temp = roomList[0].RoomNumber;
                ListViewGroup group;
                group = new ListViewGroup(roomList[0].GetRoomNumber, HorizontalAlignment.Left);
                group.Name = roomList[0].RoomNumber;
                Living_List.Groups.Add(group);
                foreach (var room in roomList)
                {
                    if (!temp.Equals(room.RoomNumber))
                    {
                        group = new ListViewGroup(room.GetRoomNumber, HorizontalAlignment.Left);
                        group.Name = room.RoomNumber;
                        Living_List.Groups.Add(group);
                        temp = room.RoomNumber;
                    }
                    // Создание элемента списка на экране
                    ListViewItem lvi = new ListViewItem(new[] {
                        room.ClientName.ToString().ToUpper(),
                        room.GetClientSex,
                        room.ClientNumber.ToString(),
                        room.DateIn.ToShortDateString()
                    });
                    lvi.Tag = room;
                    // Добавление элемента в список
                    group.Items.Add(lvi);
                    Living_List.Items.Add(lvi);
                }
            }

            enableElements();
            Cursor.Current = Cursors.Default;

            // Выравнивание столбцов по шапке
            Living_List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
            Living_List.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            Living_List.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);
            Living_List.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            Living_List.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
            Clear_btn.Select();
        }

        public override void disableElements()
        {
            checkOut_btn.Enabled = false;
            clientInfo_btn.Enabled = false;
        }
        public override void enableElements()
        {
            checkOut_btn.Enabled = true;
            //clientInfo_btn.Enabled = true;
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

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Living_List.SelectedItems.Clear();
            disableElements();
        }


        private void Living_List_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (Living_List.SelectedItems.Count > 0)
                enableElements();
            else
                disableElements();
        }

        private void checkOut_btn_Click(object sender, EventArgs e)
        {
            List<ListViewItem> list =  new List<ListViewItem>(Living_List.SelectedItems.Cast<ListViewItem>());
            Console.WriteLine(list[0].Group.Name);
        }
    }
}