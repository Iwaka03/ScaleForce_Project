using System;
using System.Windows.Forms;
using ToDoApplication123.Controller;

namespace ToDoApplication123.View
{
    public partial class AdminLoggedView : Form
    {
        AdminLoggedController adminLoggedController = new AdminLoggedController();

        public AdminLoggedView()
        {
            InitializeComponent();
        }
        public void AdminLoggedView_Load(object sender, EventArgs e)
        {
            dgvUsers.DataSource = adminLoggedController.GetAllUsers();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
