﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace SerwerTCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TcpListener serwer = null;
        private TcpClient klient = null;

        private void przycisk_start_Click(object sender, EventArgs e)
        {

        IPAddress adresIP = null;

        try{
                adresIP = IPAddress.Parse(adres.Text);
            }
        catch {
                MessageBox.Show("Błędny format adresu IP", "Błąd");
                adres.Text = String.Empty;
                return;
            }

        int port = System.Convert.ToInt32(port_p.Value);
            try
            {
                serwer = new TcpListener(adresIP, port);
                serwer.Start();

                klient = serwer.AcceptTcpClient();
                listBox1.Items.Add("Nawiązano połączenie!");

                przycisk_start.Enabled = false;
                przycisk_stop.Enabled = true;

                klient.Close();
                serwer.Stop();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("Błąd inicjacji serwera!");
                MessageBox.Show(ex.ToString(), "Błąd");
            }


        }
    }
}
