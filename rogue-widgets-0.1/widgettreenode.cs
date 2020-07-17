using System; 
using System.Collections.Generic;

namespace roguewidgets
{
public class WidgetTreeNode
{
	public int _nchildren;

	public int nchildren { get => _nchildren; set => _nchildren = value; }

	public List<WidgetTreeNode> _children;

	public List<WidgetTreeNode> children { get => _children; set => _children = value; } 

} 
} 
