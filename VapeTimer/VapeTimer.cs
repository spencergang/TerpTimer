namespace VapeTimer
{
  public partial class VapeTimer : Form
  {
    System.Windows.Forms.Timer timer;
    private bool isRunning = false;

    public VapeTimer()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        if (!isRunning)
        {
          timer = new System.Windows.Forms.Timer();
          int counter = int.Parse(textBox1.Text);
          timer.Tick += new EventHandler(timer_Tick);
          timer.Interval = 1000;
          timer.Start();
          label1.Text = counter.ToString();
          this.BackColor = Color.Red;
          isRunning = true;
          button1.Enabled = false;
        }
      }
      catch (Exception ex)
      {
        label1.Text = "Error occurred";
      }
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      int counter = int.Parse(label1.Text);
      counter--;
      if (counter == 0)
      {
        isRunning = false;
        button1.Enabled = true;
        this.BackColor = Color.Green;
        timer.Stop();
        button1.Text = "Start";
      }
      label1.Text = counter.ToString();
    }
  }
}