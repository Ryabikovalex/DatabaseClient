using Hotel_SA.DbModels;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAviableRooms_Click(object sender, EventArgs e)
        {
            Show_Available_Rooms subForm = new Show_Available_Rooms(this);
            this.disableElements();
            subForm.Show();
        }

        public void disableElements()
        {
            AvialableRooms_Btn.Enabled = false;
        }
        public void enableElements()
        {
            AvialableRooms_Btn.Enabled = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                using (u0996168_MAI_DB_LBContext db = new u0996168_MAI_DB_LBContext())
                {
                    if (db.Database.CanConnect())
                    {
                        statusLabel.Text = "Online";
                        this.enableElements();
                    }
                    else
                    {
                        statusLabel.Text = "ERROR: Can't connect to database";
                    }
                }
            }catch(Exception error)
            {
                statusLabel.Text = "ERROR: Can't connect to database";
            }
            
        }
    }
}
