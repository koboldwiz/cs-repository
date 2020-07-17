using System.Drawing;

// a widget with no editable text area in it

namespace roguewidgets
{
public class NonTextWidget : Widget 
{
	// constructors

	public NonTextWidget(int xx,int yy,int ww,int hh) : base(xx,yy,ww,hh) {
	}
	// resize the widget
	public new void resize(int new_w, int new_h) {
		base.resize(new_w, new_h);
	}	

	// move the widget	
	public new void move(int new_x, int new_y) {
		base.move(new_x, new_y);
	}	
	
}
}

