using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class FrmSimpleTextEditor : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        public FrmSimpleTextEditor()
        {

            InitializeComponent();
            // Ajout d'un item au menu composé d'un logo.
            var exitMenuItem = menuMain.Items.Add(Image.FromFile("c:\\Exit.png"));
            // Aligné à droite, j'ai mis 2h à trouver ça ! meh
            exitMenuItem.Alignment = ToolStripItemAlignment.Right;
            //Essai d'un event manuel !!!
            exitMenuItem.Click += new EventHandler(clickOnExit);



            // Appel à ma classe Static, pour ajouter un menu contextuel à ma richTextBOx
            LibEvents.AddContextMenu(this.rtbAffiche);
        }

        private void PasteAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();

        }

        private void CopyAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CutAction(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Event pour Quitter. MEH
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickOnExit(object sender, EventArgs e)
        {
            Close();
            // OH PUTAIN CA MARCHE !
        }

        /// <summary>
        /// MouseDown sur le MenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;

        }

        /// <summary>
        /// Event lors d'un Mouvement de Souris avec le bouton appuyé de déplacer la fenêtre.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
            else dragging = false;        }

        /// <summary>
        /// Annuler l'état Draggable après avoir relaché le click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuMain_MouseUp(object sender, MouseEventArgs e)
        {
           dragging = false;

        }


        private void FrmSimpleTextEditor_Load(object sender, EventArgs e)
        {
            
        }
    }
}
