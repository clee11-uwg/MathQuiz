using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class MathQuiz : Form
    {
        //Create a Random object called randomizer to generate random numbers
        Random randomizer = new Random();

        // These integer variables store the numbers for the addition problem
        int addend1;
        int addend2;
        public MathQuiz()
        {
            InitializeComponent();
        }
    }
}
