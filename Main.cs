using DatabaseClient.DbModels;
using System;
using System.Linq;
using System.Windows.Forms;


namespace DatabaseClient
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
            ShowAvailableRooms subForm = new ShowAvailableRooms(this);
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
                using (MaiDbLbContext db = new MaiDbLbContext())
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
            using (MaiDbLbContext db = new MaiDbLbContext())
            {
                if (db.Reservation.Count() > 0)
                {
                    ShowReservedRooms subForm = new ShowReservedRooms(this);
                    subForm.Show();
                }
                else
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("На данный момент нет брони.",
                        @"Внимание",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    this.enableElements();
                }
            }
        }

        private void PaidServices_btn_Click(object sender, EventArgs e)
        {
            this.disableElements();
            Cursor.Current = Cursors.WaitCursor;
            ChargeService subForm = new ChargeService(this);
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
            ShowLiving subForm = new ShowLiving(this);
            subForm.Show();
            Cursor.Current = Cursors.Default;
        }
    }
}
