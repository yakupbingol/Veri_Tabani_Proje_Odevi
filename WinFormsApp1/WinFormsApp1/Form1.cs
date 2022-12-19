using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306; username=root; password=1234");
        MySqlDataAdapter adapter;
        DataTable table;
        MySqlCommand cmd;
        MySqlCommand cmd4;
        MySqlCommand cmd5;
        MySqlDataReader dr;
        String evTakim;
        String depTakim;
        public Form1()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            evBox.Items.Clear();

            cmd = new MySqlCommand ("SELECT distinct home_team from veri_tabani.result ORDER BY home_team asc", connection) ;
         
            connection.Open(); 
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                evBox.Items.Add(dr[0].ToString());
            }
            connection.Close();
            connection.Open();
            depBox.Items.Clear();
            MySqlCommand cmd2 = new MySqlCommand("SELECT distinct away_team from veri_tabani.result ORDER BY away_team desc", connection);

            MySqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                
                depBox.Items.Add(dr2[0].ToString());
            }

            connection.Close();

            //data_goster();

        }
        void data_goster()
        {
            connection.Open();
                adapter = new MySqlDataAdapter("SELECT * from veri_tabani.result WHERE home_team = '"+ evTakim.ToString() +
                    "' AND away_team='"+ depTakim.ToString() + "'" +
                    "OR home_team = '"+ depTakim.ToString() + "' AND away_team='"+ evTakim.ToString() + "'", connection);
                table = new DataTable();      
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            connection.Close();
      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void sonucGosterBtn_Click(object sender, EventArgs e)
        {
             

            data_goster();

            connection.Open();
            cmd.CommandText = "SELECT COUNT(*) FROM veri_tabani.result WHERE home_team ='" + evTakim.ToString() + "' " +
                "AND away_team ='" + depTakim.ToString() + "' AND result='H'  OR home_team = '"+ depTakim.ToString() +
                "'AND away_team ='" + evTakim.ToString() + "' AND result='A' ";
            Int64 evSahibi = (Int64) cmd.ExecuteScalar();

         
            cmd.CommandText = "SELECT COUNT(*) FROM veri_tabani.result WHERE home_team ='" + evTakim.ToString() + "' " +
                "AND away_team ='" + depTakim.ToString() + "' AND result='D'  OR home_team = '" + depTakim.ToString() +
                "'AND away_team ='" + evTakim.ToString() + "' AND result='D' ";
            Int64 draw = (Int64) cmd.ExecuteScalar();

            cmd.CommandText = "SELECT COUNT(*) FROM veri_tabani.result WHERE home_team ='" + evTakim.ToString() + "' " +
                "AND away_team ='" + depTakim.ToString() + "' AND result='A'  OR home_team = '" + depTakim.ToString() +
                "'AND away_team ='" + evTakim.ToString() + "' AND result='H' ";
            Int64 deplasman = (Int64) cmd.ExecuteScalar();

            Int64 toplam = evSahibi + draw + deplasman;
            MessageBox.Show("Aralarýnda Oynanan Toplam Maç: " + toplam.ToString());
            long eKazanma = ((100 * evSahibi) / toplam);
            long beraberlik = ((100 * draw) / toplam);
            long dKazanma = ((100 * deplasman) / toplam);

            /*table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;*/

            connection.Close();
            MessageBox.Show("Ev sahibi kazancý: " + evSahibi.ToString() + " Beraberlik: " + draw.ToString() + " Deplasman: " + deplasman.ToString());
            //MessageBox.Show("Ev sahibi Kazanma Oraný : %" + eKazanma.ToString() + "Beraberlik Oraný : %" + beraberlik.ToString()+ "Deplasman Kazanma Oraný : %" + dKazanma.ToString());

            if (eKazanma > dKazanma)
            {
                sonucLabel.Text = evTakim.ToString();
                oranLabel.Text = "% " + eKazanma.ToString();
            }
            else if (eKazanma < dKazanma) {
                sonucLabel.Text = depTakim.ToString();
                oranLabel.Text = "% " + dKazanma.ToString();

            }
            else
            {
                sonucLabel.Text = "Beraberlik ";
                oranLabel.Text = "% " + beraberlik.ToString();
            }

        }

        private void evTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void evBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            evTakim = evBox.SelectedItem.ToString();

        }

        private void depBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            depTakim = depBox.SelectedItem.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void oranLabel_Click(object sender, EventArgs e)
        {

        }
    }
}