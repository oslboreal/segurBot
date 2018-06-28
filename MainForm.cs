using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using gma.System.Windows;
using System.Drawing;
using System.IO;
using System.Collections;

namespace GlobalHookDemo 
{
	class MainForm : System.Windows.Forms.Form
	{
        #region DISEÑO
        private System.Windows.Forms.Label labelMousePosition;
        private Label label1;
        private System.ComponentModel.IContainer components;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configuracionToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem coordenadasToolStripMenuItem;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private GroupBox groupBox1;
        private Button button2;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private Label label9;
        private Label labelCantFicheros;
        private System.Windows.Forms.TextBox textBox;

        public MainForm()
        {
            InitializeComponent();
        }
        // THIS METHOD IS MAINTAINED BY THE FORM DESIGNER
        // DO NOT EDIT IT MANUALLY! YOUR CHANGES ARE LIKELY TO BE LOST
        void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelMousePosition = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coordenadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelCantFicheros = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.textBox.Location = new System.Drawing.Point(4, 261);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(322, 102);
            this.textBox.TabIndex = 3;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelMousePosition
            // 
            this.labelMousePosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMousePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMousePosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelMousePosition.Location = new System.Drawing.Point(4, 366);
            this.labelMousePosition.Name = "labelMousePosition";
            this.labelMousePosition.Size = new System.Drawing.Size(322, 23);
            this.labelMousePosition.TabIndex = 2;
            this.labelMousePosition.Text = "labelMousePosition";
            this.labelMousePosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registro de comportamiento:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(328, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coordenadasToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // coordenadasToolStripMenuItem
            // 
            this.coordenadasToolStripMenuItem.Name = "coordenadasToolStripMenuItem";
            this.coordenadasToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.coordenadasToolStripMenuItem.Text = "Coordenadas";
            this.coordenadasToolStripMenuItem.Click += new System.EventHandler(this.coordenadasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Coordenadas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ruta ficheros:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(92, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(92, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "NO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(19, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Comenzar trabajo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labelCantFicheros);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 73);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ficheros:";
            // 
            // labelCantFicheros
            // 
            this.labelCantFicheros.AutoSize = true;
            this.labelCantFicheros.Location = new System.Drawing.Point(190, 25);
            this.labelCantFicheros.Name = "labelCantFicheros";
            this.labelCantFicheros.Size = new System.Drawing.Size(13, 13);
            this.labelCantFicheros.TabIndex = 14;
            this.labelCantFicheros.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 20);
            this.textBox1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(7, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Seleccionar ruta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo de trabajo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(92, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "RECIBO INDEMNIZACIÓN";
            // 
            // MainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(328, 398);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelMousePosition);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(344, 437);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(344, 437);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SegurBot";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        #endregion

        
        [STAThread]
		public static void Main(string[] args)
		{
			Application.Run(new MainForm());
		}

        // Creamos un nuevo objeto del tipo UserActivityHook
		UserActivityHook actHook;
		void MainFormLoad(object sender, System.EventArgs e)
		{
            actHook = new UserActivityHook(); // crate an instance with global hooks
			// hang on events
			actHook.OnMouseActivity+= new MouseEventHandler(MouseMoved);
            actHook.OnMouseActivity += new MouseEventHandler(CapturaCoordenadas);
			actHook.KeyDown+= new KeyEventHandler(MyKeyDown);
            actHook.Start();
        }
		
        /// <summary>
        /// Metodo encargado de atender el MouseEventArgs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		public void MouseMoved(object sender, MouseEventArgs e)
		{
			labelMousePosition.Text=String.Format("x={0}  y={1} Rueda={2}", e.X, e.Y, e.Delta);
            if (e.Clicks > 0)
            {
                LogWrite("Boton Mouse 	- " + e.Button.ToString());
            }
		}
        /// <summary>
        /// Metodo encargado de capturar las coordenadas con MouseEventArgs event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CapturaCoordenadas(object sender, MouseEventArgs e)
        {
            if (e.Clicks > 0 && e.Button.ToString() == "Left")
            {
                LogWrite("Coordenadas Capturadas: " + e.Location.ToString());
            }
        }
        /// <summary>
        /// Método encargado de trabajar la tecla detectada en el evento KeyEventArgs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MyKeyDown(object sender, KeyEventArgs e)
		{
			LogWrite("Tecla Presionada 	- " + e.KeyData.ToString());
		}
		/// <summary>
        /// Método encargado de escribir los distintos sucesos en el Log.
        /// </summary>
        /// <param name="txt"></param>
		private void LogWrite(string txt)
		{
			textBox.AppendText(txt + Environment.NewLine);
			textBox.SelectionStart = textBox.Text.Length;
		}

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        #region MANEJO DE MOUSE

        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        /// <summary>
        /// Realizamos click izquierdo con el Mouse
        /// </summary>
        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
        #endregion
        
        private void button1_Click(object sender, EventArgs e)
        {
            Thread.Sleep(4000);
            // Reiniciamos el actHook
            actHook.Stop();
            actHook.Start();
            //this.DoMouseClick();
            Clipboard.SetText("TEST");
        }

        private void coordenadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Ventana = new Configuraciones();
            this.Hide();
            actHook.Stop();
            Ventana.ShowDialog();
            this.Show();
            actHook.Start();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if(segurBot.isOk)
            {
                label4.Text = "SI";
                label4.BackColor = Color.LimeGreen;
            }
        }

        FolderBrowserDialog ofd = new FolderBrowserDialog();
        

        private void button2_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                // Modificamos flag de ruta asignada.
                segurBot.flagPath = true;
                segurBot.fileList = Directory.GetFiles(ofd.SelectedPath);
                segurBot.fileCount = segurBot.fileList.Length;
                this.labelCantFicheros.Text = segurBot.fileCount.ToString();
                foreach(string temp in segurBot.fileList)
                {
                    segurBot.temFile = new FileInfo(temp);
                    segurBot.files.Add(segurBot.temFile);
                    LogWrite(segurBot.temFile.Name);
                }
                // Asignamos la ruta.
                segurBot.Path = ofd.SelectedPath;
                textBox1.Text = ofd.SelectedPath;
                if (segurBot.flagPath) 
                {
                    label5.BackColor = Color.LimeGreen;
                    label5.Text = "SI";
                    label7.BackColor = Color.LimeGreen;
                }
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
