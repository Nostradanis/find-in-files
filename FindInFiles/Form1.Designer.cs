namespace FindInFiles
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listOrigenes = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbJS = new System.Windows.Forms.RadioButton();
            this.rdbTodos = new System.Windows.Forms.RadioButton();
            this.rdbJSON = new System.Windows.Forms.RadioButton();
            this.rdbCSS = new System.Windows.Forms.RadioButton();
            this.rdbHTML = new System.Windows.Forms.RadioButton();
            this.rdbTS = new System.Windows.Forms.RadioButton();
            this.rdbTXT = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFicheroSelec = new System.Windows.Forms.Label();
            this.lblNumRegistros = new System.Windows.Forms.Label();
            this.chkCase = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.listResultados = new System.Windows.Forms.ListView();
            this.txtFichero = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFichero, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1473, 834);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.listOrigenes, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listResultados, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1467, 411);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // listOrigenes
            // 
            this.listOrigenes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOrigenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listOrigenes.HideSelection = false;
            this.listOrigenes.Location = new System.Drawing.Point(736, 3);
            this.listOrigenes.Name = "listOrigenes";
            this.listOrigenes.Size = new System.Drawing.Size(728, 199);
            this.listOrigenes.TabIndex = 2;
            this.listOrigenes.UseCompatibleStateImageBehavior = false;
            this.listOrigenes.SelectedIndexChanged += new System.EventHandler(this.listOrigenes_SelectedIndexChanged);
            this.listOrigenes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listOrigenes_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbJS);
            this.panel1.Controls.Add(this.rdbTodos);
            this.panel1.Controls.Add(this.rdbJSON);
            this.panel1.Controls.Add(this.rdbCSS);
            this.panel1.Controls.Add(this.rdbHTML);
            this.panel1.Controls.Add(this.rdbTS);
            this.panel1.Controls.Add(this.rdbTXT);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnExaminar);
            this.panel1.Controls.Add(this.txtPattern);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtRuta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(736, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 200);
            this.panel1.TabIndex = 1;
            // 
            // rdbJS
            // 
            this.rdbJS.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbJS.AutoSize = true;
            this.rdbJS.Location = new System.Drawing.Point(320, 124);
            this.rdbJS.Name = "rdbJS";
            this.rdbJS.Size = new System.Drawing.Size(29, 23);
            this.rdbJS.TabIndex = 13;
            this.rdbJS.TabStop = true;
            this.rdbJS.Tag = "*.js";
            this.rdbJS.Text = "JS";
            this.rdbJS.UseVisualStyleBackColor = true;
            this.rdbJS.CheckedChanged += new System.EventHandler(this.rdbJS_CheckedChanged);
            // 
            // rdbTodos
            // 
            this.rdbTodos.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbTodos.AutoSize = true;
            this.rdbTodos.Location = new System.Drawing.Point(363, 124);
            this.rdbTodos.Name = "rdbTodos";
            this.rdbTodos.Size = new System.Drawing.Size(47, 23);
            this.rdbTodos.TabIndex = 14;
            this.rdbTodos.TabStop = true;
            this.rdbTodos.Tag = "*.txt|*.md|*.ts|*.html|*.css|*.js|*.json";
            this.rdbTodos.Text = "Todos";
            this.rdbTodos.UseVisualStyleBackColor = true;
            this.rdbTodos.CheckedChanged += new System.EventHandler(this.rdbTodos_CheckedChanged);
            // 
            // rdbJSON
            // 
            this.rdbJSON.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbJSON.AutoSize = true;
            this.rdbJSON.Location = new System.Drawing.Point(261, 124);
            this.rdbJSON.Name = "rdbJSON";
            this.rdbJSON.Size = new System.Drawing.Size(45, 23);
            this.rdbJSON.TabIndex = 12;
            this.rdbJSON.TabStop = true;
            this.rdbJSON.Tag = "*.json";
            this.rdbJSON.Text = "JSON";
            this.rdbJSON.UseVisualStyleBackColor = true;
            this.rdbJSON.CheckedChanged += new System.EventHandler(this.rdbJSON_CheckedChanged);
            // 
            // rdbCSS
            // 
            this.rdbCSS.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbCSS.AutoSize = true;
            this.rdbCSS.Location = new System.Drawing.Point(209, 124);
            this.rdbCSS.Name = "rdbCSS";
            this.rdbCSS.Size = new System.Drawing.Size(38, 23);
            this.rdbCSS.TabIndex = 11;
            this.rdbCSS.TabStop = true;
            this.rdbCSS.Tag = "*.css";
            this.rdbCSS.Text = "CSS";
            this.rdbCSS.UseVisualStyleBackColor = true;
            this.rdbCSS.CheckedChanged += new System.EventHandler(this.rdbCSS_CheckedChanged);
            // 
            // rdbHTML
            // 
            this.rdbHTML.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbHTML.AutoSize = true;
            this.rdbHTML.Location = new System.Drawing.Point(148, 124);
            this.rdbHTML.Name = "rdbHTML";
            this.rdbHTML.Size = new System.Drawing.Size(47, 23);
            this.rdbHTML.TabIndex = 10;
            this.rdbHTML.TabStop = true;
            this.rdbHTML.Tag = "*.html";
            this.rdbHTML.Text = "HTML";
            this.rdbHTML.UseVisualStyleBackColor = true;
            this.rdbHTML.CheckedChanged += new System.EventHandler(this.rdbHTML_CheckedChanged);
            // 
            // rdbTS
            // 
            this.rdbTS.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbTS.AutoSize = true;
            this.rdbTS.Location = new System.Drawing.Point(103, 124);
            this.rdbTS.Name = "rdbTS";
            this.rdbTS.Size = new System.Drawing.Size(31, 23);
            this.rdbTS.TabIndex = 9;
            this.rdbTS.TabStop = true;
            this.rdbTS.Tag = "*.ts";
            this.rdbTS.Text = "TS";
            this.rdbTS.UseVisualStyleBackColor = true;
            this.rdbTS.CheckedChanged += new System.EventHandler(this.rdbTS_CheckedChanged);
            // 
            // rdbTXT
            // 
            this.rdbTXT.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbTXT.AutoSize = true;
            this.rdbTXT.Location = new System.Drawing.Point(51, 123);
            this.rdbTXT.Name = "rdbTXT";
            this.rdbTXT.Size = new System.Drawing.Size(38, 23);
            this.rdbTXT.TabIndex = 8;
            this.rdbTXT.TabStop = true;
            this.rdbTXT.Tag = "*.txt|*.md";
            this.rdbTXT.Text = "TXT";
            this.rdbTXT.UseVisualStyleBackColor = true;
            this.rdbTXT.CheckedChanged += new System.EventHandler(this.rdbTXT_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGuardar.Location = new System.Drawing.Point(459, 118);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(152, 32);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExaminar.Location = new System.Drawing.Point(459, 41);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(152, 32);
            this.btnExaminar.TabIndex = 5;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtPattern
            // 
            this.txtPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPattern.Location = new System.Drawing.Point(93, 76);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(348, 26);
            this.txtPattern.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNombre.Location = new System.Drawing.Point(93, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(348, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pattern";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ruta";
            // 
            // txtRuta
            // 
            this.txtRuta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRuta.Location = new System.Drawing.Point(93, 44);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(348, 26);
            this.txtRuta.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblFicheroSelec);
            this.panel2.Controls.Add(this.lblNumRegistros);
            this.panel2.Controls.Add(this.chkCase);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 199);
            this.panel2.TabIndex = 2;
            // 
            // lblFicheroSelec
            // 
            this.lblFicheroSelec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFicheroSelec.AutoSize = true;
            this.lblFicheroSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFicheroSelec.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFicheroSelec.Location = new System.Drawing.Point(14, 115);
            this.lblFicheroSelec.Name = "lblFicheroSelec";
            this.lblFicheroSelec.Size = new System.Drawing.Size(0, 20);
            this.lblFicheroSelec.TabIndex = 10;
            // 
            // lblNumRegistros
            // 
            this.lblNumRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNumRegistros.AutoSize = true;
            this.lblNumRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNumRegistros.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblNumRegistros.Location = new System.Drawing.Point(14, 154);
            this.lblNumRegistros.Name = "lblNumRegistros";
            this.lblNumRegistros.Size = new System.Drawing.Size(0, 20);
            this.lblNumRegistros.TabIndex = 9;
            // 
            // chkCase
            // 
            this.chkCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCase.AutoSize = true;
            this.chkCase.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkCase.Location = new System.Drawing.Point(369, 150);
            this.chkCase.Name = "chkCase";
            this.chkCase.Size = new System.Drawing.Size(133, 24);
            this.chkCase.TabIndex = 8;
            this.chkCase.Text = "Case Sensitive";
            this.chkCase.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscar.Location = new System.Drawing.Point(541, 130);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(166, 44);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(17, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Buscar";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBuscar.Location = new System.Drawing.Point(18, 45);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(689, 26);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // listResultados
            // 
            this.listResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listResultados.HideSelection = false;
            this.listResultados.Location = new System.Drawing.Point(3, 208);
            this.listResultados.Name = "listResultados";
            this.listResultados.Size = new System.Drawing.Size(727, 200);
            this.listResultados.TabIndex = 8;
            this.listResultados.UseCompatibleStateImageBehavior = false;
            this.listResultados.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listResultados_ItemSelectionChanged);
            this.listResultados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listResultados_KeyPress);
            this.listResultados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listResultados_MouseDoubleClick);
            // 
            // txtFichero
            // 
            this.txtFichero.AutoWordSelection = true;
            this.txtFichero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFichero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFichero.Location = new System.Drawing.Point(3, 420);
            this.txtFichero.Name = "txtFichero";
            this.txtFichero.Size = new System.Drawing.Size(1467, 411);
            this.txtFichero.TabIndex = 9;
            this.txtFichero.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 837);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Find In Files";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView listOrigenes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listResultados;
        private System.Windows.Forms.RichTextBox txtFichero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkCase;
        private System.Windows.Forms.Label lblNumRegistros;
        private System.Windows.Forms.Label lblFicheroSelec;
        private System.Windows.Forms.RadioButton rdbJS;
        private System.Windows.Forms.RadioButton rdbTodos;
        private System.Windows.Forms.RadioButton rdbJSON;
        private System.Windows.Forms.RadioButton rdbCSS;
        private System.Windows.Forms.RadioButton rdbHTML;
        private System.Windows.Forms.RadioButton rdbTS;
        private System.Windows.Forms.RadioButton rdbTXT;
    }
}

