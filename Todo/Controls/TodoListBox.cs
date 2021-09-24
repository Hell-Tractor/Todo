using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Todo
{
    public class TodoItem
    {
        public string content;
        public Rectangle checkBoxRect = new();
        public bool isChecked;

        public TodoItem()
        {
            content = "";
            isChecked = false;
        }

        public TodoItem(string str, bool state)
        {
            content = str;
            isChecked = state;
        }

        public override string ToString()
        {
            return content;
        }
    }
    public class TodoListBox : ListBox
    {
        public TodoListBox()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
        }

        public TodoListBox AddItem(string obj, bool state = false)
        {
            //System.Diagnostics.Debug.WriteLine("{0}: {1}", obj, state.ToString());
            this.Items.Add(new TodoItem(obj, state));
            return this;
        }

        public TodoListBox RemoveItemAt(int index)
        {
            this.Items.RemoveAt(index);
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
            return (this.Items[index] as TodoItem).isChecked;
        }

        public TodoListBox SetItemChecked(int index, bool state)
        {
            (this.Items[index] as TodoItem).isChecked = state;
            this.RefreshItem(index);
            return this;
        }

        public TodoListBox ChangeItemChecked(int index)
        {
            (this.Items[index] as TodoItem).isChecked = !(this.Items[index] as TodoItem).isChecked;
            this.RefreshItem(index);
            return this;
        }

        public Rectangle GetCheckBoxRect(int index)
        {
            return (Items[index] as TodoItem).checkBoxRect;
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
            bool isChecked = (this.Items[e.Index] as TodoItem).isChecked;
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
            (this.Items[e.Index] as TodoItem).checkBoxRect = new Rectangle(e.Bounds.Left + 1,
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
            //e.Graphics.DrawRectangle(Pens.Blue, e.Bounds);
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
            if ((this.Items[index] as TodoItem).isChecked)
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
