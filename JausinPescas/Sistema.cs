using FontAwesome.Sharp;
using System.Data;
using System.Runtime.InteropServices;
using System.Transactions;

namespace JausinPescas
{
    public partial class Sistema : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;


        public Sistema()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,60);
            panelMenu.Controls.Add(leftBorderBtn);

            //tirar borda api
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered= true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //ativar botao pressionado
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null) 
            {
                DisableButton();
                //BUTTON
                currentBtn = (IconButton)senderBtn;
                //25, 25, 112
                currentBtn.BackColor = Color.FromArgb(28, 28, 28);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign= ContentAlignment.MiddleRight;

                //leftborder button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icon current
                iconCurrent.IconChar= currentBtn.IconChar;
                iconCurrent.IconColor = color;
            }
        }

        //desativar botao pressionado
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(2, 0, 36);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //abrir formularios secundarios
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //abrir somente um formulario
                currentChildForm.Close();
            }


            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleBar.Text = currentBtn.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 255, 255));
            OpenChildForm(new FormCadastro());
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 255, 255));
            OpenChildForm(new FormListar());
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 255, 255));
            OpenChildForm(new FormAlterar());
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(255, 255, 255));
            OpenChildForm(new FormRemover());
        }
        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        //arrastar pela barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //botao home
        private void btnHome_Click_1(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrent.IconChar = IconChar.Home;
            iconCurrent.IconColor = Color.Gainsboro;
            lblTitleBar.Text = "Página Inicial";
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void iconMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}