using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DatabaseClient
{
    public partial class CheckIn : ProjectForm
    {
        private List<GroupBox> clients;
        
        /// <summary>
        /// Конструткор формы Заселение
        /// </summary>
        /// <param name="f">Форма главная</param>
        /// <param name="roomsId">Список комнат куда заселяют</param>
        /// <param name="countClient">Число клиентов</param>
        /// <param name="dateFrom">Дата заселения</param>
        /// <param name="dateTo">Дата выселения</param>
        public CheckIn(ProjectForm f, List<int> roomsId, int countClient,  DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            ParentF = f;
            
            
            dateTimeCheckIn.Value = dateFrom;
            dateTimeCheckIn.MinDate = dateFrom;
            dateTimeCheckIn.MinDate = DateTime.Today;
            
            dateTimeCheckOut.MinDate = dateFrom.AddDays(1);
            dateTimeCheckOut.Value = dateTo;
            dateTimeCheckOut.MaxDate = DateTime.Today.AddMonths(18);
            // TODO Дописать добавление динамическое формы клиентов
            Main_panel.Controls.Clear();
            /*for (int i = 0; i < countClient; i++)
            {
                clients.Add();
                Main_panel.Controls.Add(groupbox);
            }*/
        }
        
        /// <summary>
        /// Конструткор формы Заселение при бронировании
        /// </summary>
        /// <param name="f">Форма главная</param>
        /// <param name="roomsId">Список комнат куда заселяют</param>=
        public CheckIn(ProjectForm f, List<int> roomsId)
        {
            InitializeComponent();
            ParentF = f;
            // TODO Дописать конструктор для перехода из брони
            dateTimeCheckIn.Value = DateTime.Now;
            dateTimeCheckOut.Value = DateTime.Now.AddDays(1);
            /*for (int i = 0; i < countClient; i++)
            {
                clients.Add();
            }*/
        }

        private void countPeople_ValueChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}