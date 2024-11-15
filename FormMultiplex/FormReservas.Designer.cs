namespace FormMultiplex
{
    partial class FormReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbFunciones = new ComboBox();
            rbGeneral = new RadioButton();
            rbVip = new RadioButton();
            gbTipoSilla = new GroupBox();
            label3 = new Label();
            buttonComprar = new Button();
            gbPosicion = new GroupBox();
            rbElegir = new RadioButton();
            rbAutomatico = new RadioButton();
            txtPosicionSilla = new TextBox();
            lblPosicionSilla = new Label();
            groupBox3 = new GroupBox();
            lblCategoria = new Label();
            lblCategoria1 = new Label();
            lblId = new Label();
            lblId1 = new Label();
            lblNombre = new Label();
            lblUsuario = new Label();
            groupBox4 = new GroupBox();
            lblDescuento = new Label();
            groupBox1 = new GroupBox();
            rbSi = new RadioButton();
            rdNo = new RadioButton();
            lblDescuento1 = new Label();
            label2 = new Label();
            gbCombos = new GroupBox();
            rbCombo5 = new RadioButton();
            rbCombo3 = new RadioButton();
            rbCombo4 = new RadioButton();
            rbCombo2 = new RadioButton();
            rbCombo1 = new RadioButton();
            lblValorTotal = new Label();
            lblValor = new Label();
            lblPuntos = new Label();
            lblPuntos1 = new Label();
            gbTipoSilla.SuspendLayout();
            gbPosicion.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            gbCombos.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(20, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 21);
            label1.TabIndex = 9;
            label1.Text = "Funcion";
            // 
            // cbFunciones
            // 
            cbFunciones.FormattingEnabled = true;
            cbFunciones.Location = new Point(20, 105);
            cbFunciones.Margin = new Padding(4, 3, 4, 3);
            cbFunciones.Name = "cbFunciones";
            cbFunciones.Size = new Size(229, 28);
            cbFunciones.TabIndex = 12;
            cbFunciones.Text = "Elige una funcion";
            // 
            // rbGeneral
            // 
            rbGeneral.AutoSize = true;
            rbGeneral.Location = new Point(115, 12);
            rbGeneral.Margin = new Padding(4, 3, 4, 3);
            rbGeneral.Name = "rbGeneral";
            rbGeneral.Size = new Size(80, 24);
            rbGeneral.TabIndex = 13;
            rbGeneral.Text = "General";
            rbGeneral.UseVisualStyleBackColor = true;
            rbGeneral.CheckedChanged += rbGeneral_CheckedChanged;
            // 
            // rbVip
            // 
            rbVip.AutoSize = true;
            rbVip.Location = new Point(8, 12);
            rbVip.Margin = new Padding(4, 3, 4, 3);
            rbVip.Name = "rbVip";
            rbVip.Size = new Size(50, 24);
            rbVip.TabIndex = 14;
            rbVip.TabStop = true;
            rbVip.Text = "Vip";
            rbVip.UseVisualStyleBackColor = true;
            rbVip.CheckedChanged += rbVip_CheckedChanged;
            // 
            // gbTipoSilla
            // 
            gbTipoSilla.Controls.Add(rbVip);
            gbTipoSilla.Controls.Add(rbGeneral);
            gbTipoSilla.Location = new Point(20, 164);
            gbTipoSilla.Margin = new Padding(0);
            gbTipoSilla.Name = "gbTipoSilla";
            gbTipoSilla.Padding = new Padding(4, 3, 4, 3);
            gbTipoSilla.Size = new Size(229, 39);
            gbTipoSilla.TabIndex = 15;
            gbTipoSilla.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(20, 144);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 21);
            label3.TabIndex = 18;
            label3.Text = "Silla";
            // 
            // buttonComprar
            // 
            buttonComprar.Enabled = false;
            buttonComprar.ForeColor = Color.Black;
            buttonComprar.Location = new Point(435, 274);
            buttonComprar.Margin = new Padding(4, 3, 4, 3);
            buttonComprar.Name = "buttonComprar";
            buttonComprar.Size = new Size(433, 43);
            buttonComprar.TabIndex = 20;
            buttonComprar.Text = "Comprar";
            buttonComprar.UseVisualStyleBackColor = true;
            buttonComprar.Click += buttonComprar_Click;
            // 
            // gbPosicion
            // 
            gbPosicion.Controls.Add(rbElegir);
            gbPosicion.Controls.Add(rbAutomatico);
            gbPosicion.Location = new Point(20, 203);
            gbPosicion.Margin = new Padding(0);
            gbPosicion.Name = "gbPosicion";
            gbPosicion.Padding = new Padding(4, 3, 4, 3);
            gbPosicion.Size = new Size(229, 39);
            gbPosicion.TabIndex = 16;
            gbPosicion.TabStop = false;
            gbPosicion.Visible = false;
            // 
            // rbElegir
            // 
            rbElegir.AutoSize = true;
            rbElegir.Location = new Point(8, 12);
            rbElegir.Margin = new Padding(4, 3, 4, 3);
            rbElegir.Name = "rbElegir";
            rbElegir.Size = new Size(61, 24);
            rbElegir.TabIndex = 14;
            rbElegir.Text = "Elejir";
            rbElegir.UseVisualStyleBackColor = true;
            rbElegir.CheckedChanged += rbElegir_CheckedChanged;
            // 
            // rbAutomatico
            // 
            rbAutomatico.AutoSize = true;
            rbAutomatico.Location = new Point(115, 12);
            rbAutomatico.Margin = new Padding(4, 3, 4, 3);
            rbAutomatico.Name = "rbAutomatico";
            rbAutomatico.Size = new Size(106, 24);
            rbAutomatico.TabIndex = 13;
            rbAutomatico.Text = "Automatico";
            rbAutomatico.UseVisualStyleBackColor = true;
            rbAutomatico.CheckedChanged += rbAutomatico_CheckedChanged;
            // 
            // txtPosicionSilla
            // 
            txtPosicionSilla.Location = new Point(20, 273);
            txtPosicionSilla.Margin = new Padding(4);
            txtPosicionSilla.Name = "txtPosicionSilla";
            txtPosicionSilla.Size = new Size(105, 27);
            txtPosicionSilla.TabIndex = 21;
            txtPosicionSilla.Visible = false;
            // 
            // lblPosicionSilla
            // 
            lblPosicionSilla.AutoSize = true;
            lblPosicionSilla.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosicionSilla.Location = new Point(20, 249);
            lblPosicionSilla.Margin = new Padding(4, 0, 4, 0);
            lblPosicionSilla.Name = "lblPosicionSilla";
            lblPosicionSilla.Size = new Size(99, 20);
            lblPosicionSilla.TabIndex = 22;
            lblPosicionSilla.Text = "Posicion Silla";
            lblPosicionSilla.Visible = false;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lblPuntos);
            groupBox3.Controls.Add(lblPuntos1);
            groupBox3.Controls.Add(lblCategoria);
            groupBox3.Controls.Add(lblCategoria1);
            groupBox3.Controls.Add(lblId);
            groupBox3.Controls.Add(lblId1);
            groupBox3.Controls.Add(lblNombre);
            groupBox3.Controls.Add(lblPosicionSilla);
            groupBox3.Controls.Add(txtPosicionSilla);
            groupBox3.Controls.Add(gbPosicion);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(cbFunciones);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(lblUsuario);
            groupBox3.Controls.Add(gbTipoSilla);
            groupBox3.Location = new Point(21, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(392, 305);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Boleto";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(289, 44);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(27, 20);
            lblCategoria.TabIndex = 26;
            lblCategoria.Text = "---";
            // 
            // lblCategoria1
            // 
            lblCategoria1.AutoSize = true;
            lblCategoria1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCategoria1.Location = new Point(289, 23);
            lblCategoria1.Margin = new Padding(4, 0, 4, 0);
            lblCategoria1.Name = "lblCategoria1";
            lblCategoria1.Size = new Size(84, 21);
            lblCategoria1.TabIndex = 25;
            lblCategoria1.Text = "Categoría";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(97, 44);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 15);
            lblId.TabIndex = 24;
            lblId.Text = "---";
            // 
            // lblId1
            // 
            lblId1.AutoSize = true;
            lblId1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId1.Location = new Point(68, 44);
            lblId1.Margin = new Padding(4, 0, 4, 0);
            lblId1.Name = "lblId1";
            lblId1.Size = new Size(21, 15);
            lblId1.TabIndex = 24;
            lblId1.Text = "Id:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombre.Location = new Point(97, 23);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(28, 21);
            lblNombre.TabIndex = 23;
            lblNombre.Text = "---";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsuario.Location = new Point(20, 23);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(73, 21);
            lblUsuario.TabIndex = 7;
            lblUsuario.Text = "Usuario:";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.White;
            groupBox4.Controls.Add(lblDescuento);
            groupBox4.Controls.Add(groupBox1);
            groupBox4.Controls.Add(lblDescuento1);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(gbCombos);
            groupBox4.Location = new Point(435, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(433, 208);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Combos";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescuento.Location = new Point(337, 44);
            lblDescuento.Margin = new Padding(4, 0, 4, 0);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(27, 20);
            lblDescuento.TabIndex = 28;
            lblDescuento.Text = "---";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbSi);
            groupBox1.Controls.Add(rdNo);
            groupBox1.Location = new Point(14, 46);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(186, 39);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // rbSi
            // 
            rbSi.AutoSize = true;
            rbSi.Location = new Point(9, 12);
            rbSi.Margin = new Padding(4, 3, 4, 3);
            rbSi.Name = "rbSi";
            rbSi.Size = new Size(39, 24);
            rbSi.TabIndex = 14;
            rbSi.TabStop = true;
            rbSi.Text = "Si";
            rbSi.UseVisualStyleBackColor = true;
            rbSi.CheckedChanged += rbSi_CheckedChanged;
            // 
            // rdNo
            // 
            rdNo.AutoSize = true;
            rdNo.Checked = true;
            rdNo.Location = new Point(99, 12);
            rdNo.Margin = new Padding(4, 3, 4, 3);
            rdNo.Name = "rdNo";
            rdNo.Size = new Size(48, 24);
            rdNo.TabIndex = 13;
            rdNo.TabStop = true;
            rdNo.Text = "No";
            rdNo.UseVisualStyleBackColor = true;
            rdNo.CheckedChanged += rdNo_CheckedChanged;
            // 
            // lblDescuento1
            // 
            lblDescuento1.AutoSize = true;
            lblDescuento1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDescuento1.Location = new Point(337, 23);
            lblDescuento1.Margin = new Padding(4, 0, 4, 0);
            lblDescuento1.Name = "lblDescuento1";
            lblDescuento1.Size = new Size(91, 21);
            lblDescuento1.TabIndex = 27;
            lblDescuento1.Text = "Descuento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(14, 23);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(197, 21);
            label2.TabIndex = 25;
            label2.Text = "Desea añadir un combo?";
            // 
            // gbCombos
            // 
            gbCombos.Controls.Add(rbCombo5);
            gbCombos.Controls.Add(rbCombo3);
            gbCombos.Controls.Add(rbCombo4);
            gbCombos.Controls.Add(rbCombo2);
            gbCombos.Controls.Add(rbCombo1);
            gbCombos.Enabled = false;
            gbCombos.Location = new Point(14, 85);
            gbCombos.Margin = new Padding(0);
            gbCombos.Name = "gbCombos";
            gbCombos.Padding = new Padding(4, 3, 4, 3);
            gbCombos.Size = new Size(407, 112);
            gbCombos.TabIndex = 17;
            gbCombos.TabStop = false;
            gbCombos.Visible = false;
            // 
            // rbCombo5
            // 
            rbCombo5.AutoSize = true;
            rbCombo5.Location = new Point(156, 70);
            rbCombo5.Margin = new Padding(4, 3, 4, 3);
            rbCombo5.Name = "rbCombo5";
            rbCombo5.Size = new Size(88, 24);
            rbCombo5.TabIndex = 18;
            rbCombo5.Text = "Combo 5";
            rbCombo5.UseVisualStyleBackColor = true;
            rbCombo5.CheckedChanged += rbCombo5_CheckedChanged;
            // 
            // rbCombo3
            // 
            rbCombo3.AutoSize = true;
            rbCombo3.Location = new Point(294, 26);
            rbCombo3.Margin = new Padding(4, 3, 4, 3);
            rbCombo3.Name = "rbCombo3";
            rbCombo3.Size = new Size(88, 24);
            rbCombo3.TabIndex = 17;
            rbCombo3.Text = "Combo 3";
            rbCombo3.UseVisualStyleBackColor = true;
            rbCombo3.CheckedChanged += rbCombo3_CheckedChanged;
            // 
            // rbCombo4
            // 
            rbCombo4.AutoSize = true;
            rbCombo4.Location = new Point(22, 71);
            rbCombo4.Margin = new Padding(4, 3, 4, 3);
            rbCombo4.Name = "rbCombo4";
            rbCombo4.Size = new Size(89, 24);
            rbCombo4.TabIndex = 16;
            rbCombo4.Text = "Combo 4";
            rbCombo4.UseVisualStyleBackColor = true;
            rbCombo4.CheckedChanged += rbCombo4_CheckedChanged;
            // 
            // rbCombo2
            // 
            rbCombo2.AutoSize = true;
            rbCombo2.Location = new Point(156, 25);
            rbCombo2.Margin = new Padding(4, 3, 4, 3);
            rbCombo2.Name = "rbCombo2";
            rbCombo2.Size = new Size(88, 24);
            rbCombo2.TabIndex = 15;
            rbCombo2.Text = "Combo 2";
            rbCombo2.UseVisualStyleBackColor = true;
            rbCombo2.CheckedChanged += rbCombo2_CheckedChanged;
            // 
            // rbCombo1
            // 
            rbCombo1.AutoSize = true;
            rbCombo1.Location = new Point(25, 24);
            rbCombo1.Margin = new Padding(4, 3, 4, 3);
            rbCombo1.Name = "rbCombo1";
            rbCombo1.Size = new Size(86, 24);
            rbCombo1.TabIndex = 14;
            rbCombo1.Text = "Combo 1";
            rbCombo1.UseVisualStyleBackColor = true;
            rbCombo1.CheckedChanged += rbCombo1_CheckedChanged;
            // 
            // lblValorTotal
            // 
            lblValorTotal.AutoSize = true;
            lblValorTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorTotal.ForeColor = Color.White;
            lblValorTotal.Location = new Point(435, 223);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(80, 20);
            lblValorTotal.TabIndex = 25;
            lblValorTotal.Text = "ValorTotal";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor.ForeColor = Color.White;
            lblValor.Location = new Point(435, 243);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(27, 20);
            lblValor.TabIndex = 26;
            lblValor.Text = "---";
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPuntos.Location = new Point(289, 85);
            lblPuntos.Margin = new Padding(4, 0, 4, 0);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(27, 20);
            lblPuntos.TabIndex = 28;
            lblPuntos.Text = "---";
            // 
            // lblPuntos1
            // 
            lblPuntos1.AutoSize = true;
            lblPuntos1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPuntos1.Location = new Point(289, 64);
            lblPuntos1.Margin = new Padding(4, 0, 4, 0);
            lblPuntos1.Name = "lblPuntos1";
            lblPuntos1.Size = new Size(63, 21);
            lblPuntos1.TabIndex = 27;
            lblPuntos1.Text = "Puntos";
            // 
            // FormReservas
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 45, 66);
            ClientSize = new Size(884, 337);
            Controls.Add(lblValor);
            Controls.Add(lblValorTotal);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(buttonComprar);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReservas";
            FormClosing += Cerrar;
            Load += FormReservas_Load;
            gbTipoSilla.ResumeLayout(false);
            gbTipoSilla.PerformLayout();
            gbPosicion.ResumeLayout(false);
            gbPosicion.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbCombos.ResumeLayout(false);
            gbCombos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
		private ComboBox cbFunciones;
		private RadioButton rbGeneral;
		private RadioButton rbVip;
		private GroupBox gbTipoSilla;
		private Label label3;
		private Button buttonComprar;
		private GroupBox gbPosicion;
		private RadioButton rbElegir;
		private RadioButton rbAutomatico;
		private TextBox txtPosicionSilla;
        private Label lblPosicionSilla;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox gbCombos;
        private RadioButton rbCombo5;
        private RadioButton rbCombo3;
        private RadioButton rbCombo4;
        private RadioButton rbCombo2;
        private RadioButton rbCombo1;
        private Label lblValorTotal;
        private Label lblValor;
        private Label lblNombre;
        private Label lblUsuario;
        private Label lblId1;
        private Label lblId;
        private GroupBox groupBox1;
        private RadioButton rbSi;
        private RadioButton rdNo;
        private Label label2;
        private Label lblCategoria;
        private Label lblCategoria1;
        private Label lblDescuento;
        private Label lblDescuento1;
        private Label lblPuntos;
        private Label lblPuntos1;
    }
}