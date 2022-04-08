﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace Sistema_Compra_Venta
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }
        public static MySqlConnection GetMySqlConnection()
        {

            string sql = "server=localhost;user id=root;persistsecurityinfo=True;password=Admin123;database=compraventa";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return con;
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtUNombreUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        public static void AddProd(string Nombre_Usuario, string Nombre, string Apellido_Paterno, string Apellido_Materno, string Correo_Electronico, string Telefono, string Pais)
        {
            string sql = "Insert into usuario values(Null,@Nombre_Usuario,@Nombre,@Apellido_Paterno,@Apellido_Materno,@Correo_Electronico,@Telefono,@País) ";
            MySqlConnection con = GetMySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Nombre_Usuario", MySqlDbType.VarChar).Value = Nombre_Usuario;
            cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = Nombre;
            cmd.Parameters.Add("@Apellido_Paterno", MySqlDbType.VarChar).Value = Apellido_Paterno;
            cmd.Parameters.Add("@Apellido_Materno", MySqlDbType.VarChar).Value = Apellido_Materno;
            cmd.Parameters.Add("@Correo_Electronico", MySqlDbType.VarChar).Value = Correo_Electronico;
            cmd.Parameters.Add("@Telefono", MySqlDbType.VarChar).Value = Telefono;
            cmd.Parameters.Add("@País", MySqlDbType.VarChar).Value = Pais;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateUser(string Nombre_Usuario, string Nombre, string Apellido_Paterno, string Apellido_Materno, string Correo_Electronico, string Telefono, string Pais, int ID)
        {
            string sql = "Update usuario SET Nombre_Usuario=@Nombre_Usuario,Nombre=@Nombre,Apellido_Paterno=@Apellido_Paterno,Apellido_Materno=@Apellido_Materno,Correo_Electronico=@Correo_Electronico,Telefono=@Telefono,País=@País WHERE IdUser=@ID";
            MySqlConnection con = GetMySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Nombre_Usuario", MySqlDbType.VarChar).Value = Nombre_Usuario;
            cmd.Parameters.Add("@Nombre", MySqlDbType.VarChar).Value = Nombre;
            cmd.Parameters.Add("@Apellido_Paterno", MySqlDbType.VarChar).Value = Apellido_Paterno;
            cmd.Parameters.Add("@Apellido_Materno", MySqlDbType.VarChar).Value = Apellido_Materno;
            cmd.Parameters.Add("@Correo_Electronico", MySqlDbType.VarChar).Value = Correo_Electronico;
            cmd.Parameters.Add("@Telefono", MySqlDbType.VarChar).Value = Telefono;
            cmd.Parameters.Add("@País", MySqlDbType.VarChar).Value = Pais;
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void Consulta(string NombreUsuario, DataGridView dgv)
        {
            string sql = "Select * from usuario where Nombre_Usuario=@NombreUsuario";
            MySqlConnection con = GetMySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@NombreUsuario", MySqlDbType.VarChar).Value = NombreUsuario;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

        public static void Borrauser(int ID)
        {
            string sql = "Delete from Usuario where IdUser=@ID";
            MySqlConnection con = GetMySqlConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = ID;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
    }
}
