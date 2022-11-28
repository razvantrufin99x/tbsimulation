namespace tbsimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public tb thetb = new tb();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            thetb.VCC = 5.0f; 
            thetb.VBB = 4.0f;

            thetb.VBE = 0.7f;

            thetb.RB = 100.0f;
            thetb.RE = 25.0f;
            thetb.RC = 250.0f;

            thetb.betaDC = 0.8f;

            

            thetb.IB = thetb.fIB(thetb.VBB, thetb.VBE, thetb.RB);
            thetb.IC = thetb.fIC(thetb.betaDC, thetb.IB);
            thetb.IE = thetb.fIE(thetb.IC, thetb.IB);

            thetb.alfaDC = thetb.falfaDC(thetb.IC, thetb.IE);

            thetb.VCE = thetb.fVCE(thetb.VCC, thetb.VRC);
            thetb.VCB = thetb.fVCB(thetb.VCE, thetb.VBE);

            thetb.hFE = thetb.fhFE(thetb.betaDC);

            thetb.VRB = thetb.fVRB(thetb.VBB, thetb.VBE);
            thetb.VRE = thetb.fVRE(thetb.IE, thetb.RE);
            thetb.VRC = thetb.fVRC(thetb.IC, thetb.RC);

            this.txtVBB.Text = thetb.VBB.ToString();
            this.txtVCC.Text = thetb.VCC.ToString();

            this.txtVBE.Text = thetb.VBE.ToString();

            this.txtRB.Text = thetb.RB.ToString();
            this.txtRE.Text = thetb.RE.ToString();
            this.txtRC.Text = thetb.RC.ToString();

            this.txtbetaDC.Text = thetb.betaDC.ToString();
            this.txtalfaDC.Text = thetb.alfaDC.ToString();

            this.txtIB.Text = thetb.IB.ToString();
            this.txtIC.Text = thetb.IC.ToString();
            this.txtIE.Text = thetb.IE.ToString();

            

            this.txtVCE.Text = thetb.VCE.ToString();

            this.txtVCB.Text = thetb.VCB.ToString();


            this.txthFE.Text = thetb.hFE.ToString();

            this.txtVRB.Text = thetb.VRB.ToString();
            this.txtVRE.Text = thetb.VRE.ToString();
            this.txtVRC.Text = thetb.VRC.ToString();
        }
    }
}