using live2.engine;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace live2
{
    public partial class MainForm : Form
    {
        private Controller controller = new Controller();

        public MainForm()
        {
            InitializeComponent();
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fieldform(object sender, EventArgs e)
        {

        }

        private void draw(System.Collections.ArrayList cells)
        {
            Bitmap bmp = new Bitmap(canvas.Width, canvas.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                clear(g);
            }
            canvas.Image = bmp;

            int cellSize = controller.model.sqaureSize;
            int numOfCells = controller.model.width;

            using (Graphics g = Graphics.FromImage(bmp))
            {
                drawGrid(g, cellSize, numOfCells);
                drawCells(g, cellSize, cells);
            }
        }

        private void draw()
        {
            draw(controller.getCells());
        }

        private void drawCells(Graphics g, int cellSize, System.Collections.ArrayList cells)
        {
            int size = controller.model.sqaureSize + 1;
            foreach (Cell c in cells)
            {
                g.FillRectangle(Brushes.Black, c.col * cellSize, c.row * cellSize,size ,size);
            }
        }

        private void drawGrid(Graphics g, int cellSize, int numOfCells)
        {
            Pen pen = new Pen(Color.Gray);
            pen.DashStyle = DashStyle.Dot;
            for (int i = 0; i < numOfCells + 1; i++)
            {
                g.DrawLine(pen, i * cellSize, 0, i * cellSize, numOfCells * cellSize);
                g.DrawLine(pen, 0, i * cellSize, numOfCells * cellSize, i * cellSize);
            }
        }
        private void clear(Graphics g)
        {
            g.Clear(Color.White);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Start(object sender, EventArgs e)
        {
            liveTimer.Start();
        }

        private void Stop(object sender, EventArgs e)
        {
            liveTimer.Stop();
            this.draw();
        }

        private void Step(object sender, EventArgs e)
        {
            this.draw(controller.step());
        }

        private void Clean(object sender, EventArgs e)
        {
            liveTimer.Stop();
            this.draw(controller.clean());
        }

        private void Random(object sender, EventArgs e)
        {
            liveTimer.Stop();
            this.draw(controller.random());
        }

        private void Close(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Help(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", $"/c start https://ru.wikipedia.org/wiki/Èãðà_«Æèçíü»") { CreateNoWindow = true });
        }

        private void TimerTick(object sender, EventArgs e)
        {
            this.draw(controller.step());
        }
    }
}
