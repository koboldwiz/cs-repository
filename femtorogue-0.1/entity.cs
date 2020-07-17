using System.Drawing;

namespace FemtoRogue
{

public class Entity 
{

	protected int _x,_y,_dx,_dy,_w,_h;

	protected int x {
		get => _x;
		set => _x = value;
	} 

	protected int y {
		get => _y;
		set => _y = value;
	} 

	protected int dx {
		get => _dx;
		set => _dx = value;
	} 

	protected int dy {
		get => _dy;
		set => _dy = value;
	} 

	protected int w {
		get => _w;
		set => _w = value;
	} 

	protected int h {
		get => _h;
		set => _h = value;
	} 

	public void update() {

		x += dx;
		y += dy;

	}

	public void update(int new_dx, int new_dy) {

		x += new_dx;
		y += new_dy;

	}

	public void draw(GraphicsDevice gd) {


	}

}
}
