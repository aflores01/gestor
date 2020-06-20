using System.Windows.Forms;



namespace GestionInventario
{
    public partial class inv_Search : Form
    {
        public inv_Search(string Search_query)
        {
            InitializeComponent();
            //SQLiteDataAdapter adpt = new SQLiteDataAdapter("SELECT * FROM local WHERE cliente = "+ Search_query ); 
        }
    }
}
