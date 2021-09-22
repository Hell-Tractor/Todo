using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Todo
{
    public class TodoListBox : CheckedListBox
    {
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            // close back color changing
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e = new DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State ^ DrawItemState.Selected);
            }
            e.DrawBackground();
            this.drawItem(e, this.CheckedIndices.Contains(e.Index));
        }

        private TodoListBox drawItem(DrawItemEventArgs e, bool check)
        {
            System.Drawing.Font font;
            if (check)
            {
                font = new System.Drawing.Font(e.Font.Name, e.Font.Size, System.Drawing.FontStyle.Strikeout);
            }
            else
            {
                font = new System.Drawing.Font(e.Font.Name, e.Font.Size);
            }
            var checkBoxSize = CheckBoxRenderer.GetGlyphSize(e.Graphics, System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal);
            int paddingDistance = (e.Bounds.Height - checkBoxSize.Height) / 2;
            CheckBoxRenderer.DrawCheckBox(e.Graphics,
                new System.Drawing.Point(e.Bounds.Left + 1, e.Bounds.Top + paddingDistance),
                new System.Drawing.Rectangle(e.Bounds.X + checkBoxSize.Width + 2, e.Bounds.Y, e.Bounds.Width - checkBoxSize.Width - 2, e.Bounds.Height),
                this.Items[e.Index].ToString(),
                font,
                TextFormatFlags.Default,
                false,
                check ? System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal : System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            return this;
        }
    }
}
