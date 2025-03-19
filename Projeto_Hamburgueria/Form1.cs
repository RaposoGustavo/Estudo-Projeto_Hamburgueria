using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Hamburgueria
{
    public partial class Form_cardapio: Form
    {
        public Form_cardapio()
        {
            InitializeComponent();
        }

        private void Cx_Opções_Enter(object sender, EventArgs e)
        {

        }

        private void Bt_xsalada_CheckedChanged(object sender, EventArgs e)
        {
            Pic_imagem.Image = Properties.Resources.img_x_salada;
            Txt_ingredientes.Text = "INGREDIENTES:" + Environment.NewLine +
                        "-Pão de gergelim;" + Environment.NewLine +
                        "-Maionese da casa;" + Environment.NewLine +
                        "-Alface crespa;" + Environment.NewLine +
                        "-Tomate;" + Environment.NewLine +
                        "-Cebola;" + Environment.NewLine +                    
                        "-Queijo." + Environment.NewLine +
                        "-Hambúrguer de 180g;" + Environment.NewLine;
        }

        private void Bt_xbacon_CheckedChanged(object sender, EventArgs e)
        {
            Pic_imagem.Image = Properties.Resources.img_x_bacon;
            Txt_ingredientes.Text = "INGREDIENTES:" + Environment.NewLine +
                        "-Pão de gergelim;" + Environment.NewLine +
                        "-Maionese da casa;" + Environment.NewLine +
                        "-Alface crespa;" + Environment.NewLine +
                        "-Bacon;" + Environment.NewLine +
                        "-Tomate;" + Environment.NewLine +
                        "-Hambúrguer de 180g;" + Environment.NewLine +
                        "-Queijo.";
        }

        private void Bt_xburguer_CheckedChanged(object sender, EventArgs e)
        {
            Pic_imagem.Image = Properties.Resources.img_x_burguer;
            Txt_ingredientes.Text = "INGREDIENTES:" + Environment.NewLine +
                        "-Pão de gergelim;" + Environment.NewLine +
                        "-Maionese da casa;" + Environment.NewLine +              
                        "-Hambúrguer de 180g;" + Environment.NewLine +
                        "-Queijo.";
        }

        private void Bt_xegg_CheckedChanged(object sender, EventArgs e)
        {
            Pic_imagem.Image = Properties.Resources.img_x_egg;
            Txt_ingredientes.Text = "INGREDIENTES:" + Environment.NewLine +
                        "-Pão de gergelim;" + Environment.NewLine +
                        "-Maionese da casa;" + Environment.NewLine +
                        "-Alface crespa;" + Environment.NewLine +
                        "-Bacon;" + Environment.NewLine +
                        "-Tomate;" + Environment.NewLine +
                        "-Hambúrguer de 180g;" + Environment.NewLine +
                        "-Ovo frito;" + Environment.NewLine +
                        "-Queijo.";
        }
    }
}
