using System.Drawing;

// a widget with a text on it 

namespace roguewidgets
{
public class LabelWidget : NonTextWidget 
{
	// constructors

	public LabelWidget(int xx,int yy,int ww,int hh) : base(xx,yy,ww,hh) {
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

