using MySql.Data.MySqlClient;
using System.Data;


namespace kelasss
{
    public partial class Form1 : Form

    {

        MySqlConnection koneksi = Connection.getConnection();
        MySqlCommand cmd;

        int i = 0;
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }
        public DataTable getTabelSiswa()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tabel_siswa", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;

        }
        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id :=0; Update tabel_siswa SET id = @id := (@id+1); " +
                "ALTER TABLE tabel_siswa AUTO_INCREMENT = 1;");
            script.Execute();
        }

        public void filldataTable()
        {
            dataGridView1.DataSource = getTabelSiswa();


        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM tabel_siswa WHERE CONCAT(kode_baju, merek_baju, tipe_baju, ukuran_baju, harga_baju) LIKE  '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public void button1_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd;
            //koneksi.Open();

            try
            {

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "INSERT INTO tabel_siswa(kode_baju, merek_baju, tipe_baju, ukuran_baju, harga_baju) VALUES(@kode_baju,@merek_baju,@tipe_baju,@ukuran_baju,@harga_baju)";
                cmd.Parameters.AddWithValue("@kode_baju", tb_nama.Text);
                cmd.Parameters.AddWithValue("@merek_baju", tb_jns_kelamin.Text);
                cmd.Parameters.AddWithValue("@tipe_baju", tb_tmpt_lahir.Text);
                cmd.Parameters.AddWithValue("@ukuran_baju", tb_alamat.Text);
                cmd.Parameters.AddWithValue("@harga_baju", tb_kelas.Text);
                cmd.ExecuteNonQuery();

                koneksi.Close();

                dataGridView1.Columns.Clear();
                dataTable.Clear();
                filldataTable();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error = " + ex);
            }
        }

        private void tb_search_TextChanged_1(object sender, EventArgs e)
        {
            searchData(tb_search.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
            tb_id.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            tb_nama.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            tb_jns_kelamin.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            tb_tmpt_lahir.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            tb_alamat.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
            tb_kelas.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                resetIncrement();
                //koneksi.Open();
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE tabel_siswa SET kode_baju = @kode_baju, merek_baju = @merek_baju, tipe_baju = @tipe_baju, ukuran_baju = @ukuran_baju, harga_baju = @harga_baju WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", tb_id.Text);
                cmd.Parameters.AddWithValue("@kode_baju", tb_nama.Text);
                cmd.Parameters.AddWithValue("@merek_baju", tb_jns_kelamin.Text);
                cmd.Parameters.AddWithValue("@tipe_baju", tb_tmpt_lahir.Text);
                cmd.Parameters.AddWithValue("@ukuran_baju", tb_alamat.Text);
                cmd.Parameters.AddWithValue("@harga_baju", tb_kelas.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah nich :)");
                koneksi.Close();

                dataGridView1.Columns.Clear();
                dataTable.Clear();
                filldataTable();
                //koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());

            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "DELETE FROM `tabel_siswa` WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", tb_id.Text);
            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("data berhasil dihapus", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("data belum berhasil dihapus", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            koneksi.Close();
            resetIncrement();
            filldataTable();
        }
    }
}