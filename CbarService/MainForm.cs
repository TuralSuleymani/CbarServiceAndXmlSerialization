using CbarService.Core;
using CbarService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CbarService
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void Btn_loadExchangeInfo_Click(object sender, EventArgs e)
        {
            CbarExchangeService<ValuteCur> cbarExchangeService = new CbarExchangeService<ValuteCur>();
            
          ValuteCur data = await cbarExchangeService.GetExchangeDatasByDate(datetime_pick.Value);
            listBox1.DataSource = data.ValTypes.SelectMany(x => x.Valutes).ToList();
            
            
        }
    }
}
