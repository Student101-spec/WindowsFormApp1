using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payment_slip
{
    public partial class FrmPaymentSlip : Form
    {
        public FrmPaymentSlip(string receiptNo,
    string packageName,
    double amountPaid,
    DateTime paymentDate,
    DateTime activeFrom,
    DateTime expiresOn)
        {
            InitializeComponent();
            lblPaymentRecie.Text = receiptNo;
            lblMembershipPlan.Text = packageName;
            lblAmountPaid.Text = amountPaid.ToString("C");
            lblPaymentDate.Text = paymentDate.ToString("dd/MM/yyyy");
            lblActiveFrom.Text = activeFrom.ToString("dd/MM/yyyy");
            lblExpiresOn.Text = expiresOn.ToString("dd/MM/yyyy");
        }
           
    }
}
