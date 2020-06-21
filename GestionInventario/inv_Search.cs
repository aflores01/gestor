using System.Windows.Forms;



namespace GestionInventario
{
    public partial class inv_Search : Form
    {
        private static Db_search db = new Db_search();

        public inv_Search(string Search_query)
        {
            InitializeComponent();
            DataGridResult.DataSource = db.Search_query("SELECT modelo, cliente, fecha, telefono, reparacion, coment, costo, entregado FROM 'local' WHERE cliente LIKE '%" + Search_query + "%'");
        }
    }
}
