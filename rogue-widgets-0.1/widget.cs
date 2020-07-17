using System.Drawing;

namespace roguewidgets
{
public class Widget 
{
	//dimensions of the widget
	public int xx,yy;

	public int wwidth, hheight;

	// accessors
	public int x { get => xx; set => xx = value; }
	public int y { get => yy; set => yy = value; }

	public int width { get => wwidth; set => wwidth = value; }
	public int height { get => hheight; set => hheight = value; }
	public int w { get => wwidth; set => wwidth = value; }
	public int h { get => hheight; set => hheight = value; }

	// constructors

	public Widget(int xx,int yy,int ww,int hh) {
		x = xx;
		y = yy;
		w = ww;
		h = hh;
	}

	// graphical functionality
	public bool is_in(Widget widget) {
		if (widget.x >= x && widget.x <= x + w &&
			widget.y >= y && widget.y <= y + h)
			return true;
		else
			return false;
	}

	// resize the widget
	public void resize(int new_w, int new_h) {
		this.w = new_w;
		this.h = new_h;
	}	

	// move the widget	
	public void move(int new_x, int new_y) {
		this.x = new_x;
		this.y = new_y;
	}	
	
}
}

