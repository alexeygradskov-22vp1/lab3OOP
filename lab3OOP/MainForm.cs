using System;
using System.Windows.Forms;

namespace lab3OOP
{
    public partial class MainForm : Form
    {
        private int _selIndex = 0;
        public MainForm()
        {
            InitializeComponent();
        }


        private void stateLibraryRB_CheckedChanged(object sender, EventArgs e)
        {
            _selIndex = 1;
        }

        private void showTypeBtn_Click(object sender, EventArgs e)
        {
            if (libsLB.SelectedItem != null)
            {
                var selectedIndex = libsLB.SelectedIndex;
                Library.Libraries[selectedIndex].Type();
            }
        }

        private void showCostBtn_Click(object sender, EventArgs e)
        {
            if (libsLB.SelectedItem != null)
            {
                var selectedIndex = libsLB.SelectedIndex;
                Library.Libraries[selectedIndex].Cost();
            }
        }

        private void btnCreateLib_Click(object sender, EventArgs e)
        {
            if (_selIndex == 0) { Enabled = false; MessageBox.Show("Выберите тип библиотеки!"); Enabled = true; }
            else
            {
                LibraryFactor factory = null;
                string Type = "";
                switch (_selIndex)
                {
                    case 1:
                        factory = new StateLibraryF();
                        Type = "Государственная библиотека";
                        break;
                    case 2:
                        factory = new PrivateLibraryF();
                        Type = "Частная библиотека";
                        break;
                }

                if (factory != null)
                {
                    var lib = new Library(factory);
                    Library.AddInList(lib);
                    libsLB.Items.Add($"{Type} #{lib.ObjectCounter()}");
                }
            }
        }

        private void privateLibraryRB_CheckedChanged(object sender, EventArgs e)
        {
            _selIndex = 2;
        }
    }
}

