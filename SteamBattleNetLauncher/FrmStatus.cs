﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamBattleNetLauncher {
    public partial class FrmStatus : Form {
        public FrmStatus() {
            InitializeComponent();
        }

        public void UpdateStatus(string message, params object[] args) {
            this.txtStatus.AppendText(String.Format(message, args));
            this.txtStatus.AppendText("\n");
        }
    }
}
