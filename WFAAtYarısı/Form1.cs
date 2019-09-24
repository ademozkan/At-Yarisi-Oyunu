using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAAtYarısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int bakiye = 500;
        
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = bakiye.ToString("c2");

        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (cbOynanılanAt.Text == "")
            {
                MessageBox.Show("LÜTFEN OYNAYACAGINIZ ATI GİRİN");
            }
            else
            {
                if (cbSahaSecimi.Text == "Çim Saha")
                {
                    try
                    {
                        int bahis = Convert.ToInt32(cbBahis.Text);

                        this.BackColor = Color.GreenYellow;

                        if (bakiye >= bahis)
                        {
                            pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = true;
                            tmratkosusu.Start();

                        }

                        else if (bakiye < bahis)
                        {
                            MessageBox.Show("YETERSİZ BAKİYE LÜTFEN BAKİYE YÜKLEYİNİZ");
                            Application.Exit();

                        }




                    }



                    catch
                    {
                        MessageBox.Show("LÜTFEN BAHİS ORANI GİRİNİZ");
                    }
                }
                else if (cbSahaSecimi.Text == "Kum Saha")
                {

                    try
                    {
                        int bahis = Convert.ToInt32(cbBahis.Text);

                        this.BackColor = Color.Khaki;
                        if (bakiye >= bahis)
                        {
                            pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = true;
                            tmrKumSaha.Start();

                        }
                        else if (bakiye < bahis)
                        {
                            MessageBox.Show("YETERSİZ BAKİYE LÜTFEN BAKİYE YÜKLEYİNİZ");
                            Application.Exit();
                            MessageBox.Show("LÜTFEN BAHİS ORANI GİRİNİZ");
                        }
                        else
                        {
                            MessageBox.Show("LÜTFEN BAHİS ORANI GİRİNİZ");

                        }
                    }
                    catch
                    {
                        MessageBox.Show("LÜTFEN BAHİS ORANI GİRİNİZ");
                    }
                }
                else if (cbSahaSecimi.Text == "Toprak Saha")
                {


                    try
                    {
                        int bahis = Convert.ToInt32(cbBahis.Text);
                        this.BackColor = Color.Coral;

                        if (bakiye >= bahis)
                        {
                            pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = true;
                            tmrToprakSaha.Start();

                        }
                        else if (bakiye < bahis)
                        {
                            MessageBox.Show("YETERSİZ BAKİYE LÜTFEN BAKİYE YÜKLEYİNİZ");
                            Application.Exit();
                            MessageBox.Show("LÜTFEN BAHİS ORANI GİRİNİZ");
                        }
                        else
                        {
                            MessageBox.Show("LÜTFEN BAHİS ORANI GİRİNİZ");

                        }
                    }
                    catch
                    {
                        MessageBox.Show("LÜTFEN BAHİS ORANI GİRİNİZ");
                    }
                }

                else
                {
                    MessageBox.Show("Lütfen Saha secimi YAPIN");
                }

            }


            //> <
        }

        private void cbSahaSecimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbSahaSecimi_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void cbSahaSecimi_SizeChanged(object sender, EventArgs e)
        {

        }

        private void cbSahaSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSahaSecimi.Text == "Çim Saha")
            {
                lblFavoriAt.Text = "Bu Zeminin Favorisi 1. Attır. Lakin SÜRPRİZ de olabilir";
                lblFavoriAt.ForeColor = Color.GreenYellow;


            }
            else if (cbSahaSecimi.Text == "Kum Saha")
            {
                lblFavoriAt.Text = "Bu Zeminin Favorisi 2. Attır. Lakin SÜRPRİZ de olabilir";
                lblFavoriAt.ForeColor = Color.Khaki;

            }
            else if (cbSahaSecimi.Text == "Toprak Saha")
            {
                lblFavoriAt.Text = "Bu Zeminin Favorisi 3. Attır. Lakin SÜRPRİZ de olabilir";
                lblFavoriAt.ForeColor = Color.Coral;
            }


        }
        

        private void tmratkosusu_Tick(object sender, EventArgs e)
        {
            pbAt1.Left += rnd.Next(3, 10);
            pbAt2.Left += rnd.Next(2, 10);
            pbAt3.Left += rnd.Next(2, 10);

            int bahis = Convert.ToInt32(cbBahis.Text);

            if (cbOynanılanAt.Text == "1.AT")
            {
               

                #region resimlerin labele degmesi
                if (pbAt1.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmratkosusu.Stop();
                    listBox1.Items.Add("önceki yarısı 1. at KAZANDI");
                    bakiye += bahis;
                    
                    lblBakiye.Text = bakiye.ToString("c2");
                    DialogResult dr = MessageBox.Show("1. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                        cbBahis.Text = cbOynanılanAt.Text = cbSahaSecimi.Text = "";
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt2.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmratkosusu.Stop();
                    bakiye -= bahis;
                    lblBakiye.Text = bakiye.ToString();
                    listBox1.Items.Add("önceki yarısı 2. at KAZANDI");
                    DialogResult dr = MessageBox.Show("2. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt3.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmratkosusu.Stop();
                    bakiye -= bahis;
                    lblBakiye.Text = bakiye.ToString();
                    listBox1.Items.Add("önceki yarısı 3. at KAZANDI");
                    DialogResult dr = MessageBox.Show("3. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    

                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                #endregion



            }
            else if (cbOynanılanAt.Text == "2.AT")
            {
                #region resimlerin labele degmesi
                if (pbAt1.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmratkosusu.Stop();
                    listBox1.Items.Add("önceki yarısı 1. at KAZANDI");
                    bakiye -= bahis;
                   
                    lblBakiye.Text = bakiye.ToString("c2");
                    DialogResult dr = MessageBox.Show("1. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                        cbBahis.Text = cbOynanılanAt.Text = cbSahaSecimi.Text = "";
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt2.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmratkosusu.Stop();
                    listBox1.Items.Add("önceki yarısı 2. at KAZANDI");
                    bakiye += bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("2. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt3.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmratkosusu.Stop();
                    listBox1.Items.Add("önceki yarısı 3. at KAZANDI");
                    bakiye -= bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("3. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                #endregion

            }
            else if (cbOynanılanAt.Text == "3.AT")
            {
                #region resimlerin labele degmesi
                if (pbAt1.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmratkosusu.Stop();
                    listBox1.Items.Add("önceki yarısı 1. at KAZANDI");
                    bakiye -= bahis;
                    
                    lblBakiye.Text = bakiye.ToString("c2");
                    DialogResult dr = MessageBox.Show("1. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                        cbBahis.Text = cbOynanılanAt.Text = cbSahaSecimi.Text = "";
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt2.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmratkosusu.Stop();
                    listBox1.Items.Add("önceki yarısı 2. at KAZANDI");
                    bakiye -= bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("2. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt3.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmratkosusu.Stop();
                    listBox1.Items.Add("önceki yarısı 3. at KAZANDI");
                    bakiye += bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("3. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                
                #endregion
            }










        }

        private void tmrKumSaha_Tick(object sender, EventArgs e)
        {
            pbAt1.Left += rnd.Next(2, 10);
            pbAt2.Left += rnd.Next(3, 10);
            pbAt3.Left += rnd.Next(2, 10);

            int bahis = Convert.ToInt32(cbBahis.Text);

            if (cbOynanılanAt.Text == "1.AT")
            {


                #region resimlerin labele degmesi
                if (pbAt1.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrKumSaha.Stop();
                    bakiye += bahis;

                    lblBakiye.Text = bakiye.ToString("c2");
                    listBox1.Items.Add("önceki yarısı 1. at KAZANDI");
                    DialogResult dr = MessageBox.Show("1. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                        cbBahis.Text = cbOynanılanAt.Text = cbSahaSecimi.Text = "";
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt2.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrKumSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 2. at KAZANDI");
                    bakiye -= bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("2. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt3.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrKumSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 3. at KAZANDI");
                    bakiye -= bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("3. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   

                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                #endregion



            }
            else if (cbOynanılanAt.Text == "2.AT")
            {
                #region resimlerin labele degmesi
                if (pbAt1.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrKumSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 1. at KAZANDI");
                    bakiye -= bahis;
                    
                    lblBakiye.Text = bakiye.ToString("c2");
                    DialogResult dr = MessageBox.Show("1. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                        cbBahis.Text = cbOynanılanAt.Text = cbSahaSecimi.Text = "";
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt2.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrKumSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 2. at KAZANDI");
                    bakiye += bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("2. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt3.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrKumSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 3. at KAZANDI");
                    bakiye -= bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("3. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                #endregion

            }
            else if (cbOynanılanAt.Text == "3.AT")
            {
                #region resimlerin labele degmesi
                if (pbAt1.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrKumSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 1. at KAZANDI");
                    bakiye -= bahis;
                    
                    lblBakiye.Text = bakiye.ToString("c2");
                    DialogResult dr = MessageBox.Show("1. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                        cbBahis.Text = cbOynanılanAt.Text = cbSahaSecimi.Text = "";
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt2.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrKumSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 2. at KAZANDI");
                    bakiye -= bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("2. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt3.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrKumSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 3. at KAZANDI");
                    bakiye += bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("3. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                #endregion
            }

        }

        private void tmrToprakSaha_Tick(object sender, EventArgs e)
        {
            pbAt1.Left += rnd.Next(2, 10);
            pbAt2.Left += rnd.Next(2, 10);
            pbAt3.Left += rnd.Next(3, 10);

            int bahis = Convert.ToInt32(cbBahis.Text);

            if (cbOynanılanAt.Text == "1.AT")
            {


                #region resimlerin labele degmesi
                if (pbAt1.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrToprakSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 1. at KAZANDI");
                    bakiye += bahis;

                    lblBakiye.Text = bakiye.ToString("c2");
                    DialogResult dr = MessageBox.Show("1. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                        cbBahis.Text = cbOynanılanAt.Text = cbSahaSecimi.Text = "";
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt2.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrToprakSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 2. at KAZANDI");
                    bakiye -= bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("2. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt3.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrToprakSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 3. at KAZANDI");
                    bakiye -= bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("3. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    

                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                #endregion



            }
            else if (cbOynanılanAt.Text == "2.AT")
            {
                #region resimlerin labele degmesi
                if (pbAt1.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrToprakSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 1. at KAZANDI");
                    bakiye -= bahis;
                    
                    lblBakiye.Text = bakiye.ToString("c2");
                    DialogResult dr = MessageBox.Show("1. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                        cbBahis.Text = cbOynanılanAt.Text = cbSahaSecimi.Text = "";
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt2.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrToprakSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 2. at KAZANDI");
                    bakiye += bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("2. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt3.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrToprakSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 3. at KAZANDI");
                    bakiye -= bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("3. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                #endregion

            }
            else if (cbOynanılanAt.Text == "3.AT")
            {
                #region resimlerin labele degmesi
                if (pbAt1.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrToprakSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 1. at KAZANDI");
                    bakiye -= bahis;
                   
                    lblBakiye.Text = bakiye.ToString("c2");
                    DialogResult dr = MessageBox.Show("1. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                        cbBahis.Text = cbOynanılanAt.Text = cbSahaSecimi.Text = "";
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt2.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrToprakSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 2. at KAZANDI");
                    bakiye -= bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("2. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else if (pbAt3.Right >= lblFinish.Left)
                {
                    pbAt1.Enabled = pbAt2.Enabled = pbAt3.Enabled = false;
                    tmrToprakSaha.Stop();
                    listBox1.Items.Add("önceki yarısı 3. at KAZANDI");
                    bakiye += bahis;
                    lblBakiye.Text = bakiye.ToString();
                    DialogResult dr = MessageBox.Show("3. AT kazandı.\nYeniden oynamak istiyor musunuz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   
                    if (dr == DialogResult.Yes)
                    {
                        pbAt1.Left = pbAt2.Left = pbAt3.Left = 0;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                #endregion
            }

        }

        private void cbOynanılanAt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbBahis_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbBahis_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
   