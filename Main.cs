using Hotel_SA.DbModels;
using System;
using System.Windows.Forms;


namespace Hotel_SA
{
    public partial class Main : ProjectForm
    {
        public Main()
        {
            InitializeComponent();

            Living_Btn.Enabled = false;
            PaidServices_Btn.Enabled = false;
            Archive_Btn.Enabled = false;
            checkOut_Btn.Enabled = false;
        }

        private void availableRooms_Btn_Click(object sender, EventArgs e)
        {
            this.disableElements();
            Show_Available_Rooms subForm = new Show_Available_Rooms(this);
            subForm.Show();
        }

        public override void disableElements()
        {
            AvailableRooms_Btn.Enabled = false;
            ReservedRooms_Btn.Enabled = false;

        }
        public override void enableElements()
        {
            AvailableRooms_Btn.Enabled = true;
            ReservedRooms_Btn.Enabled = true;
            AvailableRooms_Btn.Select();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                using (u0996168_MAI_DB_LBContext db = new u0996168_MAI_DB_LBContext())
                {
                    if (db.Database.CanConnect())
                    {
                        statusLabel.Text = @"Online";
                        this.enableElements();
                    }
                    else
                    {
                        statusStrip.Text = @"ERROR: Can't connect to database";
                    }
                }
            }catch(Exception error)
            {
                statusStrip.Text = @"ERROR: Can't connect to database";
                Console.WriteLine(error.Message);
            }
            
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
        private void reservedRooms_Btn_Click(object sender, EventArgs e)
        {
            this.disableElements();
            Show_Reserved_Rooms subForm = new Show_Reserved_Rooms(this);
            subForm.Show();
        }

        private void PaidServices_Btn_Click(object sender, EventArgs e)
        {

        }

        private void checkOut_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Archive_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Living_Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
