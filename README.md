# CollectionViewVisualStates
Illustrates combining Selected and PointerOver VisualStates not working together with CollectionView

The sample presents three CollectionView instances:
* The left CollectionView uses both Selected and PointerOver visual states.
  * PointerOver works as expected and the item is highlighted when the mouse hovers over it.
  * Error: Selected items use the default behavior for the selected item instead of the custom visual state.
* The middle CollectionView using only the PointerOver visual state.
  * PointerOver works as expected and the item is highlighted when the mouse hovers over it. 
* The right CollectionView using only the Selected visual state.
  * PointerOver has the default behavior and the item is highlighted when it is selected. 

The issue has been repro'd with the following Maui versions:

Microsoft.Maui.Controls v9.0.14 (The default for new Visual Studio 2022 projects)
Microsoft.Maui.Controls v9.0.50
Microsoft.Maui.Controls v9.0.70
If I remember correctly, the same issue occured with ListView.