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
    public partial class UCPessoa_Juridica : UserControl
    {
        public UCPessoa_Juridica()
        {
            InitializeComponent();
        }

        public MaskedTextBox getCNPJ()
        {
            return cnpjTbox;
        }
    }
}
