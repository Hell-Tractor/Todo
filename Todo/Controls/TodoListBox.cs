using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Todo
{
    public class TodoListBox : ListBox
    {
        protected List<bool> isChecked = new();
        protected List<Rectangle> checkBoxRect = new();

        public TodoListBox()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
        }

        public TodoListBox AddItem(object obj, bool state = false)
        {
            this.Items.Add(obj);
            this.isChecked.Add(state);
            this.checkBoxRect.Add(new Rectangle());
            return this;
        }

        public TodoListBox RemoveItemAt(int index)
        {
            isChecked.RemoveAt(index);
            this.Items.RemoveAt(index);
            this.checkBoxRect.RemoveAt(index);
            return this;
        }
        public TodoListBox RemoveItem(object obj)
        {
            if (obj == null)
            {
                return this;
            }
            int index = this.Items.IndexOf(obj);
            return this.RemoveItemAt(index);
        }

        public bool GetItemChecked(int index)
        {
            return this.isChecked[index];
        }

        public TodoListBox SetItemChecked(int index, bool state)
        {
            this.isChecked[index] = state;
            this.RefreshItem(index);
            return this;
        }

        public TodoListBox ChangeItemChecked(int index)
        {
            this.isChecked[index] = !this.isChecked[index];
            this.RefreshItem(index);
            return this;
        }

        public Rectangle GetCheckBoxRect(int index)
        {
            return checkBoxRect[index];
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= this.Items.Count)
                return;

            base.OnMeasureItem(e);

            string text = this.Items[e.Index].ToString();

            // get size
            Size checkBoxSize = CheckBoxRenderer.GetGlyphSize(e.Graphics,
                System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            Size textSize = TextRenderer.MeasureText(text,
                this.Font,
                new Size(this.Width - checkBoxSize.Width - 2,
                    this.Height),
                TextFormatFlags.WordBreak);

            e.ItemWidth = textSize.Width;
            e.ItemHeight = textSize.Height;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= this.Items.Count)
                return;

            FontStyle fontStyle = FontStyle.Regular;
            bool isChecked = this.isChecked[e.Index];
            if (isChecked)
            {
                fontStyle |= FontStyle.Strikeout;
            }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                fontStyle |= FontStyle.Underline;
            }
            Font font = new(e.Font.Name, e.Font.Size, fontStyle);

            // update DrawItemArgs
            e = new DrawItemEventArgs(e.Graphics,
                font,
                e.Bounds,
                e.Index,
                e.State,
                ForeColor,
                BackColor);

            // get text
            string text = this.Items[e.Index].ToString();

            // get size
            Size checkBoxSize = CheckBoxRenderer.GetGlyphSize(e.Graphics,
                System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            
            int verticalPadding = 2;

            // pre-draw
            e.Graphics.FillRectangle(new SolidBrush(BackColor), e.Bounds);
            e.DrawFocusRectangle();

            // draw checkBox
            CheckBoxRenderer.DrawCheckBox(e.Graphics,
                new Point(e.Bounds.Left + 1, e.Bounds.Top + verticalPadding),
                isChecked ? System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal :
                    System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            this.checkBoxRect[e.Index] = new Rectangle(e.Bounds.Left + 1,
                e.Bounds.Top + verticalPadding,
                checkBoxSize.Width,
                checkBoxSize.Height);

            // draw text
            TextRenderer.DrawText(e.Graphics,
                text,
                font,
                new Rectangle(e.Bounds.Left + 2 + checkBoxSize.Width,
                    e.Bounds.Top,
                    e.Bounds.Width - 2 - checkBoxSize.Width,
                    e.Bounds.Height),
                //e.Bounds,
                ForeColor,
                TextFormatFlags.WordBreak);

            // draw debug bounds
            e.Graphics.DrawRectangle(Pens.Blue, e.Bounds);
        }

        protected override void RefreshItem(int index)
        {
            if (index < 0 || index >= this.Items.Count)
            {
                return;
            }

            Graphics g = CreateGraphics();
            Rectangle rect = GetItemRectangle(index);
            g.SetClip(rect);

            // calculate Item State
            DrawItemState state = DrawItemState.None;
            if (this.isChecked[index])
            {
                state |= DrawItemState.Checked;
            }
            if (this.SelectedIndex == index)
            {
                state |= DrawItemState.Selected;
            }

            MeasureItemEventArgs e = new(g, index);
            this.OnMeasureItem(e);
            this.OnDrawItem(new DrawItemEventArgs(e.Graphics,
                Font,
                new Rectangle(rect.X, rect.Y, rect.Width, e.ItemHeight),
                index,
                state));
        }
    }
}
