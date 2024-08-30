namespace Practico4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBNumeros = new System.Windows.Forms.ListBox();
            this.TBHasta = new System.Windows.Forms.TextBox();
            this.TBDesde = new System.Windows.Forms.TextBox();
            this.BTNPrimos = new System.Windows.Forms.Button();
            this.BTNImpares = new System.Windows.Forms.Button();
            this.BTNPares = new System.Windows.Forms.Button();
            this.BGFuncion = new System.Windows.Forms.Button();
            this.LListaNumeros = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.LDesde = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.LBNumeros);
            this.panel1.Controls.Add(this.TBHasta);
            this.panel1.Controls.Add(this.TBDesde);
            this.panel1.Controls.Add(this.BTNPrimos);
            this.panel1.Controls.Add(this.BTNImpares);
            this.panel1.Controls.Add(this.BTNPares);
            this.panel1.Controls.Add(this.BGFuncion);
            this.panel1.Controls.Add(this.LListaNumeros);
            this.panel1.Controls.Add(this.LHasta);
            this.panel1.Controls.Add(this.LDesde);
            this.panel1.Location = new System.Drawing.Point(38, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 361);
            this.panel1.TabIndex = 0;
            // 
            // LBNumeros
            // 
            this.LBNumeros.FormattingEnabled = true;
            this.LBNumeros.Location = new System.Drawing.Point(251, 64);
            this.LBNumeros.Name = "LBNumeros";
            this.LBNumeros.Size = new System.Drawing.Size(162, 277);
            this.LBNumeros.TabIndex = 9;
            // 
            // TBHasta
            // 
            this.TBHasta.Location = new System.Drawing.Point(90, 107);
            this.TBHasta.Name = "TBHasta";
            this.TBHasta.Size = new System.Drawing.Size(144, 20);
            this.TBHasta.TabIndex = 8;
            // 
            // TBDesde
            // 
            this.TBDesde.Location = new System.Drawing.Point(90, 64);
            this.TBDesde.Name = "TBDesde";
            this.TBDesde.Size = new System.Drawing.Size(144, 20);
            this.TBDesde.TabIndex = 7;
            // 
            // BTNPrimos
            // 
            this.BTNPrimos.Location = new System.Drawing.Point(90, 250);
            this.BTNPrimos.Name = "BTNPrimos";
            this.BTNPrimos.Size = new System.Drawing.Size(144, 23);
            this.BTNPrimos.TabIndex = 6;
            this.BTNPrimos.Text = "Numeros Primos";
            this.BTNPrimos.UseVisualStyleBackColor = true;
            this.BTNPrimos.Click += new System.EventHandler(this.BTNPrimos_Click);
            // 
            // BTNImpares
            // 
            this.BTNImpares.Location = new System.Drawing.Point(90, 221);
            this.BTNImpares.Name = "BTNImpares";
            this.BTNImpares.Size = new System.Drawing.Size(144, 23);
            this.BTNImpares.TabIndex = 5;
            this.BTNImpares.Text = "Numeros Impares";
            this.BTNImpares.UseVisualStyleBackColor = true;
            this.BTNImpares.Click += new System.EventHandler(this.BTNImpares_Click);
            // 
            // BTNPares
            // 
            this.BTNPares.Location = new System.Drawing.Point(90, 195);
            this.BTNPares.Name = "BTNPares";
            this.BTNPares.Size = new System.Drawing.Size(144, 20);
            this.BTNPares.TabIndex = 4;
            this.BTNPares.Text = "Numeros Pares";
            this.BTNPares.UseVisualStyleBackColor = true;
            this.BTNPares.Click += new System.EventHandler(this.BTNPares_Click);
            // 
            // BGFuncion
            // 
            this.BGFuncion.Location = new System.Drawing.Point(90, 166);
            this.BGFuncion.Name = "BGFuncion";
            this.BGFuncion.Size = new System.Drawing.Size(144, 23);
            this.BGFuncion.TabIndex = 3;
            this.BGFuncion.Text = "Generar Funcion";
            this.BGFuncion.UseVisualStyleBackColor = true;
            this.BGFuncion.Click += new System.EventHandler(this.BGFuncion_Click);
            // 
            // LListaNumeros
            // 
            this.LListaNumeros.AutoSize = true;
            this.LListaNumeros.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaNumeros.Location = new System.Drawing.Point(245, 12);
            this.LListaNumeros.Name = "LListaNumeros";
            this.LListaNumeros.Size = new System.Drawing.Size(184, 31);
            this.LListaNumeros.TabIndex = 2;
            this.LListaNumeros.Text = "Lista de Numeros";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(37, 107);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(35, 13);
            this.LHasta.TabIndex = 1;
            this.LHasta.Text = "Hasta";
            this.LHasta.Click += new System.EventHandler(this.label1_Click);
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(34, 67);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(38, 13);
            this.LDesde.TabIndex = 0;
            this.LDesde.Text = "Desde";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(432, 62);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(264, 279);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Formulario 4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LListaNumeros;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Button BTNPrimos;
        private System.Windows.Forms.Button BTNImpares;
        private System.Windows.Forms.Button BTNPares;
        private System.Windows.Forms.Button BGFuncion;
        private System.Windows.Forms.TextBox TBHasta;
        private System.Windows.Forms.TextBox TBDesde;
        private System.Windows.Forms.ListBox LBNumeros;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

