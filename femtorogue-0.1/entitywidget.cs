using System.Drawing;

namespace FemtoRogue
{

// an entity with a widget ttached to it (clicking on a PC for example)

public class EntityWidget : Widget 
{

	protected Entity _entity;

	protected Entity entity {
		get => _entity;
		set => _entity = value;
	}	

	public EntityWidget(Entity e) {
		entity = e;
	}

	// update method : give 0,0 as arguments for default entity update
	public void update(int new_dx = 0, int new_dy = 0) {

		if (new_dx == 0 && new_dy == 0)
			entity.update(); 	
		
		entity.update(new_dx, new_dy);	

	}

	public void draw(GraphicsDevice gd) {


	}

}
}
