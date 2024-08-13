namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Invoice invoiceManager;
        public Form1()
        {
            InitializeComponent();
            invoiceManager = new Invoice();

            addInvoices.InvoiceManager = invoiceManager;
            managerInvoices.InvoiceManager = invoiceManager;

            addInvoices.Show();
            managerInvoices.Show();
        }

        private void managerInvoice1_Load(object sender, EventArgs e)
        {

        }

        private void adInvoice1_Load(object sender, EventArgs e)
        {

        }

        private void managerInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managerInvoices.Show();
            addInvoices.Hide();
            managerInvoices.RefreshInvoiceList();
        }

        private void addInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            managerInvoices.Hide();
            addInvoices.Show();
        }
    }
}
