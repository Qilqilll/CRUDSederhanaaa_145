﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDSederhana
{
    public partial class Form1 : Form
    {
        // Ganti "SERVER" sesuai dengan SQL Server Anda
        private string connectionString = "Data Source=LAPTOP-3HJQCS6H\\AQIL;Initial Catalog=OrganisasiMahasiswa;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }
        // Event saat form pertama kali dimuat
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }