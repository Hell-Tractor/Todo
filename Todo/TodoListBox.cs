using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Todo
{
    public class TodoListBox : CheckedListBox
    {
        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (this.CheckedIndices.Contains(e.Index))
            {
                System.Drawing.Font font;
                font = new System.Drawing.Font(e.Font.Name, e.Font.Size, System.Drawing.FontStyle.Strikeout);
                var checkBoxSize = CheckBoxRenderer.GetGlyphSize(e.Graphics, System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal);
                int paddingDistance = (e.Bounds.Height - checkBoxSize.Height) / 2;
                CheckBoxRenderer.DrawCheckBox(e.Graphics,
                    new System.Drawing.Point(e.Bounds.Left + 1, e.Bounds.Top + paddingDistance),
                    new System.Drawing.Rectangle(e.Bounds.X + checkBoxSize.Width + 2, e.Bounds.Y, e.Bounds.Width - checkBoxSize.Width - 2, e.Bounds.Height),
                    this.Items[e.Index].ToString(),
                    font,
                    TextFormatFlags.Default,
                    false,
                    System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal);
            }
            else
            {
                base.OnDrawItem(e);
            }
        }
    }
}
