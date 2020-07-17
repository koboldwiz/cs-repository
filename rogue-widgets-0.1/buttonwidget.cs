using System.Drawing;

// a widget which is a button 

namespace roguewidgets
{
public class ButtonWidget : NonTextWidget 
{
	// constructors

	public ButtonWidget(int xx,int yy,int ww,int hh) : base(xx,yy,ww,hh) {
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

