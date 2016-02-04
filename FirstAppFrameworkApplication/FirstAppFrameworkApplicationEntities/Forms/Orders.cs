using AppFramework.AppClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstAppFrameworkApplicationEntities.Forms
{
    public partial class Orders : FormBase
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void formDataGridView2_EntitySaved(AppFramework.Controls.FormDataGridView sender, int row, EventArgs e)
        {
            formDataGridView1.reloadCurrentEntity();
        }
    }
}
