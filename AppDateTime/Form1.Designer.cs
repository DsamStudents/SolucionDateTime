using System.Drawing;
using System.Windows.Forms;

namespace AppDateTime
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DtFecha = new DateTimePicker();
            BtGetFecha = new Button();
            button1 = new Button();
            button2 = new Button();
            TbNombre = new TextBox();
            DtFechaNacimiento = new DateTimePicker();
            LbNombre = new Label();
            label1 = new Label();
            BtCrear = new Button();
            SuspendLayout();
            // 
            // DtFecha
            // 
            DtFecha.Location = new Point(44, 30);
            DtFecha.Name = "DtFecha";
            DtFecha.Size = new Size(262, 23);
            DtFecha.TabIndex = 0;
            // 
            // BtGetFecha
            // 
            BtGetFecha.Location = new Point(44, 76);
            BtGetFecha.Name = "BtGetFecha";
            BtGetFecha.Size = new Size(189, 23);
            BtGetFecha.TabIndex = 1;
            BtGetFecha.Text = "Get Fecha actual";
            BtGetFecha.UseVisualStyleBackColor = true;
            BtGetFecha.Click += BtGetFecha_Click;
            // 
            // button1
            // 
            button1.Location = new Point(44, 117);
            button1.Name = "button1";
            button1.Size = new Size(189, 23);
            button1.TabIndex = 2;
            button1.Text = "Sumar 30 días a la fecha actual";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(312, 32);
            button2.Name = "button2";
            button2.Size = new Size(168, 23);
            button2.TabIndex = 3;
            button2.Text = "CompararFechas";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TbNombre
            // 
            TbNombre.Location = new Point(549, 40);
            TbNombre.Name = "TbNombre";
            TbNombre.Size = new Size(167, 23);
            TbNombre.TabIndex = 4;
            // 
            // DtFechaNacimiento
            // 
            DtFechaNacimiento.DropDownAlign = LeftRightAlignment.Right;
            DtFechaNacimiento.Format = DateTimePickerFormat.Short;
            DtFechaNacimiento.Location = new Point(549, 98);
            DtFechaNacimiento.Name = "DtFechaNacimiento";
            DtFechaNacimiento.Size = new Size(167, 23);
            DtFechaNacimiento.TabIndex = 5;
            // 
            // LbNombre
            // 
            LbNombre.AutoSize = true;
            LbNombre.Location = new Point(549, 22);
            LbNombre.Name = "LbNombre";
            LbNombre.Size = new Size(105, 15);
            LbNombre.TabIndex = 6;
            LbNombre.Text = "Nombre completo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(549, 80);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 7;
            label1.Text = "FechaNacimiento";
            // 
            // BtCrear
            // 
            BtCrear.Location = new Point(549, 153);
            BtCrear.Name = "BtCrear";
            BtCrear.Size = new Size(168, 23);
            BtCrear.TabIndex = 8;
            BtCrear.Text = "Crear Estudiante";
            BtCrear.UseVisualStyleBackColor = true;
            BtCrear.Click += BtCrear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtCrear);
            Controls.Add(label1);
            Controls.Add(LbNombre);
            Controls.Add(DtFechaNacimiento);
            Controls.Add(TbNombre);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(BtGetFecha);
            Controls.Add(DtFecha);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DtFecha;
        private Button BtGetFecha;
        private Button button1;
        private Button button2;
        private TextBox TbNombre;
        private DateTimePicker DtFechaNacimiento;
        private Label LbNombre;
        private Label label1;
        private Button BtCrear;
    }
}