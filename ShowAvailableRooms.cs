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

    public partial class ShowAvailableRooms : ProjectForm
    {
        struct RoomTypeStruct
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        private List<RoomTypeStruct> _types; // Список типов комнат
        private int _selectedType; // Выбранный тип комнат
        
        /// <summary>
        /// Конструткор формы Список доступных номеров
        /// </summary>
        /// <param name="f">Форма главная</param>
        public ShowAvailableRooms(ProjectForm f)
        {
            InitializeComponent();
            ParentF = f;
            using (U0996168MaiDbLbContext db = new U0996168MaiDbLbContext())
            {
                // Выборка типов номера
                _types = db.RoomTypes.Select(p => new RoomTypeStruct()
                {
                    Id = p.Id,
                    Name = p.Name
                }).ToList();
                foreach (var type in _types)
                {
                    RoomTypes_Dropdown.Items.Add(type.Name);
                }
                // По умолчанию выбираем первый тип
                _selectedType = _types[0].Id;
                RoomTypes_Dropdown.SelectedIndex = 0;

                // Правка дат выселения / заселения
                dateTimeCheckIn.Enabled = false;
                //dateTimeCheckIn.MinDate = DateTime.Today;
                dateTimeCheckOut.MinDate = DateTime.Today;
                dateTimeCheckIn.Value = DateTime.Today;
                dateTimeCheckOut.Value = DateTime.Today.AddDays(1);
                //dateTimeCheckIn.MaxDate = DateTime.Today.AddMonths(6);
                dateTimeCheckOut.MaxDate = DateTime.Today.AddMonths(18);

                // Отключение кнопок по умолчанию
                Reserve_btn.Enabled = false;
                CheckIn_btn.Enabled = false;
            }

        }

        /// <summary>
        /// Обработка события смены выбора выподающего списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedType = _types[RoomTypes_Dropdown.SelectedIndex].Id;
        }
        /// <summary>
        /// Подгрузка списка доступных комнат
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadRooms (object sender, EventArgs e)
        {
            this.disableElements();
            Cursor.Current = Cursors.WaitCursor;
            FreeRooms_List.Items.Clear();

            // Подключение к БД
            using (U0996168MaiDbLbContext db = new U0996168MaiDbLbContext())
            {
                // Выборка комнат по их типу
                List<DbModels.AvialableRooms> rooms = db.AvialableRooms
                      .Where(p => p.Type == _types[_selectedType].Id).ToList();
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
            Cursor.Current = Cursors.Default;
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
            Search_btn.Enabled = false;
            /*CheckIn_btn.Enabled = false;
            Reserve_btn.Enabled = false;*/
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
            Search_btn.Enabled = true;
            /*CheckIn_btn.Enabled = true;
            Reserve_btn.Enabled = true;*/
        }

        /// <summary>
        /// Обработка события клик по кнопке Бронь
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reserve_btn_Click(object sender, EventArgs e)
        {
            // Получение списка выбранных номеро
            var list = FreeRooms_List.SelectedItems;
            List<DbModels.AvialableRooms> newList =  new List<AvialableRooms>();
            foreach (ListViewItem element in list)
            {
                newList.Add((DbModels.AvialableRooms)(element.Tag));
            }
            // Создание формы Бронь
            Hotel_SA.MakeReserve subForm = new MakeReserve(this, newList);
            subForm.Show();
            this.Hide();
            this.disableElements();
        }

        private void CheckIn_btn_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            for (int i = 0; i < FreeRooms_List.SelectedItems.Count; i++)
            {
                ids.Add(((AvialableRooms)(FreeRooms_List.SelectedItems[i].Tag)).Id);
            }
            CheckIn subForm = new CheckIn(this, ids, Decimal.ToInt32(countPeople.Value), dateTimeCheckIn.Value, dateTimeCheckOut.Value);
            subForm.Show();
            this.Hide();
            this.disableElements();
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
                CheckIn_btn.Enabled = true;
                Reserve_btn.Enabled = true;
            }
            else
            {
                CheckIn_btn.Enabled = false;
                Reserve_btn.Enabled = false;
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
            _selectedType = 0;
        }

        private void dateTimeCheckIn_ValueChanged(object sender, EventArgs e)
        {
            dateTimeCheckOut.MinDate = dateTimeCheckIn.Value.AddDays(1);
        }
    }
}
