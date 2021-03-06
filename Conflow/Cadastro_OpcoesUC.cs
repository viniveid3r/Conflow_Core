﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conflow
{
    public partial class Cadastro_OpcoesUC : UserControl
    {
        Cadastro_MoradoresUC moradoresUC;
        Cadastro_PrediosUC prediosUC;

        public Cadastro_OpcoesUC()
        {
            InitializeComponent();
        }

        private void Cadastrar_MoradorBtn_Click(object sender, EventArgs e)
        {
            if (moradoresUC == null)
            {
                moradoresUC = new Cadastro_MoradoresUC();
            }

            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(moradoresUC);
        }

        private void Cadastrar_PredioBtn_Click(object sender, EventArgs e)
        {
            if (prediosUC == null)
            {
                prediosUC = new Cadastro_PrediosUC();
            }

            CadastrarOPPanel.Controls.Clear();
            CadastrarOPPanel.Controls.Add(prediosUC);
        }
    }
}
