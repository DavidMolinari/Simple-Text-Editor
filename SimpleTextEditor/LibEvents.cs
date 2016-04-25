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
    /// <summary>
    /// Class Static pour gérer mes Evenements Personnels
    /// </summary>
    public static class LibEvents
    {

        /// <summary>
        /// Methode statique pour ajouter un Menu Contextuel Copier/Couper/Coller
        /// </summary>
        /// <param name="rtb"></param>
        public static void AddContextMenu(RichTextBox rtb)
        {
            if (rtb.ContextMenuStrip == null)
            {
                ContextMenuStrip cms = new ContextMenuStrip { ShowImageMargin = false };
                ToolStripMenuItem tsmiCut = new ToolStripMenuItem("Copier");
                tsmiCut.Click += (sender, e) => rtb.Copy();
                cms.Items.Add(tsmiCut);
                ToolStripMenuItem tsmiCopy = new ToolStripMenuItem("Couper");
                tsmiCopy.Click += (sender, e) => rtb.Cut();
                cms.Items.Add(tsmiCopy);
                ToolStripMenuItem tsmiPaste = new ToolStripMenuItem("Coller");
                tsmiPaste.Click += (sender, e) => rtb.Paste();
                cms.Items.Add(tsmiPaste);
                rtb.ContextMenuStrip = cms;
            }
        }
    }
}
