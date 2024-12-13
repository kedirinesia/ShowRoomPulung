using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowRoomPulung
{
    public partial class CustomerService : Form
    {
        public CustomerService()
        {
            InitializeComponent();
        }

        private void CustomerService_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate("chatgpt.com");
            webView21.Source = new Uri("https://chatgpt.com");

        }
    }
}
