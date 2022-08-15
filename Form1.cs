using System.Windows.Forms;

namespace ListaDeCanciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvListado.Rows[0].Clone();
            row.Cells[0].Value = tbTitulo.Text;
            row.Cells[1].Value = tbGrupo.Text;
            row.Cells[2].Value = tbYear.Text;
            row.Cells[3].Value = tbGenero.Text;
            row.Cells[0].ReadOnly = true;
            row.Cells[1].ReadOnly = true;
            row.Cells[2].ReadOnly = true;
            row.Cells[3].ReadOnly = true;
            dgvListado.Rows.Add(row);

            tbTitulo.Text = "";
            tbGrupo.Text = "";
            tbYear.Text = "";
            tbGenero.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dgvListado.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Borrar";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;
        }

        private void dgvListado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 4)
            {
                dgvListado.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}