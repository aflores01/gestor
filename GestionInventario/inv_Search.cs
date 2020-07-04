using System.Data;
using System.Windows.Forms;



namespace GestionInventario
{
    public partial class inv_Search : Form
    {
        private static Db_search db = new Db_search();

        public inv_Search(string Search_query)
        {
            InitializeComponent();
            DataTable DbResult_value_1 = db.Search_query("SELECT modelo, cliente, fecha, telefono, reparacion, coment, costo, entregado FROM 'local' WHERE cliente LIKE '%" + Search_query + "%'");
            DataTable DbResult_value_2 = db.Search_query("SELECT modelo, cliente, fecha, telefono, reparacion, coment, costo, entregado FROM 'local' WHERE modelo LIKE '%" + Search_query + "%'");
            DbResult_value_1.Merge(DbResult_value_2, true);
            DataGridResult.DataSource = DbResult_value_1;
        }
    }
}
