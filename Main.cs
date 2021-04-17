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

            Archive_btn.Enabled = false;
        }

        private void availableRooms_btn_Click(object sender, EventArgs e)
        {
            this.disableElements();
            Cursor.Current = Cursors.WaitCursor;
            Show_Available_Rooms subForm = new Show_Available_Rooms(this);
            subForm.Show();
            Cursor.Current = Cursors.Default;
        }

        public override void disableElements()
        {
            AvailableRooms_btn.Enabled = false;
            ReservedRooms_btn.Enabled = false;
            PaidServices_btn.Enabled = false;
            Living_btn.Enabled = false;

        }
        public override void enableElements()
        {
            AvailableRooms_btn.Enabled = true;
            ReservedRooms_btn.Enabled = true;
            PaidServices_btn.Enabled = true;
            Living_btn.Enabled = true;
            AvailableRooms_btn.Select();
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
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void reservedRooms_btn_Click(object sender, EventArgs e)
        {
            this.disableElements();
            Cursor.Current = Cursors.WaitCursor;
            Show_Reserved_Rooms subForm = new Show_Reserved_Rooms(this);
            subForm.Show();
        }

        private void PaidServices_btn_Click(object sender, EventArgs e)
        {
            this.disableElements();
            Cursor.Current = Cursors.WaitCursor;
            Charge_Service subForm = new Charge_Service(this);
            subForm.Show();
            Cursor.Current = Cursors.Default;
        }

        private void Archive_btn_Click(object sender, EventArgs e)
        {

        }

        private void Living_btn_Click(object sender, EventArgs e)
        {
            this.disableElements();
            Cursor.Current = Cursors.WaitCursor;
            Show_Living subForm = new Show_Living(this);
            subForm.Show();
            Cursor.Current = Cursors.Default;
        }
    }
}
