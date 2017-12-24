using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZX;

namespace TaBILTrainer
{
    public partial class TrainerForm : Form
    {
        public const int MaxVal = 99999;

        public TrainerForm()
        {
            InitializeComponent();
        }

        public void UpdateResource(string res, string val)
        {
            switch (res)
            {
                case "gold":
                    txtbxCurGold.Text = val;
                    break;
                case "wood":
                    txtbxCurWood.Text = val;
                    break;
                case "stone":
                    txtbxCurStone.Text = val;
                    break;
                case "iron":
                    txtbxCurIron.Text = val;
                    break;
                case "oil":
                    txtbxCurOil.Text = val;
                    break;
                default:
                    MessageBox.Show("Unknown entry: " + res, "Error");
                    break;
            }
        }

        private void AddResource(string res, string val)
        {
            if (ZXLevelState.Current == null)
                return;

            int o = 0;
            if (Int32.TryParse(val, out o))
            {
                switch (res)
                {
                    case "gold":
                        ZXLevelState.Current.AddGold(o);
                        break;
                    case "wood":
                        ZXLevelState.Current.AddWood(o);
                        break;
                    case "stone":
                        ZXLevelState.Current.AddStone(o);
                        break;
                    case "iron":
                        ZXLevelState.Current.AddIron(o);
                        break;
                    case "oil":
                        ZXLevelState.Current.AddOil(o);
                        break;
                    default:
                        MessageBox.Show("Unknown entry: " + res, "Error");
                        break;
                }
            }
        }
             
        private void TrainerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        #region Set/Max Resource Buttons

        private void btnSetGold_Click(object sender, EventArgs e)
        {
            AddResource("gold", txtbxNewGold.Text);
        }

        private void btnMaxGold_Click(object sender, EventArgs e)
        {
            AddResource("gold", MaxVal.ToString());

        }

        private void btnSetWood_Click(object sender, EventArgs e)
        {
            AddResource("wood", txtbxNewGold.Text);

        }

        private void btnMaxWood_Click(object sender, EventArgs e)
        {
            AddResource("wood", MaxVal.ToString());

        }

        private void btnSetStone_Click(object sender, EventArgs e)
        {
            AddResource("stone", txtbxNewGold.Text);

        }

        private void btnMaxStone_Click(object sender, EventArgs e)
        {
            AddResource("stone", MaxVal.ToString());

        }

        private void btnSetIron_Click(object sender, EventArgs e)
        {
            AddResource("iron", txtbxNewGold.Text);

        }

        private void btnMaxIron_Click(object sender, EventArgs e)
        {
            AddResource("iron", MaxVal.ToString());

        }

        private void btnSetOil_Click(object sender, EventArgs e)
        {

            AddResource("oil", txtbxNewGold.Text);
        }

        private void btnMaxOil_Click(object sender, EventArgs e)
        {
            AddResource("oil", MaxVal.ToString());

        }

        private void btnSetAll_Click(object sender, EventArgs e)
        {
            AddResource("gold", txtbxNewGold.Text);
            AddResource("wood", txtbxNewWood.Text);
            AddResource("stone", txtbxNewStone.Text);
            AddResource("iron", txtbxNewIron.Text);
            AddResource("oil", txtbxNewOil.Text);
        }

        private void btnMaxAll_Click(object sender, EventArgs e)
        {
            AddResource("gold", MaxVal.ToString());
            AddResource("wood", MaxVal.ToString());
            AddResource("stone", MaxVal.ToString());
            AddResource("iron", MaxVal.ToString());
            AddResource("oil", MaxVal.ToString());
        }

        #endregion
    }
}
