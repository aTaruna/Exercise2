using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exercise2
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-REQ2JF73\\Asus;database=ProdiTI;Integrated Security=true");
                con.Open();
                SqlCommand cm = new SqlCommand("Create Table Apotek(Nama_Apotek varchar(30)primary key,Alamat varchar(50))" +
                    "Create Table Apoteker(Nama varchar(50),Jenis_Kelamin char(1)primary key" +
                    "Create Table Obat(Nama_Obat varchar(30),Kadaluwarsa date primary key,Harga int,Jumlah int" +
                    "Create Table Penjualan(Nama_Pembeli varchar(50)primary key,Nama_Obat varchar(30),Jumlah_Beli int,Tgl_Beli date",con);
                cm.ExecuteNonQuery();
                Console.WriteLine("Tabel berhasil dibuat");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Pembuatan tabel gagal" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(String[]args)
        {
            new Program().CreateTable();
        }
    }
}