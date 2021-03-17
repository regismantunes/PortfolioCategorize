using PortfolioCategorize_WinForm.Model;
using PortfolioCategorize_WinForm.Control;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PortfolioCategorize_WinForm
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnAddTrade_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtValueTrade.Text))
                {
                    MessageBox.Show("Enter with the value.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValueTrade.Focus();
                }
                else if (!double.TryParse(txtValueTrade.Text, out double valueTrade))
                {
                    MessageBox.Show("The value field contains invalid information.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValueTrade.Focus();
                }
                else if (valueTrade < 0)
                {
                    MessageBox.Show("The value must be greater than or equal to zero.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValueTrade.Focus();
                }
                else if (cbxClientSectorTrade.SelectedItem == null)
                {
                    MessageBox.Show("Select the client sector.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbxClientSectorTrade.Focus();
                }
                else
                {
                    Trade trade = new Trade(valueTrade, (string)cbxClientSectorTrade.SelectedItem);
                    lstPortfolio.Items.Add(new ListViewItem(new string[] { trade.Value.ToString("N2"), trade.ClientSector, string.Empty }) { Tag = trade });
                    txtValueTrade.Text = string.Empty;
                    cbxClientSectorTrade.SelectedItem = null;
                    txtValueTrade.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCategorize_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstPortfolio.Items.Count == 0)
                {
                    MessageBox.Show("Must be at least one trade.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValueTrade.Focus();
                }
                else
                {
                    List<ITrade> trades = new List<ITrade>();
                    foreach (ListViewItem item in lstPortfolio.Items)
                        trades.Add((ITrade)item.Tag);

                    PortfolioCategorizer categorizer = new PortfolioCategorizer()
                    {
                        Categories = CategoryCollection.GetDefaultCategories()
                    };

                    List<string> categories = categorizer.Categorize(trades);

                    if (categories.Count != trades.Count)
                    {
                        MessageBox.Show("An unspected error ocourred on categorize.", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    for (int i = 0; i < lstPortfolio.Items.Count; i++)
                        lstPortfolio.Items[i].SubItems[2].Text = categories[i];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtValueTrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ',' || txtValueTrade.Text.IndexOf(',') > 0);
        }
    }
}
