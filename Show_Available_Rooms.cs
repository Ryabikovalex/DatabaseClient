using Hotel_SA.DbModels;
using Microsoft.EntityFrameworkCore;
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

    public partial class Show_Available_Rooms : ProjectForm
    {
        struct RoomType_struct
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        private List<RoomType_struct> types; // Список типов комнат
        private int selectedType; // Выбранный тип комнат
        
        /// <summary>
        /// Конструткор формы Список доступных номеров
        /// </summary>
        /// <param name="F">Форма главная</param>
        public Show_Available_Rooms(ProjectForm F)
        {
            InitializeComponent();
            ParentF = F;
            using (u0996168_MAI_DB_LBContext db = new u0996168_MAI_DB_LBContext())
            {
                // Выборка типов номера
                types = db.RoomTypes.Select(p => new RoomType_struct()
                {
                    Id = p.Id,
                    Name = p.Name
                }).ToList();
                foreach (var type in types)
                {
                    RoomTypes_Dropdown.Items.Add(type.Name);
                }
                // По умолчанию выбираем первый тип
                selectedType = types[0].Id;
                RoomTypes_Dropdown.SelectedIndex = 0;

                // Правка дат выселения / заселения
                dateTimeCheckIn.MinDate = DateTime.Today;
                dateTimeCheckOut.MinDate = DateTime.Today;
                dateTimeCheckIn.Value = DateTime.Today;
                dateTimeCheckOut.Value = DateTime.Today.AddDays(1);
                dateTimeCheckIn.MaxDate = DateTime.Today.AddMonths(6);
                dateTimeCheckOut.MaxDate = DateTime.Today.AddMonths(18);

                // Отключение кнопок по умолчанию
                Reserve_Btn.Enabled = false;
                CheckIn_Btn.Enabled = false;
            }

        }

        /// <summary>
        /// Обработка события смены выбора выподающего списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedType = types[RoomTypes_Dropdown.SelectedIndex].Id;
        }
        /// <summary>
        /// Подгрузка списка доступных комнат
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadRooms (object sender, EventArgs e)
        {
            this.disableElements();
            FreeRooms_List.Items.Clear();

            // Подключение к БД
            using (u0996168_MAI_DB_LBContext db = new u0996168_MAI_DB_LBContext())
            {
                // Выборка комнат по их типу
                List<DbModels.AvialableRooms> rooms = db.AvialableRooms
                      .Where(p => p.Type == types[selectedType].Id).ToList();
                foreach (DbModels.AvialableRooms room in rooms)
                {
                    // Создание элемента списка на экране
                    ListViewItem lvi = new ListViewItem(new[] {
                        room.Number.ToString(),
                        room.Capacity.ToString(),
                        room.CheckIn,
                        room.Cost.ToString()
                    });
                    lvi.Tag = room;
                    // Добавление элемента в список
                    FreeRooms_List.Items.Add(lvi);
                }
            }

            // Выравнивание столбцов по шапке
            FreeRooms_List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            this.enableElements();
        }

        /// <summary>
        /// Отключение элементов управления формы
        /// </summary>
        public override void disableElements()
        {
            FreeRooms_List.Enabled = false;
            countPeople.Enabled = false;
            dateTimeCheckIn.Enabled = false;
            dateTimeCheckOut.Enabled = false;
            RoomTypes_Dropdown.Enabled = false;
            Search_Btn.Enabled = false;
            /*CheckIn_Btn.Enabled = false;
            Reserve_Btn.Enabled = false;*/
        }
        /// <summary>
        /// Включение элементов управления формы
        /// </summary>
        public override void enableElements()
        {
            FreeRooms_List.Enabled = true;
            countPeople.Enabled = true;
            dateTimeCheckIn.Enabled = true;
            dateTimeCheckOut.Enabled = true;
            RoomTypes_Dropdown.Enabled = true;
            Search_Btn.Enabled = true;
            /*CheckIn_Btn.Enabled = true;
            Reserve_Btn.Enabled = true;*/
        }

        /// <summary>
        /// Обработка события клик по кнопке Бронь
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reserve_Btn_Click(object sender, EventArgs e)
        {
            // Получение списка выбранных номеро
            var list = FreeRooms_List.SelectedItems;
            List<DbModels.AvialableRooms> newList =  new List<AvialableRooms>();
            foreach (ListViewItem element in list)
            {
                newList.Add((DbModels.AvialableRooms)(element.Tag));
            }
            // Создание формы Бронь
            Hotel_SA.Make_Reserve subForm = new Make_Reserve(this, newList);
            subForm.Show();
            this.Hide();
            this.disableElements();
        }

        private void CheckIn_Btn_Click(object sender, EventArgs e)
        {

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

        /// <summary>
        /// Проверка на нехватку мест для клиентов
        /// <!-- Необходимо выбрать по вместимости не меньше чем запрашивает клиент -->
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkCapacity(object sender, EventArgs e)
        {
            // Получение списка выбранных номеров
            var list = FreeRooms_List.SelectedItems;
            var totalC = 0;
            foreach (ListViewItem element in list)
            { // Подсчет вместимости всех выбранных номеро
                totalC += ((DbModels.AvialableRooms)(element.Tag)).Capacity;
            }
            // Если вместимость достаточная то идет разблокировка кнопок
            if (totalC >= countPeople.Value)
            {
                CheckIn_Btn.Enabled = true;
                Reserve_Btn.Enabled = true;
            }
            else
            {
                CheckIn_Btn.Enabled = false;
                Reserve_Btn.Enabled = false;
            }
        }
        /// <summary>
        /// Обработка события клик по кнопке Очистить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_btn_Click(object sender, EventArgs e)
        {
            FreeRooms_List.Items.Clear(); // Очистка выбранных номеров
            countPeople.Value = 1; // Сброс счетчика 
            RoomTypes_Dropdown.SelectedIndex = 0; // Сброк категории
            selectedType = 0;
        }
    }
}
