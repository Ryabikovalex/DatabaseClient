using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Hotel_SA
{
    public class ProjectForm : Form
    {
        protected ProjectForm ParentF { get; set; }
        public virtual void enableElements(){}
        public virtual void disableElements(){}
       

        protected void Event_FormClosing(object sender, FormClosingEventArgs e)
        {
            ParentF.enableElements();
            ParentF.Show();
            ParentF.Activate();
        }
    }
}