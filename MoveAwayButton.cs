using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoveRunAway
{
    public partial class MoveAwayButton : UserControl
    {
        public MoveAwayButton()
        {
            InitializeComponent();
        }
        [Description("Test text displayed in the button"), Category("Data")]
        public string ButtonText
        {
            get
            {
                return button1.Text;
            }
            set
            {
                button1.Text = value;
            }
        }

        private bool _ChangeColorOnMove = true;

        [Description("Change background color on move"), Category("Data")]
        public bool ChangeColorOnMove
        {
            get
            {
                return _ChangeColorOnMove;
            }
            set
            {
                _ChangeColorOnMove = value;
            }
        }

        private string _ClickMessage;

        [Description("Message on button click"), Category("Data")]
        public string ClickMessage
        {
            get
            {
                return _ClickMessage;
            }
            set
            {
                _ClickMessage = value;
            }
        }


        #region Moveable determine
        private bool CanMoveUp
        {
            get
            {
                return this.Top > 0;
            }
        }

        private bool CanMoveDown
        {
            get
            {
                return this.Bottom < Parent.Height;
            }
        }

        private bool CanMoveLeft
        {
            get
            {
                return this.Left > 0;
            }
        }

        private bool CanMoveRight
        {
            get
            {
                return this.Right < Parent.Width;
            }
        }

        #endregion

        private void TableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            

            if (e.X < button1.Left)
            {
                if (CanMoveRight)
                {
                    GoRight(e.Location);
                }
                else if (CanMoveUp)
                {
                    GoUp(e.Location);
                }
                else if (CanMoveDown)
                {
                    GoDown(e.Location);
                }
            }
            else if (e.X > button1.Right)
            {
                if (CanMoveLeft)
                {
                    GoLeft(e.Location);
                }

                else if (CanMoveDown)
                {
                    GoDown(e.Location);
                }
                else if (CanMoveUp)
                {
                    GoUp(e.Location);
                }
            }
            else if (e.Y < button1.Top)
            {
                if (CanMoveDown)
                {
                    GoDown(e.Location);
                }
                else if (CanMoveRight)
                {
                    GoRight(e.Location);
                }
                else if (CanMoveLeft)
                {
                    GoLeft(e.Location);
                }
            }
            else if (e.Y > button1.Bottom)
            {
                if (CanMoveUp)
                {
                    GoUp(e.Location);
                }
                else if (CanMoveRight)
                {
                    GoRight(e.Location);
                }
                else if (CanMoveLeft)
                {
                    GoLeft(e.Location);
                }
            }
            else
            {
                if (CanMoveUp)
                {
                    GoUp(e.Location);
                }
                else if (CanMoveDown)
                {
                    GoDown(e.Location);
                }
                if (CanMoveRight)
                {
                    GoRight(e.Location);
                }
                else if (CanMoveLeft)
                {
                    GoLeft(e.Location);
                }
            }
        }

        private void GoRight(Point mousePosition)
        {
            this.Left += mousePosition.X + 1;
            System.Diagnostics.Debug.WriteLine("Right : " + this.Location);
        }

        private void GoLeft(Point mousePosition)
        {
            this.Left += mousePosition.X - this.Width;
            System.Diagnostics.Debug.WriteLine("Left : " + this.Location);
        }

        private void GoUp(Point mousePosition)
        {
            this.Top -= this.Height - mousePosition.Y;

            System.Diagnostics.Debug.WriteLine("Up : " + this.Location);
        }

        private void GoDown(Point mousePosition)
        {
            this.Top += mousePosition.Y + 1;
            System.Diagnostics.Debug.WriteLine("Down : " + this.Location);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ClickMessage);
        }
        Random rnd = new Random(DateTime.Now.Millisecond);
        private void MoveAwayButton_Load(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            button1.BackColor = randomColor;
        }
    }
}
