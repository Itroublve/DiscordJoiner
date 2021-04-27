using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundBtn : Button
{
    public RoundBtn()
    {
        DoubleBuffered = true;
        MouseEnter += delegate (object sender, EventArgs e)
        {
            _isHovering = true;
            Invalidate();
        };
        MouseLeave += delegate (object sender, EventArgs e)
        {
            _isHovering = false;
            Invalidate();
        };
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics graphics = e.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        Brush brush = new SolidBrush(_isHovering ? _onHoverBorderColor : _borderColor);
        graphics.FillEllipse(brush, 0, 0, Height, Height);
        graphics.FillEllipse(brush, Width - Height, 0, Height, Height);
        graphics.FillRectangle(brush, Height / 2, 0, Width - Height, Height);
        brush.Dispose();
        brush = new SolidBrush(_isHovering ? _onHoverButtonColor : _buttonColor);
        graphics.FillEllipse(brush, _borderThicknessByTwo, _borderThicknessByTwo, Height - _borderThickness, Height - _borderThickness);
        graphics.FillEllipse(brush, Width - Height + _borderThicknessByTwo, _borderThicknessByTwo, Height - _borderThickness, Height - _borderThickness);
        graphics.FillRectangle(brush, Height / 2 + _borderThicknessByTwo, _borderThicknessByTwo, Width - Height - _borderThickness, Height - _borderThickness);
        brush.Dispose();
        brush = new SolidBrush(_isHovering ? _onHoverTextColor : _textColor);
        SizeF sizeF = graphics.MeasureString(Text, Font);
        graphics.DrawString(Text, Font, brush, ((float)Width - sizeF.Width) / 2f, ((float)Height - sizeF.Height) / 2f);
    }
    public Color BorderColor
    {
        get
        {
            return _borderColor;
        }
        set
        {
            _borderColor = value;
            base.Invalidate();
        }
    }
    public Color OnHoverBorderColor
    {
        get
        {
            return _onHoverBorderColor;
        }
        set
        {
            _onHoverBorderColor = value;
            base.Invalidate();
        }
    }
    public Color ButtonColor
    {
        get
        {
            return _buttonColor;
        }
        set
        {
            _buttonColor = value;
            base.Invalidate();
        }
    }
    public Color OnHoverButtonColor
    {
        get
        {
            return _onHoverButtonColor;
        }
        set
        {
            _onHoverButtonColor = value;
            Invalidate();
        }
    }
    public Color TextColor
    {
        get
        {
            return _textColor;
        }
        set
        {
            _textColor = value;
            base.Invalidate();
        }
    }
    public Color OnHoverTextColor
    {
        get
        {
            return _onHoverTextColor;
        }
        set
        {
            _onHoverTextColor = value;
            base.Invalidate();
        }
    }

    private Color _borderColor = Color.Silver;

    private Color _onHoverBorderColor = Color.Gray;

    private Color _buttonColor = Color.Red;

    private Color _onHoverButtonColor = Color.Yellow;

    private Color _textColor = Color.White;

    private Color _onHoverTextColor = Color.Gray;

    private bool _isHovering;

    private int _borderThickness = 6;

    private int _borderThicknessByTwo = 3;
}
