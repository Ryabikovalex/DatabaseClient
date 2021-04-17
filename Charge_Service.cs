using Hotel_SA.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_SA
{
    public partial class ChargeService : ProjectForm
    {
        private struct ServiceStruct
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Cost { get; set; }

            public int Count { get; set; }

            public string DisplayValue
            {
                get
                {
                    string temp = Name + " (" + Cost.ToString() + ") ";
                    if (Count == 1)
                    {
                        return temp;
                    }
                    else
                    {
                        return temp + " x" + Count.ToString();
                    }
                }
            }

        }

        private List<ServiceStruct> _paidServiceList;

        public ChargeService(ProjectForm p)
        {
            InitializeComponent();

            ParentF = p;

            using (U0996168MaiDbLbContext db = new U0996168MaiDbLbContext())
            {
                _paidServiceList = db.PaidServices.OrderBy(p => p.Name).Select(p => new ServiceStruct()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Cost = p.Cost,
                    Count = 1
                }).ToList();
                var rooms = db.Rooms.Where(p => p.Busy == true).ToList();
                RoomNumber_combobox.DataSource = rooms;
                RoomNumber_combobox.DisplayMember = "RoomNumber";


                PaidServices_list.DataSource = _paidServiceList;
                PaidServices_list.DisplayMember = "DisplayValue";
                PaidServices_list.ValueMember = "Id";
            }

            Service_list.DisplayMember = "DisplayValue";
            Service_list.ValueMember = "Id";
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            if(PaidServices_list.SelectedItems.Count > 0)
            {
                ServiceStruct s = _paidServiceList[PaidServices_list.SelectedIndex];
                s.Count = Decimal.ToInt32(Count_numeric.Value);

                Service_list.Items.Add(s);
                SumValue_lbl.Text = (Int32.Parse(SumValue_lbl.Text) + s.Count * s.Cost).ToString();

                Count_numeric.Value = 1;
                Charge_btn.Enabled = true;
            }
        }

        private void Remove_btn_Click(object sender, EventArgs e)
        {
            if (Service_list.SelectedItems.Count > 0)
            {
                ServiceStruct s = (ServiceStruct)Service_list.SelectedItem;

                Service_list.Items.RemoveAt(Service_list.SelectedIndex);
                SumValue_lbl.Text = (Int32.Parse(SumValue_lbl.Text) - s.Count * s.Cost).ToString();
                if (Service_list.Items.Count == 0) Charge_btn.Enabled = false;
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Service_list.Items.Clear();

            Charge_btn.Enabled = false;

            Count_numeric.Value = 1;
            SumValue_lbl.Text = "0";
        }

        private void Charge_btn_Click(object sender, EventArgs e)
        {
            Charge_btn.Enabled = false;
            using (U0996168MaiDbLbContext db = new U0996168MaiDbLbContext())
            {
                List<ServiceList> list = new List<ServiceList>();
                foreach (ServiceStruct item in Service_list.Items)
                {
                    list.Add(new ServiceList
                    {
                        Date = DateTime.Now,
                        RoomId = ((Rooms) RoomNumber_combobox.SelectedItem).Id,
                        PaidServiceId = item.Id,
                        Count = item.Count
                    });
                }
                db.ServiceList.AddRange(list);
                db.SaveChanges();
                MessageBox.Show( "Услуги оказаны", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                this.Activate();
                this.Clear_btn_Click(sender, e);
            }
        }
    }
}