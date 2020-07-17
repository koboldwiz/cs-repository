using System;
using System.Drawing;

// a widget with a picture which you can click 

namespace roguewidgets
{
public class ImageButtonWidget : ButtonWidget 
{
	protected int iimage_width, iimage_height; 
	protected int image_width { get => iimage_width; set => iimage_width = value; } 
	protected int image_height { get => iimage_height; set => iimage_height = value; } 


	Action<Widget, Widget> ccallback;

	// constructors

	public ImageButtonWidget(int xx,int yy,int ww,int hh) : base(xx,yy,ww,hh) {
		ccallback = null;
	}
	
	// resize the widget
	public new void resize(int new_w, int new_h) {
		// non aliased picture
		if (new_w <= image_width) 
			base.resize(image_width, new_h); // destructive on new_h
		if (new_h <= image_height) 
			base.resize(new_w, image_height);
		
	}	

	// click functionality
	public void add_callback(CallbackFunctor functorclass) {
		ccallback = functorclass.function;
	}

	public void click_once() {
		if (ccallback == null) 
			return;
		else
			ccallback(this, null);
	}
	
}
}

