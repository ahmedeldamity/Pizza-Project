using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class mainform : Form
    { 

        public mainform()
        {
            InitializeComponent();
        }

        float sizePrice ()
        {
            if (rbsmall.Checked) return Convert.ToSingle(rbsmall.Tag);
            else if (rbmedium.Checked) return Convert.ToSingle(rbmedium.Tag);
            else return Convert.ToSingle(rblarge.Tag);
        }
        float crustPrice()
        {
            if (rbthin.Checked) return Convert.ToSingle(rbthin.Tag);
            else return Convert.ToSingle(rbthick.Tag);
        }
        float toppingsPrice()
        {
            float ans = 0;
            if (cbextracheese.Checked) ans += Convert.ToSingle(cbextracheese.Tag);
            if (cbgreenpeppers.Checked) ans += Convert.ToSingle(cbgreenpeppers.Tag);
            if (cbmushrooms.Checked) ans += Convert.ToSingle(cbmushrooms.Tag);
            if (cbolives.Checked) ans += Convert.ToSingle(cbolives.Tag);
            if (cbtomatoes.Checked) ans += Convert.ToSingle(cbonion.Tag);
            if (cbonion.Checked) ans += Convert.ToSingle(cbonion.Tag);
            return ans;
        }

        void updatePrice()
        {
            anstotalprice.Text = "$" + Convert.ToString(sizePrice() + crustPrice() + toppingsPrice());
        }

        private void btorder_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btorder.Enabled = false;
                gbsize.Enabled = false;
                gbwhereyoueat.Enabled = false;
                gbcrusttype.Enabled = false;
                gbtoppings.Enabled = false;
            }
            else
                MessageBox.Show("Order Placed Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void resetSize ()
        {
            rbmedium.Checked = true;
        }
        void resetCrustType ()
        {
            rbthin.Checked = true;
        }
        void resetWhereYouEat ()
        {
            rbtakeaway.Checked = true;
        }
        void resetToppings ()
        {
            cbextracheese.Checked = false;
            cbgreenpeppers.Checked = false;
            cbmushrooms.Checked = false;
            cbolives.Checked = false;
            cbonion.Checked = false;
            cbtomatoes.Checked = false;
        }
        void enable ()
        {
            btorder.Enabled = true;
            gbsize.Enabled = true;
            gbwhereyoueat.Enabled = true;
            gbcrusttype.Enabled = true;
            gbtoppings.Enabled = true;
        }
        void resetans ()
        {
            anssize.Text = "Medium";
            anstoppings.Text = "No Things";
            anscrusttype.Text = "Thin";
            answhereyoueat.Text = "Take Away";
            anstotalprice.Text = "$20";
        }
        private void btreset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                enable();
                resetans();
                resetSize();
                resetCrustType();
                resetWhereYouEat();
                resetToppings();
            }
            else
                MessageBox.Show("Restart Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void rbsmall_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice();
            anssize.Text = "Small";
        }

        private void rbmedium_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice();
            anssize.Text = "Medium";
        }

        private void rblarge_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice();
            anssize.Text = "Large";
        }

        private void rbthin_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice();
            anscrusttype.Text = "Thin";
        }

        private void rbthick_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice();
            anscrusttype.Text = "Thick";
        }
        void updateToppings()
        {
            updatePrice();

            string s = "";
            int countWords = 0;

            if (cbextracheese.Checked) 
            { 
                s += ",Extra Cheese "; 
                countWords++;
                if (countWords == 3) s += "\n";
            }
            if (cbmushrooms.Checked) 
            { 
                s += ",Mushrooms "; 
                countWords++;
                if (countWords == 3) s += "\n";
            }
            if (cbtomatoes.Checked) 
            { 
                s += ",Tomatoes "; 
                countWords++;
                if (countWords == 3) s += "\n";
            }
            if (cbgreenpeppers.Checked) 
            { 
                s += ",Green Peppers "; 
                countWords++;
                if (countWords == 3) s += "\n";
            }
            if (cbolives.Checked) 
            { 
                s += ",Olives "; 
                countWords++;
                if (countWords == 3) s += "\n";
            }
            if (cbonion.Checked) 
            { 
                s += ",Onion "; 
                countWords++;
                if (countWords == 3) s += "\n";
            }

            if (s.Length > 0) s = s.Substring(1, s.Length - 1);
            else s = "No Things";

            anstoppings.Text = s;
        }
        private void cbextracheese_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void cbmushrooms_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }
        private void cbtomatoes_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void cbgreenpeppers_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void cbolives_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }


        private void cbonion_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void rbeatin_CheckedChanged(object sender, EventArgs e)
        {
            answhereyoueat.Text = "Eat In";
        }

        private void rbtakeaway_CheckedChanged(object sender, EventArgs e)
        {
            answhereyoueat.Text = "Take Away";
        }

        void setCheckForThemeBlack()
        {
            olbsize.ForeColor = Color.White; 
            olbtoppings.ForeColor = Color.White;    
            olbcrusttype.ForeColor = Color.White;   
            olbwhereyoueat.ForeColor = Color.White; 
            olbtotalprice.ForeColor = Color.White;  
        }

        void setAnotherColorInsteadOfGray()
        {
            rbsmall.ForeColor = Color.White;
            rbmedium.ForeColor = Color.White;  
            rblarge.ForeColor = Color.White;    
            rbthin.ForeColor = Color.White; 
            rbthick.ForeColor = Color.White;    
            rbeatin.ForeColor = Color.White;    
            rbtakeaway.ForeColor = Color.White; 
            cbextracheese.ForeColor = Color.White;  
            cbmushrooms.ForeColor = Color.White;
            cbtomatoes.ForeColor = Color.White; 
            cbgreenpeppers.ForeColor = Color.White; 
            cbolives.ForeColor = Color.White;
            cbonion.ForeColor = Color.White;
            anssize.ForeColor = Color.Silver;
            anstoppings.ForeColor = Color.Silver;
            anscrusttype.ForeColor = Color.Silver;  
        }
        private void rbdark_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            setCheckForThemeBlack();
            setAnotherColorInsteadOfGray();
        }
        void setCheckForThemeLight()
        {
            olbsize.ForeColor = Color.Black;
            olbtoppings.ForeColor = Color.Black;
            olbcrusttype.ForeColor = Color.Black;
            olbwhereyoueat.ForeColor = Color.Black;
            olbtotalprice.ForeColor = Color.Black;

        }
        void setGrayColor ()
        {
            rbsmall.ForeColor = Color.Gray;
            rbmedium.ForeColor = Color.Gray;
            rblarge.ForeColor = Color.Gray;
            rbthin.ForeColor = Color.Gray;
            rbthick.ForeColor = Color.Gray;
            rbeatin.ForeColor = Color.Gray;
            rbtakeaway.ForeColor = Color.Gray;
            cbextracheese.ForeColor = Color.Gray;
            cbmushrooms.ForeColor = Color.Gray;
            cbtomatoes.ForeColor = Color.Gray;
            cbgreenpeppers.ForeColor = Color.Gray;
            cbolives.ForeColor = Color.Gray;
            cbonion.ForeColor = Color.Gray;
            anssize.ForeColor = Color.Gray;
            anstoppings.ForeColor = Color.Gray;
            anscrusttype.ForeColor = Color.Gray;
        }
        private void rblight_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            setCheckForThemeLight();
            setGrayColor();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            
        }
    }
}
