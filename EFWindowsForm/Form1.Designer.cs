namespace EFWindowsForm
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
            btnListarUsuarios = new Button();
            btnBuscarUsuario = new Button();
            label1 = new Label();
            txtPesquisa = new TextBox();
            SuspendLayout();
            // 
            // btnListarUsuarios
            // 
            btnListarUsuarios.Location = new Point(25, 71);
            btnListarUsuarios.Name = "btnListarUsuarios";
            btnListarUsuarios.Size = new Size(98, 23);
            btnListarUsuarios.TabIndex = 0;
            btnListarUsuarios.Text = "Listar Usuários";
            btnListarUsuarios.UseVisualStyleBackColor = true;
            btnListarUsuarios.Click += btnListarUsuario_Click;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.Location = new Point(129, 71);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(98, 23);
            btnBuscarUsuario.TabIndex = 1;
            btnBuscarUsuario.Text = "Buscar usuário";
            btnBuscarUsuario.UseVisualStyleBackColor = true;
            btnBuscarUsuario.Click += btnBuscarUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(81, 21);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(138, 23);
            txtPesquisa.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 118);
            Controls.Add(txtPesquisa);
            Controls.Add(label1);
            Controls.Add(btnBuscarUsuario);
            Controls.Add(btnListarUsuarios);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListarUsuarios;
        private Button btnBuscarUsuario;
        private Label label1;
        private TextBox txtPesquisa;
    }
}