using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;


namespace Memory
{
    class Square 
    {
        public bool isSelected { get; set; }
        public Square pair { get; set; }
        public Button button;
        public List<Square> vedrana;

        public Square(Square p, Button b)
        {
            isSelected = false;
            pair = p;
            button = b;
            vedrana.Add(p);
        }














    }
}
