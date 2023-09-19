using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finance_tracker.Payment
{
    public partial class TypeOfPayment : UserControl
    {
        public Image PictureBoxImage
        { 
            get { return image.Image; }
            set { image.Image = value; } 
        }

        public string Title
        {
            get { return title.Text; }
            set { title.Text = value; }
        }

        public TypeOfPayment()
        {
            InitializeComponent();
        }
    }
}
